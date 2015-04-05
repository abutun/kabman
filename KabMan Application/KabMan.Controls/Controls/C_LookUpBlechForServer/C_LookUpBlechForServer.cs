using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KabMan.Data;
using System.ComponentModel;
using System.Drawing;

namespace KabMan.Controls
{
    [DesignTimeVisible(false), ToolboxItem(true), Category("KabMan Controls"), ToolboxBitmap(typeof(C_LookUpBase), "C_LookUpBlechForServer.C_LookUpBlechForServer.bmp")]
    public class C_LookUpBlechForServer : C_LookUpBase
    {
        public C_LookUpBlechForServer()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                this.StoredProcedureName = sproc.Blech_Select_ForServer_ByTypeID;
                this.DisplayMember = "Name";
                this.ValueMember = "ID";

                this.AddColumn("Name");

                this.HasParameter = true;
            }
            this.NullText = "Select Blech!";
        }

        private C_LookUpBlechType _TriggerLookUpEdit;
        /// <summary>
        /// 
        /// </summary>
        public C_LookUpBlechType TriggerLookUpEdit
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
            this.StoredProcedureParameters = new object[] { "@BlechTypeID", this._TriggerLookUpEdit.EditValue };
            this.LoadDataSource(this.StoredProcedureName, this.StoredProcedureParameters, this.DisplayMember, this.ValueMember);
        }


    }
}
