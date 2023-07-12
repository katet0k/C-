using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Maximum<T> where T : IComparable<T>
    {
        public T FindMaximum(T a, T b, T c)
        {
            T maximum = a;

            if (b.CompareTo(maximum) > 0)
            {
                maximum = b;
            }

            if (c.CompareTo(maximum) > 0)
            {
                maximum = c;
            }

            return maximum;
        }
    }

}
