﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KabMan.Import
{
    public class DataCenterListItem
    {
        public string Category { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}]", new object[] { this.Category, this.Name, this.Location });
        }
    }

    public class DataCenterCollector : ImportCollectorBase
    {
        public DataCenterCollector(string argCategory, string argColumnName)
        {
            this.Category = argCategory;
            this.ColumnName = argColumnName;
        }

        public List<DataCenterListItem> Items { get; private set; }

        public void CollectItems(ref DataSet argDataSet)
        {
            this.Items = new List<DataCenterListItem>();
            var tmp = new List<DataCenterListItem>();

            for (int i = 0; i < argDataSet.Tables.Count; i++)
            {
                if (argDataSet.Tables[i].Columns.Contains(ColumnName))
                {
                    IEnumerable<DataRow> seqTable = argDataSet.Tables[i].AsEnumerable();

                    var result = from t in seqTable
                                 let cname = t.Field<string>(ColumnName)
                                 let lname = t.Field<string>("Name") ?? ""
                                 where cname != null
                                 select new DataCenterListItem
                                 {
                                     Category = this.Category,
                                     Location = lname,
                                     Name = cname
                                 };

                    tmp.AddRange(result);
                }
            }

            this.Items = tmp;
        }
    }
}
