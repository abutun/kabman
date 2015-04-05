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
    public partial class NewSwitch : DevExpress.XtraEditors.XtraForm
    {
        DatabaseLib data = new DatabaseLib();
        private int id;
        private Home m;
        Common com;

        public NewSwitch(Home m, int id)
        {
            this.m = m;
            this.id = id;
            InitializeComponent();
        }

        private void NewSwitch_Load(object sender, EventArgs e)
        {
            Common.FillLookup2(LookUpLocation, "Select * from tblLocation where RecDelete=0", "LocationName", "Id");
            Common.FillLookup2(LookUpSan, "Select * from tblSan where RecDelete=0", "San", "Id");
            Common.FillLookup2(LookUpSwitchType, "Select * from tblSwitchType where RecDelete=0", "Type", "Id");
            Common.FillLookup2(LookUpSwitchModel, "Select * from tblSwitchModel where RecDelete=0", "Name", "Id");
            Common.FillLookup2(LookUpBlechType, "select * from tblBlechType where RecDelete=0", "Name", "Id");
        }

        private void LookUpSwitchModel_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {




            DataSet ds;
            DatabaseLib data = new DatabaseLib();

            SqlParameter[] prm1 =
            { 
                data.MakeInParam("@LocationId", LookUpLocation.EditValue),
                data.MakeInParam("@RoomId", LookUpRoom.EditValue),
                data.MakeInParam("@SanId", LookUpSan.EditValue),
                data.MakeInParam("@SwType", LookUpSwitchType.Text),
                data.MakeInParam("@Name","SW" + LookUpLocation.GetColumnValue("LocationCoord") + LookUpSan.GetColumnValue("Value"))
            };

            data.RunProc(SPROC.SWITCH_CHECK, prm1, out ds);
            data.Dispose();

            if (ds.Tables[0].Rows[0]["retValue"].ToString() == "0")
            {
                try
                {
                    SqlParameter[] prm = 
                {
                    data.MakeInParam("@Id1", id),
                    data.MakeInParam("@LocationId1", LookUpLocation.EditValue),
                    data.MakeInParam("@RoomId1", LookUpRoom.EditValue),
                    data.MakeInParam("@SanId1", LookUpSan.EditValue),
                    data.MakeInParam("@BlechId1", LookUpBlech.EditValue),
                    data.MakeInParam("@TypeId1", LookUpSwitchType.EditValue),
                    data.MakeInParam("@ModelId1", LookUpSwitchModel.EditValue),
                    data.MakeInParam("@VTPortId1", LookUpVTPort.EditValue),
                    data.MakeInParam("@SerialNo1", txtSerialNo.Text),
                    data.MakeInParam("@IpNo1", txtIpNo.Text + "." + txtIPNO2.Text + "." + txtIPNO3.Text + "." + txtIPNO4.Text),
                    data.MakeInParam("@ConnSwitchId1", ConnSwitchId),
                    data.MakeInParam("@LcUrmStartNo", LookUpLcUrmStartNo.EditValue),
                    data.MakeInParam("@CountLcUrm", Convert.ToInt32(txtCountLcUrm.Text)),
                    data.MakeInParam("@LcUrmMeter", Convert.ToInt32(CBoxLcUrmMeter.Text))
                };

                    data.RunProc("sp_insSwitch", prm);
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
            else
            {
                MessageBox.Show("The Switch is in the Database!");
            }

        }

        int ConnSwitchId = 0;
        private void LookUpSwitchType_EditValueChanged(object sender, EventArgs e)
        {


            if (LookUpLocation.EditValue == null || LookUpRoom.EditValue == null)
            {
                MessageBox.Show("Please select Location and Room!");
            }
            else
            {
                if (LookUpSwitchType.Text == "Edge")
                {
                    layoutControlItem5.ContentVisible = true;
                    Common.FillLookup2(LookUpCoreSwitch, "select * from tblSwitch where LocationId=" + LookUpLocation.EditValue + " and RoomId=" + LookUpRoom.EditValue + " and SanId=" + LookUpSan.EditValue + " and TypeId=1 and RecDelete=0", "SwName", "Id");
                }
            }
        }

        private void LookUpLocation_EditValueChanged(object sender, EventArgs e)
        {
            Common.FillLookup2(LookUpRoom, "Select * from tblRoom where RecDelete=0 and LocationId=" + LookUpLocation.EditValue.ToString(), "RoomName", "Id");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LookUpCoreSwitch_EditValueChanged(object sender, EventArgs e)
        {
            ConnSwitchId = Convert.ToInt32(LookUpCoreSwitch.EditValue.ToString());
        }

        private void BtnCreateVTPort_Click(object sender, EventArgs e)
        {

            if (XtraMessageBox.Show(
"Are you sure you want to create New VT Port?",
Text,
MessageBoxButtons.OKCancel,
MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
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
                    MessageBox.Show("Has been created VT Port succesfully!");
                    Common.FillLookup2(LookUpVTPort, "select * from tblVTPort where  RecDelete=0 and LocationId=" + LookUpLocation.EditValue + " and RoomId=" + LookUpRoom.EditValue + " and SanId=" + LookUpSan.EditValue, "Name", "Id");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void BtnCreateBlech_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(
"Are you sure you want to create New Blech?",
Text,
MessageBoxButtons.OKCancel,
MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {

                try
                {
                    SqlParameter[] prm =
                {
                    data.MakeInParam("@LocationId", LookUpLocation.EditValue),
                    data.MakeInParam("@RoomId", LookUpRoom.EditValue),
                    data.MakeInParam("@SanId", LookUpSan.EditValue),
                    data.MakeInParam("@TypeId", LookUpBlechType.EditValue),
                    data.MakeInParam("@ObjectName", "Switch")
                };
                    data.RunProc(SPROC.BLECH_INSERT, prm);
                    data.Dispose();
                    MessageBox.Show("Has been created Blech succesfully!");
                    Common.FillLookup2(LookUpBlech, "select * from tblBlech where ObjectId=3 and RecDelete=0 and LocationId=" + LookUpLocation.EditValue + " and RoomId=" + LookUpRoom.EditValue + " and SanId=" + LookUpSan.EditValue + " and TypeId=" + LookUpBlechType.EditValue, "Name", "Id");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void LookUpSan_EditValueChanged(object sender, EventArgs e)
        {
            Common.FillLookup2(LookUpVTPort, "select * from tblVTPort where  RecDelete=0 and LocationId=" + LookUpLocation.EditValue + " and RoomId=" + LookUpRoom.EditValue + " and SanId=" + LookUpSan.EditValue, "Name", "Id");
        }

        private void LookUpBlechType_EditValueChanged(object sender, EventArgs e)
        {
            Common.FillLookup2(LookUpBlech, "select * from tblBlech where ObjectId=3 and RecDelete=0 and LocationId=" + LookUpLocation.EditValue + " and RoomId=" + LookUpRoom.EditValue + " and SanId=" + LookUpSan.EditValue + " and TypeId=" + LookUpBlechType.EditValue, "Name", "Id");
        }

        private void CBoxLcUrmMeter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Common.FillLookup2(LookUpLcUrmStartNo, "Select * from tblUrm where RecDelete=0 and Visible=0 and TypeId=1 and Meter=" + Convert.ToInt32(CBoxLcUrmMeter.Text), "No", "Id");
        }

    }
}