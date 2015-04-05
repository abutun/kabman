using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class DataCenterListItem
{
    public string Category { get; set; }
    public string SwitchName { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return string.Format("[{0}, {1}, {2}]", new object[] { this.Category, this.Name, this.SwitchName });
    }
}

public class MainClass
{
    public static void Main()
    {
        var lSwitch = new List<DataCenterListItem>();
        lSwitch.Add(new DataCenterListItem { Category = "Switch", Name = "738", SwitchName = "SW23" });
        lSwitch.Add(new DataCenterListItem { Category = "Switch", Name = "023", SwitchName = "SW04" });

        var lServer = new List<DataCenterListItem>();
        lServer.Add(new DataCenterListItem { Category = "Server", Name = "738", SwitchName = "" });
        lServer.Add(new DataCenterListItem { Category = "Server", Name = "023", SwitchName = "" });
        lServer.Add(new DataCenterListItem { Category = "Server", Name = "739", SwitchName = "" });

        var lDasd = new List<DataCenterListItem>();
        lDasd.Add(new DataCenterListItem { Category = "Dasd", Name = "738", SwitchName = "" });
        lDasd.Add(new DataCenterListItem { Category = "Dasd", Name = "023", SwitchName = "" });
        lDasd.Add(new DataCenterListItem { Category = "Dasd", Name = "739", SwitchName = "" });
        lDasd.Add(new DataCenterListItem { Category = "Dasd", Name = "759", SwitchName = "SW04" });

        var all = lSwitch.Union(lServer).Union(lDasd);

        var valued = all.Where(a => !string.IsNullOrEmpty(a.SwitchName));

        var unvalued = all.Where(a => string.IsNullOrEmpty(a.SwitchName)).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0, (a) => a.Name.GetHashCode()); 

        var result = (from a in valued.Union(unvalued)
                      select a).Distinct((a, b) => (string.Compare(a.Name, b.Name)) == 0, (a) => a.Name.GetHashCode());

        foreach (var item in result)
        {
            Console.WriteLine(item.ToString());
        }
        Console.ReadKey();
    }
}

public static class Extensions
{

    public static IEnumerable<T> Distinct<T>(this IEnumerable<T> source, Func<T, T, bool> comparer)
    {
        return source.Distinct(new DelegateComparer<T>(comparer));
    }

    public static IEnumerable<T> Distinct<T>(this IEnumerable<T> source, Func<T, T, bool> comparer, Func<T, int> hashMethod)
    {
        return source.Distinct(new DelegateComparer<T>(comparer, hashMethod));
    }

}



public class DelegateComparer<T> : IEqualityComparer<T>
{
    private Func<T, T, bool> _equals;
    private Func<T, int> _getHashCode;

    public DelegateComparer(Func<T, T, bool> equals)
    {
        this._equals = equals;
    }

    public DelegateComparer(Func<T, T, bool> equals, Func<T, int> getHashCode)
    {
        this._equals = equals;
        this._getHashCode = getHashCode;
    }

    public bool Equals(T a, T b)
    {
        return _equals(a, b);
    }

    public int GetHashCode(T a)
    {
        if (_getHashCode != null)
        {
            return _getHashCode(a);
        }
        else
        {
            return a.GetHashCode();
        }
    }
}

public class ToStringEqualityComparer<T> : IEqualityComparer<T>
{
    public bool Equals(T x, T y)
    {
        return x.ToString() == y.ToString();
    }

    public int GetHashCode(T obj)
    {
        return this.ToString().GetHashCode();
        return 0;
    }
}