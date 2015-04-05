using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KabMan.Data;
using KabMan.Controls;
using KabMan.Windows;
using KabMan.Text;

namespace KabMan.Forms
{
    public partial class NewDCCForm : DevExpress.XtraEditors.XtraForm
    {
        public NewDCCForm()
        {
            Icon = Resources.GetIcon("KabManIcon");

            InitializeComponent();
            InitializeLookUps();
        }

        private void InitializeLookUps()
        {

            C_Location.StoredProcedure = sproc.Location_Select_All;
            C_Location.Columns.Clear();
            C_Location.AddColumn("Name", "Select Location");
            C_DataCenter1.StoredProcedure = sproc.DataCenter_Select_ByLocationID;
            C_DataCenter1.Columns.Clear();
            C_DataCenter1.AddColumn("Name", "Select Data Center");
            C_DataCenter2.StoredProcedure = sproc.DataCenter_Select_ByLocationID;
            C_DataCenter2.Columns.Clear();
            C_DataCenter2.AddColumn("Name", "Select Data Center");

            C_SanGroup.StoredProcedure = sproc.SanGroup_Select_All;
            C_SanGroup.Columns.Clear();
            C_SanGroup.AddColumn("Name", "Select San Group");

            C_VTPORT1San1.StoredProcedure = sproc.VtPort_Select_BySanValue;
            C_VTPORT1San1.Columns.Clear();
            C_VTPORT1San1.AddColumn("Name", "Select Vt Port");
            C_VTPORT1San2.StoredProcedure = sproc.VtPort_Select_BySanValue;
            C_VTPORT1San2.Columns.Clear();
            C_VTPORT1San2.AddColumn("Name", "Select Vt Port");
            C_VTPORT2San1.StoredProcedure = sproc.VtPort_Select_BySanValue;
            C_VTPORT2San1.Columns.Clear();
            C_VTPORT2San1.AddColumn("Name", "Select Vt Port");
            C_VTPORT2San2.StoredProcedure = sproc.VtPort_Select_BySanValue;
            C_VTPORT2San2.Columns.Clear();
            C_VTPORT2San2.AddColumn("Name", "Select Vt Port");

            C_ConnCount.StoredProcedure = sproc.Trunk_Select_ConnectionCounts;
            C_TrunkType.StoredProcedure = sproc.Cable_Select_TrunkCableTypes;
            C_TrunkType.Columns.Clear();
            C_TrunkType.AddColumn("Name", "Select Trunk Type");
            C_TrunkModel.StoredProcedure = sproc.Cable_Select_TrunkCables_ByCableLine;
            C_TrunkModel.Columns.Clear();
            C_TrunkModel.AddColumn("Name", "Select Trunk Model");

            C_TrunkCable.StoredProcedure = sproc.Cable_Select_ByCableModelID;
            C_TrunkCable.Columns.Clear();
            C_TrunkCable.AddColumn("Number", "Select Trunk Cable");
            C_TrunkCable2.StoredProcedure = sproc.Cable_Select_ByCableModelID;
            C_TrunkCable2.Columns.Clear();
            C_TrunkCable2.AddColumn("Number", "Select Trunk Cable");

            C_Location.FormToShow = typeof(LocationManagerForm);
            C_DataCenter1.FormToShow = typeof(DataCenterManagerForm);
            C_DataCenter2.FormToShow = typeof(DataCenterManagerForm);

            C_SanGroup.FormToShow = typeof(SanGroupManagerForm);

            C_VTPORT1San1.FormToShow = typeof(NewVTPortForm);
            C_VTPORT1San2.FormToShow = typeof(NewVTPortForm);
            C_VTPORT2San1.FormToShow = typeof(NewVTPortForm);
            C_VTPORT2San2.FormToShow = typeof(NewVTPortForm);

            C_TrunkType.FormToShow = typeof(CableModelManagerForm);
            C_TrunkModel.FormToShow = typeof(CableModelManagerForm);
            C_TrunkCable.FormToShow = typeof(CableManagerForm);
            C_TrunkCable2.FormToShow = typeof(CableManagerForm);

        }

        private bool Save()
        {
            if (dxValidationProvider1.Validate())
            {
                DBAssistant.ExecProcedure
                    (
                        sproc.DCC_Insert_WithDetails, new object[]
                        {
                                "@DataCenter1ID", C_DataCenter1.EditValue,
                                "@DataCenter2ID", C_DataCenter2.EditValue,
                                "@SanGroupID", C_SanGroup.EditValue,
                                "@VtPort1San1ID", C_VTPORT1San1.EditValue,
                                "@VtPort1San2ID", C_VTPORT1San2.EditValue,
                                "@VtPort2San1ID", C_VTPORT2San1.EditValue,
                                "@VtPort2San2ID", C_VTPORT2San2.EditValue,
                                "@San1TrunkID", C_TrunkCable.EditValue,
                                "@San2TrunkID", C_TrunkCable2.EditValue,
                                "@PortCount", C_ConnCount.EditValue,
                                "@UserID", Program.userId
                        }
                    );
                RefreshAssistant.RefreshTrees();
                return true;
            }
            else
                return false;
        }

        private void C_Location_EditValueChanged(object sender, EventArgs e)
        {
            C_DataCenter1.FormParameters.Clear();
            C_DataCenter1.FormParameters.Add(C_Location.EditValue);

            C_DataCenter2.FormParameters.Clear();
            C_DataCenter2.FormParameters.Add(C_Location.EditValue);

        }

        private void C_TrunkModel_Triggering(C_LookUpControl sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (C_TrunkType.EditValue != null)
            {
                string editValue = C_TrunkType.EditValue.ToString();
                string[] counts = null;
                if (editValue.Contains("x"))
                {
                    counts = editValue.Replace(" ", "").Split('x');
                    sender.Parameters[0].Value = counts[0];
                    sender.Parameters[1].Value = counts[1];
                }
                sender.Properties.Buttons[2].Enabled = !string.IsNullOrEmpty(C_TrunkType.EditValue.ToString());
                sender.LoadDataSource(sender.StoredProcedure, sender.ParametersToArray(), sender.DisplayMember, sender.ValueMember);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (Save()) Close();
        }

        private void C_TrunkCable2_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}