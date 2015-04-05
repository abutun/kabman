using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace KabMan.Server
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (UserLookAndFeel ulaf = UserLookAndFeel.Default)
            {
                ulaf.UseWindowsXPTheme = false;
                ulaf.Style = LookAndFeelStyle.Office2003;
            }


            Application.Run(new frmMain());
        }
    }
}
