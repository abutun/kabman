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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;

namespace KabMan.Client
{
    public partial class frmSAN : DevExpress.XtraEditors.XtraForm
    {
        private Common com;
        private RefreshHelper helper;
        private Home m;

        public frmSAN()
        {
            Icon = Properties.Resources.kabman;
            InitializeComponent();
        }

        private int RecordId
        {
            get { return (int)gridView1.DataController.GetCurrentRowValue("Id"); }
        }

        private void frmSAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                Close();
        }

        private void btnSchliessen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void frmSAN_Load(object sender, EventArgs e)
        {
            com = new Common();
            com.LoadWinPos(this, "SAN", true);

            helper = new RefreshHelper(gridView1, "Id");

            Liste(false);
        }

        public void Liste(bool savePos)
        {
            Cursor = Cursors.WaitCursor;

            // grid pozisyonu kayit ediliyor
            if (savePos) helper.SaveViewInfo();

            DataSet ds;
            DatabaseLib data = new DatabaseLib();

            data.RunSqlQuery("SELECT * FROM tblSAN", out ds);
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

            data.Dispose();

            // grid pozisyonu yukleniyor
            if (savePos) helper.LoadViewInfo();

            Cursor = Cursors.Default;
        }

        private void btnNeu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSANDetail f = new frmSANDetail(this, 0);
            f.ShowDialog();
        }

        private void btnDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSANDetail f = new frmSANDetail(this, RecordId);
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

                    SqlParameter[] prm = { data.MakeInParam("@SanId", RecordId) };

                    data.RunProc("sp_delSAN", prm);
                    data.Dispose();
                }


                Liste(true);
            }
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
    }
}