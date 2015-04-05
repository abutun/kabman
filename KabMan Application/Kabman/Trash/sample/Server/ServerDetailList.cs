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
using KabMan.Client.Modules.Switch;

namespace KabMan.Client
{
    public partial class ServerDetailList : DevExpress.XtraEditors.XtraForm
    {
        private int sid;
        WaitDialogForm dlgWait;
        private RefreshHelper helper;
        private Common com;
        ModifyRegistry reg;

        public ServerDetailList(int sid)
        {
            this.sid = sid;
            InitializeComponent();
        }

        private int RecordId
        {
            get { return (int)gridView1.DataController.GetCurrentRowValue("Id"); }
        }


        private void ServerDetailList_Load(object sender, EventArgs e)
        {
            reg = new ModifyRegistry();
            com = new Common();
            com.LoadViewCols(gridView1, "ServerDetailList");

            helper = new RefreshHelper(gridView1, "Id");

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
            DatabaseLib data = new DatabaseLib();

            SqlParameter[] prm = 
            {
                data.MakeInParam("@RackId", sid)
            };

            data.RunProc("sp_selRackDetailList", prm, out ds);
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
    }
}