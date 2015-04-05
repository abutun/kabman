using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using KabMan.Text;
using System.Linq;
using KabMan.Components;

namespace KabMan.Extensions
{
    public enum DictionaryElement
    {
        Key,
        Value
    }

    public static class Extensions
    {

        public static bool ContainsAll(this DataColumnCollection source, string[] argColumnList)
        {

            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            int retValue = 0;

            foreach (string name in argColumnList)
            {

                foreach (DataColumn column in source)
                {
                    if (column.ColumnName.Trim().Equals(name.Trim()))
                    {
                        retValue++;
                        break;
                    }
                }
            }
            return retValue == argColumnList.Length;
        }

        public static string ToStringList(this IEnumerable<string> source)
        {

            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            string retValue;
            StringBuilder builder = new StringBuilder();

            builder.Append("{ ");

            foreach (string item in source)
            {
                builder.Append(item + ", ");
            }
            builder.Append(" }");

            retValue = builder.ToString();
            retValue = retValue.Remove(retValue.LastIndexOf(","), 2);

            return retValue;
        }

        public static Dictionary<string, string> ToDictionary(this string source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            Dictionary<string, string> retValue = new Dictionary<string, string>();

            if (RegexAssistant.RegexMatched(@"(\{[^:;]+\:[^:;]+);?", source))
            {
                string[] pairs = source.Replace("{", "").Replace("}", "").Split(';');

                foreach (string pair in pairs)
                {
                    string[] items = pair.Split(':');

                    retValue.Add(items[0], items[1]);
                }
            }
            return retValue;
        }

        public static bool IsNothing(this string source)
        {
            return string.IsNullOrEmpty(source);
        }

        public static bool Match(this string source, string argRegex)
        {
            return RegexAssistant.RegexMatched(argRegex, source);
        }

        public static T[] ToArray<T>(this IEnumerable<T> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            return source.ToList().ToArray();
        }

        public static IEnumerable<T> Distinct<T>(this IEnumerable<T> source, Func<T, T, bool> comparer)
        {
            return source.Distinct(new DelegateComparer<T>(comparer));
        }

        public static IEnumerable<T> Distinct<T>(this IEnumerable<T> source, Func<T, T, bool> comparer, Func<T, int> hashMethod)
        {
            return source.Distinct(new DelegateComparer<T>(comparer, hashMethod));
        }


    }
}
