using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KabMan.Data;
using KabMan.Windows;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;

namespace KabMan.Forms
{
    public partial class UserManagerForm : DevExpress.XtraEditors.XtraForm
    {
        private RefreshHelper helper;

        public UserManagerForm()
        {
            InitializeComponent();

            Icon = Resources.GetIcon("KabManIcon");
            itemNew.Glyph = Resources.GetImage("ManagerAdd");
            itemDetail.Glyph = Resources.GetImage("ManagerEdit");
            itemDelete.Glyph = Resources.GetImage("ManagerDelete");
            itemClose.Glyph = Resources.GetImage("ManagerExit");
        }

        private void UserManagerForm_Load(object sender, EventArgs e)
        {
            helper = new RefreshHelper(gridView1, "ID");
            InitData(false);
        }

        public void InitData(bool savePos)
        {
            if (savePos) helper.SaveViewInfo();
            gridControl1.DataSource = DBAssistant.ExecProcedure(sproc.LoginUserList).Tables[0];
            if (savePos) helper.LoadViewInfo();
        }

        private void itemClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void itemNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (UserManagerDetailForm f = new UserManagerDetailForm(this,0))
            {
                f.ShowDialog();
            }
        }

        private void itemDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (UserManagerDetailForm f = new UserManagerDetailForm(this, (int)gridView1.DataController.GetCurrentRowValue("ID")))
            {
                f.ShowDialog();
            }
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                GridControl grid = sender as GridControl;
                BaseView view = grid.FocusedView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Location) as GridHitInfo;

                if (hitInfo.InRow)
                    itemDetail_ItemClick(sender, null);
            }
        }

        private void itemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show(
                  "Are you sure you want to delete this record?",
                  Text,
                  MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                DBAssistant.ExecProcedure(sproc.LoginUserDelete, new object[] { "@Id", (int)gridView1.DataController.GetCurrentRowValue("ID") });
                InitData(true);
            }
        }

        private void UserManagerForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                Close();
        }
    }
}