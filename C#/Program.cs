using System.Globalization;
using System.Text;
using System.IO;

namespace C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("uk-UA");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            Console.OutputEncoding = Encoding.UTF8;

            int switch_on;

            do
            {
                Console.WriteLine("\n#===========================#");
                Console.WriteLine(" |       1 -  case 1       |");
                Console.WriteLine(" |       2 -  case 2       |");
                Console.WriteLine(" |       3 -  case 3       |");
                Console.WriteLine(" |       4 -  case 4       |");
                Console.WriteLine(" |       5 -  case 5       |");
                Console.WriteLine(" |       6 -  case 6       |");
                Console.WriteLine(" |       7 -  case 7       |");
                Console.WriteLine(" |       8 -  case 8       |");
                Console.WriteLine("#===========================#");
                Console.Write("Виберіть пункт меню -> ");
                switch_on = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.Clear();

                switch (switch_on)
                {
                    case 1:
                        {
                            List<int> numbers = GenerateNumbers(100);

                            List<int> primeNumbers = new List<int>();
                            List<int> fibonacciNumbers = new List<int>();

                            foreach (int number in numbers)
                            {
                                if (IsPrime(number))
                                    primeNumbers.Add(number);

                                if (IsFibonacci(number))
                                    fibonacciNumbers.Add(number);
                            }

                            SaveNumbersToFile(primeNumbers, "prime_numbers.txt");
                            SaveNumbersToFile(fibonacciNumbers, "fibonacci_numbers.txt");

                            Console.WriteLine("Статистика:");
                            Console.WriteLine($"Загальна кількість згенерованих чисел: {numbers.Count}");
                            Console.WriteLine($"Кількість простих чисел: {primeNumbers.Count}");
                            Console.WriteLine($"Кількість чисел Фібоначчі: {fibonacciNumbers.Count}");


                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                        static List<int> GenerateNumbers(int count)
                        {
                            Random random = new Random();
                            List<int> numbers = new List<int>();

                            for (int i = 0; i < count; i++)
                            {
                                numbers.Add(random.Next(1, 1000));
                            }

                            return numbers;
                        }

                        static bool IsPrime(int number)
                        {
                            if (number <= 1)
                                return false;

                            for (int i = 2; i <= Math.Sqrt(number); i++)
                            {
                                if (number % i == 0)
                                    return false;
                            }

                            return true;
                        }

                        static bool IsFibonacci(int number)
                        {
                            double test1 = 5 * Math.Pow(number, 2) + 4;
                            double test2 = 5 * Math.Pow(number, 2) - 4;

                            return IsPerfectSquare(test1) || IsPerfectSquare(test2);
                        }

                        static bool IsPerfectSquare(double num)
                        {
                            int sqrt = (int)Math.Sqrt(num);
                            return (sqrt * sqrt == num);
                        }

                        static void SaveNumbersToFile(List<int> numbers, string fileName)
                        {
                            using (StreamWriter writer = new StreamWriter(fileName))
                            {
                                foreach (int number in numbers)
                                {
                                    writer.WriteLine(number);
                                }
                            }
                        }

                    case 2:
                        {

                            Console.Write("Введіть шукане слово: ");
                            string searchWord = Console.ReadLine();

                            Console.Write("Введіть слово для заміни: ");
                            string replaceWord = Console.ReadLine();

                            int replacementsCount = ReplaceWordsInFile("input.txt", "output.txt", searchWord, replaceWord);

                            Console.WriteLine($"Замінено {replacementsCount} входжень слова '{searchWord}' на '{replaceWord}'");

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                        static int ReplaceWordsInFile(string inputFileName, string outputFileName, string searchWord, string replaceWord)
                        {
                            int replacementsCount = 0;

                            try
                            {
                                using (StreamReader reader = new StreamReader(inputFileName))
                                using (StreamWriter writer = new StreamWriter(outputFileName))
                                {
                                    string line;
                                    while ((line = reader.ReadLine()) != null)
                                    {
                                        int startIndex = 0;
                                        int index;
                                        while ((index = line.IndexOf(searchWord, startIndex, StringComparison.OrdinalIgnoreCase)) != -1)
                                        {
                                            replacementsCount++;
                                            string prefix = line.Substring(startIndex, index - startIndex);
                                            writer.Write(prefix + replaceWord);
                                            startIndex = index + searchWord.Length;
                                        }
                                        writer.WriteLine(line.Substring(startIndex));
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Помилка: " + ex.Message);
                            }

                            return replacementsCount;
                        }

                    case 3:
                        {
                            Console.Write("Введіть шлях до файлу з текстом: ");
                            string textFilePath = Console.ReadLine();

                            Console.Write("Введіть шлях до файлу зі словами для модерації: ");
                            string moderationWordsFilePath = Console.ReadLine();

                            List<string> moderationWords = GetModerationWords(moderationWordsFilePath);

                            if (moderationWords.Count == 0)
                            {
                                Console.WriteLine("Помилка: Файл зі словами для модерації порожній або не знайдено.");
                                return;
                            }

                            int replacementsCount = ModerateTextFile(textFilePath, moderationWords);

                            Console.WriteLine($"Замінено {replacementsCount} слів.");


                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                        static List<string> GetModerationWords(string filePath)
                        {
                            List<string> moderationWords = new List<string>();

                            try
                            {
                                using (StreamReader reader = new StreamReader(filePath))
                                {
                                    string line;
                                    while ((line = reader.ReadLine()) != null)
                                    {
                                        moderationWords.Add(line.Trim());
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Помилка: " + ex.Message);
                            }

                            return moderationWords;
                        }

                        static int ModerateTextFile(string filePath, List<string> moderationWords)
                        {
                            int replacementsCount = 0;

                            try
                            {
                                string tempFilePath = filePath + ".tmp";

                                using (StreamReader reader = new StreamReader(filePath))
                                using (StreamWriter writer = new StreamWriter(tempFilePath))
                                {
                                    string line;
                                    while ((line = reader.ReadLine()) != null)
                                    {
                                        string[] words = line.Split(' ');

                                        for (int i = 0; i < words.Length; i++)
                                        {
                                            if (moderationWords.Contains(words[i].Trim(), StringComparer.OrdinalIgnoreCase))
                                            {
                                                words[i] = new string('*', words[i].Length);
                                                replacementsCount++;
                                            }
                                        }

                                        writer.WriteLine(string.Join(" ", words));
                                    }
                                }

                                // Замінюємо початковий файл на тимчасовий з модерованим текстом
                                File.Delete(filePath);
                                File.Move(tempFilePath, filePath);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Помилка: " + ex.Message);
                            }

                            return replacementsCount;
                        }

                    case 4:
                        {
                            Console.Write("Введіть шлях до файлу: ");
                            string filePath = Console.ReadLine();

                            string reversedFilePath = ReverseFileContent(filePath);

                            Console.WriteLine($"Вміст файлу перевернуто. Результат збережено у файлі: {reversedFilePath}");

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                        static string ReverseFileContent(string filePath)
                        {
                            string reversedFilePath = filePath + ".reversed";

                            try
                            {
                                using (StreamReader reader = new StreamReader(filePath))
                                using (StreamWriter writer = new StreamWriter(reversedFilePath))
                                {
                                    string line;
                                    while ((line = reader.ReadLine()) != null)
                                    {
                                        char[] charArray = line.ToCharArray();
                                        Array.Reverse(charArray);
                                        string reversedLine = new string(charArray);
                                        writer.WriteLine(reversedLine);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Помилка: " + ex.Message);
                            }

                            return reversedFilePath;
                        }

                    case 5:
                        {
                            string filePath = "numbers.txt"; // Вкажіть шлях до файлу, який містить 100000 цілих чисел

                            if (File.Exists(filePath))
                            {
                                List<int> numbers = ReadNumbersFromFile(filePath);

                                int positiveCount = CountPositiveNumbers(numbers);
                                int negativeCount = CountNegativeNumbers(numbers);
                                int twoDigitCount = CountTwoDigitNumbers(numbers);
                                int fiveDigitCount = CountFiveDigitNumbers(numbers);

                                Console.WriteLine("Статистика:");
                                Console.WriteLine($"1. Кількість додатних чисел: {positiveCount}");
                                Console.WriteLine($"2. Кількість від'ємних чисел: {negativeCount}");
                                Console.WriteLine($"3. Кількість двозначних чисел: {twoDigitCount}");
                                Console.WriteLine($"4. Кількість п'ятизначних чисел: {fiveDigitCount}");

                                WriteNumbersToFile(FilterNumbersBySign(numbers, true), "positive_numbers.txt");
                                WriteNumbersToFile(FilterNumbersBySign(numbers, false), "negative_numbers.txt");
                                WriteNumbersToFile(FilterNumbersByDigits(numbers, 2), "two_digit_numbers.txt");
                                WriteNumbersToFile(FilterNumbersByDigits(numbers, 5), "five_digit_numbers.txt");
                            }
                            else
                            {
                                Console.WriteLine("Помилка: Файл не знайдено.");
                            }
                        }
                        break;

                        static List<int> ReadNumbersFromFile(string filePath)
                        {
                            List<int> numbers = new List<int>();

                            try
                            {
                                using (StreamReader reader = new StreamReader(filePath))
                                {
                                    string line;
                                    while ((line = reader.ReadLine()) != null)
                                    {
                                        if (int.TryParse(line, out int number))
                                        {
                                            numbers.Add(number);
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Помилка: " + ex.Message);
                            }

                            return numbers;
                        }

                        static int CountPositiveNumbers(List<int> numbers)
                        {
                            int count = 0;
                            foreach (int number in numbers)
                            {
                                if (number > 0)
                                    count++;
                            }
                            return count;
                        }

                        static int CountNegativeNumbers(List<int> numbers)
                        {
                            int count = 0;
                            foreach (int number in numbers)
                            {
                                if (number < 0)
                                    count++;
                            }
                            return count;
                        }

                        static int CountTwoDigitNumbers(List<int> numbers)
                        {
                            int count = 0;
                            foreach (int number in numbers)
                            {
                                if (number >= 10 && number <= 99)
                                    count++;
                            }
                            return count;
                        }

                        static int CountFiveDigitNumbers(List<int> numbers)
                        {
                            int count = 0;
                            foreach (int number in numbers)
                            {
                                if (number >= 10000 && number <= 99999)
                                    count++;
                            }
                            return count;
                        }

                        static List<int> FilterNumbersBySign(List<int> numbers, bool positive)
                        {
                            List<int> filteredNumbers = new List<int>();
                            foreach (int number in numbers)
                            {
                                if ((positive && number > 0) || (!positive && number < 0))
                                    filteredNumbers.Add(number);
                            }
                            return filteredNumbers;
                        }

                        static List<int> FilterNumbersByDigits(List<int> numbers, int digitCount)
                        {
                            List<int> filteredNumbers = new List<int>();
                            foreach (int number in numbers)
                            {
                                if (Math.Abs(number).ToString().Length == digitCount)
                                    filteredNumbers.Add(number);
                            }
                            return filteredNumbers;
                        }

                        static void WriteNumbersToFile(List<int> numbers, string filePath)
                        {
                            try
                            {
                                using (StreamWriter writer = new StreamWriter(filePath))
                                {
                                    foreach (int number in numbers)
                                    {
                                        writer.WriteLine(number);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Помилка: " + ex.Message);
                            }
                        }

                }

            } while (switch_on != 0);
        }
    }
}