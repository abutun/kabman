using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KabMan.Components;
using KabMan.Text;
using System.Data;
using KabMan.Extensions;
using System.Collections;

namespace KabMan.Import
{
    public class BlechListItem : Blech
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

    public class BlechGroupedListItem
    {
        public string Name { get; set; }
        public string Room { get; set; }
        public int Count { get; set; }
        public BlechTypes BlechType { get; set; }
        public string San { get; set; }
        public string Coordinate { get; set; }
    }

    class BlechCollector : ImportCollectorBase
    {
        public BlechCollector(string argCategory, string argColumnName)
        {
            this.Category = argCategory;
            this.ColumnName = argColumnName;
        }

        public List<BlechListItem> Items { get; private set; }

        public void CollectItems(ref DataSet argDataSet)
        {
            this.Items = new List<BlechListItem>();
            var tmp = new List<BlechListItem>();

            for (int i = 0; i < argDataSet.Tables.Count; i++)
            {
                if (argDataSet.Tables[i].Columns.Contains(ColumnName))
                {
                    IEnumerable<DataRow> seqTable = argDataSet.Tables[i].AsEnumerable();

                    var result = from t in seqTable
                                 let cname = t.Field<string>(ColumnName)
                                 where cname != null &&
                                 cname.Match(regex.BlechAcronym)
                                 select new BlechListItem
                                 {
                                     Category = this.Category,
                                     Name = cname,
                                     BlechType = (BlechTypes)Enum.Parse(typeof(BlechTypes), this.Category)
                                 };


                    //Server blech ve dasd blech aynı name yapısına sahip. Ayırt etmek için category parametresini kullandım.
                    //if (Category == "Dasd")
                    //{

                    //    IEnumerable<BlechListItem> bleches = (IEnumerable<BlechListItem>)tmp.AsEnumerable<BlechListItem>();
                    //    IEnumerator<BlechListItem> blEnum = bleches.GetEnumerator();

                    //    while (blEnum.MoveNext())
                    //    {
                    //        blEnum.Current.BlechType = BlechTypes.Dasd;
                    //    }
                    //}

                    tmp.AddRange(result);
                }
            }

            this.Items = tmp;

        }
    }
}
