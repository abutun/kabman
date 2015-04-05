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
using KabMan.Components;

namespace KabMan.Forms
{
    public partial class ExcelImportForm
    {
        private void CollectCoordinates(out Dictionary<string, List<CoordinateListItem>> argListSet, string argColumnKey)
        {

            argListSet = new Dictionary<string, List<CoordinateListItem>>();

            string columnName;
            CoordinateCollector collector;

            columnName = userSettings.Default.ImportServerPageColumns.ToDictionary()[argColumnKey];
            collector = new CoordinateCollector("Server", columnName);
            collector.CollectItems(ref serverDataSet);
            argListSet.Add("Server", collector.Items);

            columnName = userSettings.Default.ImportDasdPageColumns.ToDictionary()[argColumnKey];
            collector = new CoordinateCollector("Dasd", columnName);
            collector.CollectItems(ref dasdDataSet);
            argListSet.Add("Dasd", collector.Items);
        }

        private void ProcessCoordinates()
        {

            Dictionary<string, List<CoordinateListItem>> listSet;

            var key = "Coordinate";

            CollectCoordinates(out listSet, "Blech");

            var seqServer = listSet["Server"];
            var seqDasd = listSet["Dasd"];

            var resultServer = (from r in seqServer
                          where r.Name.Match(regex.BlechAcronym)
                          let b = new Blech(r.Name)
                          select new CoordinateListItem
                          {
                              Category = r.Category,
                              DataCenter = b.Room,
                              Name = b.Coordinate
                          }).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0 && string.Compare(a.DataCenter, b.DataCenter) == 0, (a) => a.Name.GetHashCode());

            var resultDasd = (from r in seqDasd
                          where r.Name.Match(regex.BlechAcronym)
                          let b = new Blech(r.Name)
                          select new CoordinateListItem
                          {
                              Category = r.Category,
                              DataCenter = b.Room,
                              Name = b.Coordinate
                          }).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0 && string.Compare(a.DataCenter, b.DataCenter) == 0, (a) => a.Name.GetHashCode());


            var result = resultServer.Union(resultDasd).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0 && string.Compare(a.DataCenter, b.DataCenter) == 0, (a) => a.Name.GetHashCode());


            RefreshAssistant.AddVisualizerDataTable(key + "-Server", seqServer);
            RefreshAssistant.AddVisualizerDataTable(key + "-Dasd", seqDasd);


            RefreshAssistant.AddVisualizerDataTable(key + "-Result", result.ToList());

            listCoordinate = result.ToList();
        }
    }
}
