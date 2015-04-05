using System;
using System.Windows.Forms;
using KabMan.Data;

namespace KabMan.Forms
{
    public partial class BlechDetailManagerForm : DevExpress.XtraEditors.XtraForm
    {

        private object _BlechID;
        public long BlechID
        {
            get
            {
                return Convert.ToInt64(this._BlechID);
            }
        }

        public BlechDetailManagerForm()
        {
            InitializeComponent();
            InitializeManager();
        }

        public BlechDetailManagerForm(object argBlechID)
        {
            this._BlechID = argBlechID;
            InitializeComponent();
            InitializeManager();
        }

        private void InitializeManager()
        {
            Icon = Resources.GetIcon("KabManIcon");
            itemExit.Glyph = Resources.GetImage("ManagerExit");
        }

        private void BlechManagerForm_Load(object sender, EventArgs e)
        {
            CGridControl.DataSource = DBAssistant.ExecProcedure(sproc.BlechDetail_Select_ByBlechID, new object[] { "@BlechID", this.BlechID }).Tables[0];
            itemCount.Caption = string.Format("Records: {0}", CGridView.RowCount.ToString());
        }



        #region Toolbar Events

        private void itemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion


    }
}