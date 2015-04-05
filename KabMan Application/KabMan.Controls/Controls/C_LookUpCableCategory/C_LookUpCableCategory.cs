using System.ComponentModel;
using KabMan.Data;
using System.Drawing;
namespace KabMan.Controls
{
    [DesignTimeVisible(false), ToolboxItem(true), Category("KabMan Controls"), ToolboxBitmap(typeof(C_LookUpBase), "C_LookUpCableCategory.C_LookUpCableCategory.bmp")]
    public class C_LookUpCableCategory : C_LookUpBase
    {
        public C_LookUpCableCategory()
        {
            this.StoredProcedureName = sproc.CableCategory_Select_All;
            this.DisplayMember = "Name";
            this.ValueMember = "ID";
            this.NullText = "Select Cable Category!";

            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                this.AddColumn("Name");
                this.LoadDataSource(this.StoredProcedureName, this.DisplayMember, this.ValueMember);
            }
            
        }
    }
}
