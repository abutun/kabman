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
    public partial class frmVTPortDetail : DevExpress.XtraEditors.XtraForm
    {
        DatabaseLib data = new DatabaseLib();
        private frmVTPort v;
        private int id;

        public frmVTPortDetail(frmVTPort v, int id)
        {
            this.v = v;
            this.id = id;

            Icon = KabMan.Client.Properties.Resources.kabman;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                if (chkForDataCenterConn.Checked == false)
                {
                    try
                    {
                        SqlParameter[] prm =
                        { 
                            data.MakeInParam("@LocationId", lkpLocation.EditValue),
                            data.MakeInParam("@RoomId", lkpRoom.EditValue),
                            data.MakeInParam("@SanId", San.EditValue)
                        };

                        data.RunProc(SPROC.VTPORT_INSERT, prm);
                        data.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    v.List(true);
                }
                else
                {
                    try
                    {
                        SqlParameter[] prm =
                            { 
                                data.MakeInParam("@LocationId", lkpLocation.EditValue),
                                data.MakeInParam("@RoomId", lkpRoom.EditValue),
                                data.MakeInParam("@SanId", San.EditValue)
                            };
                        data.RunProc("sp_insVTPortForDataCenter", prm);
                        data.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmVTPortDetail_Load(object sender, EventArgs e)
        {

            Common.FillLookup2(lkpLocation, "select * from tblLocation where RecDelete=0", "LocationName", "Id");
            Common.FillLookup2(San, "select * from tblSan where RecDelete=0", "San", "Id");

            if (id > 0)
            {
                SqlDataReader dr;
                DatabaseLib data = new DatabaseLib();
                data.RunSqlQuery(string.Format("SELECT * FROM tblVTPort WHERE Id={0}", id), out dr);

                if (dr.Read())
                {
                    lkpLocation.EditValue = dr["LocationId"];
                    lkpRoom.EditValue = dr["RoomId"];
                    San.EditValue = dr["SanId"];
                }
            }

        }

        private void lkpLocation_EditValueChanged(object sender, EventArgs e)
        {
            Common.FillLookup2(lkpRoom, "select * from tblRoom where RecDelete=0 and LocationId=" + lkpLocation.EditValue, "RoomName", "Id");
        }

        private void frmVTPortDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                Close();
        }
    }
}