using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KabMan.Import
{
    public class CoordinateListItem
    {
        public string Category { get; set; }
        public string DataCenter { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}]", new object[] { this.Category, this.Name, this.DataCenter });
        }
    }

    public class CoordinateCollector : ImportCollectorBase
    {
        public CoordinateCollector(string argCategory, string argColumnName)
        {
            this.Category = argCategory;
            this.ColumnName = argColumnName;
        }

        public List<CoordinateListItem> Items { get; private set; }

        public void CollectItems(ref DataSet argDataSet)
        {
            this.Items = new List<CoordinateListItem>();
            var tmp = new List<CoordinateListItem>();

            for (int i = 0; i < argDataSet.Tables.Count; i++)
            {
                if (argDataSet.Tables[i].Columns.Contains(ColumnName))
                {
                    IEnumerable<DataRow> seqTable = argDataSet.Tables[i].AsEnumerable();

                    var result = from t in seqTable
                                 let cname = t.Field<string>(ColumnName)
                                 where cname != null
                                 select new CoordinateListItem
                                 {
                                     Category = this.Category,
                                     DataCenter = cname,
                                     Name = cname
                                 };

                    tmp.AddRange(result);
                }
            }

            this.Items = tmp;
        }
    }
}
