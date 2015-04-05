using System;
using System.Collections.Generic;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using KabMan.Data;
using KabMan.Windows;
using System.Windows.Forms;
using System.IO;

namespace KabMan.Forms
{
    public partial class Home : XtraForm
    {
        private string _UserNameSurname;
        public string UserNameSurName
        {
            get { return _UserNameSurname; }
            set { _UserNameSurname = value; }
        }

        private object _FocusedValue;

        public string FocusedValue
        {
            get
            {
                return this._FocusedValue == null ? string.Empty : this._FocusedValue.ToString();
            }
            set
            {
                this._FocusedValue = value;
            }
        }

        private object _FocusedID;

        public string FocusedID
        {
            get
            {
                return this._FocusedID == null ? string.Empty : this._FocusedID.ToString();
            }
            set
            {
                this._FocusedID = value;
            }
        }

        private List<string> validTreeValues = new List<string> { "Switch", "Server", "DASD", "DCC" };

        public Home()
        {
            InitializeComponent();
            SetMenuProperties();
            InitializeTrees();

            Icon = Resources.GetIcon("KabManIcon");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //WindowAssistant.RunAsMDI(typeof(CableManagerForm), this.Handle);
            
            //windows size and location settings
            Width = Convert.ToInt32(RegistryHelper.GetSetting("Home", "Width", "800"));
            Height = Convert.ToInt32(RegistryHelper.GetSetting("Home", "Height", "500"));
            Top = Convert.ToInt32(RegistryHelper.GetSetting("Home", "Top", "100"));
            Left = Convert.ToInt32(RegistryHelper.GetSetting("Home", "Left", "100"));

            if (Left < 0) Left = 100;
            if (Top < 0) Top = 200;
            if (Width < 400) Width = 400;
            if (Height < 300) Height = 300;


            panelContainer1.Width = int.Parse(RegistryHelper.GetSetting("HomeSettings", "LeftPanelWidth", "100"));

            statusUserName.Caption = String.Format("User = {0}, Version = {1}", UserNameSurName, Settings.Version);

        }

        public void InitializeTrees()
        {

            TreeListNode serverFocusedNode = CServerTree.FocusedNode;
            TreeListNode switchFocusedNode = CSwitchTree.FocusedNode;
            TreeListNode dasdFocusedNode = CDASDTree.FocusedNode;
            TreeListNode DCCFocusedNode = CDCCtree.FocusedNode;

            CServerTree.DataSource = DBAssistant.ExecProcedure(sproc.Tree_Select_ByGroupName, new object[] { "@GroupName", "Server" }).Tables[0];
            CSwitchTree.DataSource = DBAssistant.ExecProcedure(sproc.Tree_Select_ByGroupName, new object[] { "@GroupName", "Switch" }).Tables[0];
            CDASDTree.DataSource = DBAssistant.ExecProcedure(sproc.Tree_Select_ByGroupName, new object[] { "@GroupName", "DASD" }).Tables[0];
            CDCCtree.DataSource = DBAssistant.ExecProcedure(sproc.Tree_Select_ByGroupName, new object[] { "@GroupName", "DCC" }).Tables[0];

            CServerTree.ExpandAll();
            CSwitchTree.ExpandAll();
            CDASDTree.ExpandAll();
            CDCCtree.ExpandAll();

            CServerTree.FocusedNode = serverFocusedNode;
            CSwitchTree.FocusedNode = switchFocusedNode;
            CDASDTree.FocusedNode = dasdFocusedNode;
            CDCCtree.FocusedNode = DCCFocusedNode; 
        }

        private void CTree_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            this.FocusedValue = null;
            try
            {
                TreeList senderTree = (TreeList)sender;
                string nodeValue = e.Node.GetValue("Value").ToString();
                string nodeObjectValue = e.Node.GetValue("ObjectValue").ToString();
                object nodeObjectID = e.Node.GetValue("ObjectID");

                this.FocusedValue = this.validTreeValues.Contains(nodeObjectValue) ? nodeObjectValue : null;
                this.FocusedID = nodeObjectID.ToString();

            }
            catch
            {

            }
        }

