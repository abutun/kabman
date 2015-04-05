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
    public partial class NewBlech : DevExpress.XtraEditors.XtraForm
    {
        private Common com;
        DatabaseLib data = new DatabaseLib();
        private frmBlech b;
        private int id;

        public NewBlech(frmBlech b, int id)
        {
            this.b = b;
            InitializeComponent();
        }

        private void NewBlech_Load(object sender, EventArgs e)
        {
            Common.FillLookup2(LookUpLocation, "select * from tblLocation where RecDelete=0", "LocationName", "Id");
            Common.FillLookup2(LookUpBlechType, "select * from tblBlechType where RecDelete=0", "Name", "Id");
            Common.FillLookup2(LookUpObjectType, "select * from tblBlechObject where RecDelete=0", "Name", "Id");

            if (id > 0)
            {
                SqlDataReader dr;
                DatabaseLib data = new DatabaseLib();
                data.RunSqlQuery(string.Format("SELECT * FROM tblBlech WHERE Id={0}", id), out dr);

                if (dr.Read())
                {
                    LookUpLocation.EditValue = dr["LocationId"];
                    LookUpRoom.EditValue = dr["RoomId"];
                    LookUpSan.EditValue = dr["SanId"];
                    LookUpBlechType.EditValue = dr["TypeId"];
                    LookUpObjectType.EditValue = dr["ObjectId"];
                    txtSerialNo.Text = dr["SerialNo"].ToString();
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter[] prm =
                { 
                    data.MakeInParam("@LocationId", LookUpLocation.EditValue),
                    data.MakeInParam("@RoomId", LookUpRoom.EditValue),
                    data.MakeInParam("@SanId", LookUpSan.EditValue),
                    data.MakeInParam("@TypeId", LookUpBlechType.EditValue),
                    data.MakeInParam("@ObjectName", LookUpObjectType.Text)
                };
                data.RunProc(SPROC.BLECH_INSERT, prm);
                data.Dispose();
                MessageBox.Show("Has been saved succesfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            b.Liste(true);
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LookUpLocation_EditValueChanged(object sender, EventArgs e)
        {
            Common.FillLookup2(LookUpRoom, "select * from tblRoom where LocationId=" + LookUpLocation.EditValue, "RoomName", "Id");
        }

        private void LookUpObjectType_EditValueChanged(object sender, EventArgs e)
        {

 


        }

        private void LookUpRoom_EditValueChanged(object sender, EventArgs e)
        {
            if (LookUpObjectType.EditValue.ToString() == "3")
            {
                Common.FillLookup2(LookUpSan, "select * from tblSan where RecDelete=0", "San", "Id");
            }
            else
            {
                if (LookUpObjectType.EditValue.ToString() == "4")
                {
                    Common.FillLookup2(LookUpSan, "select * from tblCoordinate where RecDelete=0 and RoomId=" + LookUpRoom.EditValue, "CoordName", "Id");
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //NewCoordinate c = new NewCoordinate();
            //c.ShowDialog();
        }
    }
}