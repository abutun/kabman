using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;


namespace KabMan.SetupHelper
{
    [RunInstaller(true)]
    public partial class ConfigurationFileManager : Installer
    {
        public ConfigurationFileManager()
        {
            InitializeComponent();
        }

        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);

            string targetDirectory = Context.Parameters["targetdir"];
            string exePath = string.Format("{0}KabMan.exe", targetDirectory);

            string serverName = Context.Parameters["servername"];
            string userid = Context.Parameters["userid"];
            string password = Context.Parameters["password"];

            bool windowsAuth = userid == "";

            string connString = "Data Source=" + serverName + "; Initial Catalog=KabMan; " + (windowsAuth?"Integrated Security=True":"User Id=" + userid + "; Password=" + password ); 
            Configuration config = ConfigurationManager.OpenExeConfiguration(exePath);

            config.ConnectionStrings.ConnectionStrings["KabMan.Properties.Settings.KabManConnectionString"].ConnectionString = connString;

            config.Save();

        }
    }
}
