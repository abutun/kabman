using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using KabMan.Forms;
using KabMan.Windows;
using KabMan.Forms.Connection;

namespace KabMan
{
    static class Program
    {
        public static int userId;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();
            DevExpress.UserSkins.OfficeSkins.Register();

            using (UserLookAndFeel ulaf = UserLookAndFeel.Default)
            {
                ulaf.UseWindowsXPTheme = false;
                ulaf.Style = LookAndFeelStyle.Skin;
                ulaf.SkinName = "iMaginary";
            }

            KabMan.Data.Settings.ConnectionString = KabMan.Properties.Settings.Default.KabManConnectionString;

            Program.userId = 5;

            //Application.Run(new Home());

            if (WindowAssistant.RunAsDialog(typeof(LoginForm)).FormResult == DialogResult.OK)
            {
                Home home = new Home();
                home.UserNameSurName = LoginForm.UserNameAndSurName;
                Application.Run(home);
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
