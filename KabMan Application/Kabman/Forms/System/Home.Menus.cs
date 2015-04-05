using System.Windows.Forms;
using DevExpress.XtraBars.Docking;
using KabMan.Windows;
using KabMan.Data;

namespace KabMan.Forms
{
    partial class Home
    {

        private void SetMenuProperties()
        {
            itemSystemDefaultsManager.Glyph = Resources.GetImage("ImageListBoxControl");
            itemDeviceManager.Glyph = Resources.GetImage("ImageListBoxControl");
            itemOperatingSystemManager.Glyph = Resources.GetImage("ImageListBoxControl");

            itemLocationManager.Glyph = Resources.GetImage("ImageListBoxControl");
            itemDataCenterManager.Glyph = Resources.GetImage("ImageListBoxControl");
            itemCoordinateManager.Glyph = Resources.GetImage("ImageListBoxControl");

            itemCableCategoryManager.Glyph = Resources.GetImage("ImageListBoxControl");
            itemCableModelManager.Glyph = Resources.GetImage("ImageListBoxControl");
            itemCableManager.Glyph = Resources.GetImage("ImageListBoxControl");

            itemSanGroupManager.Glyph = Resources.GetImage("ImageListBoxControl");
            itemSanManager.Glyph = Resources.GetImage("ImageListBoxControl");

            itemBlechTypeManager.Glyph = Resources.GetImage("ImageListBoxControl");
            itemNewBlech.Glyph = Resources.GetImage("ImageListBoxControl");
            itemBlechManager.Glyph = Resources.GetImage("ImageListBoxControl");

            itemNewServer.Glyph = Resources.GetImage("ImageListBoxControl");
            itemServerManager.Glyph = Resources.GetImage("ImageListBoxControl");

            itemSwitchTypeManager.Glyph = Resources.GetImage("ImageListBoxControl");
            itemNewSwitch.Glyph = Resources.GetImage("ImageListBoxControl");
            itemSwitchDetails.Glyph = Resources.GetImage("ImageListBoxControl");
            itemSwitchManager.Glyph = Resources.GetImage("ImageListBoxControl");

            itemNewVTPort.Glyph = Resources.GetImage("ImageListBoxControl");
            itemVTPortManager.Glyph = Resources.GetImage("ImageListBoxControl");
            itemVTPortDetails.Glyph = Resources.GetImage("ImageListBoxControl");

            itemNewConnection.Glyph = Resources.GetImage("ImageListBoxControl");
            itemConnectionList.Glyph = Resources.GetImage("ImageListBoxControl");

            itemDasdCuTypeManager.Glyph = Resources.GetImage("ImageListBoxControl");
            itemDasdManager.Glyph = Resources.GetImage("ImageListBoxControl");
            itemNewDasd.Glyph = Resources.GetImage("ImageListBoxControl");

            itemDCCNewConnection.Glyph = Resources.GetImage("ImageListBoxControl");
            itemDCCConnectionManager.Glyph = Resources.GetImage("ImageListBoxControl");

            itemImport.Glyph = Resources.GetImage("ImageListBoxControl");
        }

        #region Menu Events

        #region File Menu

        private void itemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //DBAssistant.ExecProcedure(sproc.LogoutCheck, new object[] { "@UserID", Program.userId });

            Application.Exit();
        }

        #endregion

        #region View Menu

