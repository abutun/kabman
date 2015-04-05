using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using KabMan.Extensions;
using KabMan.Components;
using KabMan.Windows;


namespace KabMan.Import
{

    public class DccListItem : Dcc
    {
        public new string Name
        {
            get
            {
                return base.Name;
            }
            set
            {
                base.Parse(value);
                base.Name = value;
            }
        }
        public string Category { get; set; }
    }

    public class DccGroupedListItem
    {
        public string Name { get; set; }
        public string VTPort1Name { get; set; }
        public string VTPort2Name { get; set; }
        public int PortCount { get; set; }
    } 

    public class DccCollector : ImportCollectorBase
    {
        public DccCollector(string argCategory, string argColumnName)
        {     
            this.Category = argCategory;
            this.ColumnName = argColumnName;
        }
        
        public List<DccListItem> Items { get; private set; }

        public void CollectItems(ref DataSet argDataSet)
        {
            this.Items = new List<DccListItem>();
         
            var tmp = new List<DccListItem>();

            for (int i = 0; i < argDataSet.Tables.Count; i++)
            {
                if (argDataSet.Tables[i].Columns.Contains(ColumnName))
                {
                    if (argDataSet.Tables[i].Columns.Contains("TRUNK") == false)
                        continue;

                    if (argDataSet.Tables[i].Columns.Contains("VT PORT1") == false)
                        continue;

                    if (argDataSet.Tables[i].Columns.Contains("VT PORT2") == false)
                        continue;

                    IEnumerable<DataRow> seqTable = argDataSet.Tables[i].AsEnumerable();

                    var result = from t in seqTable
                                 let cname = t.Field<string>(ColumnName) ?? ""
                                 let urmLc = t.Field<string>("URM LC") ?? ""
                                 let urmUrm = t.Field<string>("URM URM") ?? ""
                                 let vtPort1FullName = t.Field<string>("VT PORT1") ?? ""
                                 let vtPort2FullName = t.Field<string>("VT PORT2") ?? ""
                                 let trunkFullName = t.Field<string>("TRUNK") ?? ""
                                 where string.IsNullOrEmpty((cname ?? string.Empty).Trim().Replace(" ", "")) == false
                                 select new DccListItem
                                 { 
                                     Category = this.Category,
                                     Name = cname,
                                     LcUrm = urmLc,
                                     UrmUrm = urmUrm,
                                     VtPort1FullName = vtPort1FullName,
                                     VtPort2FullName = vtPort2FullName,
                                     TrunkFullName = trunkFullName
                                 };

                    tmp.AddRange(result);
                }
            }

            this.Items = tmp;
        }
    }


  
}