        private void hidecontainerleft(object sender, DevExpress.XtraBars.Docking.SizingEventArgs e)
        {
            e.Cancel = true;
        }

        private void CTree_DoubleClick(object sender, EventArgs e)
        {
            switch (this.FocusedValue)
            {
                case "Switch":
                    WindowAssistant.RunAsMultiMDI(typeof(SwitchDetailManagerForm), this.Handle, new object[] { this.FocusedID, CSwitchTree.FocusedNode.GetDisplayText("Value") });
                    break;
                case "Server":
                    WindowAssistant.RunAsMultiMDI(typeof(RackDetailManagerForm), this.Handle, new object[] { this.FocusedID, CServerTree.FocusedNode.GetDisplayText("Value"), CServerTree.FocusedNode.GetValue("SubObjectValue") });
                    break; 
                case "DASD":
                    WindowAssistant.RunAsMultiMDI(typeof(DasdDetailManagerForm), this.Handle, new object[] { this.FocusedID, CDASDTree.FocusedNode.GetDisplayText("Value"), CDASDTree.FocusedNode.GetValue("SubObjectValue") });
                    break;
                case "DCC":
                    WindowAssistant.RunAsMultiMDI(typeof(DCCDetailList), this.Handle, new object[] { this.FocusedID, CDCCtree.FocusedNode.GetDisplayText("Value") });
                    break;
            }
        }

        private void panelContainer1_ActiveChildChanged(object sender, DockPanelEventArgs e)
        {
            this.FocusedValue = null;
        }

        private void toolListDataCenterConnection_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void hideContainerLeft_BackColorChanged(object sender, EventArgs e)
        {
            
        }

        private void hideContainerLeft_Click(object sender, EventArgs e)
        {

        }

        private void Home_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (WindowState != System.Windows.Forms.FormWindowState.Minimized)
            {
                RegistryHelper.SaveSetting("Home", "Width", Width.ToString());
                RegistryHelper.SaveSetting("Home", "Height", Height.ToString());
                RegistryHelper.SaveSetting("Home", "Top", Top.ToString());
                RegistryHelper.SaveSetting("Home", "Left", Left.ToString());
            }

            RegistryHelper.SaveSetting("HomeSettings", "LeftPanelWidth", panelContainer1.Width.ToString());

            DBAssistant.ExecProcedure(sproc.LogoutCheck, new object[] { "@UserID", Program.userId });
        }

        private void itemUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserManagerForm f = new UserManagerForm();
            f.ShowDialog();
            f.Dispose();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserLogs u = new UserLogs();
            u.ShowDialog();
            u.Dispose();
        }

        private void CDCCtree_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            this.FocusedValue = null;
            try
            {
                TreeList senderTree = (TreeList)sender;
                string nodeValue = e.Node.GetValue("Value").ToString();
                string nodeObjectValue = e.Node.GetValue("ObjectValue").ToString();
                object nodeObjectID = e.Node.GetValue("ObjectID");

                this.FocusedValue = this.validTreeValues.Contains(nodeObjectValue) ? nodeObjectValue : null;
                this.FocusedID = nodeObjectID.ToString();

            }
            catch
            {

            }
        }

        private void dockDCC_ClosedPanel(object sender, DockPanelEventArgs e)
        {
           
        }

        private void homeDockManager_Docking(object sender, DockingEventArgs e)
        {

        }

        private void Home_Resize(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Application.OpenForms["ExcelImportForm"] != null)
            //        this.Refresh();
            //}
            //catch
            //{

            //}
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SQLManagement man = new SQLManagement(0);

            man.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SQLManagement man = new SQLManagement(1);

            man.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowAssistant.RunAsMDI(typeof(Logs.Logs), this.Handle);
        }     
    }
}