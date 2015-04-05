using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using KabMan.Extensions;
using KabMan.Components;

namespace KabMan.Import
{
    public class SwitchListItem:Switch
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

    public class SwitchGroupedListItem
    {
        public string Name {get; set;}
        public string Category { get; set; }
        public string VtPortName { get; set; }
        public string BlechName { get; set; }
        public int SwitchType { get; set; }
        public string Model { get; set; }
        public string CoreSwitchName { get; set; }
    }

    public class SwitchCollector : ImportCollectorBase
    {
        public SwitchCollector(string argCategory, string argColumnName)
        {
            this.Category = argCategory;
            this.ColumnName = argColumnName;
        }

        public List<SwitchListItem> Items { get; private set; }

        public void CollectItems(ref DataSet argDataSet)
        {
            this.Items = new List<SwitchListItem>();
            var tmp = new List<SwitchListItem>();

            for (int i = 0; i < argDataSet.Tables.Count; i++)
            {
                if (argDataSet.Tables[i].Columns.Contains(ColumnName))
                {
                    if (argDataSet.Tables[i].Columns.Contains("Model") == false)
                        continue;

                    if (argDataSet.Tables[i].Columns.Contains("BLECH") == false)
                        continue;

                    if (argDataSet.Tables[i].Columns.Contains("VT PORT") == false)
                        continue;

                    IEnumerable<DataRow> seqTable = argDataSet.Tables[i].AsEnumerable();

                    var result = from t in seqTable
                                 let cname = t.Field<string>(ColumnName)
                                 let model = t.Field<string>("Model")
                                 let urmLc = t.Field<string>("URM LC")??""
                                 let urmUrm = t.Field<string>("URM URM")??""
                                 let blechFullName = t.Field<string>("BLECH")??""
                                 let vtPortFullName = t.Field<string>("VT PORT")??""
                                 let trunkFullName = t.Field<string>("TRUNK") ?? ""
                                 let portNoObject = t.Field<object>("Port") ?? ""
                                 let connectionName = t.Field<string>("Connection Name") ?? ""
                                 let dataCenter = (blechFullName == "" || blechFullName.Length<3?"    ":blechFullName).Substring(1, 3).Trim()
                                 where string.IsNullOrEmpty(cname ?? string.Empty) == false
                                 select new SwitchListItem
                                 {
                                     Category = this.Category,
                                     Name = cname,
                                     Model = model,
                                     BlechFullName = blechFullName,
                                     VtPortFullName = vtPortFullName, 
                                     DataCenter = dataCenter,
                                     LcUrm = urmLc,
                                     UrmUrm = urmUrm,
                                     TrunkFullName = trunkFullName,
                                     ConnectionName = connectionName,
                                     Port = portNoObject.ToString()
                                 };

                    tmp.AddRange(result);
                }
            }

            this.Items = tmp;
        }
    }
}
