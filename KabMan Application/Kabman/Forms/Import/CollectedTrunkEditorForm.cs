using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KabMan.Import;
using System.Linq;

namespace KabMan.Forms
{
    public partial class CollectedTrunkEditorForm : DevExpress.XtraEditors.XtraForm
    {
        public List<TrunkListItem> DataSource { get; set; }

        public CollectedTrunkEditorForm()
        {
            InitializeComponent();
            InitializeManager();
        }

        public CollectedTrunkEditorForm(List<TrunkListItem> argDataSource)
        {
            this.DataSource = argDataSource;
            InitializeComponent();
            InitializeManager();
            CManager.ManagerGridControl.DataSource = this.DataSource;
        }

        private void InitializeManager()
        {
            CManager.NewButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(NewButton_ItemClick);
            CManager.CancelButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(CancelButton_ItemClick);
            CManager.SaveButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(SaveButton_ItemClick);
            CManager.EditButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(EditButton_ItemClick);
            CManager.DeleteButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(DeleteButton_ItemClick);
        }

        void NewButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ClearControlValues();
        }

        void EditButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CManager.ManagerGridView.FocusedColumn != null)
            {
                CName.Text = CManager.ManagerGridView.GetFocusedRowCellValue("Name").ToString();
                CCount.Value = Convert.ToInt32(CManager.ManagerGridView.GetFocusedRowCellValue("Count").ToString());
            }
        }

        void DeleteButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CManager.AskForDelete() == DialogResult.OK)
            {
                var result = (from d in this.DataSource
                              where d.Name == CManager.ManagerGridView.GetFocusedRowCellValue("Name").ToString()
                              select d).First();
                this.DataSource.Remove(result);
                this.ClearControlValues();
            }
        }

        public void SaveButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CManager.IsEdit)
            {
                var result = (from d in this.DataSource
                              where d.Name == CManager.ManagerGridView.GetFocusedRowCellValue("Name").ToString()
                              select d).First();
                result.Name = CName.Text;
                result.Count = (int)CCount.Value;
            }
            if (CManager.IsNew)
            {
                var result = new TrunkListItem()
                {
                    Name = CName.Text,
                    Count = (int)CCount.Value
                };
                this.DataSource.Add(result);
            }
            this.ClearControlValues();
        }

        void CancelButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ClearControlValues();

        }

        private void ClearControlValues()
        {
            CName.Text = "";
            CCount.Value = 0;
            CManager.IsCancel = true;
            CManager.ManagerGridControl.RefreshDataSource();
        }

        private void TrunkCableCountEditorForm_Load(object sender, EventArgs e)
        {

        }

    }
}