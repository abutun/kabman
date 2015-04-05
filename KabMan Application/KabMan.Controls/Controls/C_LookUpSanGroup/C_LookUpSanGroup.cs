using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KabMan.Data;
using System.ComponentModel;
using System.Drawing;

namespace KabMan.Controls
{
    [DesignTimeVisible(false), ToolboxItem(true), Category("KabMan Controls"), ToolboxBitmap(typeof(C_LookUpBase), "C_LookUpSanGroup.C_LookUpSanGroup.bmp")]
    public class C_LookUpSanGroup : C_LookUpBase
    {

        public C_LookUpSanGroup()
        {
            this.StoredProcedureName = sproc.SanGroup_Select_All;
            this.DisplayMember = "Name";
            this.ValueMember = "ID";
            this.NullText = "Select San Group!";
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                this.AddColumn("Name");
                this.LoadDataSource(this.StoredProcedureName, this.DisplayMember, this.ValueMember);
            }
        }

    }
}
