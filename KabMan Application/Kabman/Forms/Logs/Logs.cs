using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KabMan.Data;

namespace KabMan.Forms.Logs
{
    public partial class Logs : DevExpress.XtraEditors.XtraForm
    {
        public Logs()
        {
            InitializeComponent();
        }

        private void Logs_Load(object sender, EventArgs e)
        {
            logsGrid.DataSource = DBAssistant.ExecProcedure(sproc.Log_SelectAll).Tables[0];

            itemResultCount.Caption = logsView.RowCount.ToString();
        }

        private void searchThisText_EditValueChanged(object sender, EventArgs e)
        {
            logsGrid.DataSource = DBAssistant.ExecProcedure(sproc.Log_SelectAll, new object[] { "@Query", searchThisText.EditValue }).Tables[0];

            itemResultCount.Caption = logsView.RowCount.ToString();
        }

        private void clearAllLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBAssistant.ExecProcedure(sproc.Log_DeleteAll);

            logsGrid.DataSource = DBAssistant.ExecProcedure(sproc.Log_SelectAll).Tables[0];
            this.logsGrid.RefreshDataSource();

            itemResultCount.Caption = logsView.RowCount.ToString();
        }
    }
}