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
using KabMan.Controls;

namespace KabMan.Client
{
    public partial class StockList : DevExpress.XtraEditors.XtraForm
    {
        int lastUrmNo = 1;
        DatabaseLib data = new DatabaseLib();
        private Common com;

        public StockList()
        {
            InitializeComponent();
        }

        private void Stockist_Load(object sender, EventArgs e)
        {
           
            com = new Common();
            com.LoadViewCols(gridView1, "LCURMCable");
            com.LoadViewCols(gridView2, "URMURMCable");
            com.LoadViewCols(gridView3, "TrunkCable");

            Liste();
            this.SetLastUrmNumbersToSpinEdit();
        }

        public void Liste()
        {
            //Loading LC URM Cables on the GridControl1
            DataSet ds;
            DatabaseLib data2 = new DatabaseLib();

            data2.RunProc("sp_selLcUrmCable", out ds);
            data2.Dispose();
            gridControl1.DataSource = ds.Tables[0];

            //Loading URM URM Cables on the GridControl2
            DataSet ds3;
            DatabaseLib data3 = new DatabaseLib();

            data3.RunProc("sp_selUrmUrmCable", out ds3);
            data3.Dispose();
            gridControl2.DataSource = ds3.Tables[0];

            //Loading TrunkCables on the GridControl2
            DataSet dsTr;
            DatabaseLib dataTr = new DatabaseLib();

            dataTr.RunProc("sp_selTrunkCableList", out dsTr);
            dataTr.Dispose();
            gridControl3.DataSource = dsTr.Tables[0];
        }


        private void BtnLoadLcUrmCable_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter[] prm =

            {
                data.MakeInParam("@QualityId", LookUpLcUrmQuality.EditValue),
                data.MakeInParam("@CountCable", spnCountCable.Value),
                data.MakeInParam("@Meter", Convert.ToInt32(CBoxLcUrmLength.Text)),
                data.MakeInParam("@StartNo", Convert.ToInt32(spnStartLCNo.Text)),
                data.MakeInParam("@Type", 1)
            };
                data.RunProc("sp_insUrmUrmCable", prm);
                data.Dispose();

                XtraMessageBox.Show("Has been Load URM_URM Cable is succesfully!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Liste();
            this.SetLastUrmNumbersToSpinEdit();
        }

        private void BtnLoadUrmUrmCable_Click(object sender, EventArgs e)
        {
            DatabaseLib data1 = new DatabaseLib();
            try
            {
                SqlParameter[] prm1 =
                {
                    data1.MakeInParam("@QualityId", LookUpUrmUrmQuality.EditValue),
                    data1.MakeInParam("@CountCable", spnHowManyUrmUrm.Text),
                    data1.MakeInParam("@Meter", Convert.ToInt32(CBoxUrmUrmLength.Text)),
                    data1.MakeInParam("@StartNo", spnStartUrmUrmNo.Value),
                    data1.MakeInParam("@Type", 2)
                };

                data1.RunProc("sp_insUrmUrmCable", prm1);
                data1.Dispose();

                XtraMessageBox.Show("Has been Load URM_URM Cable is succesfully!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Liste();
            this.SetLastUrmNumbersToSpinEdit();
        }

        private void BtnLoadTrunkCable_Click(object sender, EventArgs e)
        {
            DatabaseLib dataTr = new DatabaseLib();

            try
            {
                SqlParameter[] prmTr =

            {
                dataTr.MakeInParam("@QualityId", LookUpTrunkQuality.EditValue),
                dataTr.MakeInParam("@TypeId", LookUpTrunkType.EditValue),
                dataTr.MakeInParam("@StartNo", spnStartTrunkNo.Value),
                dataTr.MakeInParam("@Meter", Convert.ToInt32(CBoxTrunkMeter.Text)),
                dataTr.MakeInParam("@Count", spnCountTrunk.Value)
            };
                dataTr.RunProc("sp_forStoreinsTrunk", prmTr);
                dataTr.Dispose();

                XtraMessageBox.Show("Has been Load Trunk Cable is succesfully!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Liste();
        }

        private void gridView1_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            com.SaveViewCols(gridView1, "LCURMCable");
        }

        private void gridView2_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            com.SaveViewCols(gridView2, "URMURMCable");
        }

        private void gridView3_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            com.SaveViewCols(gridView3, "TrunkCable");
        }

        private void tabbedControlGroup1_SelectedPageChanged(object sender, DevExpress.XtraLayout.LayoutTabPageChangedEventArgs e)
        {
            this.SetLastUrmNumbersToSpinEdit();
        }

        private void SetLastUrmNumbersToSpinEdit()
        {
            DatabaseLib dLib = new DatabaseLib();
            SqlDataReader reader;
            dLib.RunSqlQuery("SELECT MAX(No) AS [LastNo] FROM tblUrm", out reader);
            while (reader.Read())
            {
                if (reader[0].ToString().Trim().Length > 0)
                {
                    this.lastUrmNo = Convert.ToInt32(reader["LastNo"].ToString()) + 1;
                }

            }

            spnStartLCNo.Properties.MinValue = this.lastUrmNo;
            spnStartUrmUrmNo.Properties.MinValue = this.lastUrmNo;
        }
    }
}