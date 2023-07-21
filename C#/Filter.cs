using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public static class ArrayExtensions
    {
        public static int[] Filter(this int[] array, Func<int, bool> predicate)
        {
            var filteredList = new System.Collections.Generic.List<int>();

            foreach (int item in array)
            {
                if (predicate(item))
                    filteredList.Add(item);
            }

            return filteredList.ToArray();
        }
    }
}
