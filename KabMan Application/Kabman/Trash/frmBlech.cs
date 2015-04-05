using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;

namespace KabMan.Client
{
    public partial class frmBlech : DevExpress.XtraEditors.XtraForm
    {
        private Common com;
        private RefreshHelper helper;

        public frmBlech()
        {
            Icon = KabMan.Client.Properties.Resources.kabman;
            InitializeComponent();
        }

        private int RecordId
        {
            get { return (int)gridView1.DataController.GetCurrentRowValue("Id"); }
        }


        private void frmBlech_Load(object sender, EventArgs e)
        {
            com = new Common();
            com.LoadViewCols(gridView1, "Blech");
            com.LoadWinPos(this, "Blech", true);

            helper = new RefreshHelper(gridView1, "Id");

            Liste(false);
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

                    SqlParameter[] prm = { data.MakeInParam("@Id", RecordId) };

                    data.RunProc("sp_delBlech", prm);
                    data.Dispose();
                }

                Liste(true);
            }
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBlechDetail nb = new frmBlechDetail(this, 0);
            nb.ShowDialog();
        }

        private void btnDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBlechDetail nb = new frmBlechDetail(this, RecordId);
            nb.ShowDialog();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        public void Liste(bool savePos)
        {
            Cursor = Cursors.WaitCursor;

            // grid pozisyonu kayit ediliyor
            if (savePos) helper.SaveViewInfo();

            DataSet ds;
            DatabaseLib data = new DatabaseLib();

            data.RunProc("sp_selBlech", out ds);
            data.Dispose();

            gridControl1.DataSource = ds.Tables[0];

            if (ds.Tables[0].DefaultView.Count > 0)
            {
                btnDetail.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnDetail.Enabled = false;
                btnDelete.Enabled = false;
            }


            data.Dispose();

            // grid pozisyonu yukleniyor
            if (savePos) helper.LoadViewInfo();

            Cursor = Cursors.Default;
        }

        private void frmBlech_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                Close();
        }

        private void gridView1_ColumnWidthChanged(object sender, ColumnEventArgs e)
        {
            com.SaveViewCols(gridView1, "Blech");
        }

        private void frmBlech_FormClosing(object sender, FormClosingEventArgs e)
        {
            com.SaveWinPos(this, "Blech");
        }

    }
}