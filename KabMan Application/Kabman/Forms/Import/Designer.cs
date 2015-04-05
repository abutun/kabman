using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraLayout;
using DevExpress.XtraNavBar;
using KabMan.Data;

namespace KabMan.Forms
{
    public partial class ExcelImportForm
    {
        #region Constants

        private const int NAVBAR_GROUP_HEADER_HEIGHT = 40;

        #endregion

        #region Fired Events

        #region Collapsible NavBar

        private void navBarControl_GroupExpandCollapse(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            NavBarControl navBar = (NavBarControl)sender;
            foreach (LayoutControlItem lci in ((LayoutControl)navBar.Parent).Root.Items)
            {
                if (lci.Control.Equals(navBar))
                {
                    if (navBar.Groups[0].Expanded)
                    {
                        int expandedHeight = navBar.Groups[0].ControlContainer.Height + NAVBAR_GROUP_HEADER_HEIGHT;
                        lci.MaxSize = new Size(lci.MaxSize.Width, expandedHeight);
                        lci.Height = expandedHeight;
                    }
                    else
                    {
                        lci.MinSize = new Size(lci.MinSize.Width, NAVBAR_GROUP_HEADER_HEIGHT);
                        lci.Height = NAVBAR_GROUP_HEADER_HEIGHT;
                    }
                }
            }
        }

        #endregion

        #region GridLookUpEdit

        private void GridLookUpEdit_Popup(object sender, EventArgs e)
        {
            DevExpress.Utils.Win.IPopupControl popup = sender as DevExpress.Utils.Win.IPopupControl;
            DevExpress.XtraEditors.Popup.PopupGridLookUpEditForm popupForm = popup.PopupWindow as DevExpress.XtraEditors.Popup.PopupGridLookUpEditForm;
            popupForm.Width = (sender as Control).Width;
        }

        #endregion

        #region LookUp Settings

        private void CSwitchLocation_EditValueChanged(object sender, EventArgs e)
        {
            CSwitchDataCenter.FormParameters.Clear();
            CSwitchDataCenter.FormParameters.Add(CSwitchLocation.EditValue);
        }

        private void CSwitchSanGroup_EditValueChanged(object sender, EventArgs e)
        {
            CSwitchSan.FormParameters.Clear();
            CSwitchSan.FormParameters.Add(CSwitchSanGroup.EditValue);
        }

        private void CSwitchSwitchType_EditValueChanged(object sender, EventArgs e)
        {
            CSwitchCoreSwitch.Enabled = CSwitchSwitchType.GetColumnValue("Name").ToString().Contains("Edge");
        }

        private void CRackLocation_EditValueChanged(object sender, EventArgs e)
        {
            CRackDataCenter.FormParameters.Clear();
            CRackDataCenter.FormParameters.Add(CRackLocation.EditValue);
        }

        private void CRackDataCenter_EditValueChanged(object sender, EventArgs e)
        {
            CRackCoordinate.FormParameters.Clear();
            CRackCoordinate.FormParameters.Add(CRackLocation.EditValue);
            CRackCoordinate.FormParameters.Add(CRackDataCenter.EditValue);
        }

        private void CSwitchCoreSwitch_Triggering(KabMan.Controls.C_LookUpControl sender, CancelEventArgs e)
        {
            CSwitchCoreSwitch.Properties.Buttons[2].Enabled = false;
        }

        #endregion

        #endregion

        #region Methods

        private void InitializeManager()
        {
            CSwitchLocation.StoredProcedure = sproc.Location_Select_All;
            CSwitchLocation.FormToShow = typeof(LocationManagerForm);
            CSwitchDataCenter.StoredProcedure = sproc.DataCenter_Select_ByLocationID;
            CSwitchDataCenter.FormToShow = typeof(DataCenterManagerForm);

            CSwitchSanGroup.StoredProcedure = sproc.SanGroup_Select_All;
            CSwitchSanGroup.FormToShow = typeof(SanGroupManagerForm);
            CSwitchSan.StoredProcedure = sproc.San_Select_ByGroupID;
            CSwitchSan.FormToShow = typeof(SanManagerForm);

            CSwitchSwitchType.StoredProcedure = sproc.SwitchType_Select_All;
            CSwitchSwitchType.FormToShow = typeof(SwitchTypeManagerForm);
            CSwitchCoreSwitch.StoredProcedure = sproc.Switch_Select_ByTypeName;
            CSwitchSwitchModel.StoredProcedure = sproc.SwitchModel_Select_All;


            CRackLocation.StoredProcedure = sproc.Location_Select_All;
            CRackLocation.FormToShow = typeof(LocationManagerForm);
            CRackDataCenter.StoredProcedure = sproc.DataCenter_Select_ByLocationID;
            CRackDataCenter.FormToShow = typeof(DataCenterManagerForm);
            CRackCoordinate.StoredProcedure = sproc.Coordinate_Select_ByDataCenterID;
            CRackCoordinate.FormToShow = typeof(CoordinateManagerForm);

            CRackConnectionCount.StoredProcedure = sproc.Trunk_Select_ConnectionCounts;

            CRackOperatingSystem.StoredProcedure = sproc.OS_Select_All;
            CRackOperatingSystem.FormToShow = typeof(OSManagerForm);

            itemImport.Glyph = Resources.GetImage("ManagerAdd");
            itemClose.Glyph = Resources.GetImage("ManagerExit");
        }

        #endregion



    }
}
