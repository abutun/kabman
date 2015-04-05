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
    public partial class RackList : DevExpress.XtraEditors.XtraForm
    {
        private Home m;
        private Common com;
        private RefreshHelper helper;
        WaitDialogForm dlgWait;

        public RackList(Home m)
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
            com.LoadViewCols(gridView1, "RackList");

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

            data.RunProc("sp_selRackList", out ds);
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
            RackDetailList f = new RackDetailList(RecordId);
            f.MdiParent = Home.myInstanceHandle;
            f.Show();
        }

        private void BBtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewRack nr = new NewRack(m, 0);
            nr.ShowDialog();

        }

        private void BBtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show(
"Are you sure you want to delete this information?",
Text,
MessageBoxButtons.OKCancel,
MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                // eger kayitid > 0 dan buyuk ise database dan siliniyor
                if (RecordId > 0)
                {
                    DatabaseLib data = new DatabaseLib();

                    SqlParameter[] prm = { data.MakeInParam("@RackId", RecordId) };

                    data.RunProc("sp_delRack", prm);
                    data.Dispose();
                }
                Liste(false);
            }
        }

        private void BBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataCenterConnection dcc = new DataCenterConnection();
            dcc.ShowDialog();
        }
    }
}