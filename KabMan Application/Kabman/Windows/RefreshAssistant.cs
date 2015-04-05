using System.Windows.Forms;
using KabMan.Forms;
using KabMan.Import;
using KabMan.Test;
using System.Collections.Generic;
using System.Collections;

namespace KabMan.Windows
{
    public static class RefreshAssistant
    {
        public static void RefreshTrees()
        {
            try
            {
                if (Application.OpenForms["Home"] != null)
                    ((Home)Application.OpenForms["Home"]).InitializeTrees();
            }
            catch
            {

            }

        }

        public static void RefreshSwitchImportTest(SwitchImportComponent argComponent)
        {
            try
            {
                if (Application.OpenForms["SwitchImportTest"] != null)
                    ((SwitchImportTest)Application.OpenForms["SwitchImportTest"]).RefreshTestForm(argComponent);
            }
            catch
            {

            }

        }

        public static void AddVisualizerDataTable(string argKey, IEnumerable argTable)
        {
            try
            {
                if (Application.OpenForms["DataSetVisualizerForm"] != null)
                    ((DataSetVisualizerForm)Application.OpenForms["DataSetVisualizerForm"]).AddDataTable(argKey, argTable);
            }
            catch
            {

            }
        }

        public static void RefreshConnectionDetailForm()
        {
            try { 
                Form form = Application.OpenForms["ConnectionDetailForm"];
                    if(form != null)
                    {
                        //DeviceIDLookup editvalue must be set as the second parameter
                        //FindControl()
                        //Ahmet BÜTÜN
                        ((ConnectionDetailForm)form).LoadData(true, 1);
                    }
            }
            catch
            {}
        }
    }
}
