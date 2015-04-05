using System.ComponentModel;
using KabMan.Data;
using System.Drawing;
namespace KabMan.Controls
{
    [DesignTimeVisible(false), ToolboxItem(true), Category("KabMan Controls"), ToolboxBitmap(typeof(C_LookUpBase), "C_LookUpClass.C_LookUpClass.bmp")]
    public class C_LookUpClass : C_LookUpBase
    {
        public C_LookUpClass()
        {
            this.StoredProcedureName = sproc.Class_Select_All;
            this.DisplayMember = "Class";
            this.ValueMember = "Value";
            this.NullText = "Select Class!";
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                this.AddColumn("Class", "Class Name");
                this.LoadDataSource(this.StoredProcedureName, this.DisplayMember, this.ValueMember);
            }
        }
    }
}
