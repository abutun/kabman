using System;
using KabMan.Data;
using System.Data;
using System.Collections.Generic;
using System.Diagnostics;

namespace KabMan.XtraReports
{
    public partial class NewConnectionReportDCC : DevExpress.XtraReports.UI.XtraReport
    {
        public NewConnectionReportDCC()
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
            DataSet dstmp = DBAssistant.ExecProcedure("[sproc].[ConnectionDetail_Select_ByConnectionDevice_Detail]", new object[] { "@DeviceID", 7 });
            //DataSet dstmp  = DBAssistant.ExecProcedure("[sproc].[ConnectionDetail_Select_ByConnectionID_Detail]");

            Debug.WriteLine(dstmp.Tables[0].DefaultView.Count);

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ConnectionID", typeof(int)));
            dt.Columns.Add(new DataColumn("ConnectionName", typeof(string)));
            dt.Columns.Add(new DataColumn("Rack", typeof(string)));
            dt.Columns.Add(new DataColumn("VTPort", typeof(string)));
            dt.Columns.Add(new DataColumn("UrmUrm1", typeof(string)));
            dt.Columns.Add(new DataColumn("VTPort1", typeof(string)));
            dt.Columns.Add(new DataColumn("Trunk1", typeof(string)));
            dt.Columns.Add(new DataColumn("VTPort2", typeof(string)));
            dt.Columns.Add(new DataColumn("UrmUrm2", typeof(string)));
            dt.Columns.Add(new DataColumn("VTPort3", typeof(string)));
            dt.Columns.Add(new DataColumn("PortNo", typeof(string)));
            dt.Columns.Add(new DataColumn("Switch", typeof(string)));

            for (int i = 0; i < dstmp.Tables[0].DefaultView.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["ConnectionID"] = dstmp.Tables[0].Rows[i]["ConnectionID"];
                dr["ConnectionName"] = dstmp.Tables[0].Rows[i]["ConnectionName"];
                dr["Rack"] = dstmp.Tables[0].Rows[i]["Rack"];
                dr["VTPort"] = dstmp.Tables[0].Rows[i]["VTPort"];
                dr["UrmUrm1"] = dstmp.Tables[0].Rows[i]["UrmUrm1"];
                dr["VTPort1"] = dstmp.Tables[0].Rows[i]["VTPort1"];
                dr["Trunk1"] = dstmp.Tables[0].Rows[i]["Trunk1"];
                dr["VTPort2"] = dstmp.Tables[0].Rows[i]["VTPort2"];
                dr["UrmUrm2"] = dstmp.Tables[0].Rows[i]["UrmUrm2"];
                dr["VTPort3"] = dstmp.Tables[0].Rows[i]["VTPort3"];
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
