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
    public partial class frmServerDetailCreate : DevExpress.XtraEditors.XtraForm
    {
        private int sid;
        public DataTable dt;
        public int indexRow;

        private int sanServer;
        private int cable;
        private int blech;

        public frmServerDetailCreate(int sid)
        {
            this.sid = sid;
            InitializeComponent();
        }

        private void btnSchliessen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void frmServerDetailCreate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                Close();
        }

        private void btnErstellen_Click(object sender, EventArgs e)
        {
            if (dt.DefaultView.Count == 0)
            {
                indexRow = 0;
                int totalRow = cable * sanServer;

                float i = int.Parse(txtKabelURMLC.Text);
                float j = int.Parse(txtKabelTrunkMulti.Text);

                int grup = 1;
                while (indexRow < totalRow)
                {
                    DataRow dr;
                    dr = dt.NewRow();
                    dr[0] = indexRow;

                    dr[1] = StrToFormat(i.ToString(), 6);
                    dr[3] = StrToFormat(j.ToString(), 6);

                    if (grup < 4) grup++;
                    else
                    {
                        grup = 1;
                        j++;
                    }

                    dt.Rows.Add(dr);

                    i++;                    
                    indexRow++;
                }

                gridControl1.DataSource = dt;
            }
        }

        private string StrToFormat(string value, int size)
        {
            string _zero = null;
            int j = value.Length;
            if (j < size)
            {
                int zero = size - j;
                for (int i = 0; i < zero - 1; i++)
                {
                    _zero += "0";
                }
            }

            return string.Format("A{0}", _zero + value);
        }

        private void GetServerInfo()
        {
            SqlDataReader dr;
            DatabaseLib data = new DatabaseLib();
            data.RunSqlQuery(string.Format("SELECT * FROM tblServer WHERE ServerId={0}", sid), out dr);

            if (dr.Read())
            {
                blech = Convert.ToInt32(dr["Blech"]);
                cable = Convert.ToInt32(dr["Cable"]);
            }

            dr.Close();
            data.Dispose();
        }

        private void GetSanInfo()
        {
            SqlDataReader dr;
            DatabaseLib data = new DatabaseLib();
            data.RunSqlQuery(string.Format("SELECT COUNT(*) AS I FROM tblSAN"), out dr);

            if (dr.Read())
            {
                sanServer = Convert.ToInt32(dr["I"]);
            }

            dr.Close();
            data.Dispose();
        }

        private void frmServerDetailCreate_Load(object sender, EventArgs e)
        {
            ListeCreate();

            GetServerInfo();
            GetSanInfo();

            Common.FillLookup2(lkpSAN, "SELECT * FROM tblSAN", "SAN", "SanId");
        }

        private void ListeCreate()
        {
            indexRow = 0;
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("IndexRow", typeof(int)));
            dt.Columns.Add(new DataColumn("KabelURMLC", typeof(string)));
            dt.Columns.Add(new DataColumn("Blech", typeof(string)));
            dt.Columns.Add(new DataColumn("CableTrunkMulti", typeof(string)));
            dt.Columns.Add(new DataColumn("VTPort", typeof(string)));
            dt.Columns.Add(new DataColumn("PatchCableURM_URM", typeof(string)));
            dt.Columns.Add(new DataColumn("SanId", typeof(int)));
        }

        private void btnListeLoeschen_Click(object sender, EventArgs e)
        {
            dt.Clear();
            gridControl1.DataSource = null;
        }

        private void btnSpeichern_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DatabaseLib data;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                object objValue1 = gridView1.GetRowCellValue(i, "KabelURMLC");
                object objValue2 = gridView1.GetRowCellValue(i, "Blech");
                object objValue3 = gridView1.GetRowCellValue(i, "CableTrunkMulti");
                object objValue4 = gridView1.GetRowCellValue(i, "VTPort");
                object objValue5 = gridView1.GetRowCellValue(i, "SanId");

                data = new DatabaseLib();
                SqlParameter[] prm = 
                {
                    data.MakeInParam("@ServerDetailId", 0),
                    data.MakeInParam("@ServerId", sid),
                    data.MakeInParam("@KabelURMLC", objValue1),
                    data.MakeInParam("@Blech", objValue2),
                    data.MakeInParam("@CableTrunkMulti", objValue3),
                    data.MakeInParam("@VTPort", objValue4),
                    data.MakeInParam("@PatchCableURM_URM", DBNull.Value),
                    data.MakeInParam("@SanId", objValue5),
                    data.MakeInParam("@Reservation", false)
                };

                data.RunProc("sp_insServerDetail", prm);
                data.Dispose();
            }

            Close();
        }
    }
}