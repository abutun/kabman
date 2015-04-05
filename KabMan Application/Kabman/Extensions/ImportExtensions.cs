using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using KabMan.Import;
using KabMan.Components;
using KabMan.Controls;

namespace KabMan.Extensions
{
    public static class ImportExtensions
    {
        public static DataTable ToDataTable(this IEnumerable<TrunkListItem> source)
        {
            DataTable retValue = new DataTable();
            retValue.Columns.Add("Name", typeof(string));
            retValue.Columns.Add("Symbol", typeof(string));
            retValue.Columns.Add("Number", typeof(string));
            retValue.Columns.Add("Class", typeof(string));
            retValue.Columns.Add("Index", typeof(string));
            retValue.Columns.Add("Count", typeof(int));

            foreach (TrunkListItem item in source)
            {
                TrunkCable trunk = new TrunkCable();

                if (trunk.IsAcronymValid(item.Name))
                {
                    trunk.Parse(item.Name);

                    DataRow row = retValue.NewRow();
                    row.ItemArray = new object[] { item.Name, item.Symbol, item.Number, item.Class, item.Index, item.Count };
                    retValue.Rows.Add(row);
                }

                if (string.IsNullOrEmpty(item.Name))
                {
                    DataRow row = retValue.NewRow();
                    row.ItemArray = new object[] { item.Name, null, null, null, null, item.Count };
                    retValue.Rows.Add(row);
                }

            }

            return retValue;
        }
    }
}
