using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using KabMan.Data;
using System.Drawing;

namespace KabMan.Controls
{

    [DesignTimeVisible(false), ToolboxItem(true), Category("KabMan Controls"), ToolboxBitmap(typeof(C_LookUpBase), "C_LookUpDevice2.C_LookUpDevice2.bmp")]
    public class C_LookUpDevice2 : C_LookUpBase
    {
        public C_LookUpDevice2()
        {
            this.StoredProcedureName = sproc.Device_Select_ByCondition2;
            this.DisplayMember = "Name";
            this.ValueMember = "ID";
            this.NullText = "Select Device!";
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                this.AddColumn("Name");
                this.LoadDataSource(this.StoredProcedureName, this.DisplayMember, this.ValueMember);
            }
        }
    }

}
