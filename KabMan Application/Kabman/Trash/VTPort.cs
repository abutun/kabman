using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Utils;
using System.Data.SqlClient;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace KabMan.Client
{
    public partial class VTPort : DevExpress.XtraEditors.XtraForm
    {
        private Common com;
        private RefreshHelper helper;
        
        public VTPort()
        {
            InitializeComponent();
        }

        private int RecordId
        {
            get { return (int)gridView1.DataController.GetCurrentRowValue("Id"); }
        }


        private void VTPort_Load(object sender, EventArgs e)
        {
            com = new Common();
            com.LoadWinPos(this, "VTPort", true);

            helper = new RefreshHelper(gridView1, "Id");

            Liste(false);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmVTPort nv = new frmVTPort(this, 0);
            nv.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmVTPort nv = new frmVTPort(this, RecordId);
            nv.ShowDialog();
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

                    data.RunProc("sp_delVTPort", prm);
                    data.Dispose();
                }

                Liste(true);
            }
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

            data.RunProc("sp_selVTPort", out ds);
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