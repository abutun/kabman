using System;
using System.Windows.Forms;
using KabMan.Data;
using KabMan.Windows;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;

namespace KabMan.Forms
{
    public partial class RackManagerForm : DevExpress.XtraEditors.XtraForm
    {
        public RackManagerForm()
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
            CRackGrid.DataSource = DBAssistant.ExecProcedure(sproc.Server_Select_All).Tables[0];
            itemCount.Caption = string.Format("Records: {0}", CRackView.RowCount.ToString());
        }

        #region Toolbar Events

        private void itemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void itemDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CRackView.FocusedColumn != null)
            {
                
                //WindowAssistant.RunAsDialog(typeof(RackDetailManagerForm), new object[] { Convert.ToInt64(CRackView.DataController.GetCurrentRowValue("ID")) , Convert.ToInt64(CRackView.DataController.GetCurrentRowValue("SanGroup_ID")) });
                //Control con = (Control)sender;
                //Form parent = con.FindForm();

                //while (parent != null && !(parent is Home))
                //{
                  //  parent = parent.ParentForm;

                //
                //CRackView.DataController.
                WindowAssistant.RunAsMultiMDI(typeof(RackDetailManagerForm),this.TopLevelControl.Handle ,new object[] { Convert.ToInt64(CRackView.DataController.GetCurrentRowValue("ID")), Convert.ToInt64(CRackView.DataController.GetCurrentRowValue("SanGroup_ID")) });
            }
        }

        private void itemNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(NewRackForm));
            LoadData();
        }

        #endregion

        private void CRackGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
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
}