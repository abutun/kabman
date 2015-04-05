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

    public class ServerListItem : Server
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

    public class ServerGroupedListItem
    {
        public string Name { get; set; }
        public string BlechName { get; set; }
        public string OperatingSystem { get; set; }
        public int PortCount { get; set; }
    } 

    public class ServerCollector : ImportCollectorBase
    {      
        public ServerCollector(string argCategory, string argColumnName)
        {     
            this.Category = argCategory;
            this.ColumnName = argColumnName;
        }
        
        public List<ServerListItem> Items { get; private set; }

        public void CollectItems(ref DataSet argDataSet)
        {
            this.Items = new List<ServerListItem>();
         
            var tmp = new List<ServerListItem>();

            for (int i = 0; i < argDataSet.Tables.Count; i++)
            {
                if (argDataSet.Tables[i].Columns.Contains(ColumnName))
                {

                    if (argDataSet.Tables[i].Columns.Contains("Operating System") == false)
                        continue;

                    if (argDataSet.Tables[i].Columns.Contains("BLECH") == false)
                        continue;

                    if (argDataSet.Tables[i].Columns.Contains("VT PORT") == false)
                        continue;

                    IEnumerable<DataRow> seqTable = argDataSet.Tables[i].AsEnumerable();

                    var result = from t in seqTable
                                 let cname = t.Field<string>(ColumnName) ?? ""
                                 let urmLc = t.Field<string>("URM LC") ?? ""
                                 let urmUrm = t.Field<string>("URM URM") ?? ""
                                 let blechFullName = t.Field<string>("BLECH") ?? ""
                                 let vtPortFullName = t.Field<string>("VT PORT") ?? ""
                                 let trunkFullName = t.Field<string>("TRUNK") ?? ""
                                 let Os = t.Field<string>("Operating System") ?? ""
                                 where string.IsNullOrEmpty((cname ?? string.Empty).Trim().Replace(" ", "")) == false
                                 select new ServerListItem
                                 { 
                                     Category = this.Category,
                                     Name = cname,
                                     LcUrm = urmLc,
                                     UrmUrm = urmUrm,
                                     BlechFullName = blechFullName,
                                     VtPortFullName = vtPortFullName,
                                     TrunkFullName = trunkFullName,
                                     OperatingSystem = Os
                                 };

                    tmp.AddRange(result);
                }
            }

            this.Items = tmp;
        }
    }


  
}
