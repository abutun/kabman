using System.Collections.Generic;
using KabMan.Import;
using userSettings = KabMan.Properties.Settings;
using KabMan.Extensions;
using KabMan.Windows;
using System.Linq;
using System.Globalization;
using KabMan.Text;

namespace KabMan.Forms
{
    public partial class ExcelImportForm
    {
        private void CollectSwitchLocations(ref Dictionary<string, List<LocationListItem>> argListSet, string argColumnKey)
        {
            string columnName;
            LocationCollector collector;

            columnName = userSettings.Default.ImportSwitchPageColumns.ToDictionary()[argColumnKey];
            collector = new LocationCollector("Switch", columnName);
            collector.CollectItems(ref switchDataSet);
            argListSet.Add("Switch", collector.Items);

        }

        //private void CollectDasdLocations(ref Dictionary<string, List<LocationListItem>> argListSet, string argColumnKey)
        //{
        //    string columnName;
        //    LocationCollector collector;

        //    columnName = userSettings.Default.ImportDasdPageColumns.ToDictionary()[argColumnKey];
        //    collector = new LocationCollector("Dasd", columnName);
        //    collector.CollectItems(ref dasdDataSet);
        //    argListSet.Add("Dasd", collector.Items);

        //}


        private void ProcessLocations()
        {
            Dictionary<string, List<LocationListItem>> listSet = new Dictionary<string, List<LocationListItem>>();

            var key = "Location";

            CollectSwitchLocations(ref listSet, "Name");
            //CollectDasdLocations(ref listSet, "Location");

            var seqSwitch = listSet["Switch"];
            //var seqDasd = listSet["Dasd"];

            RefreshAssistant.AddVisualizerDataTable(key + "-Switch", seqSwitch);
            //RefreshAssistant.AddVisualizerDataTable(key + "-Dasd", seqDasd);

            var swLocs = (from a in seqSwitch
                          where !a.Name.IsNothing() &&
                          a.Name.Match(regex.SwitchName)
                          select new LocationListItem
                          {
                              Category = a.Category,
                              Prefix = "KWA",
                              Name = a.Name.Replace("SW", "").Remove(2)
                          }).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0, (a) => a.Name.GetHashCode());

            //var daLocs = (from a in seqDasd
            //              where !a.Name.IsNothing() &&
            //              a.Name.Match(regex.LocationAcronym)
            //              select new LocationListItem
            //              {
            //                  Category = a.Category,
            //                  Prefix = "KWA",
            //                  Name = a.Name.Replace("KWA", "")
            //              }).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0, (a) => a.Name.GetHashCode());

            //var all = (from l in swLocs.Union(daLocs)
            //           select new LocationListItem
            //           {
            //               Prefix = "KWA",
            //               Name = l.Name
            //           }).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0, (a) => a.Name.GetHashCode());

            var all = (from l in swLocs
                       select new LocationListItem
                       {
                           Prefix = "KWA",
                           Name = l.Name
                       }).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0, (a) => a.Name.GetHashCode());

            RefreshAssistant.AddVisualizerDataTable(key + "-All", all.ToList());

            listLocation = all.ToList();

        }
    }
}
