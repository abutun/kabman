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

        private void CollectDataCenters(out Dictionary<string, List<DataCenterListItem>> argListSet, string argColumnKey)
        {

            argListSet = new Dictionary<string, List<DataCenterListItem>>();

            string columnName;
            DataCenterCollector collector;

            //columnName = userSettings.Default.ImportSwitchPageColumns.ToDictionary()[argColumnKey];
            //collector = new DataCenterCollector("Switch", columnName);
            //collector.CollectItems(ref switchDataSet);
            //argListSet.Add("Switch", collector.Items);

            //columnName = userSettings.Default.ImportServerPageColumns.ToDictionary()[argColumnKey];
            //collector = new DataCenterCollector("Server", columnName);
            //collector.CollectItems(ref serverDataSet);
            //argListSet.Add("Server", collector.Items);

            //columnName = userSettings.Default.ImportDasdPageColumns.ToDictionary()[argColumnKey];
            //collector = new DataCenterCollector("Dasd", columnName);
            //collector.CollectItems(ref dasdDataSet);
            //argListSet.Add("Dasd", collector.Items);

            //columnName = userSettings.Default.ImportDccPageColumns.ToDictionary()[argColumnKey];
            //collector = new DataCenterCollector("Dcc", columnName);
            //collector.CollectItems(ref dccDataSet);
            //argListSet.Add("Dcc", collector.Items);

            if (userSettings.Default.ImportSwitchPageColumns.ToDictionary().ContainsKey(argColumnKey))
                columnName = userSettings.Default.ImportSwitchPageColumns.ToDictionary()[argColumnKey];
            else
                columnName = "Nothing";
            collector = new DataCenterCollector("Switch", columnName);
            collector.CollectItems(ref switchDataSet);
            argListSet.Add("Switch", collector.Items);

            if (userSettings.Default.ImportServerPageColumns.ToDictionary().ContainsKey(argColumnKey))
                columnName = userSettings.Default.ImportServerPageColumns.ToDictionary()[argColumnKey];
            else
                columnName = "Nothing";
            collector = new DataCenterCollector("Server", columnName);
            collector.CollectItems(ref serverDataSet);
            argListSet.Add("Server", collector.Items);

            if (userSettings.Default.ImportDasdPageColumns.ToDictionary().ContainsKey(argColumnKey))
                columnName = userSettings.Default.ImportDasdPageColumns.ToDictionary()[argColumnKey];
            else
                columnName = "Nothing";
            collector = new DataCenterCollector("Dasd", columnName);
            collector.CollectItems(ref dasdDataSet);
            argListSet.Add("Dasd", collector.Items);

            if (userSettings.Default.ImportDccPageColumns.ToDictionary().ContainsKey(argColumnKey))
                columnName = userSettings.Default.ImportDccPageColumns.ToDictionary()[argColumnKey];
            else
                columnName = "Nothing";
            collector = new DataCenterCollector("Dcc", columnName);
            collector.CollectItems(ref dccDataSet);
            argListSet.Add("Dcc", collector.Items);

        }

        private void ProcessDataCenters(string argVtPortKey)
        {
            Dictionary<string, List<DataCenterListItem>> listSet;

            var key = "DataCenter";

            CollectDataCenters(out listSet, argVtPortKey);

            var seqSwitch = listSet["Switch"];
            var seqServer = listSet["Server"];
            var seqDasd = listSet["Dasd"];
            var seqDcc = listSet["Dcc"];

            RefreshAssistant.AddVisualizerDataTable(key + "-Switch", seqSwitch);
            RefreshAssistant.AddVisualizerDataTable(key + "-Server", seqServer);
            RefreshAssistant.AddVisualizerDataTable(key + "-Dasd", seqDasd);
            RefreshAssistant.AddVisualizerDataTable(key + "-Dcc", seqDcc);

            var swDcs = (from w in seqSwitch
                         where !w.Name.IsNothing() &&
                         w.Location.Match(regex.SwitchName) &&
                         w.Name.Match(regex.VtPortAcronym)
                         select new DataCenterListItem
                         {
                             Category = w.Category,
                             Name = w.Name.Substring(1, 3),
                             Location = w.Location.Replace("SW", "").Remove(2)
                         }).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0, (a) => a.Name.GetHashCode());

            var srDcs = (from r in seqServer
                         where !r.Name.IsNothing() &&
                         r.Name.Match(regex.VtPortAcronym)
                         select new DataCenterListItem
                         {
                             Category = r.Category,
                             Name = r.Name.Substring(1, 3)
                         }).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0, (a) => a.Name.GetHashCode());

            var daDcs = (from d in seqDasd
                         where !d.Name.IsNothing() &&
                         d.Name.Match(regex.VtPortAcronym) &&
                         d.Location.Match(regex.LocationAcronym)
                         select new DataCenterListItem
                         {
                             Category = d.Category,
                             Location = d.Location.Replace("KWA", ""),
                             Name = d.Name.Substring(1, 3)
                         }).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0, (a) => a.Name.GetHashCode());

            var srDccs = (from r in seqDcc
                         where !r.Name.IsNothing() &&
                         r.Name.Match(regex.VtPortAcronym)
                         select new DataCenterListItem
                         {
                             Category = r.Category,
                             Name = r.Name.Substring(1, 3)
                         }).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0, (a) => a.Name.GetHashCode());


            var all = swDcs.Union(srDcs).Union(daDcs).Union(srDccs);

            RefreshAssistant.AddVisualizerDataTable(key + "-All", all.ToList());

            var valued = all.Where(a => !string.IsNullOrEmpty(a.Location));

            var unvalued = all.Where(a => string.IsNullOrEmpty(a.Location)).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0, (a) => a.Name.GetHashCode());

            var result = (from a in valued.Union(unvalued)
                          select a).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0, (a) => a.Name.GetHashCode());

            RefreshAssistant.AddVisualizerDataTable(key + "-Result", result.ToList());

            if (argVtPortKey == "VtPort")
                listDataCenter = result.ToList();
            else if (argVtPortKey == "VtPort1")
                listDataCenter1 = result.ToList();
            else if (argVtPortKey == "VtPort2")
                listDataCenter2 = result.ToList();
            
        }

    }
}
