using KabMan.Import;
using System;
using System.Collections.Generic;
using userSettings = KabMan.Properties.Settings;
using KabMan.Extensions;
using System.Linq;
using System.Diagnostics;
using System.Data;
using KabMan.Controls;
using KabMan.Windows;

namespace KabMan.Forms
{
    public partial class ExcelImportForm
    {
        private void CollectVtPorts(out Dictionary<string, List<VtPortListItem>> argListSet, string argColumnKey)
        {
            argListSet = new Dictionary<string, List<VtPortListItem>>();

            string columnName;
            VtPortCollector collector;

            if (userSettings.Default.ImportSwitchPageColumns.ToDictionary().ContainsKey(argColumnKey))
                columnName = userSettings.Default.ImportSwitchPageColumns.ToDictionary()[argColumnKey];
            else
                columnName = "Nothing";
            collector = new VtPortCollector("Switch", columnName);
            collector.CollectItems(ref switchDataSet);
            argListSet.Add("Switch", collector.Items);

            if (userSettings.Default.ImportServerPageColumns.ToDictionary().ContainsKey(argColumnKey))
                columnName = userSettings.Default.ImportServerPageColumns.ToDictionary()[argColumnKey];
            else
                columnName = "Nothing";
            collector = new VtPortCollector("Server", columnName);
            collector.CollectItems(ref serverDataSet);
            argListSet.Add("Server", collector.Items);

            if (userSettings.Default.ImportDasdPageColumns.ToDictionary().ContainsKey(argColumnKey))
                columnName = userSettings.Default.ImportDasdPageColumns.ToDictionary()[argColumnKey];
            else
                columnName = "Nothing";
            collector = new VtPortCollector("Dasd", columnName);
            collector.CollectItems(ref dasdDataSet);
            argListSet.Add("Dasd", collector.Items);

            if (userSettings.Default.ImportDccPageColumns.ToDictionary().ContainsKey(argColumnKey))
                columnName = userSettings.Default.ImportDccPageColumns.ToDictionary()[argColumnKey];
            else
                columnName = "Nothing";
            collector = new VtPortCollector("Dcc", columnName);
            collector.CollectItems(ref dccDataSet);
            argListSet.Add("Dcc", collector.Items);

        }

        private void ProcessVtPorts(string argVtPortKey)
        {
            Dictionary<string, List<VtPortListItem>> listSet;

            var key = argVtPortKey;
            List<VtPortListItem> tmp = new List<VtPortListItem>();

            CollectVtPorts(out listSet, key);

            var seqSwitch = listSet["Switch"];
            var seqServer = listSet["Server"];
            var seqDasd = listSet["Dasd"];
            var seqDcc = listSet["Dcc"];

            RefreshAssistant.AddVisualizerDataTable(key + "-Switch", seqSwitch);
            RefreshAssistant.AddVisualizerDataTable(key + "-Server", seqServer);
            RefreshAssistant.AddVisualizerDataTable(key + "-Dasd", seqDasd);
            RefreshAssistant.AddVisualizerDataTable(key + "-Dcc", seqDcc);
            
            var vtSwitch = from sw in seqSwitch
                           select sw;

            tmp.AddRange(vtSwitch.ToList());
            
            var vtServer = from sw in seqServer
                           select sw;

            tmp.AddRange(vtServer.ToList());

            var vtDasd = from sw in seqDasd
                           select sw;

            tmp.AddRange(vtDasd.ToList());

            var vtDcc = from sw in seqDcc
                         select sw;

            tmp.AddRange(vtDcc.ToList());


            var vtPortGrouped = from sw in tmp
                                group sw by new
                                {
                                    sw.Room, 
                                    sw.San
                                } into g
                                select new VtPortGroupedListItem
                                {
                                    Room = g.Key.Room,
                                    San = g.Key.San
                                };

            RefreshAssistant.AddVisualizerDataTable(key + "-Grouped", vtPortGrouped.ToList());
            if (argVtPortKey == "VtPort")
                listVtPortGrouped = vtPortGrouped.ToList();
            else if (argVtPortKey == "VtPort1")
                listVtPort1Grouped = vtPortGrouped.ToList();
            else if (argVtPortKey == "VtPort2")
                listVtPort2Grouped = vtPortGrouped.ToList();
            //var vtSwitchDis = from v in vtSwitch
            //                  group v by v.Name into g
            //                  where g.Count() > 1
            //                  select new VtPortListItem
            //                  {
            //                      Name = g.Key,
            //                      Count = g.Count()
            //                  };
            //RefreshAssistant.AddVisualizerDataTable(key + "Switch Duplicates", vtSwitchDis.ToList());

        }
    }
}
