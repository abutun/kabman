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
        private void CollectSwitchModels(out Dictionary<string, List<SwitchModelListItem>> argListSet, string argColumnKey)
        {
            argListSet = new Dictionary<string, List<SwitchModelListItem>>();

            string columnName;
            SwitchModelCollector collector;

            columnName = userSettings.Default.ImportSwitchPageColumns.ToDictionary()[argColumnKey];
            collector = new SwitchModelCollector("Switch", columnName);
            collector.CollectItems(ref switchDataSet);
            argListSet.Add("Switch", collector.Items);
        }

        private void ProcessSwitchModels()
        {
            Dictionary<string, List<SwitchModelListItem>> listSet;

            var key = "Switch Model";

            CollectSwitchModels(out listSet, "Model");

            var seqSwitch = listSet["Switch"];

            RefreshAssistant.AddVisualizerDataTable(key + "-Switch", seqSwitch);

            var all = (from a in seqSwitch
                       where !string.IsNullOrEmpty(a.Name.Trim())
                       select a).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0, (a) => a.Name.GetHashCode()); ; ;
            RefreshAssistant.AddVisualizerDataTable(key + "-All", all.ToList());

            listSwitchModel = all.ToList();

            //var countEditor = new CollectedSwitchModelEditorForm(all.ToList());
            //countEditor.ShowDialog();
            //var returnSource = countEditor.DataSource;
            //RefreshAssistant.AddVisualizerDataTable(key + "-Grouped-Edited", returnSource);
        }

    }
}
