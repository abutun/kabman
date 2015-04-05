using System;
using System.Windows.Forms;
using KabMan.Data;

namespace KabMan.Forms
{
    public partial class CableModelManagerForm : DevExpress.XtraEditors.XtraForm
    {
        public CableModelManagerForm()
        {
            Icon = Resources.GetIcon("KabManIcon");

            InitializeComponent();
            InitializeManager();
        }

        public CableModelManagerForm(long argCategoryID)
        {
            InitializeComponent();
            InitializeManager();
            CCategory.EditValue = argCategoryID;
        }

        private void InitializeManager()
        {
            CCategory.FormToShow = typeof(CableCategoryManagerForm);

            CSample.EditValue = Resources.GetImage("ExampleCableColor");

            CManager.SelectProcedure = sproc.CableModel_Select_ByCategoryID;
            CManager.UpdateProcedure = sproc.CableModel_Update_ByID;
            CManager.InsertProcedure = sproc.CableModel_Insert;
            CManager.DeleteProcedure = sproc.CableModel_Delete_ByID;

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
                CModel.Text = CManager.SelectedRowValues["Model"].ToString();
                CLength.Value = Convert.ToInt32(CManager.SelectedRowValues["Length"].ToString());
                CCableCount.Value = Convert.ToInt32(CManager.SelectedRowValues["Cable Count"].ToString());
                CLineCount.Value = Convert.ToInt32(CManager.SelectedRowValues["Line Count"].ToString());
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
                    CManager.dbUpdate(new object[] { "@ID", id, "@CategoryID", CCategory.EditValue, "@Model", CModel.EditValue, "@Length", CLength.Value, "@CableCount", CCableCount.Value, "@LineCount", CLineCount.Value });
                }
                else if (CManager.IsNew)
                {
                    CManager.dbInsert(new object[] { "@CategoryID", CCategory.EditValue, "@Model", CModel.EditValue, "@Length", CLength.Value, "@CableCount", CCableCount.Value, "@LineCount", CLineCount.Value });
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
            CModel.Text = "";
            CLength.Value = CCableCount.Value = CLineCount.Value = CLength.Properties.MinValue;
            CManager.IsCancel = true;
        }

        private void DataCenterManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void CCategory_EditValueChanged(object sender, EventArgs e)
        {
            if (CCategory.EditValue != null && !CManager.IsEdit)
            {
                CManager.dbSelect(new object[] { "@CategoryID", CCategory.EditValue });
            }
        }
    }
}