        private void itemServerWindow_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dockServer.Visibility = itemServerWindow.Checked ? DockVisibility.Visible : DockVisibility.Hidden;
        }

        private void itemSwitchWindow_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dockSwitch.Visibility = itemSwitchWindow.Checked ? DockVisibility.Visible : DockVisibility.Hidden;
        }

        private void itemDASDWindow_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dockDASD.Visibility = itemDASDWindow.Checked ? DockVisibility.Visible : DockVisibility.Hidden;
        }

        #endregion

        #region Management Menu

        #region System Sub Menu

        private void itemSystemDefaultsManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(DefaultsManagerForm));
        }

        private void itemDeviceManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(DeviceManagerForm));
        }

        private void itemOperatingSystemManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(OSManagerForm));
        }

        #endregion

        #region Location Sub Menu

        private void itemLocationManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(LocationManagerForm));
        }

        private void itemDataCenterManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(DataCenterManagerForm));
        }

        private void itemCoordinateManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(CoordinateManagerForm));
        }

        #endregion

        #region Cable Sub Menu

        private void itemCableCategoryManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(CableCategoryManagerForm));
        }

        private void itemCableModelManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(CableModelManagerForm));
        }

        private void itemCableManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsMDI(typeof(CableManagerForm), Handle);
        }

        #endregion

        #region San Sub Menu

        private void itemSanGroupManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(SanGroupManagerForm));
        }

        private void itemSanManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(SanManagerForm));
        }

        #endregion

        #region Blech Sub Menu

        private void itemBlechTypeManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(BlechTypeManagerForm));
        }

        private void itemNewBlech_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(NewBlechForm));
        }

        private void itemBlechManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsMDI(typeof(BlechManagerForm), Handle);
        }

        private void itemBlechDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(BlechDetailManagerForm));
        }

        #endregion

        #region Server Sub Menu

        private void itemNewServer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(NewRackForm));
        }

        private void itemServerManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsMDI(typeof(RackManagerForm), this.Handle);
        }

        private void itemServerDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsMDI(typeof(RackDetailManagerForm), this.Handle);
        }
        #endregion

        #region Switch Sub Menu

        private void itemSwitchManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsMDI(typeof(SwitchManagerForm), this.Handle);
        }

        private void itemSwitchTypeManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(SwitchTypeManagerForm));
        }

        private void itemNewSwitch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(NewSwitchForm));
        }

        private void itemSwitchDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsMDI(typeof(SwitchDetailManagerForm), this.Handle);
        }

        #endregion

        #region VTPort Sub Menu

        private void itemNewVTPort_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(NewVTPortForm));
        }

        private void itemVTPortManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsMDI(typeof(VTPortManagerForm), this.Handle);
        }

        private void itemVTPortDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(VTPortDetailManagerForm));
        }

        #endregion

        #region Connection Sub Menu

        private void itemNewConnection_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            WindowAssistant.RunAsDialog(typeof(NewConnectionForm));
            connectionDetailForm = null;
        }
        Form connectionDetailForm = null;
        private void itemConnectionList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {        
           connectionDetailForm =  WindowAssistant.RunAsMDI(typeof(ConnectionDetailForm), this.Handle);            
        }

        #endregion

        #region DASD

        private void itemDasdCuTypeManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(DasdCuTypeManagerForm));
        }

        private void itemDasdManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsMDI(typeof(DasdManagerForm), this.Handle);
        }

        private void itemNewDasd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(NewDasdForm));
        }

        private void itemDasdDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(DasdDetailManagerForm));
        }



        #endregion

        #region Data Center Connection

        private void itemDCCNewConnection_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(NewDCCForm));
        }

        private void itemDCCConnectionManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsMDI(typeof(DCCList), this.Handle);
        }

        private void itemDCCDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(DCCDetailList));
        }

        #endregion

        #endregion

        #region Reports


        private void itemCategorizedReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsMDI(typeof(ReportForm), Handle);
        }

        #endregion

        #region Tools Menu

        private void itemImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsMDI(typeof(ExcelImportForm), this.Handle);
        }

        private void itemExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        #endregion

        #region Window Menu

        private void subWindows_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {

        }

        #endregion

        #region Help Menu

        private void itemHelp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void itemAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //WindowAssistant.RunAsDialog(typeof(LoginForm));
        }

        #endregion

        #endregion

        #region Toolbar Events

        private void toolNewServer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(NewRackForm));
        }

        private void toolServerManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsDialog(typeof(RackManagerForm));
        }

        #endregion

        #region Dock Bar

        private void dockServer_ClosedPanel(object sender, DockPanelEventArgs e)
        {
            itemServerWindow.Checked = dockServer.Visibility == DockVisibility.Visible ? true : false;
        }

        private void dockSwitch_ClosedPanel(object sender, DockPanelEventArgs e)
        {
            itemSwitchWindow.Checked = dockSwitch.Visibility == DockVisibility.Visible ? true : false;
        }

        private void dockDASD_ClosedPanel(object sender, DockPanelEventArgs e)
        {
            itemDASDWindow.Checked = dockDASD.Visibility == DockVisibility.Visible ? true : false;
        }
        #endregion

    }
}
