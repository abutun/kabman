using System;
using KabMan.Data;

namespace KabMan.Forms
{
    public partial class DefaultsManagerForm : DevExpress.XtraEditors.XtraForm
    {
        public DefaultsManagerForm()
        {
            Icon = Resources.GetIcon("KabManIcon");
            
            InitializeComponent();

            CManager.SelectProcedure = sproc.Defaults_Select_All;
            CManager.UpdateProcedure = sproc.Defaults_Update_ByID;
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
                CKey.Text = CManager.SelectedRowValues["Key"].ToString();
                CValue.Text = CManager.SelectedRowValues["Value"].ToString();
                CManager.SetToolbarButtonEnabledStates(false, CManager.EditButton.Enabled, false, CManager.SaveButton.Enabled, CManager.CancelButton.Enabled, true);
            }
            else
            {
                CManager.IsCancel = true;
            }
        }

        void DeleteButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void SaveButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CManagerValidator.Validate())
            {
                object id = CManager.SelectedRowValues["ID"];
                if (CManager.IsEdit)
                {
                    CManager.dbUpdate(new object[] { "@ID", id, "@Value", CValue.Text });
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
            CValue.Text = "";
            CManager.IsCancel = true;
            CManager.SetToolbarButtonEnabledStates(false, CManager.EditButton.Enabled, false, false, CManager.CancelButton.Enabled, true);
        }

        private void DefaultsManagerForm_Load(object sender, EventArgs e)
        {
            this.ClearControlValues();
        }
    }
}