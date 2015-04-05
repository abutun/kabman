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
    public partial class frmSANDetail : DevExpress.XtraEditors.XtraForm
    {
        frmSAN f;
        int id;

        public frmSANDetail(frmSAN f, int id)
        {
            this.f = f;
            this.id = id;

            Icon = Properties.Resources.kabman;
            InitializeComponent();
        }

        private void frmSANDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                Close();
        }

        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                DatabaseLib data = new DatabaseLib();

                SqlParameter[] prm = {
                                         data.MakeInParam("@SanId", id),
                                         data.MakeInParam("@SAN", txtSAN.Text)
                                     };

                data.RunProc("sp_insSAN", prm);
                data.Dispose();

                f.Liste(true);

                Close();
            }
        }

        private void frmSANDetail_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                SqlDataReader dr;
                DatabaseLib data = new DatabaseLib();
                data.RunSqlQuery(string.Format("SELECT * FROM tblSAN WHERE Id={0}", id), out dr);

                if (dr.Read())
                {
                    txtSAN.Text = dr["SAN"].ToString();
                }

                data.Dispose();
            }
        }
    }
}