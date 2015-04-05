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
        private void CollectDasdModels(out Dictionary<string, List<DasdModelListItem>> argListSet, string argColumnKey)
        {
            argListSet = new Dictionary<string, List<DasdModelListItem>>();

            string columnName;
            DasdModelCollector collector;

            columnName = userSettings.Default.ImportDasdPageColumns.ToDictionary()[argColumnKey];
            collector = new DasdModelCollector("Dasd", columnName);
            collector.CollectItems(ref dasdDataSet);
            argListSet.Add("Dasd", collector.Items);
        }

        private void ProcessDasdModels()
        {
            Dictionary<string, List<DasdModelListItem>> listSet;

            var key = "Dasd Model";

            CollectDasdModels(out listSet, "Model");

            var seqDasd = listSet["Dasd"];

            RefreshAssistant.AddVisualizerDataTable(key + "-Dasd", seqDasd);

            var all = (from a in seqDasd
                       where !string.IsNullOrEmpty(a.Name.Trim())
                       select a).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0, (a) => a.Name.GetHashCode()); ; ;
            RefreshAssistant.AddVisualizerDataTable(key + "-All", all.ToList());

            //var countEditor = new CollectedDasdModelEditorForm(all.ToList());
            //countEditor.ShowDialog();
            //var returnSource = countEditor.DataSource;
            //RefreshAssistant.AddVisualizerDataTable(key + "-Grouped-Edited", returnSource);
        }

    }
}
