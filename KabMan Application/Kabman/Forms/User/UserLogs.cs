using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KabMan.Data;

namespace KabMan.Forms
{
    public partial class UserLogs : DevExpress.XtraEditors.XtraForm
    {
        public UserLogs()
        {
            InitializeComponent();
        }

        private void UserLogs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                Close();
        }

        private void UserLogs_Load(object sender, EventArgs e)
        {
            lkpUser.Properties.DataSource = DBAssistant.ExecProcedure(sproc.LoginUserList).Tables[0];
            lkpUser.Properties.DisplayMember = "UserName";
            lkpUser.Properties.ValueMember = "ID";
        }

        private void newSearchButton_Click(object sender, EventArgs e)
        {
            lkpUser.EditValue = null;
            dtmEndDate.EditValue = null;
            dtmStartDate.EditValue = null;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}