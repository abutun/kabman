using System;
using System.Windows.Forms;
using KabMan.Data;

namespace KabMan.Forms
{
    public partial class SanManagerForm : DevExpress.XtraEditors.XtraForm
    {
        private object _SanGroupID;

        public long SanGroupID
        {
            get
            {
                return Convert.ToInt64(this._SanGroupID);
            }
        }

        public SanManagerForm()
        {
            InitializeComponent();
            InitializeManager();
        }

        public SanManagerForm(object argSanGroupID)
        {
            this._SanGroupID = argSanGroupID;
            InitializeComponent();
            InitializeManager();
            CSanGroup.EditValue = this.SanGroupID;
        }

        private void InitializeManager()
        {
            CSanGroup.StoredProcedure = sproc.SanGroup_Select_All;
            CSanGroup.FormToShow = typeof(SanGroupManagerForm);

            this.Icon = Resources.GetIcon("KabManIcon");

            CManager.SelectProcedure = sproc.San_Select_ByGroupID;
            CManager.UpdateProcedure = sproc.San_Update_ByID;
            CManager.InsertProcedure = sproc.San_Insert;
            CManager.DeleteProcedure = sproc.San_Delete_ByID;
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
                CSanValue.Value = Convert.ToInt16(CManager.SelectedRowValues["Value"].ToString());
                CSwitchValue.Text = CManager.SelectedRowValues["SwitchValue"].ToString();
                CBlechValue.Text = CManager.SelectedRowValues["BlechValue"].ToString();
                CDataCenterValue.Text = CManager.SelectedRowValues["DataCenterValue"].ToString();
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
                    CManager.dbUpdate(new object[] { "@ID", id, "@SanGroupID", CSanGroup.EditValue, "@Name", CName.Text, "@Value", CSanValue.Value, "@BlechValue", CBlechValue.EditValue, "@SwitchValue", CSwitchValue.EditValue, "@DataCenterValue", CDataCenterValue.EditValue });
                }
                else if (CManager.IsNew)
                {
                    CManager.dbInsert(new object[] { "@SanGroupID", CSanGroup.EditValue, "@Name", CName.Text, "@Value", CSanValue.Value, "@BlechValue", CBlechValue.EditValue, "@SwitchValue", CSwitchValue.EditValue, "@DataCenterValue", CDataCenterValue.EditValue });
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
            CName.Text = CBlechValue.Text = CSwitchValue.Text = CDataCenterValue.Text = "";
            CSanValue.Value = CSanValue.Properties.MinValue;
            CManager.IsCancel = true;
        }

        private void CSanGroup_EditValueChanged(object sender, EventArgs e)
        {
            if (CSanGroup.EditValue != null && !CManager.IsEdit)
            {
                CManager.dbSelect(new object[] { "@SanGroupID", CSanGroup.EditValue });
            }
        }
    }
}