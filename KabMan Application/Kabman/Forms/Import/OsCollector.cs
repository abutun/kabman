using System.Collections.Generic;
using KabMan.Import;
using userSettings = KabMan.Properties.Settings;
using KabMan.Extensions;
using KabMan.Windows;
using System.Linq;
using System.Globalization;

namespace KabMan.Forms
{
    public partial class ExcelImportForm
    {
        private void CollectOSs(out Dictionary<string, List<OSListItem>> argListSet, string argColumnKey)
        {
            argListSet = new Dictionary<string, List<OSListItem>>();

            string columnName;
            OperatingSystemCollector collector;

            columnName = userSettings.Default.ImportServerPageColumns.ToDictionary()[argColumnKey];
            collector = new OperatingSystemCollector("Server", columnName);
            collector.CollectItems(ref serverDataSet);
            argListSet.Add("Server", collector.Items);

        }

        private void ProcessOSs()
        {
            Dictionary<string, List<OSListItem>> listSet;

            var key = "OS";

            CollectOSs(out listSet, key);

            var seqServer = listSet["Server"];

            RefreshAssistant.AddVisualizerDataTable(key + "-Server", seqServer);

            var all = (from a in seqServer
                       where !string.IsNullOrEmpty(a.Name.Trim())
                       select new OSListItem
                       {
                           Category = a.Category,
                           Name = a.Name.ToLower(CultureInfo.CreateSpecificCulture("en-US"))
                       }).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0, (a) => a.Name.GetHashCode()); ;
            RefreshAssistant.AddVisualizerDataTable(key + "-All", all.ToList());

            listOS = all.ToList();

        }

    }
}
