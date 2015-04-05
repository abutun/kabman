using System;
using System.Drawing;
using System.ComponentModel;
using KabMan.Data;

namespace KabMan.Controls
{
    [DesignTimeVisible(false), ToolboxItem(true), Category("KabMan Controls"), ToolboxBitmap(typeof(C_LookUpBase), "C_LookUpTrunkCableTypes.C_LookUpTrunkCableTypes.bmp")]
    public class C_LookUpTrunkCableTypes : C_LookUpBase
    {
        public C_LookUpTrunkCableTypes()
        {
            this.DisplayMember = "Name";
            this.ValueMember = "Name";
            this.NullText = "Select Trunk Cable Type!";
            this.HasParameter = false;
            this.StoredProcedureName = sproc.Cable_Select_TrunkCableTypes;
            this.StoredProcedureParameters = new object[] { };
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                this.AddColumn("Name");
                this.LoadDataSource(this.StoredProcedureName, this.DisplayMember, this.ValueMember);
            }
        }
    }
}