using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.Win32;
using System.Collections.Generic;
using KabMan.Forms;
using KabMan;
using KabMan.Data;

namespace Utils
{
    public class Common
    {
        #region Constants

        private const string REGISTRY_PATH = "Software\\KabMan\\";

        #endregion

        private readonly int maxx = 640;
        private readonly int maxy = 480;
        private RegistryKey creg;

        public Common()
        {
            maxy = Screen.PrimaryScreen.WorkingArea.Height;
            maxx = Screen.PrimaryScreen.WorkingArea.Width;
        }

        public static string RemoveSpaces(string str)
        {
            string result;
            Regex regulEx = new Regex(@"[\s]+");
            result = regulEx.Replace(str, " ");
            return result;
        }

        public static string ReplaceString(string value)
        {
            string newValue;

            if (value == String.Empty)
                return value;

            newValue = value.Replace("'", " ");
            newValue = newValue.Replace("\"", " ");

            return newValue;
        }

        public static int TimeConvertToMinute(TimeEdit tm)
        {
            DateTime dt = Convert.ToDateTime(tm.EditValue);
            return dt.Hour * 60 + dt.Minute;
        }

        public static int TimeConvertToMinute(TimeEdit tm1, TimeEdit tm2)
        {
            DateTime dt = Convert.ToDateTime(tm1.EditValue);
            int first = dt.Hour * 60 + dt.Minute;

            dt = Convert.ToDateTime(tm2.EditValue);
            int last = dt.Hour * 60 + dt.Minute;

            return last - first;
        }

        public static object ValueControl(string fieldValue)
        {
            if (fieldValue != String.Empty)
                return fieldValue;
            else
                return null;
        }

        public static object DBValueControl(string fieldValue)
        {
            if (fieldValue != String.Empty)
                return fieldValue;
            else
                return DBNull.Value;
        }

        public static object DBValueControl(object fieldValue)
        {
            if (fieldValue != null)
                return fieldValue;
            else
                return DBNull.Value;
        }


        public static void FillLookup(LookUpEdit objName, string procName, string displayMember, string valueMember)
        {
            objName.Properties.DataSource = DBAssistant.ExecProcedure(procName).Tables[0];
            objName.Properties.DisplayMember = displayMember;
            objName.Properties.ValueMember = valueMember;


        }

        public static void FillLookup(LookUpEdit objName, string procName, SqlParameter[] prm, string displayMember, string valueMember)
        {

            objName.Properties.DataSource = DBAssistant.ExecProcedure(procName, prm).Tables[0];
            objName.Properties.DisplayMember = displayMember;
            objName.Properties.ValueMember = valueMember;

        }

        public static void FillLookup(RepositoryItemLookUpEdit objName, string procName, string displayMember, string valueMember)
        {
            objName.DataSource = DBAssistant.ExecProcedure(procName).Tables[0];
            objName.DisplayMember = displayMember;
            objName.ValueMember = valueMember;
        }

        public static void FillLookup2(RepositoryItemLookUpEdit objName, string queryString, string displayMember, string valueMember)
        {

            objName.DataSource = DBAssistant.RunQuery(queryString).Tables[0];
            objName.DisplayMember = displayMember;
            objName.ValueMember = valueMember;

        }


        public static void FillLookup2(LookUpEdit objName, string queryString, string displayMember, string valueMember)
        {


            objName.Properties.DataSource = DBAssistant.RunQuery(queryString).Tables[0];
            objName.Properties.DisplayMember = displayMember;
            objName.Properties.ValueMember = valueMember;

        }

        public static void FillLookUpEdit(LookUpEdit argLookUpEdit, string argProcedureName, string argDisplayMember, string argValueMember)
        {
            FillLookUpEdit(argLookUpEdit, argProcedureName, null, argDisplayMember, argValueMember);
        }

        public static void FillLookUpEdit(LookUpEdit argLookUpEdit, string argProcedureName, object[] argParameters, string argDisplayMember, string argValueMember)
        {

            DataSet ds = DBAssistant.ExecProcedure(argProcedureName, argParameters);

            argLookUpEdit.Properties.DataSource = ds.Tables[0];
            argLookUpEdit.Properties.DisplayMember = argDisplayMember;
            argLookUpEdit.Properties.ValueMember = argValueMember;

        }
        // Load/save window positions
        public void SaveWinPos(XtraForm swin, string sname)
        {
            try
            {
                creg = Registry.CurrentUser.CreateSubKey(REGISTRY_PATH + "Windows\\" + sname);
                creg.SetValue("Left", swin.Left, RegistryValueKind.DWord);
                creg.SetValue("Top", swin.Top, RegistryValueKind.DWord);
                creg.SetValue("Width", swin.Width, RegistryValueKind.DWord);
                creg.SetValue("Height", swin.Height, RegistryValueKind.DWord);
                creg.Close();
            }
            catch (Exception)
            {
            }
            ;
        }

        public void LoadWinPos(XtraForm swin, string sname, bool getsize)
        {
            try
            {
                creg = Registry.CurrentUser.OpenSubKey(REGISTRY_PATH + "Windows\\" + sname);
                swin.Left = (int)creg.GetValue("Left", swin.Left);
                swin.Top = (int)creg.GetValue("Top", swin.Top);
                if (getsize)
                {
                    swin.Width = (int)creg.GetValue("Width", swin.Width);
                    swin.Height = (int)creg.GetValue("Height", swin.Height);
                    if (swin.Width <= 32) swin.Width = 32;
                    if (swin.Width > maxx) swin.Width = maxx;
                    if (swin.Height <= 16) swin.Height = 16;
                    if (swin.Height > maxy) swin.Height = maxy;
                }
                creg.Close();
            }
            catch (Exception)
            {
            }
            ;
            if ((swin.Top < 0) || (swin.Top > maxx)) swin.Top = 8;
            if ((swin.Left < 0) || (swin.Left > maxx)) swin.Left = 8;
        }

        // Load/save ListView columns
        public void SaveViewCols(GridView view, string sname)
        {
            try
            {
                Registry.CurrentUser.DeleteSubKeyTree(REGISTRY_PATH + "Grids\\" + sname);
            }
            catch (Exception)
            {
            }
            ;

            try
            {
                creg = Registry.CurrentUser.CreateSubKey(REGISTRY_PATH + "Grids\\" + sname);
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

        public void LoadViewCols(GridView view, string sname)
        {
            try
            {
                creg = Registry.CurrentUser.OpenSubKey(REGISTRY_PATH + "Grids\\" + sname);
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
            ;
        }
    }
}