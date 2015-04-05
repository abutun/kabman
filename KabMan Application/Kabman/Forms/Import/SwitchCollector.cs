using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KabMan.Import;
using userSettings = KabMan.Properties.Settings;
using KabMan.Extensions;
using KabMan.Windows;

namespace KabMan.Forms
{
    public partial class ExcelImportForm
    {
        private void CollectSwitches(out Dictionary<string, List<SwitchListItem>> argListSet, string argColumnKey)
        {
            argListSet = new Dictionary<string, List<SwitchListItem>>();

            string columnName;
            SwitchCollector collector;

            columnName = userSettings.Default.ImportSwitchPageColumns.ToDictionary()[argColumnKey];
            collector = new SwitchCollector("Switch", columnName);
            collector.CollectItems(ref switchDataSet);
            argListSet.Add("Switch", collector.Items);
        }

        private void ProcessSwitches()
        {
            Dictionary<string, List<SwitchListItem>> listSet;

            var key = "Switch";

            CollectSwitches(out listSet, "Name");

            var seqSwitch = listSet["Switch"];

            RefreshAssistant.AddVisualizerDataTable(key + "-All", seqSwitch.ToList());

            var grouped = from grp in seqSwitch
                          group grp by new
                          {
                              grp.Name,
                              grp.Category,
                              grp.Model,
                              grp.BlechName,
                              grp.VtPortName,
                              grp.SwitchType,
                              grp.CoreSwitchName

                          } into g
                          select new SwitchGroupedListItem
                          {
                              Category = g.Key.Category,
                              Name = g.Key.Name,
                              Model = g.Key.Model,
                              BlechName = g.Key.BlechName,
                              CoreSwitchName = g.Key.CoreSwitchName,
                              SwitchType = g.Key.SwitchType,
                              VtPortName = g.Key.VtPortName

                          };
            
            RefreshAssistant.AddVisualizerDataTable(key + "-Grouped", grouped.ToList());
            
            listSwitchAll = seqSwitch.ToList();
            listSwitchGrouped = grouped.ToList();

        }


       
    }
}
