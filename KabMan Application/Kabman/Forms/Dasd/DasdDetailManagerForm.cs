using System;
using KabMan.Data;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors;

namespace KabMan.Forms
{
    public partial class DasdDetailManagerForm : DevExpress.XtraEditors.XtraForm
    {

        #region Properties

        private object _DasdID = null;
        /// <summary>
        /// Gets Rack ID which associated to this form
        /// </summary>
        public long DasdID
        {
            get
            {
                if (_DasdID != null)
                {
                    return Convert.ToInt64(this._DasdID);
                }
                return 0;
            }
        }

        private object _SanGroupId;
        public long SanGroupId
        {
            get
            {
                if (_SanGroupId != null)
                {
                    return Convert.ToInt64(this._SanGroupId);
                }
                return 0;
            }
        }

        #endregion

        #region Constructor

        public DasdDetailManagerForm()
        {
            InitializeComponent();
        }

        public DasdDetailManagerForm(object argRackID, Int64 sanGroupId)
        {
            this._DasdID = argRackID;
            this._SanGroupId = sanGroupId;
            InitializeComponent();
        }

        public DasdDetailManagerForm(object argRackID, string text, Int64 sanGroupId)
        {
            this._DasdID = argRackID;
            this._SanGroupId = sanGroupId;
            InitializeComponent();
            this.Text = text;
        }


        #endregion

        private void setVTPortRepositoryDataSource()
        {
            DataSet ds = DBAssistant.ExecProcedure(sproc.VTPort_For_Dasd_BySanGroupId, new object[] { "@SanGroupId", SanGroupId });

            repVtPortSan1.DataSource = ds.Tables[0];
            repVtPortSan2.DataSource = ds.Tables[1];
        }

        private void setBlechRepositoryDataSource()
        {
            DataSet ds = DBAssistant.ExecProcedure(sproc.Blech_For_Dasd, new object[] { });
            repBlechSan1.DataSource = ds.Tables[0];
            repBlechSan2.DataSource = ds.Tables[0];
        }

        private void setLcUrmRepositoryDataSource()
        {
            DataSet ds = DBAssistant.ExecProcedure(sproc.Cable_Select_Available_LcUrm_For_Dasd_BySanGroupId, new object[] { "@DasdID", this.DasdID, "@SanGroupId", this.SanGroupId });
            repLcUrmSan1.DataSource = ds.Tables[0];
            repLcUrmSan2.DataSource = ds.Tables[1];
        }

        private void DasdDetailManagerForm_Load(object sender, EventArgs e)
        {
            if (this.DasdID > 0)
            {
                DataSet dsMain = DBAssistant.ExecProcedure(sproc.DASDDetail_Select_BySanGroupId, new object[] { "@DASDID", this.DasdID, "@SanGroupId", this.SanGroupId });
                CSan1Grid.DataSource = dsMain.Tables[0];
                CSan2Grid.DataSource = dsMain.Tables[1];

                setVTPortRepositoryDataSource();
                setBlechRepositoryDataSource();
                setLcUrmRepositoryDataSource();

            }
        }

        private void CSan1View_ShownEditor(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            if (gridView.FocusedColumn == gridColumn2 || gridView.FocusedColumn == gridColumn4 || gridView.FocusedColumn == gridColumn7)
                if (XtraMessageBox.Show("Do you wish to edit this row?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                    gridView.CloseEditor();
                else
                {
                    if (gridView.ActiveEditor != null)
                        gridView.ActiveEditor.SelectAll();
                }

        }
        private void CSan2View_ShownEditor(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            if (gridView.FocusedColumn == gridColumn9 || gridView.FocusedColumn == gridColumn12 || gridView.FocusedColumn == gridColumn10)
                if (XtraMessageBox.Show("Do you wish to edit this row?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                    gridView.CloseEditor();
                else
                {
                    if (gridView.ActiveEditor != null)
                        gridView.ActiveEditor.SelectAll();
                }

        }

        private void repVtPortSan1_Popup(object sender, EventArgs e)
        {
            DataView view = ((DataTable)repVtPortSan1.DataSource).DefaultView;
            view.RowFilter = "VTPortId=" + CSan1View.GetFocusedRowCellValue("VTPortId").ToString();
        }

        private void repVtPortSan1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            DataView view = ((DataTable)repVtPortSan1.DataSource).DefaultView;
            view.RowFilter = "" ;

        }

        private void repVtPortSan2_Popup(object sender, EventArgs e)
        {
            DataView view = ((DataTable)repVtPortSan2.DataSource).DefaultView;
            view.RowFilter = "VTPortId=" + CSan2View.GetFocusedRowCellValue("VTPortId").ToString();

        }

        private void repVtPortSan2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            DataView view = ((DataTable)repVtPortSan2.DataSource).DefaultView;
            view.RowFilter = "" ;

        }

        private void repBlechSan1_Popup(object sender, EventArgs e)
        {
            DataView view = ((DataTable)repBlechSan1.DataSource).DefaultView;
            view.RowFilter = "BlechId=" + CSan1View.GetFocusedRowCellValue("BlechId").ToString();
        }

        private void repBlechSan1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            DataView view = ((DataTable)repBlechSan1.DataSource).DefaultView;
            view.RowFilter = "";
        }

        private void repBlechSan2_Popup(object sender, EventArgs e)
        {
            DataView view = ((DataTable)repBlechSan2.DataSource).DefaultView;
            view.RowFilter = "BlechId=" + CSan2View.GetFocusedRowCellValue("BlechId").ToString();
        }

        private void repBlechSan2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            DataView view = ((DataTable)repBlechSan2.DataSource).DefaultView;
            view.RowFilter = "";
        }

