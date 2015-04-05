using System;
using System.ComponentModel;
using System.Windows.Forms;
using KabMan.Controls;
using KabMan.Data;
using KabMan.Text;
using KabMan.Windows;
using System.Data;
using DevExpress.XtraEditors;

namespace KabMan.Forms
{
    public partial class NewSwitchForm : DevExpress.XtraEditors.XtraForm
    {
        public NewSwitchForm()
        {
            this.Icon = Resources.GetIcon("KabManIcon");

            InitializeComponent();
            InitializeManager();
        }

        private void InitializeManager()
        {
            CSwitchType.StoredProcedure = sproc.SwitchType_Select_All;
            CSwitchModel.StoredProcedure = sproc.SwitchModel_Select_All;
            CSwitchModel.Columns.Clear();
            CSwitchModel.AddColumn("Name", "Select Switch Model");
            CCoreSwitch.StoredProcedure = sproc.Switch_Select_ByTypeName;

            CLocation.StoredProcedure = sproc.Location_Select_All;
            CDataCenter.StoredProcedure = sproc.DataCenter_Select_ByLocationID;
            CDataCenter.Columns.Clear();
            CDataCenter.AddColumn("Name", "Select Data Center");

            CSanGroup.StoredProcedure = sproc.SanGroup_Select_All;
            CSan.StoredProcedure = sproc.San_Select_ByGroupID;
            CSan.Columns.Clear();
            CSan.AddColumn("Name", "Select SAN");

            CVtPort.StoredProcedure = sproc.VtPort_Select_BySanID;

            CFirstTrunk.StoredProcedure = sproc.Cable_Select_FirstTrunk_BySanValue;
            CFirstTrunk.Columns.Clear();
            CFirstTrunk.AddColumn("Name", "Select Start Trunk Cable");

            CBlechType.StoredProcedure = sproc.BlechType_Select_All;
            CBlech.StoredProcedure = sproc.Blech_Select_ForServer_ByTypeID;
            CBlech.Columns.Clear();
            CBlech.AddColumn("Name", "Select Blech");

            CLcLength.StoredProcedure = sproc.Cable_Select_LengthsByCategory;
            CLcCable.StoredProcedure = sproc.Cable_Select_LcByLength;
            CLcCable.Columns.Clear();
            CLcCable.AddColumn("Name", "Select LC URM Cable");

            CSwitchType.FormToShow = typeof(SwitchTypeManagerForm);
            /// CSwitchModel.FormToShow =
            CSwitchType.Columns.Clear();
            CSwitchType.AddColumn("Name", "Select Switch Type");

            CLocation.FormToShow = typeof(LocationManagerForm);
            CLocation.Columns.Clear();
            CLocation.AddColumn("Name", "Select Location");
            CDataCenter.FormToShow = typeof(DataCenterManagerForm);

            CSanGroup.FormToShow = typeof(SanGroupManagerForm);
            CSanGroup.Columns.Clear();
            CSanGroup.AddColumn("Name", "Select San Group");
            CSan.FormToShow = typeof(SanManagerForm);

            CVtPort.FormToShow = typeof(NewVTPortForm);
            CVtPort.Columns.Clear();
            CVtPort.AddColumn("Name", "Select VT Port");

            CFirstTrunk.FormToShow = typeof(CableManagerForm);

            CBlechType.FormToShow = typeof(BlechTypeManagerForm);
            CBlechType.Columns.Clear();
            CBlechType.AddColumn("Name", "Select Blech Type");
            CBlech.FormToShow = typeof(NewBlechForm);

            CLcLength.FormToShow = typeof(CableModelManagerForm);
            CLcCable.FormToShow = typeof(CableManagerForm);
        }

        private void defaultButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private bool Save()
        {
            object coreSwitch = CCoreSwitch.EditValue == null ? DBNull.Value : CCoreSwitch.EditValue;
            if (CManagerValidator.Validate())
            {

                if (Convert.ToInt32(CSwitchType.EditValue) == 1)
                {
                    DataSet ds = DBAssistant.ExecProcedure(sproc.Switch_Insert_Check_Record, new object[]
                                {
                                    "@DatacenterID", CDataCenter.EditValue,
                                    "@SanID", CSan.EditValue
                                });

                    if (ds.Tables[0].DefaultView.Count > 0)
                    {
                        XtraMessageBox.Show("Same Switch does already exist on the records!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ds.Dispose();
                        return false;
                    }

                    ds.Dispose();
                }

                DBAssistant.ExecProcedure
                    (sproc.Switch_Insert_WithDetails, new object[]
                        {
                            "@SerialNo", CSwitchSerial.Text,
                            "@SanID", CSan.EditValue,
                            "@DatacenterID", CDataCenter.EditValue,
                            "@VtPortID", CVtPort.EditValue,
                            "@BlechID", CBlech.EditValue,
                            "@SwitchTypeID", CSwitchType.EditValue,
                            "@SwitchModelID", CSwitchModel.EditValue,
                            "@IpNo", CSwitchIP.Text,
                            "@CoreSwitchID", coreSwitch,
                            "@TrunkNo", CFirstTrunk.EditValue,
                            "@StartLcUrmID", CLcCable.EditValue,
                            "@LcUrmCount", CLcCount.Value
                        }
                    );



                RefreshAssistant.RefreshTrees();
                
                return true;
            }
            else
                return false;            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CSwitchType_EditValueChanged(object sender, EventArgs e)
        {
            CCoreSwitch.Enabled = CSwitchType.GetColumnValue("Name").ToString().Contains("Edge") ? true : false;
        }

        private void CFirstTrunk_Triggering(KabMan.Controls.C_LookUpControl sender, CancelEventArgs e)
        {
            e.Cancel = true;

            sender.Properties.Buttons[2].Enabled = true;
            sender.Parameters = new NameValuePair[] { new NameValuePair("@SanValue", (Convert.ToInt32(sender.TriggerControl.GetColumnValue("Value")) % 2).ToString()) };
            sender.LoadDataSource(sender.StoredProcedure, sender.ParametersToArray(), sender.DisplayMember, sender.ValueMember);
        }

        private void CBlech_Triggering(C_LookUpControl sender, CancelEventArgs e)
        {
            e.Cancel = true;

            this.FillBlechLookUp();
        }

        private void CDataCenter_EditValueChanged(object sender, EventArgs e)
        {
            this.FillBlechLookUp();
        }

        private void FillBlechLookUp()
        {
            if (CDataCenter.EditValue != null && CBlechType.EditValue != null)
            {
                CBlech.Properties.Buttons[2].Enabled = true;
            }
            CBlech.Parameters = null;
            CBlech.Parameters = new NameValuePair[]
                {
                    new NameValuePair("BlechTypeID", TextAssistant.TryConvertToString(CBlechType.EditValue)),
                    new NameValuePair("DeviceName", "Switch"),
                    new NameValuePair("DataCenterID", TextAssistant.TryConvertToString(CDataCenter.EditValue))
                };
            CBlech.LoadDataSource();
        }

        private void CLocation_EditValueChanged(object sender, EventArgs e)
        {
            CDataCenter.FormParameters.Clear();
            CDataCenter.FormParameters.Add(CLocation.EditValue);
        }

        private void CSanGroup_EditValueChanged(object sender, EventArgs e)
        {
            CSan.FormParameters.Clear();
            CSan.FormParameters.Add(CSanGroup.EditValue);
        }

        private void CLcLength_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (Save()) Close();
        }

    }
}