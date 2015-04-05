using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KabMan.Data;
using DevExpress.XtraGrid.Views.Grid;

namespace KabMan.Forms
{
    public partial class DCCDetailList : DevExpress.XtraEditors.XtraForm
    {
        Int64 san1vtport1oldvalue = 0;
        Int64 san1vtport2oldvalue = 0;
        Int64 san2vtport1oldvalue = 0;
        Int64 san2vtport2oldvalue = 0;

        #region Properties

        private object _DCC_ID = null;
        /// <summary>
        /// Gets DCC ID which associated to this form
        /// </summary>
        public long DCC_ID
        {
            get
            {
                if (_DCC_ID != null)
                {
                    return Convert.ToInt64(this._DCC_ID);
                }
                return 0;
            }
        }

        private object _SanGroupId11;
        public long SanGroupId11
        {
            get
            {
                if (_SanGroupId11 != null)
                {
                    return Convert.ToInt64(this._SanGroupId11);
                }
                return 0;
            }
        }

        private object _SanGroupId12;
        public long SanGroupId12
        {
            get
            {
                if (_SanGroupId12 != null)
                {
                    return Convert.ToInt64(this._SanGroupId12);
                }
                return 0;
            }
        }

        private object _SanGroupId21;
        public long SanGroupId21
        {
            get
            {
                if (_SanGroupId21 != null)
                {
                    return Convert.ToInt64(this._SanGroupId21);
                }
                return 0;
            }
        }

        private object _SanGroupId22;
        public long SanGroupId22
        {
            get
            {
                if (_SanGroupId22!= null)
                {
                    return Convert.ToInt64(this._SanGroupId22);
                }
                return 0;
            }
        }

        #endregion

        #region Constructor

        public DCCDetailList()
        {
            this.Icon = Resources.GetIcon("KabManIcon");
            InitializeComponent();
        }

