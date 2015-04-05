using System;
using System.Windows.Forms;
using KabMan.Data;
using KabMan.Windows;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace KabMan.Forms
{
    public partial class VTPortManagerForm : DevExpress.XtraEditors.XtraForm
    {
        public VTPortManagerForm()
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

        private void VTPortManagerForm_Load(object sender, EventArgs e)
        {
            this.FillGrid();
        }

        private void FillGrid()
        {
            CGridControl.DataSource = DBAssistant.ExecProcedure(sproc.VtPort_Select_All).Tables[0];
            itemCount.Caption = string.Format("Records: {0}", CGridView.RowCount.ToString());
        }


        #region Toolbar Events

        private void itemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void itemDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CGridView.FocusedColumn != null)
            {
                //WindowAssistant.RunAsDialog(typeof(VTPortDetailManagerForm), new object[] { CGridView.GetFocusedRowCellValue("ID") });
                WindowAssistant.RunAsMultiMDI(typeof(VTPortDetailManagerForm), this.TopLevelControl.Handle, new object[] { (CGridView.DataController.GetCurrentRowValue("ID")) });
            }
        }

        private void itemNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(NewVTPortForm));
            this.FillGrid();
        }

        #endregion

        private void CGridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GridControl grid = sender as GridControl;
            BaseView view = grid.FocusedView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Location) as GridHitInfo;

            if (hitInfo.InRow)
            {
                //Control con = (Control)sender;
                //Form parent = con.FindForm();

                //while (parent != null && !(parent is Home))
                //{
                //  parent = parent.ParentForm;

                //}

                //WindowAssistant.RunAsMultiMDI(typeof(RackDetailManagerForm), parent.Handle, new object[] { Convert.ToInt64(CRackView.DataController.GetCurrentRowValue("ID")), Convert.ToInt64(CRackView.DataController.GetCurrentRowValue("SanGroup_ID")) });
                itemDetails_ItemClick(sender, null);
            }
        }


    }
}