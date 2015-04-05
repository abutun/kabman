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

namespace KabMan.Client
{
    public partial class NewUrm_UrmCable : DevExpress.XtraEditors.XtraForm
    {
        DatabaseLib data = new DatabaseLib();

        public NewUrm_UrmCable()
        {
            InitializeComponent();
        }

        private void BtnLoadUrmUrmCable_Click(object sender, EventArgs e)
        {

            try
            {
                SqlParameter[] prm =


            {
                data.MakeInParam("@CountCable", Convert.ToInt32(txtCountCable.Text)),
                data.MakeInParam("@Meter", Convert.ToInt32(CBoxMeter.Text)),
                data.MakeInParam("@StartNo", Convert.ToInt32(txtStartUrmNo.Text)),
                data.MakeInParam("@Type", Type)
            };
                data.RunProc("sp_insUrmUrmCable", prm);
                data.Dispose();
                MessageBox.Show("Has been Load URM_URM Cable is succesfully!");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            
            }
            Close();
            
        }

        private void NewUrm_UrmCable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void NewUrm_UrmCable_Load(object sender, EventArgs e)
        {
            SqlDataReader dr;
            DatabaseLib data1 = new DatabaseLib();
            data1.RunSqlQuery("SELECT * FROM tblUrm WHERE Id=(select max(Id) from tblUrm where RecDelete=0)", out dr);

            if (dr.Read())
            {
                txtLastUrmNo.Text = dr["No"].ToString();
            }

            if (txtLastUrmNo.Text == "")
            {
                txtLastUrmNo.Text = "The Store haven't URM Cable!";
                txtStartUrmNo.Text = "1";
            }
        }
        int Type = 0;
        private void CBoxUrmType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CBoxUrmType.Text == "LC_URM")
            {
                Type = 1;
            }
            else
            {
                Type = 2;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtStartUrmNo_Leave(object sender, EventArgs e)
        {
            DataSet ds;
            DatabaseLib data2 = new DatabaseLib();

            SqlParameter[] prm1 =
            { 
                data2.MakeInParam("@StartNo", txtStartUrmNo.Text),
            };

            data.RunProc(SPROC.URM_CHECK, prm1, out ds);
            data.Dispose();

            if (ds.Tables[0].Rows[0]["retValue"].ToString() == "0")
            {

            }
            else
            {
                MessageBox.Show("UrmNo is used!");
                txtStartUrmNo.Text = "";
                txtStartUrmNo.Focus();
            }

            
        }

    }
}