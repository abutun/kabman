using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KabMan.Client
{
    public partial class frmPasswordAendern : DevExpress.XtraEditors.XtraForm
    {
        public frmPasswordAendern()
        {
            Icon = Properties.Resources.kabman;
            InitializeComponent();
        }

        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {

        }

        private void frmPasswordAendern_Load(object sender, EventArgs e)
        {

        }
    }
}