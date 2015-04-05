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
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace KabMan.Client
{
    public partial class frmServerDetailListe : DevExpress.XtraEditors.XtraForm
    {
        private int sid;

        WaitDialogForm dlgWait;
        private RefreshHelper helper;
        private Common com;
        ModifyRegistry reg;

        public frmServerDetailListe(int sid)
        {
            this.sid = sid;
            InitializeComponent();
        }

        private int RecordId
        {
            get { return (int)gridView1.DataController.GetCurrentRowValue("Id"); }
        }

        private void frmServerDetailListe_Load(object sender, EventArgs e)
        {
            reg = new ModifyRegistry();
            com = new Common();
            com.LoadViewCols(gridView1, "ServerList");
            com.LoadViewCols(gridView2, "SNMP");

            helper = new RefreshHelper(gridView1, "Id");

            FormText();

            RestoreView();
            Liste(false);
        }

        private void FormText()
        {
            SqlDataReader dr;
            DatabaseLib data = new DatabaseLib();
            data.RunSqlQuery(string.Format("SELECT Room + Coordinate AS Server FROM tblReck WHERE Id={0}", sid), out dr);

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
                data.MakeInParam("@Id", sid)
            };

            data.RunProc("sp_selServer", prm, out ds);
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

            dlgWait.Close();

            Cursor = Cursors.Default;
        }

        private void SaveView()
        {
            reg.Write("grdSMTPView", btnCheckSNMPView.Down.ToString());
        }

        private void RestoreView()
        {
            if (reg.Read("grdSMTPView") != null)
            {
                btnCheckSNMPView.Down = Convert.ToBoolean(reg.Read("grdSMTPView"));
                Status();
            }
        }

        private void btnCheckSNMPView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Status();
        }

        private void Status()
        {
            if (btnCheckSNMPView.Down)
                splitterItem1.Visibility = layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            else
                splitterItem1.Visibility = layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void btnSchliessen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnNeu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmServerDetailListeDetail f = new frmServerDetailListeDetail(this, 0, sid);
            f.ShowDialog();
        }

        private void gridView1_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            com.SaveViewCols(gridView1, "ServerList");
        }

        private void gridView2_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            com.SaveViewCols(gridView2, "SNMP");
        }

        private void frmServerDetailListe_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveView();
        }

        private void btnDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmServerDetailListeDetail f = new frmServerDetailListeDetail(this, RecordId, sid);
            f.ShowDialog();
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

                    SqlParameter[] prm = { data.MakeInParam("@Id", RecordId) };

                    data.RunProc("sp_delServer", prm);
                    data.Dispose();
                }
                Liste(false);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void barCheckItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem1.Checked == true)
            {
                KabelURMLC.Visible = true;
            }
            else
            {
                KabelURMLC.Visible = false;
            }

        }

        private void barCheckItem2_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem2.Checked == true)
            {
                Blech.Visible = true;
            }
            else
            {
                Blech.Visible = false;
            }
        }

        private void barCheckItem3_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem3.Checked == true)
            {
                CableTrunkMulti.Visible = true;
            }
            else
            {
                CableTrunkMulti.Visible = false;
            }
        }

        private void barCheckItem4_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem4.Checked == true)
            {
                VTPort.Visible = true;
            }
            else
            {
                VTPort.Visible = false;
            }
        }

        private void barCheckItem5_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem5.Checked == true)
            {
                PatchCableURM_URM.Visible = true;
            }
            else
            {
                PatchCableURM_URM.Visible = false;
            }
        }

        private void barCheckItem6_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem6.Checked == true)
            {
                SAN.Visible = true;
            }
            else
            {
                SAN.Visible = false;
            }

        }


    }
}