using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KabMan.Data;
using KabMan.Windows;


namespace KabMan.Forms
{

    public partial class DataCenterManagerForm : XtraForm
    {

        public DataCenterManagerForm()
        {
            Icon = Resources.GetIcon("KabManIcon");

            InitializeComponent();
            InitializeManager();
        }

        public DataCenterManagerForm(object argLocationID)
        {
            InitializeComponent();
            InitializeManager();
            CLocation.EditValue = argLocationID;
        }

        private void InitializeManager()
        {
            CLocation.FormToShow = typeof(LocationManagerForm);

            this.Icon = Resources.GetIcon("KabManIcon");

            CManager.SelectProcedure = sproc.DataCenter_Select_ByLocationID;
            CManager.UpdateProcedure = sproc.DataCenter_Update_ByID;
            CManager.InsertProcedure = sproc.DataCenter_Insert;
            CManager.DeleteProcedure = sproc.DataCenter_Delete_ByID;
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
                //CHasSwitch.Checked = (bool)CManager.SelectedRowValues["HasSwitch"];
            }
            else
            {
                CManager.IsCancel = true;
            }
            RefreshAssistant.RefreshTrees();
        }

        void DeleteButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CManager.AskForDelete() == DialogResult.OK)
            {
                object id = CManager.SelectedRowValues["ID"];
                CManager.dbDelete(new object[] { "@ID", id });
                this.ClearControlValues();
            }
            RefreshAssistant.RefreshTrees();
        }

        void SaveButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CManagerValidator.Validate())
            {
                object id = CManager.SelectedRowValues["ID"];
                if (CManager.IsEdit)
                {
                    CManager.dbUpdate(new object[] { "@ID", id, "@LocationID", CLocation.EditValue, "@Name", CName.Text, "@HasSwitch", CHasSwitch.Checked });
                }
                else if (CManager.IsNew)
                {
                    CManager.dbInsert(new object[] { "@LocationID", CLocation.EditValue, "@Name", CName.Text, "@HasSwitch", CHasSwitch.Checked });
                }
                this.ClearControlValues();
                RefreshAssistant.RefreshTrees();
            }

        }

        void CancelButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ClearControlValues();
        }

        private void ClearControlValues()
        {
            CName.Text = "";
            CHasSwitch.Checked = false;
            CManager.IsCancel = true;
        }

        private void DataCenterManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void CLocation_EditValueChanged(object sender, EventArgs e)
        {
            if (CLocation.EditValue != null && !CManager.IsEdit)
            {
                CManager.dbSelect(new object[] { "@LocationID", CLocation.EditValue });
            }
        }


    }
}