using KabMan.Data;
using DevExpress.XtraEditors.Controls;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace KabMan.Controls
{
    [DesignTimeVisible(false), ToolboxItem(true), Category("KabMan Controls"), ToolboxBitmap(typeof(C_LookUpBase), "C_LookUpLocation.C_LookUpLocation.bmp")]
    public class C_LookUpLocation : C_LookUpBase
    {
        public C_LookUpLocation()
        {
            this.StoredProcedureName = sproc.Location_Select_All;
            this.DisplayMember = "Name";
            this.ValueMember = "ID";
            this.NullText = "Select Location!";
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {

                this.AddColumn("Name");
                this.LoadDataSource(this.StoredProcedureName, this.DisplayMember, this.ValueMember);
            }
        }

    }
}
