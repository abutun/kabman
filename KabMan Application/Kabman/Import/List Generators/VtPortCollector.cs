using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KabMan.Components;
using KabMan.Text;
using System.Data;
using KabMan.Extensions;

namespace KabMan.Import
{
    public class VtPortListItem : VtPort
    {
        public string Category { get; set; }

        private string _Name;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                base.Parse(value);
            }
        }
        public int Count { get; set; }
    }

    public class VtPortGroupedListItem
    {
        public string Room { get; set; }
        public string San { get; set; }
    }


    class VtPortCollector : ImportCollectorBase
    {
        public VtPortCollector(string argCategory, string argColumnName)
        {
            this.Category = argCategory;
            this.ColumnName = argColumnName;
        }

        public List<VtPortListItem> Items { get; private set; }

        public void CollectItems(ref DataSet argDataSet)
        {
            this.Items = new List<VtPortListItem>();
            var tmp = new List<VtPortListItem>();

            for (int i = 0; i < argDataSet.Tables.Count; i++)
            {
                if (argDataSet.Tables[i].Columns.Contains(ColumnName))
                {
                    IEnumerable<DataRow> seqTable = argDataSet.Tables[i].AsEnumerable();

                    var result = from t in seqTable
                                 let cname = t.Field<string>(ColumnName)
                                 where cname != null &&
                                 cname.Match(regex.VtPortAcronym)
                                 select new VtPortListItem
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
