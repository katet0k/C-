using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public static class StringExtensions1
    {
        public static int LengthOfLastWord1(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            // Розділяємо рядок по пробілам та видаляємо порожні елементи.
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length > 0)
            {
                // Останнє слово буде останнім елементом масиву.
                string lastWord = words[words.Length - 1];
                return lastWord.Length;
            }

            return 0;
        }
    }

}
