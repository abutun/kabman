using System;
using System.Windows.Forms;
using KabMan.Data;

namespace KabMan.Forms
{
    public partial class BlechTypeManagerForm : DevExpress.XtraEditors.XtraForm
    {
        public BlechTypeManagerForm()
        {
            InitializeComponent();

            this.Icon = Resources.GetIcon("KabManIcon");

            BlechTypeCManager.SelectProcedure = sproc.BlechType_Select_All;
            BlechTypeCManager.UpdateProcedure = sproc.BlechType_Update_ByID;
            BlechTypeCManager.InsertProcedure = sproc.BlechType_Insert;
            BlechTypeCManager.DeleteProcedure = sproc.BlechType_Delete_ByID;
            BlechTypeCManager.CancelButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(CancelButton_ItemClick);
            BlechTypeCManager.SaveButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(SaveButton_ItemClick);
            BlechTypeCManager.DeleteButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(DeleteButton_ItemClick);
            BlechTypeCManager.EditButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(EditButton_ItemClick);
            BlechTypeCManager.NewButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(NewButton_ItemClick);

        }

        void NewButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ClearControlValues();
        }

        void EditButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NameTextBox.Text = BlechTypeCManager.SelectedRowValues["Name"].ToString();
            PortCountSpinEdit.Value = Convert.ToInt64(BlechTypeCManager.SelectedRowValues["PortCount"].ToString());
        }

        void DeleteButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BlechTypeCManager.AskForDelete() == DialogResult.OK)
            {
                object id = BlechTypeCManager.SelectedRowValues["ID"];
                BlechTypeCManager.dbDelete(new object[] { "@ID", id });
                this.ClearControlValues();
            }
        }

        public void SaveButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (BlechTypeControlsValidator.Validate())
            {
                object id = BlechTypeCManager.SelectedRowValues["ID"];
                if (BlechTypeCManager.IsEdit)
                {
                    BlechTypeCManager.dbUpdate(new object[] { "@ID", id, "@Name", NameTextBox.Text, "@PortCount", PortCountSpinEdit.Value });
                }
                else if (BlechTypeCManager.IsNew)
                {
                    BlechTypeCManager.dbInsert(new object[] { "@Name", NameTextBox.Text, "@PortCount", PortCountSpinEdit.Value });
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
            NameTextBox.Text = "";
            PortCountSpinEdit.Value = 0;
            BlechTypeCManager.IsCancel = true;
        }

    }
}