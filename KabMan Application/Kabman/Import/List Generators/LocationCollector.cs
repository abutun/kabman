using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KabMan.Import
{
    public class LocationListItem
    {
        public string Category { get; set; }
        public string Prefix { get; set; }
        public string Name { get; set; }
    }

    public class LocationCollector : ImportCollectorBase
    {
        public LocationCollector(string argCategory, string argColumnName)
        {
            this.Category = argCategory;
            this.ColumnName = argColumnName;
        }

        public List<LocationListItem> Items { get; private set; }

        public void CollectItems(ref DataSet argDataSet)
        {
            this.Items = new List<LocationListItem>();
            var tmp = new List<LocationListItem>();

            for (int i = 0; i < argDataSet.Tables.Count; i++)
            {
                if (argDataSet.Tables[i].Columns.Contains(ColumnName))
                {
                    IEnumerable<DataRow> seqTable = argDataSet.Tables[i].AsEnumerable();

                    var result = from t in seqTable
                                 let cname = t.Field<string>(ColumnName)
                                 where cname != null
                                 select new LocationListItem
                                 {
                                     Category = this.Category,
                                     Name = cname
                                 };

                    tmp.AddRange(result);
                }
            }

            this.Items = tmp;
        }
    }
}
