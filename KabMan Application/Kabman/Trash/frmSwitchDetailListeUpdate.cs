using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KabMan.Client.Modules.Switch
{
    public partial class frmSwitchDetailListeUpdate : DevExpress.XtraEditors.XtraForm
    {
        public frmSwitchDetailListeUpdate()
        {
            InitializeComponent();
        }

    

        private void btnSpeichern_Click(object sender, EventArgs e)
        {

        }

        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}