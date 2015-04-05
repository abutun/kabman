using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KabMan.Data;
using System.ComponentModel;
using System.Drawing;

namespace KabMan.Controls
{
    [DesignTimeVisible(false), ToolboxItem(true), Category("KabMan Controls"), ToolboxBitmap(typeof(C_LookUpBase), "C_LookUpDevice1.C_LookUpDevice1.bmp")]
    public class C_LookUpDevice1 : C_LookUpBase
    {
        public C_LookUpDevice1()
        {
            this.StoredProcedureName = sproc.Device_Select_ByCondition1;
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
