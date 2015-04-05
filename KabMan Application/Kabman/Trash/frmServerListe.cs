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
    public partial class frmServerListe : DevExpress.XtraEditors.XtraForm
    {
        DatabaseLib data = new DatabaseLib();

        private Home m;
        private Common com;
        private RefreshHelper helper;
        private GridControl grdcntrl;
        WaitDialogForm dlgWait;

        public frmServerListe(Home m)
        {
            this.m = m;
            this.gridControl1 = grdcntrl;
            Icon = Properties.Resources.kabman;
            InitializeComponent();
        }

        private int RecordId
        {
            get { return (int)gridView1.DataController.GetCurrentRowValue("ServerId"); }
        }

        private void btnNeu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmServerDetail f = new frmServerDetail(m, 0);
            f.ShowDialog();
        }

        private void frmServerListe_Load(object sender, EventArgs e)
        {
            com = new Common();
            com.LoadViewCols(gridView1, "ServerList");

            // refresh islemlerinde grid in pozisyonunu takip edecek class
            helper = new RefreshHelper(gridView1, "ServerId");

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

            data.RunProc("sp_selServer", out ds);
            data.Dispose();

            gridControl1.DataSource = ds.Tables[0];

            if (ds.Tables[0].DefaultView.Count > 0)
            {
                btnDetail.Enabled = true;
                btnLoeschen.Enabled = true;
            }
            else
            {
                btnDetail.Enabled = false;
                btnLoeschen.Enabled = false;
            }

            // grid pozisyonu yukleniyor
            if (savePos) helper.LoadViewInfo();

            m.InitTree();

            dlgWait.Close();

            Cursor = Cursors.Default;
        }

        private void btnSchliessen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                GridControl grid = sender as GridControl;
                BaseView view = grid.FocusedView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Location) as GridHitInfo;

                if (hitInfo.InRow)
                    btnDetail_ItemClick(sender, null);
            }
        }

        private void btnDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmServerDetail f = new frmServerDetail(m, RecordId);
            f.ShowDialog();
        }

        private void btnListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmServerDetailListe f = new frmServerDetailListe(RecordId);
            f.MdiParent = Home.myInstanceHandle;
            f.Show();
        }

        private void btnErstellen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmServerDetailCreate f = new frmServerDetailCreate(RecordId);
            f.ShowDialog();
        }

        private void btnLoeschen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

                    SqlParameter[] prm = { data.MakeInParam("@ServerId", RecordId) };

                    data.RunProc("sp_delServer", prm);
                    data.Dispose();
                }
                Liste(false);
            }
        }

        private void barCheckItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem1.Checked == true)
            {
                LocationName.Visible = true;
            }
            else
            {
                LocationName.Visible = false;
            }
        }

        private void barCheckItem2_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem2.Checked == true)
            {
                ServerName.Visible = true;
            }
            else
            {
                ServerName.Visible = false;
            }
        }

        private void barCheckItem3_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem3.Checked == true)
            {
                Standort.Visible = true;
            }
            else
            {
                Standort.Visible = false;
            }
        }

        private void barCheckItem4_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem4.Checked == true)
            {
                OPSys.Visible = true;
            }
            else
            {
                OPSys.Visible = false;
            }
        }

        private void barCheckItem5_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem5.Checked == true)
            {
                Size.Visible = true;
            }
            else
            {
                Size.Visible = false;
            }
        }

    }
}