using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KabMan.Data;
using System.ComponentModel;
using System.Drawing;

namespace KabMan.Controls
{
    [DesignTimeVisible(false), ToolboxItem(true), Category("KabMan Controls"), ToolboxBitmap(typeof(C_LookUpBase), "C_LookUpSan.C_LookUpSan.bmp")]
    public class C_LookUpSan : C_LookUpBase
    {
        public C_LookUpSan()
        {
            this.StoredProcedureName = sproc.San_Select_ByGroupID;
            this.DisplayMember = "Name";
            this.ValueMember = "ID";
            this.NullText = "Select San!";
            this.HasParameter = true;
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                this.AddColumn("Name");
                this.AddColumn("Value");
                this.AddColumn("BlechValue", "Blech Value");
                this.AddColumn("SwitchValue", "Switch Value");
                this.AddColumn("DataCenterValue", "Data Center Value");
            }
        }

        private C_LookUpSanGroup _TriggerLookUpEdit;
        /// <summary>
        /// 
        /// </summary>
        public C_LookUpSanGroup TriggerLookUpEdit
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
            this.StoredProcedureParameters = new object[] { "@SanGroupID", _TriggerLookUpEdit.EditValue };
            this.LoadDataSource(this.StoredProcedureName, this.StoredProcedureParameters, this.DisplayMember, this.ValueMember);
        }
    }
}
