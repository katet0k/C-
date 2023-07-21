using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public static class StringExtensions11
    {
        public static bool AreBracketsValid(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return true; 

            Dictionary<char, char> bracketPairs = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

            Stack<char> openBrackets = new Stack<char>();

            foreach (char ch in input)
            {
                if (bracketPairs.ContainsKey(ch))
                {
                    openBrackets.Push(ch);
                }
                else if (bracketPairs.ContainsValue(ch))
                {
                    if (openBrackets.Count == 0 || bracketPairs[openBrackets.Pop()] != ch)
                        return false;
                }
            }

            return openBrackets.Count == 0;
        }
    }
}
