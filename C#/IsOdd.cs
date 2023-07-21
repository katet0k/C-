using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public static class IntegerExtensions1
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }
    }
}
