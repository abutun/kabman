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
        private void CollectBleches(out Dictionary<string, List<BlechListItem>> argListSet, string argColumnKey)
        {
            argListSet = new Dictionary<string, List<BlechListItem>>();

            string columnName;
            BlechCollector collector;

            columnName = userSettings.Default.ImportSwitchPageColumns.ToDictionary()[argColumnKey];
            collector = new BlechCollector("Switch", columnName);
            collector.CollectItems(ref switchDataSet);
            argListSet.Add("Switch", collector.Items);

            columnName = userSettings.Default.ImportServerPageColumns.ToDictionary()[argColumnKey];
            collector = new BlechCollector("Server", columnName);
            collector.CollectItems(ref serverDataSet);
            argListSet.Add("Server", collector.Items);

            columnName = userSettings.Default.ImportDasdPageColumns.ToDictionary()[argColumnKey];
            collector = new BlechCollector("Dasd", columnName);
            collector.CollectItems(ref dasdDataSet);
            argListSet.Add("Dasd", collector.Items);

        }

        private void ProcessBleches()
        {

            Dictionary<string, List<BlechListItem>> listSet;

            var key = "Blech"; 

            CollectBleches(out listSet, key);

            var seqSwitch = listSet["Switch"];
            var seqServer = listSet["Server"];
            var seqDasd = listSet["Dasd"];

            RefreshAssistant.AddVisualizerDataTable(key + "-Switch", seqSwitch);
            RefreshAssistant.AddVisualizerDataTable(key + "-Server", seqServer);
            RefreshAssistant.AddVisualizerDataTable(key + "-Dasd", seqDasd);

            string[] npqr = new string[] { "N", "P", "Q", "R" };

            var vtSwitch = from sw in seqSwitch
                           where npqr.Contains(sw.Class1)
                           let vname = string.Format("{0}", new object[] { sw.Symbol + sw.Room + sw.San })
                           group sw by vname into g
                           select new BlechListItem
                           {
                               Name = g.Key,
                               Count = g.Count()
                           };
            
            RefreshAssistant.AddVisualizerDataTable(key + "SwitchCounts", vtSwitch.ToList());

            var all = (from a in seqSwitch.Union(seqServer).Union(seqDasd)
                       where !string.IsNullOrEmpty(a.Name)
                       select new BlechListItem
                       {
                           Class1 = a.Class1,
                           Class2 = a.Class2,
                           Coordinate = a.Coordinate,
                           Count = a.Count,
                           Name = a.Name,
                           Category = a.Category,
                           Number = a.Number,
                           Room = a.Room,
                           San = a.San,
                           Symbol = a.Symbol,
                           BlechType = a.BlechType
                       });

            RefreshAssistant.AddVisualizerDataTable(key + "-All", all.ToList());

            var grouped = from a in all
                          let Isim = a.Name.Split(new string[] { "." }, StringSplitOptions.None)[0]
                          group a by new
                          {
                              Isim,
                              a.Room,
                              a.San,
                              a.BlechType,
                              a.Coordinate
                          }
                              into g
                              select new BlechGroupedListItem
                              {
                                  Name = g.Key.Isim,
                                  Room = g.Key.Room,
                                  BlechType = g.Key.BlechType,
                                  San = g.Key.San,
                                  Coordinate = g.Key.Coordinate,
                                  Count = g.Count()
                              };

            RefreshAssistant.AddVisualizerDataTable(key + "-Grouped", grouped.ToList());
            
            listBlechAll = all.ToList();
            listBlechGrouped = grouped.ToList();

        }
    }
}
