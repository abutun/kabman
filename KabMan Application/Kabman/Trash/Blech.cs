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
    public partial class Blech : DevExpress.XtraEditors.XtraForm
    {
        private Common com;
        private RefreshHelper helper;

        public Blech()
        {
            InitializeComponent();
        }

        private int RecordId
        {
            get { return (int)gridView1.DataController.GetCurrentRowValue("Id"); }
        }


        private void Blech_Load(object sender, EventArgs e)
        {
            com = new Common();
            com.LoadWinPos(this, "Blech", true);

            helper = new RefreshHelper(gridView1, "Id");

            Liste(false);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewBlech nb = new NewBlech(this, 0);
            nb.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewBlech nb = new NewBlech(this, RecordId);
            nb.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                    barButtonItem2_ItemClick(sender, null);
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
                barButtonItem2.Enabled = true;
                barButtonItem3.Enabled = true;
            }
            else
            {
                barButtonItem2.Enabled = false;
                barButtonItem3.Enabled = false;
            }


            data.Dispose();

            // grid pozisyonu yukleniyor
            if (savePos) helper.LoadViewInfo();

            Cursor = Cursors.Default;
        }

    }
}