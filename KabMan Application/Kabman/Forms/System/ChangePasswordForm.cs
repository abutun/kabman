using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KabMan.Forms
{
    public partial class ChangePasswordForm : XtraForm
    {
        public ChangePasswordForm()
        {
            Icon = Resources.GetIcon("KabManIcon");
            InitializeComponent();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            Password1Box.Properties.PasswordChar = KabMan.Properties.Settings.Default.PasswordChar[0];
            Password2Box.Properties.PasswordChar = KabMan.Properties.Settings.Default.PasswordChar[0];
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (PasswordValidator.Validate())
            {
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}