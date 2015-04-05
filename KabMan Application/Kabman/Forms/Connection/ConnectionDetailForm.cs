using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using KabMan.Data;
using KabMan.Windows;
using KabMan.XtraReports;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Drawing;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;
using KabMan.Forms.Connection;

namespace KabMan.Forms
{
    public partial class ConnectionDetailForm : DevExpress.XtraEditors.XtraForm
    {

        private RefreshHelper helper;
        GridHitInfo hitInfo;

        private long _FocusedDetailID = -1;
        private long FocusedDetailID
        {
            get
            {
                return _FocusedDetailID;
            }
            set
            {
                _FocusedDetailID = value;
            }
        }

        private int _SanValue;
        private int SanValue
        {
            get
            {
                return _SanValue;
            }
            set
            {
                _SanValue = value;
            }
        }

        private int _ExpandedRowIndex;
        private int ExpandedRowIndex
        {
            get
            {
                return _ExpandedRowIndex;
            }
            set
            {
                _ExpandedRowIndex = value;
            }
        }

        public ConnectionDetailForm()
        {
            InitializeComponent();
        }

        private void InitDetailViewColumns(int DeviceID)
        {
            this.CDetailView.Columns.Clear();

            if (DeviceID == 1)
            {
                //DASD
                this.CDetailView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
                this.gridColumn19, //DeviceType
                this.gridColumn21, //Connection Name
                this.gridColumn20, //Port
                this.gridColumn6,
                this.gridColumn7,
                this.gridColumn8,
                this.gridColumn9,
                this.gridColumn10,
                this.gridColumn11,
                this.gridColumn12,
                this.gridColumn13,
                this.gridColumn14,
                this.gridColumn15,
                this.gridColumn16,
                this.gridColumn17});
            }
            else if (DeviceID == 2)
            {
                //Server
                this.CDetailView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
                this.gridColumn19, //Device Type
                this.gridColumn5, //Server Name
                this.gridColumn6, //Rack
                this.gridColumn7, //LCURM
                this.gridColumn8, //Blech
                this.gridColumn9, //Trunk
                this.gridColumn10, //VTPort
                this.gridColumn11, //UrmUrm
                this.gridColumn12, //VTPort1
                this.gridColumn13, //Trunk
                this.gridColumn14, //Blech
                this.gridColumn15, //LCURM
                this.gridColumn16, //PortNo
                this.gridColumn17}); //Switch Name
            }
            else if (DeviceID == 7)
            {
                //Data Center Connection
                this.CDetailView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
                this.gridColumn19, //Type
                this.gridColumn21, //Connection Name
                this.gridColumn6, //Rack
                this.gridColumn10, //VTPort
                this.gridColumn22, //UrmUrm1
                this.gridColumn12, //VtPort1
                this.gridColumn13, //Trunk
                this.gridColumn23, //VTPort2
                this.gridColumn24, //UrmUrm2
                this.gridColumn25, //VTPort(3)
                this.gridColumn16, //Port No
                this.gridColumn17}); //Switch Name
            }

        }

        private void ConnectionDetailForm_Load(object sender, EventArgs e)
        {
            focusView = CMasterView;

            helper = new RefreshHelper(CMasterView, "ID");

            if (this.DeviceIDLookUp.ItemIndex >= 0)
                LoadData(false, int.Parse(this.DeviceIDLookUp.EditValue.ToString()));
        }

        internal void LoadData(bool savePos, int deviceID)
        {
            // grid pozisyonu kayit ediliyor
            if (savePos) helper.SaveViewInfo();

            InitDetailViewColumns(deviceID);

            DataSet ds = DBAssistant.ExecProcedure("[sproc].[ConnectionDetail_Select_ByConnectionDevice]", new object[] { "@DeviceID", deviceID });
            ds.Tables[0].TableName = "Master";

            DataSet ds1 = DBAssistant.ExecProcedure("[sproc].[ConnectionDetail_Select_ByConnectionDevice_Detail]", new object[] { "@DeviceID", deviceID });
            ds1.Tables[0].TableName = "Detail";
            ds.Merge(ds1);

            CGrid.LevelTree.Nodes.Add("Master", CDetailView);
            ds.Relations.Add("Connection Detail", ds.Tables[0].Columns["ID"], ds.Tables[1].Columns["ConnectionID"]);

            CGrid.DataSource = ds.Tables[0];

            string relationName = ds.Relations[0].RelationName;
            CGrid.LevelTree.Nodes.Add(relationName, CDetailView);

            GridHelper.LoadViewCols(CMasterView, "ConnectionDetail_Master");
            GridHelper.LoadViewCols(CDetailView, "ConnectionDetail_Detail");

            CGrid.RefreshDataSource();

            // grid pozisyonu yukleniyor
            if (savePos) helper.LoadViewInfo();
        }
       
        private void itemReservation_ItemClick(object sender, ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(ActivateReservationForm), new object[] { FocusedDetailID, this.SanValue, int.Parse(this.DeviceIDLookUp.EditValue.ToString()) });

            LoadData(true, int.Parse(this.DeviceIDLookUp.EditValue.ToString()));

            CMasterView.ExpandMasterRow(this.ExpandedRowIndex);
        }

        private void CMasterView_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridView detail = view.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            ExpandedRowIndex = e.RowHandle;
            detail.ShowGridMenu += new GridMenuEventHandler(detail_ShowGridMenu);
        }

        void detail_ShowGridMenu(object sender, GridMenuEventArgs e)
        {
            GridView senderGrid = (GridView)sender;

            if (e.HitInfo.RowHandle >= 0)
            {
                FocusedDetailID = (long)senderGrid.GetRowCellValue(e.HitInfo.RowHandle, "ID");
                this.SanValue = senderGrid.FocusedRowHandle + 1;
                CDetailContextMenu.ShowPopup(Control.MousePosition);

            }
        }

        private void itemDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show(
                    "Are you sure you want to delete this connection ?",
                    "Information",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //PRINT REPORT
                if (this.DeviceIDLookUp.EditValue.ToString() == "1")//DASD
                {
                    NewConnectionReportDASD newconectionreport = new NewConnectionReportDASD();

                    newconectionreport.newConnectionId = new System.Collections.Generic.List<long>();
                    newconectionreport.newConnectionId.Add(Convert.ToInt64(CMasterView.GetFocusedRowCellValue("ID")));
                    newconectionreport.ShowPreviewDialog();

                    DBAssistant.ExecProcedure
                    (
                        sproc.Connection_Delete_WithDetail, new object[]
                    {
                        "@ID", CMasterView.GetFocusedRowCellValue("ID"),
                        "@UserID", Program.userId
                    }
                    );
                }
                else if (this.DeviceIDLookUp.EditValue.ToString() == "2") //Server
                {
                    NewConnectionReportServer newconectionreport = new NewConnectionReportServer();

                    newconectionreport.newConnectionId = new System.Collections.Generic.List<long>();
                    newconectionreport.newConnectionId.Add(Convert.ToInt64(CMasterView.GetFocusedRowCellValue("ID")));
                    newconectionreport.ShowPreviewDialog();

                    DBAssistant.ExecProcedure
                    (
                        sproc.Connection_Delete_WithDetail, new object[]
                    {
                        "@ID", CMasterView.GetFocusedRowCellValue("ID"),
                        "@UserID", Program.userId
                    }
                    );
                }
                else if (this.DeviceIDLookUp.EditValue.ToString() == "7")
                {
                    NewConnectionReportDCC newconectionreport = new NewConnectionReportDCC();

                    newconectionreport.newConnectionId = new System.Collections.Generic.List<long>();
                    newconectionreport.newConnectionId.Add(Convert.ToInt64(CMasterView.GetFocusedRowCellValue("ID")));
                    newconectionreport.ShowPreviewDialog();

                    DBAssistant.ExecProcedure
                    (
                        sproc.Connection_Delete_WithDetail, new object[]
                    {
                        "@ID", CMasterView.GetFocusedRowCellValue("ID"),
                        "@UserID", Program.userId
                    }
                    );
                }

                LoadData(true, int.Parse(this.DeviceIDLookUp.EditValue.ToString()));
            }
        }

        private void CMasterView_ShowGridMenu(object sender, GridMenuEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                CMasterContextMenu.ShowPopup(Control.MousePosition);
            }
        }

        private void itemPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            //PRINT REPORT
            if (this.DeviceIDLookUp.EditValue.ToString() == "1")//DASD
            {
                NewConnectionReportDASD newconectionreport = new NewConnectionReportDASD();

                if (newconectionreport != null)
                {
                    newconectionreport.newConnectionId = new System.Collections.Generic.List<long>();
                    newconectionreport.newConnectionId.Add(Convert.ToInt64(CMasterView.DataController.GetCurrentRowValue("ID")));
                    newconectionreport.ShowPreviewDialog();

                    LoadData(true, int.Parse(this.DeviceIDLookUp.EditValue.ToString()));
                }
            }
            else if (this.DeviceIDLookUp.EditValue.ToString() == "2") //Server
            {
                NewConnectionReportServer newconectionreport = new NewConnectionReportServer();

                if (newconectionreport != null)
                {
                    newconectionreport.newConnectionId = new System.Collections.Generic.List<long>();
                    newconectionreport.newConnectionId.Add(Convert.ToInt64(CMasterView.DataController.GetCurrentRowValue("ID")));
                    newconectionreport.ShowPreviewDialog();

                    LoadData(true, int.Parse(this.DeviceIDLookUp.EditValue.ToString()));
                }
            }
            else if (this.DeviceIDLookUp.EditValue.ToString() == "7")
            {
                NewConnectionReportDCC newconectionreport = new NewConnectionReportDCC();

                if (newconectionreport != null)
                {
                    newconectionreport.newConnectionId = new System.Collections.Generic.List<long>();
                    newconectionreport.newConnectionId.Add(Convert.ToInt64(CMasterView.DataController.GetCurrentRowValue("ID")));
                    newconectionreport.ShowPreviewDialog();

                    LoadData(true, int.Parse(this.DeviceIDLookUp.EditValue.ToString()));
                }
            }
        }

        private void itemDetailDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            object detailID = CDetailView.GetFocusedRowCellValue("ID");
            if (detailID == null) return;
            if (XtraMessageBox.Show(
                   "Are you sure you want to delete this Item ?",
                   "Information",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                DBAssistant.ExecProcedure
                (
                    sproc.Coordinate_Delete_ByID, new object[]
                {
                    "@ID", detailID
                }
                );

                LoadData(true, (int)this.DeviceIDLookUp.EditValue);
            }
        }

        DataRowView rowview;
        private void itemCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (focusView != null)
            {
                if (focusView.FocusedRowHandle > -1)
                    rowview = focusView.GetRow(focusView.FocusedRowHandle) as DataRowView;
            }
        }

        private void itemPaste_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (rowview != null)
            {

            }
            rowview = null;
        }

        //DevExpress.XtraGrid.Views.BandedGrid.BandedGridView focusView = null;
        DevExpress.XtraGrid.Views.Grid.GridView focusView = null;


        private void CGrid_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
            if (focusView != null)
            {
                focusView.MouseDown -= new MouseEventHandler(CDetailView_MouseDown);
                focusView.MouseMove -= new MouseEventHandler(CDetailView_MouseMove);
            }

            focusView = (DevExpress.XtraGrid.Views.Grid.GridView)e.View;
            if (focusView == null)
                return;

            focusView.MouseDown += new MouseEventHandler(CDetailView_MouseDown);
            focusView.MouseMove += new MouseEventHandler(CDetailView_MouseMove);
            focusView.OptionsSelection.MultiSelect = true;
            focusView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;

        }


        //Polat... Drag&Drop
        private void CDetailView_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            hitInfo = null;

            GridHitInfo dhitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None)
                return;
            if (e.Button == MouseButtons.Left && dhitInfo.InRow && dhitInfo.HitTest != GridHitTest.RowIndicator)
                hitInfo = dhitInfo;


        }

        long[] GetDragData(GridView view)
        {
            int[] selection = view.GetSelectedRows();
            if (selection == null)
                return null;

            int count = selection.Length;
            long[] result = new long[count];
            for (int i = 0; i < count; i++)
                result[i] = Convert.ToInt64(view.GetRowCellValue(selection[i], "ID"));
            return result;
        }

        private void CDetailView_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && hitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(hitInfo.HitPoint.X - dragSize.Width / 2,
                    hitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    view.GridControl.DoDragDrop(GetDragData(view), DragDropEffects.All);
                    hitInfo = null;
                }

            }
        }

        private void CGrid_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(long[])))
                e.Effect = DragDropEffects.Move;
            else e.Effect = DragDropEffects.None;

        }

        private void CGrid_DragDrop(object sender, DragEventArgs e)
        {
            if (Control.ModifierKeys != Keys.None)
                return;

            GridControl grid = sender as GridControl;

            BaseView view = grid.GetViewAt(grid.PointToClient(new Point(e.X, e.Y)));
            if (view == null)
                return;

            long[] kayitlar = e.Data.GetData(typeof(long[])) as long[];
            if (XtraMessageBox.Show(
               String.Format("Are you sure you want to move {0} item(s) to the specified Connection ?", kayitlar.Length),
               "Information",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            GridView newView = (GridView)view.SourceView;
            long connId = Convert.ToInt64(newView.GetRowCellValue(view.SourceRowHandle, "ID"));

            for (int i = 0; i < kayitlar.Length; i++)
            {
                MoveRow(kayitlar[i], connId, newView);
            }
        }


        private void MoveRow(long connDetailId, long connId, GridView newView)
        {
            DataSet ds = DBAssistant.ExecProcedure(sproc.ConnectionDetail_Move, new object[] { "@ConnectionDetailId", connDetailId, "@NewConnectionId", connId });
            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0 || ds.Tables[0].Columns.Count == 0 || Convert.ToInt32(ds.Tables[0].Rows[0][0]) < 1)
                return;

            DataTable detailTable = ((DataView)newView.DataSource).Table.DataSet.Tables[1];
            DataRow[] rows = detailTable.Select(String.Format("ID='{0}'", connDetailId));
            for (int i = 0; i < rows.Length; i++)
            {
                rows[i].BeginEdit();
                rows[i]["ConnectionID"] = connId;
                rows[i].EndEdit();
            }
            newView.RefreshData();

        }

        private void CMasterView_ColumnWidthChanged(object sender, ColumnEventArgs e)
        {
            GridHelper.SaveViewCols(CMasterView, "ConnectionDetail_Master");            
        }

        private void CDetailView_ColumnWidthChanged(object sender, ColumnEventArgs e)
        {
            GridHelper.SaveViewCols(CDetailView, "ConnectionDetail_Detail");
        }

        private void c_LookUpDeviceSpecific1_EditValueChanged(object sender, EventArgs e)
        {
            this.LoadData(false, int.Parse(this.DeviceIDLookUp.EditValue.ToString()));
        }

        private void itemSwitchUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(SwitchDetailUpdateForm), new object[] { FocusedDetailID, this.SanValue });

            LoadData(true, int.Parse(this.DeviceIDLookUp.EditValue.ToString()));

            CMasterView.ExpandMasterRow(this.ExpandedRowIndex);
        }
    }
}