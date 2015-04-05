using System.Collections.Generic;
using KabMan.Import;
using userSettings = KabMan.Properties.Settings;
using KabMan.Extensions;
using KabMan.Windows;
using System.Linq;

namespace KabMan.Forms
{
    public partial class ExcelImportForm
    {

        private void CollectJumpers(out Dictionary<string, List<JumperListItem>> argListSet, string argColumnKey)
        {
            argListSet = new Dictionary<string, List<JumperListItem>>();

            string columnName;
            JumperCableCollector collector;

            columnName = userSettings.Default.ImportSwitchPageColumns.ToDictionary()[argColumnKey];
            collector = new JumperCableCollector("Switch", columnName);
            collector.CollectItems(ref switchDataSet);
            argListSet.Add("Switch", collector.Items);

            columnName = userSettings.Default.ImportServerPageColumns.ToDictionary()[argColumnKey];
            collector = new JumperCableCollector("Server", columnName);
            collector.CollectItems(ref serverDataSet);
            argListSet.Add("Server", collector.Items);

            columnName = userSettings.Default.ImportDasdPageColumns.ToDictionary()[argColumnKey];
            collector = new JumperCableCollector("Dasd", columnName);
            collector.CollectItems(ref dasdDataSet);
            argListSet.Add("Dasd", collector.Items);

            columnName = userSettings.Default.ImportDccPageColumns.ToDictionary()[argColumnKey];
            collector = new JumperCableCollector("Dcc", columnName);
            collector.CollectItems(ref dccDataSet);
            argListSet.Add("Dcc", collector.Items);
        }

        private void ProcessJumpers(string argJumperKey)
        {
            Dictionary<string, List<JumperListItem>> listSet;

            var key = argJumperKey;

            CollectJumpers(out listSet, key);

            var seqSwitch = listSet["Switch"];
            var seqServer = listSet["Server"];
            var seqDasd = listSet["Dasd"];
            var seqDcc = listSet["Dcc"];

            RefreshAssistant.AddVisualizerDataTable(key + "-Switch", seqSwitch);
            RefreshAssistant.AddVisualizerDataTable(key + "-Server", seqServer);
            RefreshAssistant.AddVisualizerDataTable(key + "-Dasd", seqDasd);
            RefreshAssistant.AddVisualizerDataTable(key + "-Dcc", seqDcc);

            //var dupswr = from sw in seqSwitch
            //             join sr in seqServer
            //             on new { sw.Symbol, sw.Number } equals new { sr.Symbol, sr.Number } into j1
            //             from j in j1
            //             let nm = j == null ? string.Empty : j.Name
            //             where !string.IsNullOrEmpty(nm)
            //             select new JumperListItem
            //             {
            //                 Name = nm
            //             };

            //var dupswd = from sw in seqSwitch
            //             join da in seqDasd
            //             on new { sw.Symbol, sw.Number } equals new { da.Symbol, da.Number } into j1
            //             from j in j1
            //             let nm = j == null ? string.Empty : j.Name
            //             where !string.IsNullOrEmpty(nm)
            //             select new JumperListItem
            //             {
            //                 Name = nm
            //             };

            //var dupsrd = from sr in seqServer
            //             join da in seqDasd
            //             on new { sr.Symbol, sr.Number } equals new { da.Symbol, da.Number } into j1
            //             from j in j1
            //             let nm = j == null ? string.Empty : j.Name
            //             where !string.IsNullOrEmpty(nm)
            //             select new JumperListItem
            //              {
            //                  Name = nm
            //              };

            //var dups = (from d in dupswr.Union(dupswd).Union(dupsrd)
            //            select new JumperListItem
            //            {
            //                Name = d.Name
            //            }).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0, (a) => a.Name.GetHashCode());

            //RefreshAssistant.AddVisualizerDataTable(key + "-Duplicates", dups.ToList());

            var all = (from a in seqSwitch.Union(seqServer).Union(seqDasd).Union(seqDcc)
                       where !string.IsNullOrEmpty(a.Name)
                       select new JumperListItem
                       {
                           Category = a.Category,
                           Name = a.Name
                       });
            RefreshAssistant.AddVisualizerDataTable(key + "-All", all.ToList());

            var grouped = from a in all
                          group a by a.Symbol + a.Number into g
                          select new JumperListItem
                          {
                              Name = g.Key,
                              Count = g.Count()
                          };
            RefreshAssistant.AddVisualizerDataTable(key + "-Grouped", grouped.ToList());
            
            if(argJumperKey == "LcUrm")
                listLcUrmJumperGrouped = grouped.ToList();
            else listUrmUrmJumperGrouped = grouped.ToList();




        }
    }
}
