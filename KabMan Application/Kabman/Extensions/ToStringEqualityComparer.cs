using System.Collections.Generic;

namespace KabMan
{
    public class ToStringEqualityComparer<T> : IEqualityComparer<T>
    {
        public bool Equals(T x, T y)
        {
            return x.ToString() == y.ToString();
        }

        public int GetHashCode(T obj)
        {
            return this.ToString().GetHashCode();
        }
    }

}
