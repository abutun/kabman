using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using FunfKabMan;
using KabMan.Client.Modules;
using KabMan.Client.Modules.Switch;


namespace KabMan.Client
{
    public partial class frmMain : XtraForm
    {

        public static frmMain myInstanceHandle = null;
        private Common com;
        ModifyRegistry reg;
        public frmServerListe ServerList = null;
        TreeListNode SavedFocused;
        bool NeedRestoreFocused;

        public frmMain()
        {
            myInstanceHandle = this;
            Icon = Properties.Resources.kabman;
            InitializeComponent();
        }

        public bool FindMdiForm(string formName)
        {
            bool result = true;
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                if (MdiChildren[i].Name == formName)
                {
                    MdiChildren[i].Activate();
                    result = false;
                }
            }

            return result;
        }

        public bool FindMdiForm(string formName, string tag)
        {
            bool result = true;
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                if ((MdiChildren[i].Name == formName) && (MdiChildren[i].Tag.ToString() == tag))
                {
                    MdiChildren[i].Activate();
                    result = false;
                }
            }

            return result;
        }

        private void btnPasswordAendern_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPasswordAendern f = new frmPasswordAendern();
            f.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            reg = new ModifyRegistry();
            com = new Common();
            com.LoadWinPos(this, "Main", true);
            RestoreTreeSize();

            // init data
            InitTree();
        }

        public void InitTree()
        {
            SavedFocused = treeMenu.FocusedNode;

            DataSet ds;
            DatabaseLib data = new DatabaseLib();
            data.RunProc("sp_selTree", out ds);

            treeMenu.DataSource = ds.Tables[0];

            // first tree expand
            if (treeMenu.Nodes.Count > 0)
                treeMenu.Nodes[0].ExpandAll();
            treeMenu.Nodes[1].ExpandAll();

            treeMenu.FocusedNode = SavedFocused;
        }

        //private void LoadServerTree()
        //{
        //    treeMenu.BeginUnboundLoad();
        //    TreeListNode node;

        //    //server liste
        //    SqlDataReader dr;
        //    DatabaseLib data;
        //    data = new DatabaseLib();
        //    data.RunSqlQuery("SELECT * FROM tblLocation WHERE RecDelete=0", out dr);

        //    while (dr.Read())
        //    {
        //        node = treeMenu.AppendNode(new object[] { dr["LocationName"].ToString() }, treeMenu.Nodes[0].Id, 2, 2, 2);
        //    }

        //    dr.Close();
        //    data.Dispose();

        //    data = new DatabaseLib();
        //    data.RunProc("sp_selServer", out dr);

        //    while (dr.Read())
        //    {
        //        node = treeMenu.AppendNode(new object[] { dr["serverName"].ToString() }, treeMenu.Nodes[0].Id, 1, 1, 1);
        //    }

        //    treeMenu.EndUnboundLoad();
        //}

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTreeSize();
            com.SaveWinPos(this, "Main");
        }

        private void btnSchliessen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void treeMenu_DoubleClick(object sender, EventArgs e)
        {
            TreeList tree = sender as TreeList;
            if (tree.State == TreeListState.Regular)
            {
                // MessageBox.Show("dsdsd");
            }
        }

        private void SaveTreeSize()
        {
            reg.Write("treeMenu", layoutControl1.Size.Width.ToString());
        }

        private void RestoreTreeSize()
        {
            if (reg.Read("treeMenu") != null)
                layoutControl1.Size = new Size(int.Parse(reg.Read("treeMenu")), layoutControl1.Size.Height);
        }

        private void treeMenu_MouseUp(object sender, MouseEventArgs e)
        {
            TreeList tree = sender as TreeList;
            if (e.Button == MouseButtons.Right && ModifierKeys == Keys.None && tree.State == TreeListState.Regular)
            {

                Point pt = treeMenu.PointToClient(MousePosition);
                TreeListHitInfo info = treeMenu.CalcHitInfo(pt);
                if (info.HitInfoType == HitInfoType.Cell)
                {
                    SavedFocused = treeMenu.FocusedNode;
                    treeMenu.FocusedNode = info.Node;
                    NeedRestoreFocused = true;
                    //popupMenuNodes.ShowPopup(MousePosition);
                }
            }

        }

        private void popupMenuNodes_CloseUp(object sender, EventArgs e)
        {
            if (NeedRestoreFocused)
                treeMenu.FocusedNode = SavedFocused;
        }

        private void btnNeuServer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NeedRestoreFocused = false;
            NewRack nr = new NewRack(this, 0);
            nr.ShowDialog();

        }

        private void treeMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point pt = treeMenu.PointToClient(MousePosition);
                TreeListHitInfo info = treeMenu.CalcHitInfo(pt);

                if (info.Node != null)
                {
                    //server 
                    if (info.Node.Id == 0)
                    {                        
                        if (FindMdiForm("ServerList"))
                        {
                            RackList rl = new RackList(this);
                            rl.MdiParent = this;
                            rl.Show();
                        }                        
                    }

                    else
                    {
                        string objId = treeMenu.FindNodeByID(info.Node.Id).GetValue(3).ToString();
                        string objValue = treeMenu.FindNodeByID(info.Node.Id).GetValue(4).ToString();
                        if (objValue == "Server")
                        {
                            if (FindMdiForm("ServerDetailList", objId))
                            {
                                ServerDetailList f = new ServerDetailList(int.Parse(objId));
                                f.MdiParent = frmMain.myInstanceHandle;
                                f.Show();
                            }
                        }

                    }

                    if (info.Node.Id == 1)
                    {
                        if (FindMdiForm("SwitchList"))
                        {
                            SwitchList f1 = new SwitchList(this);
                            f1.MdiParent = this;
                            f1.Show();
                        }
                    }
                    else
                    {
                        string objId = treeMenu.FindNodeByID(info.Node.Id).GetValue(3).ToString();
                        string objValue = treeMenu.FindNodeByID(info.Node.Id).GetValue(4).ToString();
                        if (objValue == "Switch")
                        {
                            if (FindMdiForm("SwitchDetailList", objId))
                            {
                                SwitchDetailList fsdl = new SwitchDetailList(int.Parse(objId));
                                fsdl.MdiParent = frmMain.myInstanceHandle;
                                fsdl.Show();
                            }
                        }
                    }
                }
            }
        }

        private void mnuLocation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLocation f = new frmLocation(this);
            f.ShowDialog();
        }

        private void btnBenutzerliste_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUsers f = new frmUsers();
            f.ShowDialog();
        }

        private void btnServerListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FindMdiForm("ServerList"))
            {
                RackList sl = new RackList(this);
                sl.MdiParent = this;
                sl.Show();
            }    
        }

        private void btnSwitchListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FindMdiForm("SwitchList"))
            {
                SwitchList f = new SwitchList(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void mnuSanServers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSAN f = new frmSAN();
            f.ShowDialog();
        }

        private void barStaticItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form1 FI = new Form1(this);
            FI.ShowDialog();

        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NeedRestoreFocused = false;
            NewSwitch sw = new NewSwitch(this, 0);
            sw.ShowDialog();
        }

        private void BarBtnUserManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUsers u = new frmUsers();
            u.ShowDialog();
        }


        private void BarBtnChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPasswordAendern f = new frmPasswordAendern();
            f.ShowDialog();
        }

        private void BarBtnImportFromExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FindMdiForm("frmExcelImport"))
            {
                frmExcelImport f = new frmExcelImport(this);
                f.MdiParent = this;
                f.Show(); ;
            }
        }

        private void BarBtnCloseKabMan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }



        private void BBtnNewConnection_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NeedRestoreFocused = false;
            NewConnection nc = new NewConnection(this, 0);
            nc.ShowDialog();
        }
        
    }
}
