using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using Utils;

namespace KabMan.Client
{
    public partial class NewCoordinate : DevExpress.XtraEditors.XtraForm
    {
        
        private Common com;
        DatabaseLib data = new DatabaseLib();

        public NewCoordinate()
        {          
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter[] prm =
                {
                    data.MakeInParam("@RoomId",LookUpRoom.EditValue),
                    data.MakeInParam("@CoordName", txtCoordinateName.Text)
                };
                data.RunProc("sp_insRackCoordinate", prm);
                data.Dispose();
                MessageBox.Show("Has been created Coordinate succesfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            this.DialogResult = DialogResult.OK;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void NewCoordinate_Load(object sender, EventArgs e)
        {
            Common.FillLookup2(LookUpRoom, "select * from tblRoom where RecDelete=0", "RoomName", "Id");
        }
    }
}