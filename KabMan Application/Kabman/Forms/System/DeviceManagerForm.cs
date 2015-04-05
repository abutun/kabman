using System;
using System.Windows.Forms;
using KabMan.Data;

namespace KabMan.Forms
{
    public partial class DeviceManagerForm : DevExpress.XtraEditors.XtraForm
    {
        public DeviceManagerForm()
        {
            Icon = Resources.GetIcon("KabManIcon");
            InitializeComponent();

            CManager.SelectProcedure = sproc.Device_Select_All;
            CManager.UpdateProcedure = sproc.Device_Update_ByID;
            CManager.InsertProcedure = sproc.Device_Insert;
            CManager.DeleteProcedure = sproc.Device_Delete_ByID;
            
            CManager.CancelButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(CancelButton_ItemClick);
            CManager.SaveButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(SaveButton_ItemClick);
            CManager.DeleteButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(DeleteButton_ItemClick);
            CManager.EditButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(EditButton_ItemClick);
            CManager.NewButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(NewButton_ItemClick);
        }

        void NewButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ClearControlValues();
        }

        void EditButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CManager.ManagerGridView.FocusedColumn != null)
            {
                CName.Text = CManager.SelectedRowValues["Name"].ToString();
                CCondition1.Checked = (bool)CManager.SelectedRowValues["Condition1"];
                CCondition2.Checked = (bool)CManager.SelectedRowValues["Condition2"];
            }
            else
            {
                CManager.IsCancel = true;
            }

        }

        void DeleteButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CManager.AskForDelete() == DialogResult.OK)
            {
                object id = CManager.SelectedRowValues["ID"];
                CManager.dbDelete(new object[] { "@ID", id });
                this.ClearControlValues();
            }
        }

        void SaveButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CManagerValidator.Validate())
            {
                object id = CManager.SelectedRowValues["ID"];
                if (CManager.IsEdit)
                {
                    CManager.dbUpdate(new object[] { "@ID", id, "@Name", CName.Text, "@Condition1", CCondition1.Checked, "@Condition2", CCondition2.Checked });
                }
                else if (CManager.IsNew)
                {
                    CManager.dbInsert(new object[] { "@Name", CName.Text, "@Condition1", CCondition1.Checked, "@Condition2", CCondition2.Checked });
                }
                this.ClearControlValues();
            }
        }

        void CancelButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ClearControlValues();
        }

        private void ClearControlValues()
        {
            CName.Text = "";
            CCondition1.Checked = CCondition2.Checked = false;
            CManager.IsCancel = true;
        }

        private void CManager_Load(object sender, EventArgs e)
        {

        }
    }
}