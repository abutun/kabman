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
        private void CollectDasds(out Dictionary<string, List<DasdListItem>> argListSet, string argColumnKey)
        {
            argListSet = new Dictionary<string, List<DasdListItem>>();

            string columnName;
            DasdCollector collector;

            columnName = userSettings.Default.ImportDasdPageColumns.ToDictionary()[argColumnKey]; // burada userSettings bulamadı bir saniye
            collector = new DasdCollector("Name", columnName);
            collector.CollectItems(ref dasdDataSet);

            argListSet.Add("Dasd", collector.Items);
        }

        private void ProcessDasds()
        {
            Dictionary<string, List<DasdListItem>> listSet;

            var key = "Dasd";

            CollectDasds(out listSet, "Name");

            var seqDasd = listSet["Dasd"];

            RefreshAssistant.AddVisualizerDataTable(key + "-All", seqDasd.ToList());

            var groupedByName = from grp in seqDasd
                                group grp by new
                                {
                                    grp.Name
                                } into g
                                select new
                                {
                                    DasdName = g.Key.Name,
                                    Count = g.Count()
                                };

            var grouped = from grp in seqDasd
                          group grp by new
                          {
                              grp.Name,
                              grp.BlechName,
                              grp.CuType,
                              grp.Model
                             
                          } into g
                          join ports in groupedByName on g.Key.Name equals ports.DasdName
                          select new DasdGroupedListItem
                          {
                              Name = g.Key.Name,
                              Model = g.Key.Model,
                              BlechName = g.Key.BlechName,
                              Port = ports.Count
                          };

            RefreshAssistant.AddVisualizerDataTable(key + "-Grouped", grouped.ToList());

            listDasdAll = seqDasd.ToList();
            listDasdGrouped = grouped.ToList();

        }
    }
}
