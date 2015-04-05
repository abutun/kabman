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

namespace KabMan.Client
{
    public partial class RoomDetail : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        private Room r;
        private Home m;

        public RoomDetail(Room r, int id, Home m)
        {
            this.m = m;
            this.r = r;
            this.id = id;
            Icon = Properties.Resources.kabman;
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                try
                {
                    DatabaseLib data = new DatabaseLib();

                    SqlParameter[] prm = {
                                         data.MakeInParam("@Id", id),
                                         data.MakeInParam("@LocationId", LookUpLocation.EditValue),
                                         data.MakeInParam("@Room", txtRoomName.Text),
                                         data.MakeInParam("@Exit", CheckDataCenterExit.Checked)
                                     };

                    data.RunProc("sp_insRoom", prm);
                    data.Dispose();

                    r.Liste(true);
                    m.InitTree();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                Close();
            }
        }

        private void RoomDetail_Load(object sender, EventArgs e)
        {
            Common.FillLookup2(LookUpLocation, "select * from tblLocation where RecDelete=0", "LocationName", "Id");


                if (id > 0)
                {
                    SqlDataReader dr;
                    DatabaseLib data = new DatabaseLib();
                    data.RunSqlQuery(string.Format("SELECT LocationId, RoomName FROM tblRoom WHERE Id={0}", id), out dr);

                    if (dr.Read())
                    {
                        LookUpLocation.EditValue = dr["LocationId"];
                        txtRoomName.Text = dr["RoomName"].ToString();
                    }
                }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RoomDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                Close();
        }
    }
}