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


namespace KabMan.Client
{
    public partial class frmServerDetail : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        private Home m;

        public frmServerDetail(Home m, int id)
        {
            this.m = m;
            this.id = id;

            Icon = Properties.Resources.kabman;
            InitializeComponent();
        }

        private void frmServerDetail_Load(object sender, EventArgs e)
        {
            Common.FillLookup2(lkpLocation, "SELECT * FROM tblLocation WHERE RecDelete=0", "LocationName", "LocationId");
            /*
            if (id > 0)
            {
                SqlDataReader dr;
                DatabaseLib data = new DatabaseLib();
                data.RunSqlQuery(string.Format("SELECT * FROM tblServer WHERE ServerId={0}", id), out dr);

                if (dr.Read())
                {
                    lkpLocation.EditValue = dr["LocationId"];
                    cmbOP.Text = dr["OPSys"].ToString();
                    txtServerName.Text = dr["ServerName"].ToString();
                    cmbSize.Text = dr["Size"].ToString();
                    txtStandort.Text = dr["Standort"].ToString();
                    cmbKable.Text = dr["Cable"].ToString();
                    cmbBlech.Text = dr["Blech"].ToString();
                }
            }    */
        }

        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            /*
            if (dxValidationProvider1.Validate())
            {
                DatabaseLib data = new DatabaseLib();

                SqlParameter[] prm = 
                {
                    data.MakeInParam("@ServerId", id),
                    data.MakeInParam("@ServerName", txtServerName.Text),
                    data.MakeInParam("@Standort", txtStandort.Text),
                    data.MakeInParam("@Cable", cmbKable.Text),
                    data.MakeInParam("@Blech", cmbBlech.Text),
                    data.MakeInParam("@LocationId", lkpLocation.EditValue),
                    data.MakeInParam("@Size", Common.DBValueControl(cmbSize.Text)),
                    data.MakeInParam("@OPSys", cmbOP.Text)
                };

                data.RunProc("sp_insServer", prm);
                data.Dispose();
                m.InitTree();

                Close();
            }
             */
        }

        private void frmServerDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                Close();
        }

        private void lkpLocation_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            if (string.Empty.Equals(e.DisplayValue))
            {
                lkpLocation.EditValue = null;
                e.Handled = true;
            }
        }

        private void lkpLocation_EditValueChanged(object sender, EventArgs e)
        {

        }


    }
}