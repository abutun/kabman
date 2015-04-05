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
using KabMan.Client.Modules.Common;

namespace KabMan.Client
{
    public partial class RackDetailList : DevExpress.XtraEditors.XtraForm
    {

        private int sid;
        WaitDialogForm dlgWait;
        private RefreshHelper helper;
        private Common com;
        ModifyRegistry reg;
        DatabaseLib data = new DatabaseLib();
        public RackDetailList(int sid)
        {
            this.sid = sid;
            InitializeComponent();
        }

        private int RecordId
        {
            get { return (int)bandedGridView1.DataController.GetCurrentRowValue("Id"); }
        }

        private int RecordId2
        {
            get { return (int)bandedGridView2.DataController.GetCurrentRowValue("Id"); }
        }


        private void ServerDetailList_Load(object sender, EventArgs e)
        {
            reg = new ModifyRegistry();
            com = new Common();
            com.LoadViewCols(bandedGridView1, "ServerDetailList");

            helper = new RefreshHelper(bandedGridView1, "Id");
            helper = new RefreshHelper(bandedGridView2, "Id");
            
            FormText();

            Liste(false);
        }

        private void FormText()
        {
            SqlDataReader dr;
            DatabaseLib data = new DatabaseLib();
            data.RunSqlQuery(string.Format("SELECT Value AS Server FROM tblTree WHERE RecDelete=0 and ObjectValue='Server' and ObjectId={0}", sid), out dr);

            if (dr.Read())
            {
                this.Text = dr["Server"].ToString();
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
            SqlParameter[] prm = 
            {
                data.MakeInParam("@RackId", sid),
                data.MakeInParam("@SanId", 7)
            };

            data.RunProc("sp_selRackDetailList", prm, out ds);
            data.Dispose();

            gridControl1.DataSource = ds.Tables[0];

            DataSet ds2;
            SqlParameter[] prm2 = 
            {
                data.MakeInParam("@RackId", sid),
                data.MakeInParam("@SanId", 9)
            };

            data.RunProc("sp_selRackDetailList", prm2, out ds2);
            data.Dispose();


            gridControl2.DataSource = ds2.Tables[0];

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

        private void BBtnDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

                    SqlParameter[] prm = { data.MakeInParam("@RackDetailId", RecordId) };

                    data.RunProc("sp_delRackDetail", prm);
                    data.Dispose();
                }
                Liste(false);
            }
        }

        private void BBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void gridControl2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RackActivite ra = new RackActivite(this, RecordId2);
            ra.ShowDialog();
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RackActivite ra = new RackActivite(this, RecordId);
            ra.ShowDialog();
        }

        private void gridView1_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                if (bandedGridView1.GetRowCellValue(e.RowHandle, Connect).ToString().Trim() == "True")
                {
                    e.Appearance.BackColor = Color.FromArgb(255, Color.FromArgb(33333));
                    e.Appearance.BackColor2 = Color.FromArgb(255, Color.FromArgb(33333));
                }


                if (bandedGridView1.GetRowCellValue(e.RowHandle, Reservation).ToString().Trim() == "True")
                {
                    e.Appearance.BackColor = Color.FromArgb(255, Color.FromArgb(44444));
                    e.Appearance.BackColor2 = Color.FromArgb(255, Color.FromArgb(44444));
                }
            }
        }

        private void gridView2_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {

            if (e.RowHandle >= 0)
            {
                if (bandedGridView2.GetRowCellValue(e.RowHandle, Connect2).ToString().Trim() == "True")
                {
                    e.Appearance.BackColor = Color.FromArgb(255, Color.FromArgb(33333));
                    e.Appearance.BackColor2 = Color.FromArgb(255, Color.FromArgb(33333));
                }

                if (bandedGridView2.GetRowCellValue(e.RowHandle, Reservation2).ToString().Trim() == "True")
                {
                    e.Appearance.BackColor = Color.FromArgb(255, Color.FromArgb(44444));
                    e.Appearance.BackColor2 = Color.FromArgb(255, Color.FromArgb(44444));
                }                
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void  gridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {
            // checkbox dan database update yapilacak.
            DatabaseLib dataUp = new DatabaseLib();

            SqlParameter[] prmUp =
            {
                dataUp.MakeInParam("@Id", rowId),
                dataUp.MakeInParam("@Value", checkValue)
            };

            dataUp.RunProc("sp_UpRackDetail", prmUp);
            dataUp.Dispose();
        }

        int rowId = 0;
        bool checkValue;
        private void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = bandedGridView1;
            rowId = Convert.ToInt32(bandedGridView1.GetRowCellValue(view.FocusedRowHandle, bandedGridColumn1));

            checkValue = !Convert.ToBoolean(bandedGridView1.GetRowCellValue(view.FocusedRowHandle, gridColumn19));
        }

        private void bandedGridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {
            DatabaseLib dataUp = new DatabaseLib();

            SqlParameter[] prmUp =
            {
                dataUp.MakeInParam("@Id", rowId),
                dataUp.MakeInParam("@Value", checkValue)
            };

            dataUp.RunProc("sp_UpRackDetail", prmUp);
            dataUp.Dispose();
        }
        
    }
}