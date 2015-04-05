using System;
using System.Drawing;
using System.ComponentModel;
using KabMan.Data;

namespace KabMan.Controls
{
    [DesignTimeVisible(false), ToolboxItem(true), Category("KabMan Controls"), ToolboxBitmap(typeof(C_LookUpBase), "C_LookUpCableLengths.C_LookUpCableLengths.bmp")]
    public class C_LookUpCableLengths : C_LookUpBase
    {
        public C_LookUpCableLengths()
        {
            this.DisplayMember = "Length";
            this.ValueMember = "Length";
            this.HasParameter = true;
            this.NullText = "Select Cable Length!";
            this.StoredProcedureName = sproc.Cable_Select_LengthsByCategory;

            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                this.AddColumn("Length");
            }
        }

        protected override void OnLoaded()
        {
            if (this._TriggerLookUpEdit == null)
            {
                this.StoredProcedureParameters = new object[] { "@CategoryID", DBNull.Value, "@CategoryName", this.CableCategory };
                this.LoadDataSource(this.StoredProcedureName, this.StoredProcedureParameters, this.DisplayMember, this.ValueMember);
            }
            base.OnLoaded();
        }

        private string _CableCategory;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string CableCategory
        {
            get
            {
                return this._CableCategory;
            }
            set
            {
                this._CableCategory = value;
            }
        }

        private C_LookUpCableCategory _TriggerLookUpEdit;
        /// <summary>
        /// 
        /// </summary>
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
                    _TriggerLookUpEdit.EditValueChanged += new EventHandler(_TriggerLookUpEdit_EditValueChanged);
                }
            }
        }

        void _TriggerLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.Properties.Buttons[2].Enabled = !string.IsNullOrEmpty(this._TriggerLookUpEdit.EditValue.ToString());
            this.StoredProcedureParameters = new object[] { "@CategoryID", _TriggerLookUpEdit.EditValue, "@CategoryName", DBNull.Value };
            this.LoadDataSource(this.StoredProcedureName, this.StoredProcedureParameters, this.DisplayMember, this.ValueMember);
        }
    }
}
