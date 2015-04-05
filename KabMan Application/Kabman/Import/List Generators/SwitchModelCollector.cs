using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using KabMan.Extensions;

namespace KabMan.Import
{
    public class SwitchModelListItem
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public int PortCount { get; set; }
    }

    public class SwitchModelCollector : ImportCollectorBase
    {
        public SwitchModelCollector(string argCategory, string argColumnName)
        {
            this.Category = argCategory;
            this.ColumnName = argColumnName;
        }

        public List<SwitchModelListItem> Items { get; private set; }

        public void CollectItems(ref DataSet argDataSet)
        {
            this.Items = new List<SwitchModelListItem>();
            var tmp = new List<SwitchModelListItem>();

            for (int i = 0; i < argDataSet.Tables.Count; i++)
            {
                if (argDataSet.Tables[i].Columns.Contains(ColumnName))
                {
                    IEnumerable<DataRow> seqTable = argDataSet.Tables[i].AsEnumerable();

                    var result = from t in seqTable
                                 let cname = t.Field<string>(ColumnName)
                                 where !string.IsNullOrEmpty(!cname.IsNothing() ? cname.Trim() : null)
                                 group t by t.Field<string>(ColumnName) into g
                                 select new SwitchModelListItem
                                 {
                                     Name = g.Key,
                                     PortCount = g.Count()
                                 };

                    var match = from r in result
                                from t in tmp
                                where r.Name == t.Name
                                select r;

                    var matchCount = from m in match
                                     from t in tmp
                                     where m.PortCount < t.PortCount
                                     select m;

                    if (match.Count() > 0)
                    {
                        if (matchCount.Count() > 0)
                        {
                            foreach (SwitchModelListItem item in matchCount)
                            {
                                var old = (from t in tmp
                                           where t.Name == item.Name
                                           select t).First();
                                old.PortCount = item.PortCount;
                            }
                        }
                        else
                        {
                            // skip
                        }
                    }
                    else
                    {
                        tmp.AddRange(result);
                    }
                }
            }

            this.Items = tmp;
        }
    }
}
