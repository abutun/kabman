using KabMan.Components;
using System.Collections.Generic;
using System.Data;
using userSettings = KabMan.Properties.Settings;
using KabMan.Extensions;
using System.Linq;
using KabMan.Controls;
using System;
using KabMan.Text;

namespace KabMan.Import
{
    public class JumperListItem : JumperCable
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

    public class JumperCableCollector : ImportCollectorBase
    {
        public JumperCableCollector(string argCategory, string argColumnName)
        {
            this.Category = argCategory;
            this.ColumnName = argColumnName;
        }

        public List<JumperListItem> Items { get; private set; }

        public void CollectItems(ref DataSet argDataSet)
        {
            this.Items = new List<JumperListItem>();
            var tmp = new List<JumperListItem>();

            for (int i = 0; i < argDataSet.Tables.Count; i++)
            {
                if (argDataSet.Tables[i].Columns.Contains(ColumnName))
                {
                    IEnumerable<DataRow> seqTable = argDataSet.Tables[i].AsEnumerable();

                    var result = from t in seqTable
                                 let cname = t.Field<string>(ColumnName)
                                 where cname != null &&
                                 RegexAssistant.RegexMatched(regex.JumperCableAcronym, cname)
                                 select new JumperListItem
                                 {
                                     Category = this.Category,
                                     Name = t.Field<string>(ColumnName)
                                 };


                    tmp.AddRange(result);
                }
            }

            this.Items = tmp;

        }

    }
}
