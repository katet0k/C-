using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public static class StringExtensions
    {
        public static int WordCount(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            // Використовуємо простий підхід розділення рядка по пробілам
            // і підрахунку кількості отриманих елементів.
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
