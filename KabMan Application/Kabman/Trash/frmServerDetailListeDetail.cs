using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Utils;

namespace KabMan.Client
{
    public partial class frmServerDetailListeDetail : DevExpress.XtraEditors.XtraForm
    {
        private frmServerDetailListe f;
        private int id;
        private int sid;

        public frmServerDetailListeDetail(frmServerDetailListe f, int id, int sid)
        {
            this.id = id;
            this.f = f;
            this.sid = sid;

            Icon = Properties.Resources.kabman;
            InitializeComponent();
        }

        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            Close();
        }

        int SID = 0;

        private void frmServerDetailListeDetail_Load(object sender, EventArgs e)
        {

            Common.FillLookup2(lkpSAN, "SELECT * FROM tblSAN", "SAN", "SanId");

            if (id > 0)
            {
                SqlDataReader dr;
                DatabaseLib data = new DatabaseLib();
                data.RunSqlQuery(string.Format("SELECT * FROM tblServerDetailListe WHERE ServerDetailId={0}", id), out dr);
                
                if (dr.Read())
                {
                    SID = Convert.ToInt32(dr["ServerId"].ToString());
                    txtKabelURMLC.EditValue = dr["KabelURMLC"].ToString();
                    txtBlech.Text = dr["Blech"].ToString();
                    txtCableMultiTrunk.Text = dr["CableTrunkMulti"].ToString();
                    txtVTPort.Text = dr["VTPort"].ToString();
                    txtPatchcabel.Text = dr["PatchCableURM_URM"].ToString();
                    chkResevervation.Checked = (bool)dr["Reservation"];
                    lkpSAN.EditValue = dr["SanId"];
                }
            }
        }

        private void frmServerDetailListeDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                DatabaseLib data = new DatabaseLib();
                SqlParameter[] prm = 
                {
                    data.MakeInParam("@ServerDetailId", id),
                    data.MakeInParam("@ServerId", SID),
                    data.MakeInParam("@KabelURMLC", txtKabelURMLC.Text),
                    data.MakeInParam("@Blech", txtBlech.Text),
                    data.MakeInParam("@CableTrunkMulti", txtCableMultiTrunk.Text),
                    data.MakeInParam("@VTPort", txtVTPort.Text),
                    data.MakeInParam("@PatchCableURM_URM", txtPatchcabel.Text),
                    data.MakeInParam("@Reservation", chkResevervation.Checked),
                    data.MakeInParam("@SanId", lkpSAN.EditValue)
                };

                data.RunProc("sp_insServerDetail", prm);
                data.Dispose();

                f.Liste(true);

                Close();
            }
        }

        private int CheckCable(string value, int type)
        {
            SqlDataReader dr;
            DatabaseLib data = new DatabaseLib();

            SqlParameter[] prm = {
                                     data.MakeInParam("@Cable", value),
                                     data.MakeInParam("@Type", type)
                                 };

            data.RunProc("sp_insCable", prm, out dr);

            int cableId = 0;
            if (dr.Read())
            {
                cableId = Convert.ToInt32(dr["CableId"]);
            }

            data.Dispose();

            return cableId;
        }


    }
}