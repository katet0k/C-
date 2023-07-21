using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public static class IntegerExtensions111
    {
        public static bool IsPrime(this int number)
        {
            if (number <= 1)
                return false;

            int sqrt = (int)Math.Sqrt(number);
            for (int i = 2; i <= sqrt; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
