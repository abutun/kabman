using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.IO;

namespace KabMan.Forms
{
    public partial class SQLManagement : DevExpress.XtraEditors.XtraForm
    {
        private int _type = 0; //Backup

        public SQLManagement(int type)
        {
            InitializeComponent();

            this._type = type;
        }

        private void BackUp()
        {
            this.backupButton.Enabled = false;
            try
            {
                //Backup
                DateTime d = DateTime.Now;

                string filename = Data.Settings.DatabaseName + "_" + d.Day.ToString().PadLeft(2, '0') + d.Month.ToString().PadLeft(2, '0') + d.Year.ToString() +
                                  "_" + d.Hour.ToString().PadLeft(2, '0') + d.Minute.ToString().PadLeft(2, '0') + d.Second.ToString().PadLeft(2, '0') +
                                  d.Millisecond.ToString().PadLeft(4, '0') + ".bak";

                Server server = new Server(new ServerConnection(new System.Data.SqlClient.SqlConnection(Data.Settings.ConnectionString)));

                // Create a new backup operation
                Backup bkpDatabase = new Backup();

                // Set the backup type to a database backup
                bkpDatabase.Action = BackupActionType.Database;

                // Set the database that we want to perform a backup on
                bkpDatabase.Database = Data.Settings.DatabaseName;

                // Set the backup device to a file
                BackupDeviceItem bkpDevice = new BackupDeviceItem(filename, DeviceType.File);

                // Add the backup device to the backup
                bkpDatabase.Devices.Add(bkpDevice);

                bkpDatabase.PercentComplete += new PercentCompleteEventHandler(bkpDatabase_PercentComplete);

                // Perform the backup
                bkpDatabase.SqlBackup(server);

                this.progressBarControl1.Position = 0;

                XtraMessageBox.Show("Backup finished...", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.backupButton.Enabled = true;
        }

        void bkpDatabase_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            this.progressBarControl1.Position = e.Percent;
            this.progressBarControl1.Refresh();

            this.statusLabel.Text = e.Percent.ToString() + "% of backup completed.";

            this.statusLabel.Refresh();

            this.Refresh();
        }

        void rstDatabase_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            this.progressBarControl1.Position = e.Percent;
            this.progressBarControl1.Refresh();

            this.statusLabel.Text = e.Percent.ToString() + "% of restore completed.";

            this.statusLabel.Refresh();

            this.Refresh();
        }

        private void Restore()
        {
            //Restore
            this.restoreButton.Enabled = false;
            try
            {
                Server server = new Server(new ServerConnection(new System.Data.SqlClient.SqlConnection(Data.Settings.ConnectionString)));

                this.openBackupFileDialog.Multiselect = false;
                this.openBackupFileDialog.InitialDirectory = server.BackupDirectory;

                if (this.openBackupFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filepath = this.openBackupFileDialog.FileName;

                    if (filepath != "")
                    {
                        if (File.Exists(filepath))
                        {
                            // Create a new database restore operation
                            Restore rstDatabase = new Restore();

                            // Set the restore type to a database restore
                            rstDatabase.Action = RestoreActionType.Database;

                            // Set the database that we want to perform the restore on
                            rstDatabase.Database = Data.Settings.DatabaseName;

                            // Set the backup device from which we want to restore, to a file
                            BackupDeviceItem bkpDevice = new BackupDeviceItem(filepath, DeviceType.File);

                            // Add the backup device to the restore type
                            rstDatabase.Devices.Add(bkpDevice);

                            // If the database already exists, replace it
                            rstDatabase.ReplaceDatabase = true;

                            rstDatabase.PercentComplete += new PercentCompleteEventHandler(rstDatabase_PercentComplete);

                            server.KillAllProcesses(Data.Settings.DatabaseName);

                            rstDatabase.Wait();

                            // Perform the restore
                            rstDatabase.SqlRestore(server);

                            XtraMessageBox.Show("Restore finished...Application will be restarted!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Application.Restart();
                        }
                        else
                            XtraMessageBox.Show("Error!", "File does not exists!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        XtraMessageBox.Show("Error!", "Invalid file path!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.restoreButton.Enabled = true;
        }

        private void SQLManagement_Load(object sender, EventArgs e)
        {

        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            this.BackUp();
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            this.Restore();
        }
    }
}