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
    public partial class SwitchList : DevExpress.XtraEditors.XtraForm
    {
        private Home m;
        private Common com;
        private RefreshHelper helper;
        WaitDialogForm dlgWait;

        public SwitchList(Home m)
        {
            this.m = m;
            Icon = Properties.Resources.kabman;
            InitializeComponent();
        }

        private int RecordId
        {
            get { return (int)gridView1.DataController.GetCurrentRowValue("Id"); }
        }

        private void SwitchList_Load(object sender, EventArgs e)
        {
            com = new Common();
            com.LoadViewCols(gridView1, "SwitchList");

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

            data.RunProc("sp_selSwitchList", out ds);
            data.Dispose();

            gridControl1.DataSource = ds.Tables[0];

            if (ds.Tables[0].DefaultView.Count > 0)
            {
                BBtnList.Enabled = true;
                BBtnDelete.Enabled = true;
            }
            else
            {
                BBtnList.Enabled = false;
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
                    BBtnList_ItemClick(sender, null);
            }
        }

        private void BBtnList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SwitchDetailList f = new SwitchDetailList(RecordId);
            f.MdiParent = Home.myInstanceHandle;
            f.Show();
        }

        private void BBtnNewSwitch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewSwitch sw = new NewSwitch(m, 0);
            sw.ShowDialog();
        }

        private void BBtnSwitchDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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

                    SqlParameter[] prm = { data.MakeInParam("@SwitchId", RecordId) };

                    data.RunProc("sp_delSwitch", prm);
                    data.Dispose();
                }
                Liste(false);
            }
        }

        private void BBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

    }
}