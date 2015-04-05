using System;
using System.Windows.Forms;
using KabMan.Data;
using KabMan.Windows;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace KabMan.Forms
{
    public partial class SwitchManagerForm : DevExpress.XtraEditors.XtraForm
    {
        public SwitchManagerForm()
        {
            Icon = Resources.GetIcon("KabManIcon");

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

        private void itemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void itemViewDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CSwitchView.FocusedColumn != null)
            {
                ////WindowAssistant.RunAsDialog(typeof(SwitchDetailManagerForm), new object[] { CSwitchView.GetFocusedRowCellValue("ID") }); 
                //Control con = (Control)sender;
                //Form parent = con.FindForm();

                //while (parent != null && !(parent is Home))
                //{
                //    parent = parent.ParentForm;

                //}

                //WindowAssistant.RunAsMultiMDI(typeof(SwitchDetailManagerForm), parent.Handle, new object[] { Convert.ToInt64(CSwitchView.DataController.GetCurrentRowValue("ID")) });
                WindowAssistant.RunAsMultiMDI(typeof(SwitchDetailManagerForm), this.TopLevelControl.Handle, new object[] { Convert.ToInt64(CSwitchView.DataController.GetCurrentRowValue("ID")) });
            }

        }

        private void itemNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(NewSwitchForm));
            this.FillGrid();
        }

        private void SwitchManagerForm_Load(object sender, EventArgs e)
        {
            this.FillGrid();
        }

        private void FillGrid()
        {
            CSwitchGrid.DataSource = DBAssistant.ExecProcedure(sproc.Switch_Select_All).Tables[0];
            itemCount.Caption = string.Format("Records: {0}", CSwitchView.RowCount.ToString());
        }

        private void CSwitchGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //GridControl grid = sender as GridControl;
                //BaseView view = grid.FocusedView;
                //GridHitInfo hitInfo = view.CalcHitInfo(e.Location) as GridHitInfo;

                //if (hitInfo.InRow)
                    itemViewDetails_ItemClick(sender, null);

            }
        }
    }
}