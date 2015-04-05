using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KabMan.Data;


namespace KabMan.Forms
{

    public partial class CoordinateManagerForm : XtraForm
    {

        public CoordinateManagerForm()
        {
            Icon = Resources.GetIcon("KabManIcon");

            InitializeComponent();
            InitializeManager();
        }

        public CoordinateManagerForm(object argLocationID, object argDataCenterID)
        {
            InitializeComponent();
            InitializeManager();
            CLocation.EditValue = argLocationID;
            CDataCenter.EditValue = argDataCenterID;
        }

        private void InitializeManager()
        {
            CLocation.FormToShow = typeof(LocationManagerForm);
            CDataCenter.FormToShow = typeof(DataCenterManagerForm);

            CManager.SelectProcedure = sproc.Coordinate_Select_ByDataCenterID;
            CManager.UpdateProcedure = sproc.Coordinate_Update_ByID;
            CManager.InsertProcedure = sproc.Coordinate_Insert;
            CManager.DeleteProcedure = sproc.Coordinate_Delete_ByID;
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
                    CManager.dbUpdate(new object[] { "@ID", id, "@DataCenterID", CDataCenter.EditValue, "@Name", CName.Text });
                }
                else if (CManager.IsNew)
                {
                    CManager.dbInsert(new object[] { "@DataCenterID", CDataCenter.EditValue, "@Name", CName.Text });
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
            CManager.IsCancel = true;
        }

        private void CoordinateManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void CDataCenter_EditValueChanged(object sender, EventArgs e)
        {

            if (CDataCenter.EditValue != null && !CManager.IsEdit)
            {
                CManager.dbSelect(new object[] { "@DataCenterID", CDataCenter.EditValue });
            }

        }

        private void CLocation_EditValueChanged(object sender, EventArgs e)
        {
            CDataCenter.FormParameters = new object[] { CLocation.EditValue };
        }

    }
}