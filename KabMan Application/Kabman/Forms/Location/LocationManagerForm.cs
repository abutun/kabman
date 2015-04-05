using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KabMan.Data;
using KabMan.Windows;

namespace KabMan.Forms
{
    public partial class LocationManagerForm : XtraForm
    {

        public LocationManagerForm()
        {
            Icon = Resources.GetIcon("KabManIcon");

            InitializeComponent();
            InitializeManager();
        }

        private void InitializeManager()
        {
            this.Icon = Resources.GetIcon("KabManIcon");

            CManager.SelectProcedure = sproc.Location_Select_All;
            CManager.UpdateProcedure = sproc.Location_Update_ByID;
            CManager.InsertProcedure = sproc.Location_Insert;
            CManager.DeleteProcedure = sproc.Location_Delete_ByID;

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
                CPrefix.Text = CManager.SelectedRowValues["OnlyPrefix"].ToString();
                CName.Text = CManager.SelectedRowValues["OnlyName"].ToString();
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
                DBAssistant.ExecProcedure(sproc.UserLog, new object[] { "@UserId", Program.userId, "@ActionValue", string.Format("{0} {1} ", CPrefix.Text, CName.Text), "@ModulName", "Location", "@ActionTyp", 3 });
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
                    CManager.dbUpdate(new object[] { "@ID", id, "@Prefix", CPrefix.Text, "@Name", CName.Text });
                    DBAssistant.ExecProcedure(sproc.UserLog, new object[] { "@UserId", Program.userId, "@ActionValue", string.Format("{0} {1} ", CPrefix.Text, CName.Text), "@ModulName", "Location", "@ActionTyp", 2 });
                }
                else if (CManager.IsNew)
                {
                    CManager.dbInsert(new object[] { "@Prefix", CPrefix.Text, "@Name", CName.Text });
                    DBAssistant.ExecProcedure(sproc.UserLog, new object[] { "@UserId", Program.userId, "@ActionValue", string.Format("{0} {1} ", CPrefix.Text, CName.Text), "@ModulName", "Location", "@ActionTyp", 1 });
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
            CPrefix.Text = CName.Text = "";
            CManager.IsCancel = true;
        }

        private void LocationManagerForm_Load(object sender, EventArgs e)
        {

        }
    }
}