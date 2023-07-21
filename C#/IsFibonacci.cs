using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public static class IntegerExtensions
    {
        public static bool IsFibonacci(this int number)
        {
            if (number < 0)
                return false;

            int a = 0;
            int b = 1;

            while (b < number)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return b == number;
        }
    }
}
