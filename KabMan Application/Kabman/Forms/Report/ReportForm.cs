using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KabMan.Data;

namespace KabMan.Forms
{
    public partial class ReportForm : DevExpress.XtraEditors.XtraForm
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void InitializeManager()
        {
            itemPreview.Glyph = Resources.GetImage("ManagerEdit");
            ItemBtnClose.Glyph = Resources.GetImage("ManagerExit");
        }
        DataTable resultTable = new DataTable();

        private void CSearchIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoSearch("");
        }

        private void CSearchThis_EditValueChanged(object sender, EventArgs e)
        {
            DoSearch(CSearchThis.EditValue.ToString());
        }

        #region DoSearch

        private void DoSearch(string argQuery)
        {
            switch (CSearchIn.SelectedItem.ToString())
            {
                case "Cable":
                    this.CSearchTypeItemControl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    DoSearch(sproc.Search_Cable_Select_All, argQuery, "");
                    break;
                case "Server":
                    this.CSearchTypeItemControl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    DoSearch(sproc.Search_Server_Select_All, argQuery, "");
                    break;
                case "Connection":
                    this.CSearchTypeItemControl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    this.comboBoxEdit1_SelectedIndexChanged(this, new EventArgs());
                    break;
                case "Switch":
                    this.CSearchTypeItemControl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    DoSearch(sproc.Search_Switch_Select_All, argQuery, "");
                    break;
                case "DASD":
                    this.CSearchTypeItemControl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    DoSearch(sproc.Search_DASD_Select_All, argQuery, "");
                    break;
                case "DCC":
                    this.CSearchTypeItemControl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    DoSearch(sproc.Search_DCC_Select_All, argQuery, "");
                    break;
            }

            itemResultCount.Caption = resultTable.DefaultView.Count.ToString();
        }

        private void DoSearch(string argProcedure, string argQuery, string argType)
        {
            ClearResult();
            if (argType != "")
                resultTable = DBAssistant.ExecProcedure(argProcedure, new object[] { "@Query", argQuery, "@DeviceType", argType }).Tables[0];
            else
                resultTable = DBAssistant.ExecProcedure(argProcedure, new object[] { "@Query", argQuery }).Tables[0];
            CResultGrid.DataSource = resultTable;
            itemResultCount.Caption = resultTable.DefaultView.Count.ToString();
        }

        #endregion

        private void ClearResult()
        {
            CResultView.Columns.Clear();
            resultTable = new DataTable();
            CResultGrid.DataSource = resultTable;
        }



        private void itemClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the XtraGrid control can be previewed.
            if (!CResultGrid.IsPrintingAvailable)
            {
                XtraMessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Opens the Preview window.
            CResultGrid.ShowPrintPreview();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string argQuery = "";

            if (this.CSearchThis.EditValue != null)
                argQuery = this.CSearchThis.EditValue.ToString();

            if (CSearchType.SelectedItem != null)
            {
                switch (CSearchType.SelectedItem.ToString())
                {
                    case "DASD":
                        DoSearch(sproc.Search_Connection_Select_All, argQuery, "1");
                        break;
                    case "Server":
                        DoSearch(sproc.Search_Connection_Select_All, argQuery, "2");
                        break;
                    case "DCC":
                        DoSearch(sproc.Search_Connection_Select_All, argQuery, "7");
                        break;
                }
            }
        }

    }
}