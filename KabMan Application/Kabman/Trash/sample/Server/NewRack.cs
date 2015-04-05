using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Utils;
using DevExpress.Utils;
using System.Data.SqlClient;

namespace KabMan.Client
{
    public partial class NewServer : DevExpress.XtraEditors.XtraForm
    {
        DatabaseLib data = new DatabaseLib();
        private int id;
        private frmMain m;


        public NewServer(frmMain m, int id)
        {
            this.m = m;
            this.id = id;
            Common com;
            Icon = Properties.Resources.kabman;
            InitializeComponent();
        }

        int ConnCount = 0;
        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnCount = Convert.ToInt32(CBoxConnValue.Text);
            Common.FillLookup2(LookUpTrunkType, "Select * from tblTrunkCableType where Value=" + (ConnCount / 2), "Type", "Id");
        }

        private void BtnReckSave_Click(object sender, EventArgs e)
        {
        
            try
            {
                SqlParameter[] prm = 
                {
                    data.MakeInParam("@Id1", 0),
                    data.MakeInParam("@LocationId1",LookUpLocation.EditValue),
                    data.MakeInParam("@RoomId1", LookUpRoom.EditValue),
                    data.MakeInParam("@CoordId1", LookUpCoordinate.EditValue),
                    data.MakeInParam("@OPSysId1", LookUpOpSys.EditValue),
                    data.MakeInParam("@BlechTypeId1", LookUpBlechType.EditValue),
                    data.MakeInParam("@TrunkTypeId1", LookUpTrunkType.EditValue),
                    data.MakeInParam("@ConnValue1", Convert.ToInt32(CBoxConnValue.Text))
                };

                data.RunProc("sp_insRack", prm);
                data.Dispose();
                m.InitTree();
                MessageBox.Show("Has been saved succesfully!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Close();
    
        }


        private void NewReck_Load(object sender, EventArgs e)
        {
            Common.FillLookup2(LookUpLocation, "select * from tblLocation where RecDelete=0", "LocationName", "Id");
            Common.FillLookup2(LookUpOpSys, "select * from tblOPSys where RecDelete=0", "Name", "Id");
            Common.FillLookup2(LookUpBlechType, "select * from tblBlechType where RecDelete=0", "BlechType", "Id");

            if (id > 0)
            {
                SqlDataReader dr;
                data.RunSqlQuery(string.Format("SELECT * FROM tblRack WHERE Id={0}", id), out dr);

                if (dr.Read())
                {
                    LookUpLocation.EditValue = dr["LocationId"].ToString();
                    LookUpRoom.EditValue = dr["RoomId"].ToString();
                    LookUpCoordinate.EditValue = dr["CoordinateId"].ToString();
                    LookUpOpSys.EditValue = dr["OPSysId"].ToString();
                    LookUpBlechType.EditValue = dr["BlechTypeId"].ToString();
                    LookUpTrunkType.EditValue = dr["TrunkTypeId"].ToString();
                    CBoxConnValue.SelectedText = dr["ConnValue"].ToString();
                }
            }
        }

        private void BtnReckCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LookUpLocation_EditValueChanged(object sender, EventArgs e)
        {
            Common.FillLookup2(LookUpRoom, "Select * from tblRoom where RecDelete=0 and LocationId=" + LookUpLocation.EditValue, "RoomName", "Id");
        }

        private void LookUpRoom_EditValueChanged(object sender, EventArgs e)
        {
            Common.FillLookup2(LookUpCoordinate, "Select * from tblCoordinate where RecDelete=0 and RoomId=" + LookUpRoom.EditValue, "CoordName", "Id");
        }

    }
}

