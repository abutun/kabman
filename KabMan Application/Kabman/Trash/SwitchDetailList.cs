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
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace KabMan.Client
{
    public partial class SwitchDetailList : DevExpress.XtraEditors.XtraForm
    {
        private int sid;
        WaitDialogForm dlgWait;
        private RefreshHelper helper;
        private Common com;
        ModifyRegistry reg;

        public SwitchDetailList(int sid)
        {
            this.sid = sid;
            InitializeComponent();
        }

        private int RecordId
        {
            get { return (int)gridView1.DataController.GetCurrentRowValue("Id"); }
        }


        private void SwitchDetailList_Load(object sender, EventArgs e)
        {
            reg = new ModifyRegistry();
            com = new Common();
            com.LoadViewCols(gridView1, "SwitchDetailList");

            helper = new RefreshHelper(gridView1, "Id");

            FormText();

            Liste(false);
        }

        private void FormText()
        {
            SqlDataReader dr;
            DatabaseLib data = new DatabaseLib();
            data.RunSqlQuery(string.Format("SELECT SwName AS Switch FROM tblSwitch WHERE Id={0}", sid), out dr);

            if (dr.Read())
            {
                this.Text = dr["Switch"].ToString();
                this.Tag = sid.ToString();
            }

            data.Dispose();
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

            SqlParameter[] prm = 
            {
                data.MakeInParam("@SwitchId", sid)
            };

            data.RunProc("sp_selSwitchDetailList", prm, out ds);
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

            dlgWait.Close();

            Cursor = Cursors.Default;
        }

        private void BBtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

                    SqlParameter[] prm = { data.MakeInParam("@SwitchDetailId", RecordId) };

                    data.RunProc("sp_delSwitchDetail", prm);
                    data.Dispose();
                }
                Liste(false);
            }
        }

        private void BBtnDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SwitchActivite sa = new SwitchActivite(this, RecordId);
            sa.ShowDialog();
        }

        private void gridView1_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                if (gridView1.GetRowCellValue(e.RowHandle, Connect).ToString().Trim() == "True")
                {
                    e.Appearance.BackColor = Color.Green;
                    e.Appearance.BackColor2 = Color.Green;
                }
                if (gridView1.GetRowCellValue(e.RowHandle, Reservation).ToString().Trim() == "True")
                {
                    e.Appearance.BackColor = Color.DarkKhaki;
                    e.Appearance.BackColor2 = Color.Yellow;
                }
            }
        }

 

    }
}