using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public static class StringExtensions111
    {
        public static int CountVowels(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            int count = 0;
            foreach (char ch in input)
            {
                if (Array.IndexOf(vowels, ch) != -1)
                    count++;
            }

            return count;
        }
    }
}
