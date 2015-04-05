using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Utils;
using System.Data.SqlClient;
using KabMan.Controls;

namespace KabMan.Client
{
    public partial class frmDefaults : DevExpress.XtraEditors.XtraForm
    {
        public frmDefaults()
        {
            InitializeComponent();
        }

     
        private void frmDefaults_Load(object sender, EventArgs e)
        {

        }

        DatabaseLib dLib = new DatabaseLib();

        private void btnDasdSave_Click(object sender, EventArgs e)
        {
            SqlParameter[] frm = {
                                     dLib.MakeInParam("@ds",lkpDasdSymbol.EditValue),
                                     dLib.MakeInParam("@dds",lkpDasdDescStart.EditValue),
                                     dLib.MakeInParam("@dde",lkpDasdDescEnd.EditValue),
                                     dLib.MakeInParam("@dns",txtDasdStartNo.Text),
                                     dLib.MakeInParam("@dne",txtDasdEndNo.Text),
                                     dLib.MakeInParam("@dcs",lkpDasdConnStart.EditValue),
                                     dLib.MakeInParam("@dce",lkpDasdConnEnd.EditValue)
                                 };

            dLib.RunProc("Set_Defaults", frm);
            dLib.Dispose();
        }
    }
}