        public DCCDetailList(object argDCC_ID, string text)
        {
            this.Icon = Resources.GetIcon("KabManIcon");
            this._DCC_ID = argDCC_ID;

            // Get sunids from connection object
            DataSet ds = DBAssistant.ExecProcedure(sproc.DCC_Select_ById, new Object[] { "@ID", argDCC_ID });

            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        this._SanGroupId11 = ds.Tables[0].Rows[0]["SanGroup11_ID"]; //VTPort1San1
                        this._SanGroupId12 = ds.Tables[0].Rows[0]["SanGroup12_ID"]; //VTPort1San2
                        this._SanGroupId21 = ds.Tables[0].Rows[0]["SanGroup21_ID"]; //VTPort2San1
                        this._SanGroupId22 = ds.Tables[0].Rows[0]["SanGroup22_ID"]; //VTPort2San2
                    }
                }
            }
            InitializeComponent();
            this.Text = text;
        }

        public DCCDetailList(object argDCC_ID, Int64 sanGroupId11, Int64 sanGroupId12, Int64 sanGroupId21, Int64 sanGroupId22)
        {
            this.Icon = Resources.GetIcon("KabManIcon");
            this._DCC_ID = argDCC_ID;
            this._SanGroupId11 = sanGroupId11;
            this._SanGroupId12 = sanGroupId12;
            this._SanGroupId21 = sanGroupId21;
            this._SanGroupId22 = sanGroupId22;
            InitializeComponent();
        }

        public DCCDetailList(object argDCCID, string text, Int64 sanGroupId11, Int64 sanGroupId12, Int64 sanGroupId21, Int64 sanGroupId22)
        {
            this._DCC_ID = argDCCID;
            this._SanGroupId11 = sanGroupId11;
            this._SanGroupId12 = sanGroupId12;
            this._SanGroupId21 = sanGroupId21;
            this._SanGroupId22 = sanGroupId22;
            InitializeComponent();
            this.Text = text;
        }
        #endregion

        private void DCCDetailList_Load(object sender, EventArgs e)
        {
            if (this.DCC_ID > 0)
            {
                DCCSan1Grid.DataSource = DBAssistant.ExecProcedure(sproc.DCCDetail_Select_BySanValue, new object[] { "@DCC_ID", this.DCC_ID, "@SanValue", 1 }).Tables[0];
                DCCSan2Grid.DataSource = DBAssistant.ExecProcedure(sproc.DCCDetail_Select_BySanValue, new object[] { "@DCC_ID", this.DCC_ID, "@SanValue", 2 }).Tables[0];

                LoadSanValues();
            }
        }

        private void LoadSanValues()
        {
            setVTPortRepositoryDataSource4SAN11();
            setVTPortRepositoryDataSource4SAN12();
            setVTPortRepositoryDataSource4SAN21();
            setVTPortRepositoryDataSource4SAN22();
        }

        private void setVTPortRepositoryDataSource4SAN11()
        {
            DataSet ds = DBAssistant.ExecProcedure(sproc.VTPort_For_Dcc1_BySanGroupId, new object[] { "@SanID", SanGroupId11 });

            repVtPort1San1.DataSource = ds.Tables[0];
        }


        private void setVTPortRepositoryDataSource4SAN12()
        {
            DataSet ds = DBAssistant.ExecProcedure(sproc.VTPort_For_Dcc2_BySanGroupId, new object[] { "@SanID", SanGroupId21 });

            repVtPort1San2.DataSource = ds.Tables[0];
        }

        private void setVTPortRepositoryDataSource4SAN21()
        {
            DataSet ds = DBAssistant.ExecProcedure(sproc.VTPort_For_Dcc1_BySanGroupId, new object[] { "@SanID", SanGroupId12 });

            repVtPort2San1.DataSource = ds.Tables[0];
        }


        private void setVTPortRepositoryDataSource4SAN22()
        {
            DataSet ds = DBAssistant.ExecProcedure(sproc.VTPort_For_Dcc2_BySanGroupId, new object[] { "@SanID", SanGroupId22 });

            repVtPort2San2.DataSource = ds.Tables[0];
        }

        private void CSan1View_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == gridColumn4)
            {
                object dccDetailId = CSan1View.GetRowCellValue(e.RowHandle, "ID");
                object newVtPortId = e.Value;

                if (Int64.Parse(newVtPortId.ToString()) != this.san1vtport1oldvalue)
                {
                    if (XtraMessageBox.Show("Do you wish to edit this row?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DBAssistant.ExecProcedure(sproc.DccDetail_VTPort_Update, new object[] { "@DccDetailID", dccDetailId, "@NewObjectId", newVtPortId, "@Type", "1" });

                        this.san1vtport1oldvalue = Int64.Parse(newVtPortId.ToString());

                        LoadSanValues();
                    }
                }
            }
            else if (e.Column == gridColumn7)
            {
                object dccDetailId = CSan1View.GetRowCellValue(e.RowHandle, "ID");
                object newVtPortId = e.Value;

                if (Int64.Parse(newVtPortId.ToString()) != this.san1vtport2oldvalue)
                {
                    if (XtraMessageBox.Show("Do you wish to edit this row?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DBAssistant.ExecProcedure(sproc.DccDetail_VTPort_Update, new object[] { "@DccDetailID", dccDetailId, "@NewObjectId", newVtPortId, "@Type", "2" });

                        this.san1vtport2oldvalue = Int64.Parse(newVtPortId.ToString());

                        LoadSanValues();
                    }
                }
            }

        }

        private void CSan1View_ShownEditor(object sender, EventArgs e)
        {
            //GridView gridView = sender as GridView;
            //if (gridView.FocusedColumn == gridColumn4 || gridView.FocusedColumn == gridColumn7)
            //    if (XtraMessageBox.Show("Do you wish to edit this row?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            //        gridView.CloseEditor();
            //    else
            //    {
            //        if (gridView.ActiveEditor != null)
            //            gridView.ActiveEditor.SelectAll();
            //    }
        }

        private void CSan2View_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == gridColumn17)
            {
                object dccDetailId = CSan2View.GetRowCellValue(e.RowHandle, "ID");
                object newVtPortId = e.Value;

                if (Int64.Parse(newVtPortId.ToString()) != this.san2vtport1oldvalue)
                {
                    if (XtraMessageBox.Show("Do you wish to edit this row?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DBAssistant.ExecProcedure(sproc.DccDetail_VTPort_Update, new object[] { "@DccDetailID", dccDetailId, "@NewObjectId", newVtPortId, "@Type", "1" });

                        this.san2vtport1oldvalue = Int64.Parse(newVtPortId.ToString());

                        LoadSanValues();
                    }
                }
            }
            else if (e.Column == gridColumn19)
            {
                object dccDetailId = CSan2View.GetRowCellValue(e.RowHandle, "ID");
                object newVtPortId = e.Value;

                if (Int64.Parse(newVtPortId.ToString()) != this.san2vtport2oldvalue)
                {
                    if (XtraMessageBox.Show("Do you wish to edit this row?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DBAssistant.ExecProcedure(sproc.DccDetail_VTPort_Update, new object[] { "@DccDetailID", dccDetailId, "@NewObjectId", newVtPortId, "@Type", "2" });

                        this.san2vtport2oldvalue = Int64.Parse(newVtPortId.ToString());

                        LoadSanValues();
                    }
                }
            }
        }

        private void CSan2View_ShownEditor(object sender, EventArgs e)
        {
            //GridView gridView = sender as GridView;
            //if (gridView.FocusedColumn == gridColumn4 || gridView.FocusedColumn == gridColumn7)
            //    if (XtraMessageBox.Show("Do you wish to edit this row?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            //        gridView.CloseEditor();
            //    else
            //    {
            //        if (gridView.ActiveEditor != null)
            //            gridView.ActiveEditor.SelectAll();
            //    }
        }

        private void CSan1View_RowClick(object sender, RowClickEventArgs e)
        {
            //object vtport1id = CSan1View.GetRowCellValue(e.RowHandle, "VTPORT1DetailId");
            //object vtport2id = CSan1View.GetRowCellValue(e.RowHandle, "VTPORT2DetailId");

            //this.san1vtport1oldvalue = Int64.Parse(vtport1id.ToString());
            //this.san1vtport2oldvalue = Int64.Parse(vtport2id.ToString());
        }

        private void CSan1View_Click(object sender, EventArgs e)
        {
            object vtport1id = this.CSan1View.GetFocusedRowCellValue("VTPORT1DetailId");
            object vtport2id = this.CSan1View.GetFocusedRowCellValue("VTPORT2DetailId");

            this.san1vtport1oldvalue = Int64.Parse(vtport1id.ToString());
            this.san1vtport2oldvalue = Int64.Parse(vtport2id.ToString());
        }

        private void CSan2View_Click(object sender, EventArgs e)
        {
            object vtport1id = this.CSan1View.GetFocusedRowCellValue("VTPORT1DetailId");
            object vtport2id = this.CSan1View.GetFocusedRowCellValue("VTPORT2DetailId");

            this.san2vtport1oldvalue = Int64.Parse(vtport1id.ToString());
            this.san2vtport2oldvalue = Int64.Parse(vtport2id.ToString());
        }

        private void repVtPort2San1_Popup(object sender, EventArgs e)
        {
            //DataView view = ((DataTable)repVtPort2San1.DataSource).DefaultView;
            //view.RowFilter = "VTPORT1Id=" + CSan2View.GetFocusedRowCellValue("VTPORT1Id").ToString();
        }

        private void repVtPort2San1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            //DataView view = ((DataTable)repVtPort2San1.DataSource).DefaultView;
            //view.RowFilter = "";
        }

        private void repVtPort1San2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            //DataView view = ((DataTable)repVtPort1San2.DataSource).DefaultView;
            //view.RowFilter = "";
        }

        private void repVtPort1San2_Popup(object sender, EventArgs e)
        {
            //DataView view = ((DataTable)repVtPort1San2.DataSource).DefaultView;
            //view.RowFilter = "VTPORT2Id=" + CSan1View.GetFocusedRowCellValue("VTPORT2Id").ToString();
        }

        private void repVtPort2San2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            //DataView view = ((DataTable)repVtPort2San2.DataSource).DefaultView;
            //view.RowFilter = "";
        }

        private void repVtPort2San2_Popup(object sender, EventArgs e)
        {
            //DataView view = ((DataTable)repVtPort2San2.DataSource).DefaultView;
            //view.RowFilter = "VTPORT2Id=" + CSan2View.GetFocusedRowCellValue("VTPORT2Id").ToString();
        }

        private void repVtPort1San1_Popup(object sender, EventArgs e)
        {
            //DataView view = ((DataTable)repVtPort1San1.DataSource).DefaultView;
            //view.RowFilter = "VTPORT1Id=" + CSan1View.GetFocusedRowCellValue("VTPORT1Id").ToString();
        }

        private void repVtPort1San1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            //DataView view = ((DataTable)repVtPort1San1.DataSource).DefaultView;
            //view.RowFilter = "";
        }


    }
}