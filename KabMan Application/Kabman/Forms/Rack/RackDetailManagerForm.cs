using System;
using KabMan.Data;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;

namespace KabMan.Forms
{
    public partial class RackDetailManagerForm : DevExpress.XtraEditors.XtraForm
    {

        #region Properties

        private object _RackID = null;
        /// <summary>
        /// Gets Rack ID which associated to this form
        /// </summary>
        public long RackID
        {
            get
            {
                if (_RackID != null)
                {
                    return Convert.ToInt64(this._RackID);
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

        public RackDetailManagerForm()
        {
            this.Icon = Resources.GetIcon("KabManIcon");
            InitializeComponent();
        }

        public RackDetailManagerForm(object argRackID, Int64 sanGroupId)
        {
            this.Icon = Resources.GetIcon("KabManIcon");
            this._RackID = argRackID;
            this._SanGroupId = sanGroupId;
            InitializeComponent();
        }

        public RackDetailManagerForm(object argRackID, string text, Int64 sanGroupId)
        {
            this._SanGroupId = sanGroupId;
            this._RackID = argRackID;
            InitializeComponent();
            this.Text = text;
        }

        private void RackDetailManagerForm_Load(object sender, EventArgs e)
        {
            if (this.RackID > 0)
            {
                DataSet ds = DBAssistant.ExecProcedure(sproc.ServerDetail_Select_BySanGroupId, new object[] { "@ServerID", this.RackID, "@SanGroupId", this.SanGroupId });
                CSan1Grid.DataSource = ds.Tables[0];
                CSan2Grid.DataSource = ds.Tables[1];

                setVTPortRepositoryDataSource();
                setBlechRepositoryDataSource();
                setLcUrmRepositoryDataSource();
            }
        }

        #endregion

        private void setVTPortRepositoryDataSource()
        {
            DataSet ds = DBAssistant.ExecProcedure(sproc.VTPort_For_Rack_BySanGroupId, new object[]{"@SanGroupId", SanGroupId});

            repVtPortSan1.DataSource = ds.Tables[0];
            repVtPortSan2.DataSource = ds.Tables[1];
        }

        private void setBlechRepositoryDataSource()
        {
            DataSet ds = DBAssistant.ExecProcedure(sproc.Blech_For_Rack, new object[] {});
            repBlechSan1.DataSource = ds.Tables[0];
            repBlechSan2.DataSource = ds.Tables[0];
        }

        private void setLcUrmRepositoryDataSource()
        {
            DataSet ds = DBAssistant.ExecProcedure(sproc.Cable_Select_Available_LcUrm_For_Rack_BySanGroupId, new object[] { "@RackID", this.RackID, "@SanGroupId", this.SanGroupId });

            repLcUrmSan1.DataSource = ds.Tables[0];
            repLcUrmSan2.DataSource = ds.Tables[1];

        }

        private void CSan2View_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {            
            if (e.Column == gridColumn9)
            {
                DBAssistant.ExecProcedure(sproc.ServerDetail_Update_LcUrm, new object[] { "@LcUrmID", e.Value, "@ID", CSan2View.GetRowCellValue(e.RowHandle, "ID") });
                repLcUrmSan2.DataSource = DBAssistant.ExecProcedure(sproc.Cable_Select_Available_LcUrm_For_Rack, new object[] { "@RackID", this.RackID, "@SanValue", 2 }).Tables[0].DefaultView;
            }
            else if (e.Column == gridColumn12)
            {

                string typeName = "VTPort";
                object serverDetailId = CSan2View.GetRowCellValue(e.RowHandle, "ID");
                object newVtPortId = e.Value;

                DBAssistant.ExecProcedure(sproc.ServerDetail_Blech_VTPort_Update, new object[] { "@ServerDetailID", serverDetailId, "@TypeName", typeName, "@NewObjectId", newVtPortId });
                setVTPortRepositoryDataSource();
                
            }
            else if (e.Column == gridColumn10)
            {

                string typeName = "Blech";
                object serverDetailId = CSan2View.GetRowCellValue(e.RowHandle, "ID");
                object newBlechId = e.Value;

                DBAssistant.ExecProcedure(sproc.ServerDetail_Blech_VTPort_Update, new object[] { "@ServerDetailID", serverDetailId, "@TypeName", typeName, "@NewObjectId", newBlechId });
                setBlechRepositoryDataSource();

            }
            
        }

        private void CSan1View_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {            
            if (e.Column == gridColumn2)
            {
                DBAssistant.ExecProcedure(sproc.ServerDetail_Update_LcUrm, new object[] { "@LcUrmID", e.Value, "@ID", CSan1View.GetRowCellValue(e.RowHandle, "ID") });
                setLcUrmRepositoryDataSource();
            }
            else if (e.Column == gridColumn4)
            {
                string typeName = "VTPort";
                object serverDetailId = CSan1View.GetRowCellValue(e.RowHandle, "ID");
                object newVtPortId = e.Value;

                DBAssistant.ExecProcedure(sproc.ServerDetail_Blech_VTPort_Update, new object[] { "@ServerDetailID", serverDetailId, "@TypeName", typeName, "@NewObjectId", newVtPortId });
                setVTPortRepositoryDataSource();
            }
            else if (e.Column == gridColumn7)
            {
                string typeName = "Blech";
                object serverDetailId = CSan1View.GetRowCellValue(e.RowHandle, "ID");
                object newBlechId = e.Value;

                DBAssistant.ExecProcedure(sproc.ServerDetail_Blech_VTPort_Update, new object[] { "@ServerDetailID", serverDetailId, "@TypeName", typeName, "@NewObjectId", newBlechId });
                setBlechRepositoryDataSource();


            }
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

        private void repVtPortSan1_Popup(object sender, EventArgs e)
        {
            DataView view = ((DataTable)repVtPortSan1.DataSource).DefaultView;
            view.RowFilter = "VTPortId=" + CSan1View.GetFocusedRowCellValue("VTPortId").ToString();
        }

        private void repVtPortSan1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            DataView view = ((DataTable)repVtPortSan1.DataSource).DefaultView;
            view.RowFilter = "";
        }

        private void repVtPortSan2_Popup(object sender, EventArgs e)
        {
            DataView view = ((DataTable)repVtPortSan2.DataSource).DefaultView;
            view.RowFilter = "VTPortId=" + CSan2View.GetFocusedRowCellValue("VTPortId").ToString();
        }
    
        private void repVtPortSan2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            DataView view = ((DataTable)repVtPortSan2.DataSource).DefaultView;
            view.RowFilter = "";
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
        private void CSan1View_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //if (e.Column == gridColumn2 || e.Column == gridColumn4 || e.Column == gridColumn7)
            //{
            //    if (MessageBox.Show("CSan1View", "Bla Bla", MessageBoxButtons.YesNo) != DialogResult.Yes)
            //    {                                        
            //        return;
            //    }                
            //}
        }

        private void CSan1View_ShownEditor(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            if (gridView.FocusedColumn == gridColumn2 || gridView.FocusedColumn == gridColumn4 || gridView.FocusedColumn == gridColumn7)
                if (XtraMessageBox.Show("Do you wish to edit this row?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                    gridView.CloseEditor();
                else
                {
                    if(gridView.ActiveEditor!=null)
                    gridView.ActiveEditor.SelectAll();
                }

        }

        private void CSan2View_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //GridView gridView = sender as GridView;
            //if (gridView.FocusedColumn == gridColumn9 || gridView.FocusedColumn == gridColumn12 || gridView.FocusedColumn == gridColumn10)
            //    if (XtraMessageBox.Show("Do you wish to edit this row?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            //        gridView.CloseEditor();
            //    else
            //    {
            //        if (gridView.ActiveEditor != null)
            //            gridView.ActiveEditor.SelectAll();
            //    }
        }

    }
}