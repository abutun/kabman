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

        private void CollectTrunks(out Dictionary<string, List<TrunkListItem>> argListSet, string argColumnKey)
        {

            argListSet = new Dictionary<string, List<TrunkListItem>>();

            string columnName;
            TrunkCableCollector collector;

            columnName = userSettings.Default.ImportSwitchPageColumns.ToDictionary()[argColumnKey];
            collector = new TrunkCableCollector("Switch", columnName);
            collector.CollectItems(ref switchDataSet);
            argListSet.Add("Switch", collector.Items);

            columnName = userSettings.Default.ImportServerPageColumns.ToDictionary()[argColumnKey];
            collector = new TrunkCableCollector("Server", columnName);
            collector.CollectItems(ref serverDataSet);
            argListSet.Add("Server", collector.Items);

            columnName = userSettings.Default.ImportDasdPageColumns.ToDictionary()[argColumnKey];
            collector = new TrunkCableCollector("Dasd", columnName);
            collector.CollectItems(ref dasdDataSet);
            argListSet.Add("Dasd", collector.Items);

            columnName = userSettings.Default.ImportDccPageColumns.ToDictionary()[argColumnKey];
            collector = new TrunkCableCollector("Dcc", columnName);
            collector.CollectItems(ref dccDataSet);
            argListSet.Add("Dcc", collector.Items);

        }

        private void ProcessTrunks()
        {
            Dictionary<string, List<TrunkListItem>> listSet;

            var key = "Trunk";

            CollectTrunks(out listSet, key);

            var seqSwitch = listSet["Switch"];
            var seqServer = listSet["Server"];
            var seqDasd = listSet["Dasd"];
            var seqDcc = listSet["Dcc"];

            RefreshAssistant.AddVisualizerDataTable(key + "-Switch", seqSwitch);
            RefreshAssistant.AddVisualizerDataTable(key + "-Server", seqServer);
            RefreshAssistant.AddVisualizerDataTable(key + "-Dasd", seqDasd);
            RefreshAssistant.AddVisualizerDataTable(key + "-Dcc", seqDcc);

            //var dupswr = (from sw in seqSwitch
            //              join sr in seqServer
            //              on new { sw.Symbol, sw.Number } equals new { sr.Symbol, sr.Number } into j1
            //              from j in j1
            //              let nm = j == null ? string.Empty : j.Name
            //              where !string.IsNullOrEmpty(nm)
            //              select new TrunkListItem
            //              {
            //                  Name = nm
            //              });

            //var dupswd = (from sw in seqSwitch
            //              join da in seqDasd
            //              on new { sw.Symbol, sw.Number } equals new { da.Symbol, da.Number } into j1
            //              from j in j1
            //              let nm = j == null ? string.Empty : j.Name
            //              where !string.IsNullOrEmpty(nm)
            //              select new TrunkListItem
            //              {
            //                  Name = nm
            //              });

            //var dupsrd = (from sr in seqServer
            //              join da in seqDasd
            //              on new { sr.Symbol, sr.Number } equals new { da.Symbol, da.Number } into j1
            //              from j in j1
            //              let nm = j == null ? string.Empty : j.Name
            //              where !string.IsNullOrEmpty(nm)
            //              select new TrunkListItem
            //              {
            //                  Name = nm
            //              });

            //var dups = (from d in dupswr.Union(dupswd).Union(dupsrd)
            //            select new TrunkListItem
            //            {
            //                Name = d.Name
            //            }).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0, (a) => a.Name.GetHashCode());

            //RefreshAssistant.AddVisualizerDataTable(key + "-Duplicates", dups.ToList());

            var all = (from a in seqSwitch.Union(seqServer).Union(seqDasd).Union(seqDcc)
                       where !string.IsNullOrEmpty(a.Name)
                       select new TrunkListItem
                       {
                           Category = a.Category,
                           Name = a.Name
                       });
            RefreshAssistant.AddVisualizerDataTable(key + "-All", all.ToList());

            var grouped = from a in all
                          group a by a.Symbol + a.Number into g
                          select new TrunkListItem
                          {
                              Name = g.Key,
                              Count = g.Count()
                          };
            RefreshAssistant.AddVisualizerDataTable(key + "-Grouped", grouped.ToList());

            listTrunkGrouped = grouped.ToList();
        }

    }
}
