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
    public partial class frmBlechDetail : DevExpress.XtraEditors.XtraForm
    {
        DatabaseLib data = new DatabaseLib();
        private frmBlech b;
        private int id;

        public frmBlechDetail(frmBlech b, int id)
        {
            this.b = b;
            Icon = KabMan.Client.Properties.Resources.kabman;
            InitializeComponent();
        }

        private void frmBlechDetail_Load(object sender, EventArgs e)
        {
            Common.FillLookup2(LkpLocation, "select Id, LocationName + LocationCoord AS FullLocationName from tblLocation where RecDelete=0", "FullLocationName", "Id");
            Common.FillLookup2(lkpBlechType, "select * from tblBlechType where RecDelete=0", "Name", "Id");
            Common.FillLookup2(LkpObjectType, "select * from tblBlechObject where RecDelete=0", "Name", "Id");

            if (id > 0)
            {
                SqlDataReader dr;
                DatabaseLib data = new DatabaseLib();
                data.RunSqlQuery(string.Format("SELECT * FROM tblBlech WHERE Id={0}", id), out dr);

                if (dr.Read())
                {
                    LkpLocation.EditValue = dr["LocationId"];
                    lkpDataCenter.EditValue = dr["RoomId"];
                    lkpSan.EditValue = dr["SanId"];
                    lkpBlechType.EditValue = dr["TypeId"];
                    LkpObjectType.EditValue = dr["ObjectId"];
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                try
                {
                    SqlParameter[] prm =
                                    { 
                                        data.MakeInParam("@LocationId", LkpLocation.EditValue),
                                        data.MakeInParam("@RoomId", lkpDataCenter.EditValue),
                                        data.MakeInParam("@SanId", lkpSan.EditValue),
                                        data.MakeInParam("@TypeId", lkpBlechType.EditValue),
                                        data.MakeInParam("@ObjectName", LkpObjectType.Text)
                                    };

                    data.RunProc(SPROC.BLECH_INSERT, prm);
                    data.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                b.Liste(true);

                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lkpLocation_EditValueChanged(object sender, EventArgs e)
        {
            Common.FillLookup2(lkpDataCenter, "select * from tblRoom where LocationId=" + LkpLocation.EditValue, "RoomName", "Id");
        }

        private void lkpLocation_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue != null)
                lkpDataCenter.Enabled = true;
            else
                lkpDataCenter.Enabled = false;
        }

        private void lkpDataCenter_EditValueChanged(object sender, EventArgs e)
        {
            if ((int)LkpObjectType.EditValue == 3)          //switch
            {
                lkpSan.Properties.DataSource = null;
                Common.FillLookup2(lkpSan, "SELECT San, Id FROM tblSan WHERE RecDelete=0", "San", "Id");
                lkpSan.Properties.Columns[0].Caption = "SAN";
                lkpSan.Properties.Columns[0].FieldName = "San";                
            }
            else if ((int)LkpObjectType.EditValue == 4)     // rack
            {
                lkpSan.Properties.DataSource = null;
                Common.FillLookup2(lkpSan, "select CoordName, Id from tblCoordinate where RecDelete=0 and RoomId=" + lkpDataCenter.EditValue, "CoordName", "Id");
                lkpSan.Properties.Columns[0].Caption = "Coordinate";
                lkpSan.Properties.Columns[0].FieldName = "CoordName"; 
            } 
        }

        private void LkpObjectType_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            lkpSan.EditValue = null;
        }
    }
}