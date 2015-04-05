using System;
using System.Windows.Forms;
using KabMan.Data;

namespace KabMan.Forms
{
    public partial class VTPortDetailManagerForm : DevExpress.XtraEditors.XtraForm
    {

        private object _VTPortID;
        public long VTPortID
        {
            get
            {
                return Convert.ToInt64(this._VTPortID);
            }
        }

        public VTPortDetailManagerForm()
        {
            this.Icon = Resources.GetIcon("KabManIcon");

            InitializeComponent();
            InitializeManager();
        }

        public VTPortDetailManagerForm(object argVTPortID)
        {
            this.Icon = Resources.GetIcon("KabManIcon");

            this._VTPortID = argVTPortID;
            InitializeComponent();
            InitializeManager();
        }

        private void InitializeManager()
        {
            itemExit.Glyph = Resources.GetImage("ManagerExit");
        }

        private void VTPortManagerForm_Load(object sender, EventArgs e)
        {
            CGridControl.DataSource = DBAssistant.ExecProcedure(sproc.VtPortDetail_Select_ByVtPortID, new object[] { "@VtPortID", this.VTPortID }).Tables[0];
            itemCount.Caption = string.Format("Records: {0}", CGridView.RowCount.ToString());
        }



        #region Toolbar Events

        private void itemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion

        private void ItemClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}