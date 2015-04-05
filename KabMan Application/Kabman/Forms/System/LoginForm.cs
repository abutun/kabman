using System;
using System.Windows.Forms;
using KabMan.Windows;
using KabMan.Data;
using System.Data;
using DevExpress.XtraEditors;

namespace KabMan.Forms
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            this.Icon = Resources.GetIcon("KabManIcon");
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        static string _UserNameAndSurName;
        public static string UserNameAndSurName
        {
            get { return _UserNameAndSurName; }
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            // LOGIN CHECK HERE hay
            if (dxValidationProvider1.Validate())
            {
                try
                {
                    DataTable dt = DBAssistant.ExecProcedure(sproc.LoginCheck, new object[] { "@username", this.UserNameBox.Text, "@password", this.PasswordBox.Text }).Tables[0];
                    if (dt.Rows.Count <= 0)
                    {
                        XtraMessageBox.Show("Username or password is wrong", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //this.DialogResult = DialogResult.No;
                        return;
                    }
                    _UserNameAndSurName = String.Format("{0} {1}", dt.Rows[0]["FirstName"], dt.Rows[0]["LastName"]);
                    Program.userId = (int)dt.Rows[0]["ID"];
                    WindowAssistant.RunNewForm(typeof(SplashForm), WindowAssistant.FormShowType.ShowDialog);
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }
                catch(Exception ex)
                {
                    XtraMessageBox.Show("Error!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            PasswordBox.Properties.PasswordChar = KabMan.Properties.Settings.Default.PasswordChar[0];
        }

        private void UserNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                PasswordBox.Focus();
        }

        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                LoginButton_Click(sender, e);
        }
    }
}