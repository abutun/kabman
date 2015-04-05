using System;
using System.ComponentModel;
using KabMan.Controls;
using KabMan.Data;
using KabMan.Text;
using KabMan.Windows;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;

namespace KabMan.Forms
{
    public partial class NewDasdForm : DevExpress.XtraEditors.XtraForm
    {
        public NewDasdForm()
        {
            Icon = Resources.GetIcon("KabManIcon");
            InitializeComponent();
            InitializeLookUps();
        }

        private void InitializeLookUps()
        {
            CLocation.StoredProcedure = sproc.Location_Select_All;
            CLocation.Columns.Clear();
            CLocation.AddColumn("Name", "Select Location");
            CDataCenter.StoredProcedure = sproc.DataCenter_Select_ByLocationID;
            CDataCenter.Columns.Clear();
            CDataCenter.AddColumn("Name", "Select Data Center");
            CCoordinate.StoredProcedure = sproc.Coordinate_Select_ByDataCenterID;
            CCoordinate.Columns.Clear();
            CCoordinate.AddColumn("Name", "Select Coordinate");

            CSanGroup.StoredProcedure = sproc.SanGroup_Select_All;
            CFirstVTPort.StoredProcedure = sproc.VtPort_Select_BySanValue;
            CSecondVTPort.StoredProcedure = sproc.VtPort_Select_BySanValue;

            CBlechType.StoredProcedure = sproc.BlechType_Select_All;
            CBlech.StoredProcedure = sproc.Blech_Select_ForServer_ByTypeID;

            CTrunkType.StoredProcedure = sproc.Cable_Select_TrunkCableTypes;
            CTrunkType.Columns.Clear();
            CTrunkType.AddColumn("Name", "Select Trunk Type");
            CFirstTrunkModel.StoredProcedure = sproc.Cable_Select_TrunkCables_ByCableLine;
            CFirstTrunkModel.Columns.Clear();
            CFirstTrunkModel.AddColumn("Name", "Select Trunk Model");
            CFirstTrunkCable.StoredProcedure = sproc.Cable_Select_ByCableModelID;
            CFirstTrunkCable.Columns.Clear();
            CFirstTrunkCable.AddColumn("Number", "Select Trunk Cable");
            CSecondTrunkModel.StoredProcedure = sproc.Cable_Select_TrunkCables_ByCableLine;
            CSecondTrunkModel.Columns.Clear();
            CSecondTrunkModel.AddColumn("Name", "Select Trunk Model");
            CSecondTrunkCable.StoredProcedure = sproc.Cable_Select_ByCableModelID;
            CSecondTrunkCable.Columns.Clear();
            CSecondTrunkCable.AddColumn("Number", "Select Trunk Cable");
            CTrunkConnCount.StoredProcedure = sproc.Trunk_Select_ConnectionCounts;

            CLCLength.StoredProcedure = sproc.Cable_Select_LengthsByCategory;
            CLCFirstCable.StoredProcedure = sproc.Cable_Select_LcByLength;
            CLCFirstCable.Columns.Clear();
            CLCFirstCable.AddColumn("Name", "Select First LC URM");
            CCuType.StoredProcedure = sproc.DasdCuType_Select_All;

            CLocation.FormToShow = typeof(LocationManagerForm);
            CLocation.Columns.Clear();
            CLocation.AddColumn("Name", "Select Location");
            CDataCenter.FormToShow = typeof(DataCenterManagerForm);
            CCoordinate.FormToShow = typeof(CoordinateManagerForm);

            CSanGroup.FormToShow = typeof(SanGroupManagerForm);
            CSanGroup.Columns.Clear();
            CSanGroup.AddColumn("Name", "Select San Group");
            CFirstVTPort.FormToShow = typeof(NewVTPortForm);
            CSecondVTPort.FormToShow = typeof(NewVTPortForm);

            CBlechType.FormToShow = typeof(BlechTypeManagerForm);
            CBlechType.Columns.Clear();
            CBlechType.AddColumn("Name", "Select Blech Type");
            CBlech.FormToShow = typeof(NewBlechForm);

            CTrunkType.FormToShow = typeof(CableModelManagerForm);
            CFirstTrunkModel.FormToShow = typeof(CableModelManagerForm);
            CFirstTrunkCable.FormToShow = typeof(CableManagerForm);
            CSecondTrunkModel.FormToShow = typeof(CableModelManagerForm);
            CSecondTrunkCable.FormToShow = typeof(CableManagerForm);

            CLCLength.FormToShow = typeof(CableModelManagerForm);
            CLCFirstCable.FormToShow = typeof(CableManagerForm);

            CCuType.FormToShow = typeof(DasdCuTypeManagerForm);
            CCuType.Columns.Clear();
            CCuType.AddColumn("Name", "Select Cu Type");
        }

