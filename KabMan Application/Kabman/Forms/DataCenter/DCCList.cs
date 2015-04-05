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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace KabMan.Forms
{
    public partial class DCCList : DevExpress.XtraEditors.XtraForm
    {
        public DCCList()
        {
            InitializeComponent();

            itemNew.Glyph = Resources.GetImage("ManagerAdd");
            itemDelete.Glyph = Resources.GetImage("ManagerDelete");
            itemDetail.Glyph = Resources.GetImage("ManagerEdit");
            itemExit.Glyph = Resources.GetImage("ManagerExit");
        }

        private void DCCList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DCCGrid.DataSource = DBAssistant.ExecProcedure(sproc.DCC_Select_All).Tables[0];
        }

        private void itemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void itemNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(NewDCCForm));
            LoadData();
        }

        private void itemDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CRackView.FocusedColumn != null)
            {
                WindowAssistant.RunAsDialog(typeof(DCCDetailList), new object[] { Convert.ToInt64(CRackView.DataController.GetCurrentRowValue("ID")) });
            }
        }

        private void itemDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CRackView.FocusedColumn != null)
            {
                ////WindowAssistant.RunAsDialog(typeof(RackDetailManagerForm), new object[] { Convert.ToInt64(CRackView.DataController.GetCurrentRowValue("ID")) , Convert.ToInt64(CRackView.DataController.GetCurrentRowValue("SanGroup_ID")) });
                //Control con = (Control)sender;
                //Form parent = con.FindForm();

                //while (parent != null && !(parent is Home))
                //{
                //    parent = parent.ParentForm;

                //}

                WindowAssistant.RunAsMultiMDI(typeof(DCCDetailList), this.TopLevelControl.Handle, new object[] { Convert.ToInt64(CRackView.DataController.GetCurrentRowValue("ID")), Convert.ToInt64(CRackView.DataController.GetCurrentRowValue("SanGroup11_ID")), Convert.ToInt64(CRackView.DataController.GetCurrentRowValue("SanGroup12_ID")), Convert.ToInt64(CRackView.DataController.GetCurrentRowValue("SanGroup21_ID")), Convert.ToInt64(CRackView.DataController.GetCurrentRowValue("SanGroup22_ID")) });
            }
        }

        private void DCCGrid_MouseDoubleClick(object sender, MouseEventArgs e)
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