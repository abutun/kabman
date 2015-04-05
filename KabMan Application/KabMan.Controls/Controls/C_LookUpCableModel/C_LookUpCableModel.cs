using DevExpress.XtraEditors;
using System.ComponentModel;
using KabMan.Data;
using System.Drawing;

namespace KabMan.Controls
{
    [DesignTimeVisible(false), ToolboxItem(true), Category("KabMan Controls"), ToolboxBitmap(typeof(C_LookUpBase), "C_LookUpCableModel.C_LookUpCableModel.bmp")]
    public class C_LookUpCableModel : C_LookUpBase
    {
        public C_LookUpCableModel()
        {
            this.StoredProcedureName = sproc.CableModel_Select_ByCategoryID;
            this.DisplayMember = "Model";
            this.ValueMember = "ID";
            this.NullText = "Select Cable Model!";
            this.HasParameter = true;
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                this.AddColumn("Model");
                this.AddColumn("Symbol");
                this.AddColumn("Length");
                this.AddColumn("Cable Count");
                this.AddColumn("Line Count");
            }
        }

        private C_LookUpCableCategory _TriggerLookUpEdit;
        /// <summary>
        /// C_LookUpCableCategory
        /// </summary>
        [ToolboxItem(true)]
        public C_LookUpCableCategory TriggerLookUpEdit
        {
            get
            {
                return this._TriggerLookUpEdit;
            }
            set
            {
                this._TriggerLookUpEdit = value;
                if (value != null)
                {
                    _TriggerLookUpEdit.EditValueChanged += new System.EventHandler(_TriggerLookUpEdit_EditValueChanged);
                }
            }
        }

        void _TriggerLookUpEdit_EditValueChanged(object sender, System.EventArgs e)
        {
            this.Properties.Buttons[2].Enabled = !string.IsNullOrEmpty(this._TriggerLookUpEdit.EditValue.ToString());
            this.StoredProcedureParameters = new object[] { "@CategoryID", this._TriggerLookUpEdit.EditValue };
            this.LoadDataSource(this.StoredProcedureName, this.StoredProcedureParameters, this.DisplayMember, this.ValueMember);
        }

    }
}