        void CDataCenter_EditValueChanged(object sender, EventArgs e)
        {
            CCoordinate.FormParameters.Clear();
            CCoordinate.FormParameters.Add(CLocation.EditValue);
            CCoordinate.FormParameters.Add(CDataCenter.EditValue);

            FillBlechLookUp();
        }

        void CLocation_EditValueChanged(object sender, EventArgs e)
        {
            CDataCenter.FormParameters.Clear();
            CDataCenter.FormParameters.Add(CLocation.EditValue);
        }

        private void NewDasdForm_Load(object sender, EventArgs e)
        {

        }

        private void CTrunkModels_Triggering(KabMan.Controls.C_LookUpControl sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (CTrunkType.EditValue != null)
            {
                string editValue = CTrunkType.EditValue.ToString();
                string[] counts = null;
                if (editValue.Contains("x"))
                {
                    counts = editValue.Replace(" ", "").Split('x');
                    sender.Parameters[0].Value = counts[0];
                    sender.Parameters[1].Value = counts[1];
                }

                sender.Properties.Buttons[2].Enabled = !string.IsNullOrEmpty(CTrunkType.EditValue.ToString());
                sender.LoadDataSource(sender.StoredProcedure, sender.ParametersToArray(), sender.DisplayMember, sender.ValueMember);

            }
        }

        private void defaultButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private bool Save()
        {           
            if (CManagerValidator.Validate())
            {
                if (CFirstTrunkCable.EditValue.Equals(CSecondTrunkCable.EditValue))
                {
                    XtraMessageBox.Show("Same trunk cable value can not be used again!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                DataSet ds = DBAssistant.ExecProcedure(sproc.Server_Insert_Check_Record, new object[]
                                                {
                                                    "@DataCenterID", CDataCenter.EditValue,
                                                    "@CoordinateID", CCoordinate.EditValue
                                                });

                int control = 0;
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        control = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());

                        if (control > 0)
                        {
                            DialogResult dr = XtraMessageBox.Show("Same DASD does already exist!Do you want to update it anyway?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.No)
                                return false;
                        }
                    }
                }

                DBAssistant.ExecProcedure
                    (
                        sproc.DASD_Insert_WithDetails, new object[] 
	                    { 
	                        "@DataCenterID", CDataCenter.EditValue,
	                        "@CoordinateID", CCoordinate.EditValue,
	                        "@BlechID", CBlech.EditValue,
	                        "@TrunkCableModelID", CFirstTrunkModel.EditValue,
	                        "@PortCount", CTrunkConnCount.EditValue,
	                        "@SanGroupID", CSanGroup.EditValue,
	                        "@VtPort1ID", CFirstVTPort.EditValue,
	                        "@VtPort2ID", CSecondVTPort.EditValue,
	                        "@StartLcUrmID", CLCFirstCable.EditValue,
	                        "@LcUrmCount", CLCCount.EditValue,
                            "@CuTypeID", CCuType.EditValue,
                            "@UserID", Program.userId
	                    }
                    );
                RefreshAssistant.RefreshTrees();
                return true;
            }
            else
                return false;
        }

        private void CBlech_Triggering(KabMan.Controls.C_LookUpControl sender, CancelEventArgs e)
        {
            e.Cancel = true;
            this.FillBlechLookUp();
        }

        private void FillBlechLookUp()
        {
            if (CDataCenter.EditValue != null && CBlechType.EditValue != null)
            {
                CBlech.Properties.Buttons[2].Enabled = CBlech.TriggerControl.EditValue != null;
            }
            CBlech.Parameters = null;
            CBlech.Parameters = new NameValuePair[] 
            {
                new NameValuePair("@BlechTypeID", TextAssistant.TryConvertToString(CBlechType.EditValue)),
                new NameValuePair("@DeviceName", "DASD"),
                new NameValuePair("@DataCenterID",TextAssistant.TryConvertToString(CDataCenter.EditValue))
            };
            CBlech.LoadDataSource();
        }

        private void CSecondVTPort_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (Save()) Close();
        }
    }
}