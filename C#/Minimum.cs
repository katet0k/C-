using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Minimum<T> where T : IComparable<T>
    {
        public T FindMinimum(T a, T b, T c)
        {
            T minimum = a;

            if (b.CompareTo(minimum) < 0)
            {
                minimum = b;
            }

            if (c.CompareTo(minimum) < 0)
            {
                minimum = c;
            }

            return minimum;
        }
    }

}
