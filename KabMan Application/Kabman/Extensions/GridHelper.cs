using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace KabMan
{
    class GridHelper
    {
        // Load/save ListView columns
        public static void SaveViewCols(GridView view, string sname)
        {
            //try
            //{

            //    //Registry.CurrentUser.DeleteSubKeyTree(REGISTRY_PATH + "Grids\\" + sname);
            //}
            //catch (Exception)
            //{
            //}
            //;

            try
            {
                RegistryKey creg;
                creg = Application.UserAppDataRegistry.CreateSubKey("Grids\\" + sname);
                //creg = Registry.CurrentUser.CreateSubKey(Application.UserAppDataRegistry. + "\\Grids\\" + sname);
                int i;
                for (i = 0; i < view.Columns.Count; i++)
                {
                    creg.SetValue("Col" + string.Format("{0:d3}", i), view.Columns[i].Width, RegistryValueKind.DWord);
                }
                creg.Close();
            }
            catch (Exception)
            {
            }
            ;
        }

        public static void LoadViewCols(GridView view, string sname)
        {
            try
            {
                RegistryKey creg;
                creg = Application.UserAppDataRegistry.OpenSubKey("Grids\\" + sname);
                //creg = Registry.CurrentUser.OpenSubKey(Application.UserAppDataRegistry + "\\Grids\\" + sname);

                int i;
                for (i = 0; i < view.Columns.Count; i++)
                {
                    view.Columns[i].Width =
                        (int)creg.GetValue("Col" + string.Format("{0:d3}", i), view.Columns[i].Width);
                }
                creg.Close();
            }
            catch (Exception)
            {
            }
        }
    }
}
