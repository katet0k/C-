using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Sum<T>
    {
        public T CalculateSum(T[] array)
        {
            dynamic sum = default(T);

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
    }

}
