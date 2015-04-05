using System;
using KabMan.Data;
using DevExpress.XtraEditors.Controls;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using System.ComponentModel;
using KabMan.Windows;
using System.Drawing;

namespace KabMan.Controls
{
    [DesignTimeVisible(false), ToolboxItem(true), Category("KabMan Controls"), ToolboxBitmap(typeof(C_LookUpBase), "C_LookUpDataCenter.C_LookUpDataCenter.bmp")]
    public class C_LookUpDataCenter : C_LookUpBase
    {
        public C_LookUpDataCenter()
        {
            this.StoredProcedureName = sproc.DataCenter_Select_ByLocationID;
            this.DisplayMember = "Name";
            this.ValueMember = "ID";
            this.NullText = "Select Data Center!";
            this.HasParameter = true;
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                this.AddColumn("Name");
                this.AddColumn("HasSwitch", "Has Switch");

            }
        }

        protected override void Properties_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                if (e.Button.Tag.ToString() == "Add")
                {
                    this.StoredProcedureParameters = new object[] { "@LocationID", _TriggerLookUpEdit.EditValue };
                    this.LoadDataSource(this.StoredProcedureName, this.StoredProcedureParameters, this.DisplayMember, this.ValueMember);
                }
            }
            catch (System.Exception ex)
            {
            }
            base.Properties_ButtonPressed(sender, e);
        }

        private C_LookUpLocation _TriggerLookUpEdit;
        /// <summary>
        /// 
        /// </summary>
        public C_LookUpLocation TriggerLookUpEdit
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
            this.EditValue = null;
            this.StoredProcedureParameters = new object[] { "@LocationID", _TriggerLookUpEdit.EditValue };
            this.LoadDataSource(this.StoredProcedureName, this.StoredProcedureParameters, this.DisplayMember, this.ValueMember);
        }


    }
}
