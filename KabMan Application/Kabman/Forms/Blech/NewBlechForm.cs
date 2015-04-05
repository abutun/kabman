using System;
using System.Windows.Forms;
using KabMan.Data;

namespace KabMan.Forms
{
    public partial class NewBlechForm : DevExpress.XtraEditors.XtraForm
    {
        public NewBlechForm()
        {
            this.Icon = Resources.GetIcon("KabManIcon");

            InitializeComponent();
            InitializeManager();
        }

        private void InitializeManager()
        {
            CBlechType.StoredProcedure = sproc.BlechType_Select_All;
            CBlechType.Columns.Clear();
            CBlechType.AddColumn("Name", "Select Blech Type");
            CDevice.StoredProcedure = sproc.Device_Select_ByCondition2;
            CDevice.Columns.Clear();
            CDevice.AddColumn("Name", "Select Device");
            CSwitchType.StoredProcedure = sproc.SwitchType_Select_All;
            CSwitchType.Columns.Clear();
            CSwitchType.AddColumn("Name", "Select Switch Type");

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
            CSanGroup.Columns.Clear();
            CSanGroup.AddColumn("Name", "Select San Group");
            CSan.StoredProcedure = sproc.San_Select_ByGroupID;
            CSan.Columns.Clear();
            CSan.AddColumn("Name", "Select San");

            CBlechType.FormToShow = typeof(BlechTypeManagerForm);
            CDevice.FormToShow = typeof(DeviceManagerForm);
            CSwitchType.FormToShow = typeof(SwitchTypeManagerForm);

            CLocation.FormToShow = typeof(LocationManagerForm);
            CDataCenter.FormToShow = typeof(DataCenterManagerForm);
            CCoordinate.FormToShow = typeof(CoordinateManagerForm);

            CSanGroup.FormToShow = typeof(SanGroupManagerForm);
            CSan.FormToShow = typeof(SanManagerForm);
        }

        private void NewBlechForm_Load(object sender, EventArgs e)
        {

        }

        private void CDataCenter_EditValueChanged(object sender, EventArgs e)
        {
            CCoordinate.FormParameters.Clear();
            CCoordinate.FormParameters.Add(CLocation.EditValue);
            CCoordinate.FormParameters.Add(CDataCenter.EditValue);
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

        private bool Save()
        {
            if (CManagerValidator.Validate())
            {
                object coordinateID = CCoordinate.Enabled ? CCoordinate.EditValue : DBNull.Value;
                object switchType = CSwitchType.Enabled ? CSwitchType.EditValue : DBNull.Value;

                DBAssistant.ExecProcedure
                    (
                        sproc.Blech_Insert_WithDetails, new object[]
                        {
                            "@DataCenterID", CDataCenter.EditValue,
                            "@SanID", CSan.EditValue,
                            "@CoordinateID", coordinateID,
                            "@BlechTypeID", CBlechType.EditValue,
                            "@DeviceID", CDevice.EditValue,
                            "@UserID", Program.userId
                        }
                    );
                return true;
            }
            else
                return false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void CDevice_EditValueChanged(object sender, EventArgs e)
        {
            string deviceName = CDevice.GetColumnValue("Name").ToString();

            CCoordinate.Enabled = deviceName.Contains("Server") | deviceName.Contains("DASD");
            CSwitchType.Enabled = deviceName.Contains("Switch");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveCloseButton_Click(object sender, EventArgs e)
        {
            if (Save()) Close();
        }

    }
}