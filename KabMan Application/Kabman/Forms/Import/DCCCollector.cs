using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KabMan.Import;
using userSettings = KabMan.Properties.Settings;
using KabMan.Extensions;
using KabMan.Windows;

namespace KabMan.Forms
{
    public partial class ExcelImportForm
    {
        private void CollectDCCDevices(out Dictionary<string, List<DccListItem>> argListSet, string argColumnKey)
        {
            argListSet = new Dictionary<string, List<DccListItem>>();

            string columnName;
            DccCollector collector;

            columnName = userSettings.Default.ImportDccPageColumns.ToDictionary()[argColumnKey]; // burada userSettings bulamadı bir saniye
            collector = new DccCollector("Dcc", columnName);
            collector.CollectItems(ref dccDataSet);

            argListSet.Add("Dcc", collector.Items);
        }

        private void ProcessDCCs()
        {
            Dictionary<string, List<DccListItem>> listSet;

            var key = "Dcc";

            CollectDCCDevices(out listSet, "Name");

            var seqDcc = listSet["Dcc"];

            RefreshAssistant.AddVisualizerDataTable(key + "-All", seqDcc.ToList());

            var groupedByName = from grp in seqDcc
                                group grp by new
                                {
                                    grp.Name
                                } into g
                                select new
                                {
                                    DccName = g.Key.Name,
                                    PortCount = g.Count()
                                };

            var grouped = from grp in seqDcc
                          group grp by new
                          {
                              grp.Name,
                              grp.VtPort1Name,
                              grp.VtPort2Name
                          } into g
                          join ports in groupedByName on g.Key.Name equals ports.DccName
                          select new DccGroupedListItem
                          {
                              Name = g.Key.Name,
                              VTPort1Name = g.Key.VtPort1Name,
                              VTPort2Name = g.Key.VtPort2Name,
                              PortCount = ports.PortCount
                          };

            RefreshAssistant.AddVisualizerDataTable(key + "-Grouped", grouped.ToList());

            listDccAll = seqDcc.ToList();
            listDccGrouped = grouped.ToList();

        }
    }
}
