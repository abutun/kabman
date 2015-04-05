using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KabMan.Data;
using System.ComponentModel;
using System.Drawing;

namespace KabMan.Controls
{
    [DesignTimeVisible(false), ToolboxItem(true), Category("KabMan Controls"), ToolboxBitmap(typeof(C_LookUpBase), "C_LookUpOS.C_LookUpOS.bmp")]
    public class C_LookUpOS : C_LookUpBase
    {
        public C_LookUpOS()
        {
            this.StoredProcedureName = sproc.OS_Select_All;
            this.DisplayMember = "Name";
            this.ValueMember = "ID";
            this.NullText = "Select Operating System!";
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                this.AddColumn("Name");
                this.LoadDataSource(this.StoredProcedureName, this.DisplayMember, this.ValueMember);
            }
        }
    }
}
