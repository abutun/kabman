using System;
using KabMan.Data;
using System.Data;
using System.Collections.Generic;
using System.Diagnostics;

namespace KabMan.XtraReports
{
    public partial class NewConnectionReportServer : DevExpress.XtraReports.UI.XtraReport
    {
        public NewConnectionReportServer()
        {
            InitializeComponent();
        }

        private DataTable DoDataTableFilter(DataTable dt, string filter)
        {
            DataTable dt1 = dt.Clone();
            foreach (DataRow dr in dt.Select(filter))
            {
                dt1.ImportRow(dr);
            }
            return dt1;
        }

        public List<Int64> newConnectionId;

        public void DoSearch(string argQuery)
        {
            DataSet dstmp = DBAssistant.ExecProcedure("[sproc].[ConnectionDetail_Select_ByConnectionDevice_Detail]", new object[] { "@DeviceID", 2 });
            //DataSet dstmp  = DBAssistant.ExecProcedure("[sproc].[ConnectionDetail_Select_ByConnectionID_Detail]");

            Debug.WriteLine(dstmp.Tables[0].DefaultView.Count);

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ConnectionID", typeof(int)));
            dt.Columns.Add(new DataColumn("ServerName", typeof(string)));
            dt.Columns.Add(new DataColumn("Rack", typeof(string)));
            dt.Columns.Add(new DataColumn("LCURM", typeof(string)));
            dt.Columns.Add(new DataColumn("Blech", typeof(string)));
            dt.Columns.Add(new DataColumn("VTPort", typeof(string)));
            dt.Columns.Add(new DataColumn("UrmUrm", typeof(string)));
            dt.Columns.Add(new DataColumn("VTPort1", typeof(string)));
            dt.Columns.Add(new DataColumn("Blech1", typeof(string)));
            dt.Columns.Add(new DataColumn("LCURM1", typeof(string)));
            dt.Columns.Add(new DataColumn("PortNo", typeof(string)));
            dt.Columns.Add(new DataColumn("Switch", typeof(string)));

            for (int i = 0; i < dstmp.Tables[0].DefaultView.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["ConnectionID"] = dstmp.Tables[0].Rows[i]["ConnectionID"];
                dr["ServerName"] = dstmp.Tables[0].Rows[i]["ServerName"];
                dr["Rack"] = dstmp.Tables[0].Rows[i]["Rack"];
                dr["LCURM"] = dstmp.Tables[0].Rows[i]["LCURM"];
                dr["LCURM1"] = dstmp.Tables[0].Rows[i]["LCURM1"];
                dr["Blech"] = dstmp.Tables[0].Rows[i]["Blech"];
                dr["Blech1"] = dstmp.Tables[0].Rows[i]["Blech1"];
                dr["VTPort"] = dstmp.Tables[0].Rows[i]["VTPort"];
                dr["VTPort1"] = dstmp.Tables[0].Rows[i]["VTPort1"];
                dr["UrmUrm"] = dstmp.Tables[0].Rows[i]["UrmUrm"];
                dr["PortNo"] = dstmp.Tables[0].Rows[i]["PortNo"];
                dr["Switch"] = dstmp.Tables[0].Rows[i]["Switch"];
                dt.Rows.Add(dr);
            }

            dsConnection.Tables.Clear();
            dsConnection.Tables.Add(DoDataTableFilter(dt, String.Format("ConnectionID={0}", newConnectionId[0])));

            DataSource = dsConnection;
            DataMember = ((DataSet)DataSource).Tables[0].TableName;          
        }         

        private void NewConnectionReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DoSearch("");
        }        
    } 
}
