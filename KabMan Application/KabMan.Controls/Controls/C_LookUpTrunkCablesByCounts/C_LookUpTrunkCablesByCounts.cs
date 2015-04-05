using System;
using System.Drawing;
using System.ComponentModel;
using KabMan.Data;
using System.Collections.Generic;

namespace KabMan.Controls
{
    [DesignTimeVisible(false), ToolboxItem(true), Category("KabMan Controls"), ToolboxBitmap(typeof(C_LookUpBase), "C_LookUpTrunkCablesByCounts.C_LookUpTrunkCablesByCounts.bmp")]
    public class C_LookUpTrunkCablesByCounts : C_LookUpBase
    {
        public C_LookUpTrunkCablesByCounts()
        {
            this.DisplayMember = "Model";
            this.ValueMember = "ID";
            this.NullText = "Select Trunk Cable!";
            this.HasParameter = true;
            this.StoredProcedureName = sproc.Cable_Select_TrunkCables_ByCableLine;

            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                this.AddColumn("Model");
                this.AddColumn("Name");
                
            }

        }

        private C_LookUpTrunkCableTypes _TriggerLookUpEdit;
        /// <summary>
        /// 
        /// </summary>
        public C_LookUpTrunkCableTypes TriggerLookUpEdit
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
            string editValue = _TriggerLookUpEdit.EditValue.ToString();
            List<object> args = new List<object>();
            if (editValue.Contains("x"))
            {
                string[] counts = editValue.Replace(" ", "").Split('x');
                args.AddRange(new object[] { "@CableCount", counts[0], "@LineCount", counts[1] });
            }

            this.StoredProcedureParameters = args.ToArray();
            this.LoadDataSource(this.StoredProcedureName, this.StoredProcedureParameters, this.DisplayMember, this.ValueMember);
        }
    }
}
