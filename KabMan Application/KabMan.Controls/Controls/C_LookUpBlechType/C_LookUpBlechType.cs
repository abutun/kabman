using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KabMan.Data;
using System.ComponentModel;
using System.Drawing;

namespace KabMan.Controls
{
    [DesignTimeVisible(false), ToolboxItem(true), Category("KabMan Controls"), ToolboxBitmap(typeof(C_LookUpBase), "C_LookUpBlechType.C_LookUpBlechType.bmp")]
    public class C_LookUpBlechType : C_LookUpBase
    {
        public C_LookUpBlechType()
        {
            this.StoredProcedureName = sproc.BlechType_Select_All;
            this.DisplayMember = "Name";
            this.ValueMember = "ID";
            this.NullText = "Select Blech Type!";

            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                this.AddColumn("Name");
                this.AddColumn("PortCount", "Port Count");
                this.LoadDataSource(this.StoredProcedureName, this.DisplayMember, this.ValueMember);
            }
        }
    }
}
