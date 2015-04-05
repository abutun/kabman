using System;
using System.Windows.Forms;
using KabMan.Data;

namespace KabMan.Forms
{
    public partial class NewVTPortForm : DevExpress.XtraEditors.XtraForm
    {
        public NewVTPortForm()
        {
            InitializeComponent();
            InitializeManager();
        }

        private void InitializeManager()
        {
            this.Icon = Resources.GetIcon("KabManIcon");

            CLocation.StoredProcedure = sproc.Location_Select_All;
            CLocation.Columns.Clear();
            CLocation.AddColumn("Name", "Select Location");
            CDataCenter.StoredProcedure = sproc.DataCenter_Select_ByLocationID;
            CDataCenter.Columns.Clear();
            CDataCenter.AddColumn("Name", "Select Data Center");

            CSanGroup.StoredProcedure = sproc.SanGroup_Select_All;
            CSanGroup.Columns.Clear();
            CSanGroup.AddColumn("Name", "Select San Group");
            CSan.StoredProcedure = sproc.San_Select_ByGroupID;
            CSan.Columns.Clear();
            CSan.AddColumn("Name", "Select San");

            CLocation.FormToShow = typeof(LocationManagerForm);
            CDataCenter.FormToShow = typeof(DataCenterManagerForm);

            CSanGroup.FormToShow = typeof(SanGroupManagerForm);
            CSan.FormToShow = typeof(SanManagerForm);
        }

        private void NewVTPortForm_Load(object sender, EventArgs e)
        {

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
                DBAssistant.ExecProcedure
                    (
                        sproc.VtPort_Insert_WithDetails, new object[]
                        {
                            "@DataCenterID", CDataCenter.EditValue,
                            "@SanID", CSan.EditValue
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