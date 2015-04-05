using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;

namespace KabMan.Client
{
    public partial class ServerList : DevExpress.XtraEditors.XtraForm
    {
        private frmMain m;
        private Common com;
        private RefreshHelper helper;
        WaitDialogForm dlgWait;

        public ServerList(frmMain m)
        {
            this.m = m;
            Icon = Properties.Resources.kabman;
            InitializeComponent();
        }

        private int RecordId
        {
            get { return (int)gridView1.DataController.GetCurrentRowValue("Id"); }
        }

        private void ServerList_Load(object sender, EventArgs e)
        {
            com = new Common();
            com.LoadViewCols(gridView1, "ServerList");

            // refresh islemlerinde grid in pozisyonunu takip edecek class
            helper = new RefreshHelper(gridView1, "Id");

            Liste(false);
        }

        public void Liste(bool savePos)
        {
            Cursor = Cursors.WaitCursor;
            dlgWait = new WaitDialogForm("Loading Data...");
            dlgWait.StartPosition = FormStartPosition.CenterParent;

            // grid pozisyonu kayit ediliyor
            if (savePos) helper.SaveViewInfo();

            DataSet ds;
            DatabaseLib data = new DatabaseLib();

            data.RunProc("sp_selRack", out ds);
            data.Dispose();

            gridControl1.DataSource = ds.Tables[0];

            if (ds.Tables[0].DefaultView.Count > 0)
            {
                BBtnDetail.Enabled = true;
                BBtnDelete.Enabled = true;
            }
            else
            {
                BBtnDetail.Enabled = false;
                BBtnDelete.Enabled = false;
            }

            // grid pozisyonu yukleniyor
            if (savePos) helper.LoadViewInfo();

            m.InitTree();

            dlgWait.Close();

            Cursor = Cursors.Default;
        }


        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                GridControl grid = sender as GridControl;
                BaseView view = grid.FocusedView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Location) as GridHitInfo;

                if (hitInfo.InRow)
                    BBtnDetail_ItemClick(sender, null);
            }

        }


        private void BBtnDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BBtnList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ServerDetailList f = new ServerDetailList(RecordId);
            f.MdiParent = frmMain.myInstanceHandle;
            f.Show();
        }
    }
}