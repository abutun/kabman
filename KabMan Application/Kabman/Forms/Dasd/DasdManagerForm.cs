using System;
using System.Windows.Forms;
using KabMan.Data;
using KabMan.Windows;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace KabMan.Forms
{
    public partial class DasdManagerForm : DevExpress.XtraEditors.XtraForm
    {
        public DasdManagerForm()
        {
            InitializeComponent();
            InitializeManager();
        }

        private void InitializeManager()
        {
            itemNew.Glyph = Resources.GetImage("ManagerAdd");
            itemDelete.Glyph = Resources.GetImage("ManagerDelete");
            itemDetails.Glyph = Resources.GetImage("ManagerEdit");
            itemExit.Glyph = Resources.GetImage("ManagerExit");
        }

        private void RackManagerForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            CDasdGrid.DataSource = DBAssistant.ExecProcedure(sproc.DASD_Select_All).Tables[0];
            itemCount.Caption = string.Format("Records: {0}", CDasdView.RowCount.ToString());
        }

        #region Toolbar Events

        private void itemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void itemDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CDasdView.FocusedColumn != null)
            {
                //Control con = (Control)sender;
                //Form parent = con.FindForm();

                //while (parent != null && !(parent is Home))
                //{
                //    parent = parent.ParentForm;

                //}

                //WindowAssistant.RunAsMultiMDI(typeof(DasdDetailManagerForm), parent.Handle, new object[] { Convert.ToInt64(CDasdView.DataController.GetCurrentRowValue("ID")), Convert.ToInt64(CDasdView.DataController.GetCurrentRowValue("SanGroup_ID")) });
                WindowAssistant.RunAsMultiMDI(typeof(DasdDetailManagerForm), this.TopLevelControl.Handle, new object[] { Convert.ToInt64(CDasdView.DataController.GetCurrentRowValue("ID")), Convert.ToInt64(CDasdView.DataController.GetCurrentRowValue("SanGroup_ID")) });
            }
        }

        private void itemNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(NewDasdForm));
            LoadData();
        }

        #endregion

        private void CDasdGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //GridControl grid = sender as GridControl;
                //BaseView view = grid.FocusedView;
                //GridHitInfo hitInfo = view.CalcHitInfo(e.Location) as GridHitInfo;

                //if (hitInfo.InRow)
                //    itemDetails_ItemClick(sender, null);
                itemDetails_ItemClick(sender, null);

            }
        }


    }
}