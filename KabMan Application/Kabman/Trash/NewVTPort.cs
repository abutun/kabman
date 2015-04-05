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

namespace KabMan.Client
{
    public partial class NewVTPort : DevExpress.XtraEditors.XtraForm
    {
        private Common com;
        DatabaseLib data = new DatabaseLib();
        private VTPort v;
        private int id;

        public NewVTPort(VTPort v, int id)
        {
            this.v=v;
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (chkboxForDataCenterConn.Checked == false)
            {

                try
                {
                    SqlParameter[] prm =
                { 
                    data.MakeInParam("@LocationId", LookUpLocation.EditValue),
                    data.MakeInParam("@RoomId", LookUpRoom.EditValue),
                    data.MakeInParam("@SanId", LookUpSan.EditValue)
                };
                    data.RunProc(SPROC.VTPORT_INSERT, prm);
                    data.Dispose();
                    MessageBox.Show("Has been saved succesfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                v.Liste(true);

            }
            else
            {
                try
                {
                    SqlParameter[] prm =
                { 
                    data.MakeInParam("@LocationId", LookUpLocation.EditValue),
                    data.MakeInParam("@RoomId", LookUpRoom.EditValue),
                    data.MakeInParam("@SanId", LookUpSan.EditValue)
                };
                    data.RunProc("sp_insVTPortForDataCenter", prm);
                    data.Dispose();
                    MessageBox.Show("Has been saved succesfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewVTPort_Load(object sender, EventArgs e)
        {

            Common.FillLookup2(LookUpLocation, "select * from tblLocation where RecDelete=0", "LocationName", "Id");
            Common.FillLookup2(LookUpSan, "select * from tblSan where RecDelete=0", "San", "Id");

            if (id > 0)
            {
                SqlDataReader dr;
                DatabaseLib data = new DatabaseLib();
                data.RunSqlQuery(string.Format("SELECT * FROM tblVTPort WHERE Id={0}", id), out dr);

                if (dr.Read())
                {
                    LookUpLocation.EditValue = dr["LocationId"];
                    LookUpRoom.EditValue = dr["RoomId"];
                    LookUpSan.EditValue = dr["SanId"];
                }
            }

        }

        private void LookUpLocation_EditValueChanged(object sender, EventArgs e)
        {
            Common.FillLookup2(LookUpRoom, "select * from tblRoom where RecDelete=0 and LocationId=" + LookUpLocation.EditValue, "RoomName", "Id");
        }
    }
}