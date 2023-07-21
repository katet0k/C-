using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public static class StringExtensions13
    {
        public static int CountSentences(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            char[] sentenceEndChars = { '.', '!', '?' };

            int count = 0;
            foreach (char ch in input)
            {
                if (Array.IndexOf(sentenceEndChars, ch) != -1)
                    count++;
            }

            return count;
        }
    }
}
