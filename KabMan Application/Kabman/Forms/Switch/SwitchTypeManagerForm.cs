using System.Windows.Forms;
using KabMan.Data;

namespace KabMan.Forms
{
    public partial class SwitchTypeManagerForm : DevExpress.XtraEditors.XtraForm
    {
        public SwitchTypeManagerForm()
        {
            InitializeComponent();
            InitializeManager();
        }

        private void InitializeManager()
        {
            Icon = Resources.GetIcon("KabManIcon");

            CManager.SelectProcedure = sproc.SwitchType_Select_All;
            CManager.UpdateProcedure = sproc.SwitchType_Update_ByID;
            CManager.InsertProcedure = sproc.SwitchType_Insert;
            CManager.DeleteProcedure = sproc.SwitchType_Delete_ByID;
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
                    CManager.dbUpdate(new object[] { "@ID", id, "@Name", CName.Text });
                }
                else if (CManager.IsNew)
                {
                    CManager.dbInsert(new object[] { "@Name", CName.Text });
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
    }
}