        private void repLcUrmSan1_Popup(object sender, EventArgs e)
        {
            DataView dv = ((DataTable)repLcUrmSan1.DataSource).DefaultView;
            dv.RowFilter = "Connected = 'False'";
        }

        private void repLcUrmSan1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            DataView dv = ((DataTable)repLcUrmSan1.DataSource).DefaultView;
            dv.RowFilter = "";
        }

        private void repLcUrmSan2_Popup(object sender, EventArgs e)
        {
            DataView dv = ((DataTable)repLcUrmSan2.DataSource).DefaultView;
            dv.RowFilter = "Connected = 'False'";
        }

        private void repLcUrmSan2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            DataView dv = ((DataTable)repLcUrmSan2.DataSource).DefaultView;
            dv.RowFilter = "";
        }

        private void CSan1View_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == gridColumn2)
            {
                DBAssistant.ExecProcedure(sproc.DasdDetail_Update_LcUrm, new object[] { "@LcUrmID", e.Value, "@ID", CSan1View.GetRowCellValue(e.RowHandle, "ID") });
                setLcUrmRepositoryDataSource();
            }
            else if (e.Column == gridColumn4)
            {
                string typeName = "VTPort";
                object dasdDetailId = CSan1View.GetRowCellValue(e.RowHandle, "ID");
                object newVtPortId = e.Value;

                DBAssistant.ExecProcedure(sproc.DasdDetail_Blech_VTPort_Update, new object[] { "@DasdDetailID", dasdDetailId, "@TypeName", typeName, "@NewObjectId", newVtPortId });
                setVTPortRepositoryDataSource();
            }
            else if (e.Column == gridColumn7)
            {
                string typeName = "Blech";
                object dasdDetailId = CSan1View.GetRowCellValue(e.RowHandle, "ID");
                object newBlechId = e.Value;

                DBAssistant.ExecProcedure(sproc.DasdDetail_Blech_VTPort_Update, new object[] { "@DasdDetailID", dasdDetailId, "@TypeName", typeName, "@NewObjectId", newBlechId });
                setBlechRepositoryDataSource();
            }
        }

        private void CSan2View_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == gridColumn9)
            {
                DBAssistant.ExecProcedure(sproc.DasdDetail_Update_LcUrm, new object[] { "@LcUrmID", e.Value, "@ID", CSan2View.GetRowCellValue(e.RowHandle, "ID") });
                setLcUrmRepositoryDataSource();
            }
            else if (e.Column == gridColumn12)
            {
                string typeName = "VTPort";
                object dasdDetailId = CSan2View.GetRowCellValue(e.RowHandle, "ID");
                object newVtPortId = e.Value;

                DBAssistant.ExecProcedure(sproc.DasdDetail_Blech_VTPort_Update, new object[] { "@DasdDetailID", dasdDetailId, "@TypeName", typeName, "@NewObjectId", newVtPortId });
                setVTPortRepositoryDataSource();
            }
            else if (e.Column == gridColumn10)
            {
                string typeName = "Blech";
                object dasdDetailId = CSan2View.GetRowCellValue(e.RowHandle, "ID");
                object newBlechId = e.Value;

                DBAssistant.ExecProcedure(sproc.DasdDetail_Blech_VTPort_Update, new object[] { "@DasdDetailID", dasdDetailId, "@TypeName", typeName, "@NewObjectId", newBlechId });
                setBlechRepositoryDataSource();
            }
        }


        

    }
}