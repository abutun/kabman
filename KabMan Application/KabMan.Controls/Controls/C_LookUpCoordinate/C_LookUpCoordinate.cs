using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KabMan.Data;
using DevExpress.XtraEditors.Controls;
using System.Windows.Forms;
using System.ComponentModel;
using KabMan.Windows;
using System.Drawing;

namespace KabMan.Controls
{
    [DesignTimeVisible(false), ToolboxItem(true), Category("KabMan Controls"), ToolboxBitmap(typeof(C_LookUpBase), "C_LookUpCoordinate.C_LookUpCoordinate.bmp")]
    public class C_LookUpCoordinate : C_LookUpBase
    {
        public C_LookUpCoordinate()
        {
            this.StoredProcedureName = sproc.Coordinate_Select_ByDataCenterID;
            this.DisplayMember = "Name";
            this.ValueMember = "ID";
            this.NullText = "Select Coordinate!";
            this.HasParameter = true;
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                this.AddColumn("Name");
            }
        }

        protected override void Properties_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                if (e.Button.Tag.ToString() == "Add")
                {
                    this.StoredProcedureParameters = new object[] { "@DataCenterID", _TriggerLookUpEdit.EditValue };
                }
            }
            catch (System.Exception ex)
            {

            }
            base.Properties_ButtonPressed(sender, e);
        }

        private C_LookUpDataCenter _TriggerLookUpEdit;
        /// <summary>
        /// 
        /// </summary>
        public C_LookUpDataCenter TriggerLookUpEdit
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
            this.StoredProcedureParameters = new object[] { "@DataCenterID", _TriggerLookUpEdit.EditValue };
            this.LoadDataSource(this.StoredProcedureName, this.StoredProcedureParameters, this.DisplayMember, this.ValueMember);
        }


    }
}
