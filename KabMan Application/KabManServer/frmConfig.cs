using System;

namespace KabMan.Server
{
    public partial class frmConfig : DevExpress.XtraEditors.XtraForm
    {
        frmMain f;
        public frmConfig(frmMain f)
        {
            this.f = f;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RegistryHelper.SaveSetting("Config", "AutoStart", chkAutoStart.Checked.ToString());
            RegistryHelper.SaveSetting("Config", "Minute", spnTimer.Text);

            Close();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(RegistryHelper.GetSetting("Config", "AutoStart", null)))
                chkAutoStart.Checked = Convert.ToBoolean(RegistryHelper.GetSetting("Config", "AutoStart", null));

            spnTimer.Text = RegistryHelper.GetSetting("Config", "Minute", "10");            
        }
    }
}