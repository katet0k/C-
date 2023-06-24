using System.Globalization;
using System.Text;
using System;

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
                Console.WriteLine(" |       9 -  case 9       |");
                Console.WriteLine(" |      10 -  case 10      |");
                Console.WriteLine(" |      11 -  case 11      |");
                Console.WriteLine(" |      12 -  case 12      |");
                Console.WriteLine(" |      13 -  case 13      |");
                Console.WriteLine(" |      14 -  case 14      |");
                Console.WriteLine(" |      15 -  case 15      |");
                Console.WriteLine(" |      16 -  case 16      |");
                Console.WriteLine(" |       0 -   exit        |");
                Console.WriteLine("#===========================#");
                Console.Write("Виберіть пункт меню -> ");
                switch_on = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.Clear();

                switch (switch_on)
                {
                    case 1:
                        {
                            int[] A = new int[5];
                            double[,] B = new double[3, 4];

                            Console.WriteLine("Введіть значення для масиву A (5 елементів):");
                            for (int i = 0; i < A.Length; i++)
                            {
                                Console.Write($"Елемент {i + 1}: ");
                                A[i] = Convert.ToInt32(Console.ReadLine());
                            }

                            Random random = new Random();
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    B[i, j] = random.NextDouble();
                                }
                            }

                            Console.WriteLine("Масив A:");
                            foreach (int element in A)
                            {
                                Console.Write($"{element} ");
                            }
                            Console.WriteLine();

                            Console.WriteLine("Масив B:");
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    Console.Write($"{B[i, j]} ");
                                }
                                Console.WriteLine();
                            }

                            double maxElement = B[0, 0];
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    if (B[i, j] > maxElement)
                                    {
                                        maxElement = B[i, j];
                                    }
                                }
                            }
                            Console.WriteLine($"Загальний максимальний елемент: {maxElement}");

                            double minElement = B[0, 0];
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    if (B[i, j] < minElement)
                                    {
                                        minElement = B[i, j];
                                    }
                                }
                            }
                            Console.WriteLine($"Загальний мінімальний елемент: {minElement}");

                            double sum = 0;
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    sum += B[i, j];
                                }
                            }
                            Console.WriteLine($"Загальна сума усіх елементів: {sum}");

                            double product = 1;
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    product *= B[i, j];
                                }
                            }
                            Console.WriteLine($"Загальний добуток усіх елементів: {product}");

                            int evenSum = 0;
                            foreach (int element in A)
                            {
                                if (element % 2 == 0)
                                {
                                    evenSum += element;
                                }
                            }
                            Console.WriteLine($"Сума парних елементів масиву A: {evenSum}");

                            double oddColumnsSum = 0;
                            for (int j = 0; j < 4; j += 2)
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    oddColumnsSum += B[i, j];
                                }
                            }
                            Console.WriteLine($"Сума непарних стовпців масиву B: {oddColumnsSum}");
                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();

                        }
                        break;
                    case 2:
                        {
                            int[,] array = new int[5, 5];
                            Random random = new Random();

                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    array[i, j] = random.Next(-100, 101);
                                }
                            }

                            Console.WriteLine("Масив:");
                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    Console.Write($"{array[i, j]}\t");
                                }
                                Console.WriteLine();
                            }

                            int minElement = array[0, 0];
                            int minElementRow = 0;
                            int minElementColumn = 0;
                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    if (array[i, j] < minElement)
                                    {
                                        minElement = array[i, j];
                                        minElementRow = i;
                                        minElementColumn = j;
                                    }
                                }
                            }

                            int maxElement = array[0, 0];
                            int maxElementRow = 0;
                            int maxElementColumn = 0;
                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    if (array[i, j] > maxElement)
                                    {
                                        maxElement = array[i, j];
                                        maxElementRow = i;
                                        maxElementColumn = j;
                                    }
                                }
                            }

                            int startRow = Math.Min(minElementRow, maxElementRow) + 1;
                            int endRow = Math.Max(minElementRow, maxElementRow) - 1;
                            int startColumn = Math.Min(minElementColumn, maxElementColumn) + 1;
                            int endColumn = Math.Max(minElementColumn, maxElementColumn) - 1;

                            int sum = 0;
                            for (int i = startRow; i <= endRow; i++)
                            {
                                for (int j = startColumn; j <= endColumn; j++)
                                {
                                    sum += array[i, j];
                                }
                            }

                            Console.WriteLine($"Сума елементів масиву, розташованих між мінімальним ({minElement}) і максимальним ({maxElement}) елементами: {sum}");
                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Введіть рядок:");
                            string input = Console.ReadLine();

                            Console.WriteLine("Введіть зсув:");
                            int shift = Convert.ToInt32(Console.ReadLine());

                            string encrypted = Encrypt(input, shift);
                            Console.WriteLine($"Зашифрований рядок: {encrypted}");

                            string decrypted = Decrypt(encrypted, shift);
                            Console.WriteLine($"Розшифрований рядок: {decrypted}");


                            static string Encrypt(string input, int shift)
                            {
                                string encrypted = "";

                                foreach (char c in input)
                                {
                                    if (char.IsLetter(c))
                                    {
                                        char encryptedChar = (char)(((c - 'a' + shift) % 26) + 'a');
                                        encrypted += encryptedChar;
                                    }
                                    else
                                    {
                                        encrypted += c;
                                    }
                                }

                                return encrypted;
                            }

                            static string Decrypt(string input, int shift)
                            {
                                string decrypted = "";

                                foreach (char c in input)
                                {
                                    if (char.IsLetter(c))
                                    {
                                        char decryptedChar = (char)(((c - 'a' - shift + 26) % 26) + 'a');
                                        decrypted += decryptedChar;
                                    }
                                    else
                                    {
                                        decrypted += c;
                                    }
                                }

                                return decrypted;
                            }
                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();

                        }
                        break;

                    case 4:
                        {
                            Matrix();
                            Console.WriteLine("1 - Множення матриці на число");
                            Console.WriteLine("2 - Додавання матриць");
                            Console.WriteLine("3 - Добуток матриць");
                            Console.WriteLine("0 - Вихід");
                            Console.Write("--> ");
                            int choice = int.Parse(Console.ReadLine());

                            switch (choice)
                            {
                                case 1:
                                    MultiplyByScalarOption();
                                    break;
                                case 2:
                                    AddMatricesOption();
                                    break;
                                case 3:
                                    MultiplyMatricesOption();
                                    break;
                                case 0:
                                    Environment.Exit(0);
                                    break;
                                default:
                                    Console.WriteLine("Невірний вибір");
                                    break;
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();


                            static void Matrix()
                            {
                                int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 } };
                                PrintMatrix(matrix1);

                            }
                            static void MultiplyByScalarOption()
                            {
                                int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 } };
                                int scalar = 2;

                                int[,] result = MultiplyByScalar(matrix1, scalar);

                                Console.WriteLine("Множення матриці на число:");
                                PrintMatrix(result);
                            }

                            static void AddMatricesOption()
                            {
                                int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 } };
                                int[,] matrix2 = { { 7, 8, 9 }, { 10, 11, 12 } };

                                int[,] result = AddMatrices(matrix1, matrix2);

                                Console.WriteLine("Додавання матриць:");
                                PrintMatrix(result);
                            }

                            static void MultiplyMatricesOption()
                            {
                                int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 } };
                                int[,] matrix2 = { { 7, 8, 9 }, { 10, 11, 12 } };

                                int[,] result = MultiplyMatrices(matrix1, matrix2);

                                Console.WriteLine("Добуток матриць:");
                                PrintMatrix(result);
                            }

                            static int[,] MultiplyByScalar(int[,] matrix, int scalar)
                            {
                                int rows = matrix.GetLength(0);
                                int columns = matrix.GetLength(1);
                                int[,] result = new int[rows, columns];

                                for (int i = 0; i < rows; i++)
                                {
                                    for (int j = 0; j < columns; j++)
                                    {
                                        result[i, j] = matrix[i, j] * scalar;
                                    }
                                }

                                return result;
                            }

                            static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
                            {
                                int rows = matrix1.GetLength(0);
                                int columns = matrix1.GetLength(1);
                                int[,] result = new int[rows, columns];

                                for (int i = 0; i < rows; i++)
                                {
                                    for (int j = 0; j < columns; j++)
                                    {
                                        result[i, j] = matrix1[i, j] + matrix2[i, j];
                                    }
                                }

                                return result;
                            }

                            static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
                            {
                                int rows1 = matrix1.GetLength(0);
                                int columns1 = matrix1.GetLength(1);
                                int rows2 = matrix2.GetLength(0);
                                int columns2 = matrix2.GetLength(1);

                                if (columns1 != rows2)
                                {
                                    throw new Exception("Неможливо перемножити матриці. Кількість стовпців першої матриці повинна дорівнювати кількості рядків другої матриці.");
                                }

                                int[,] result = new int[rows1, columns2];

                                for (int i = 0; i < rows1; i++)
                                {
                                    for (int j = 0; j < columns2; j++)
                                    {
                                        int sum = 0;
                                        for (int k = 0; k < columns1; k++)
                                        {
                                            sum += matrix1[i, k] * matrix2[k, j];
                                        }
                                        result[i, j] = sum;
                                    }
                                }

                                return result;
                            }

                            static void PrintMatrix(int[,] matrix)
                            {
                                int rows = matrix.GetLength(0);
                                int columns = matrix.GetLength(1);

                                for (int i = 0; i < rows; i++)
                                {
                                    for (int j = 0; j < columns; j++)
                                    {
                                        Console.Write(matrix[i, j] + " ");
                                    }
                                    Console.WriteLine();
                                }
                            }
                        }
                        break;
                    case 5:
                        {

                            Console.WriteLine("Введіть арифметичний вираз:");
                            string expression = Console.ReadLine();

                            int result = CalculateExpression(expression);
                            Console.WriteLine("Результат: " + result);


                            static int CalculateExpression(string expression)
                            {
                                int result = 0;
                                int sign = 1;
                                int num = 0;

                                for (int i = 0; i < expression.Length; i++)
                                {
                                    char c = expression[i];

                                    if (char.IsDigit(c))
                                    {
                                        num = num * 10 + (c - '0');
                                    }
                                    else if (c == '+')
                                    {
                                        result += sign * num;
                                        num = 0;
                                        sign = 1;
                                    }
                                    else if (c == '-')
                                    {
                                        result += sign * num;
                                        num = 0;
                                        sign = -1;
                                    }
                                }

                                // Додавання останнього числа до результату
                                result += sign * num;

                                return result;
                            }

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;

                    case 6:
                        {
                            Console.WriteLine("Введіть текст:");
                            string text = Console.ReadLine();

                            string result = ChangeSentenceCase(text);
                            Console.WriteLine("Результат: " + result);


                            static string ChangeSentenceCase(string text)
                            {
                                string[] sentences = text.Split('.', StringSplitOptions.RemoveEmptyEntries);

                                for (int i = 0; i < sentences.Length; i++)
                                {
                                    if (!string.IsNullOrWhiteSpace(sentences[i]))
                                    {
                                        char[] sentenceChars = sentences[i].ToCharArray();

                                        if (char.IsLetter(sentenceChars[0]))
                                        {
                                            sentenceChars[0] = char.ToUpper(sentenceChars[0]);
                                        }

                                        sentences[i] = new string(sentenceChars);
                                    }
                                }

                                string result = string.Join(". ", sentences);
                                return result;
                            }
                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Введіть текст:");
                            string text = Console.ReadLine();

                            Console.WriteLine("Введіть неприпустимі слова (розділені комою):");
                            string invalidWordsInput = Console.ReadLine();
                            string[] invalidWords = invalidWordsInput.Split(',');

                            string result = CensorText(text, invalidWords, out int replaceCount);
                            Console.WriteLine("Результат:");
                            Console.WriteLine(result);
                            Console.WriteLine("Статистика: " + replaceCount + " заміни слова");


                            static string CensorText(string text, string[] invalidWords, out int replaceCount)
                            {
                                List<string> words = new List<string>(text.Split(' '));
                                replaceCount = 0;

                                for (int i = 0; i < words.Count; i++)
                                {
                                    if (invalidWords.Contains(words[i].ToLower()))
                                    {
                                        words[i] = new string('*', words[i].Length);
                                        replaceCount++;
                                    }
                                }

                                return string.Join(' ', words);
                            }
                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 8:
                        {
                            Console.WriteLine("Введіть елементи масиву (розділені комою):");
                            string input = Console.ReadLine();
                            int[] array = input.Split(',').Select(int.Parse).ToArray();

                            int evenCount = CountEvenNumbers(array);
                            int oddCount = CountOddNumbers(array);
                            int uniqueCount = CountUniqueNumbers(array);

                            Console.WriteLine("Кількість парних елементів: " + evenCount);
                            Console.WriteLine("Кількість непарних елементів: " + oddCount);
                            Console.WriteLine("Кількість унікальних елементів: " + uniqueCount);


                            static int CountEvenNumbers(int[] array)
                            {
                                return array.Count(x => x % 2 == 0);
                            }

                            static int CountOddNumbers(int[] array)
                            {
                                return array.Count(x => x % 2 != 0);
                            }

                            static int CountUniqueNumbers(int[] array)
                            {
                                HashSet<int> uniqueNumbers = new HashSet<int>(array);
                                return uniqueNumbers.Count;
                            }
                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 9:
                        {
                            Console.WriteLine("Введіть елементи масиву (розділені комою):");
                            string input = Console.ReadLine();
                            int[] array = input.Split(',').Select(int.Parse).ToArray();

                            Console.WriteLine("Введіть значення:");
                            int threshold = int.Parse(Console.ReadLine());

                            int count = CountValuesLessThanThreshold(array, threshold);
                            Console.WriteLine("Кількість значень менших, ніж " + threshold + ": " + count);


                            static int CountValuesLessThanThreshold(int[] array, int threshold)
                            {
                                int count = 0;
                                for (int i = 0; i < array.Length; i++)
                                {
                                    if (array[i] < threshold)
                                    {
                                        count++;
                                    }
                                }
                                return count;
                            }
                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 10:
                        {
                            Console.WriteLine("Введіть три числа (розділені пробілом):");
                            string input = Console.ReadLine();
                            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

                            Console.WriteLine("Введіть елементи масиву (розділені пробілом):");
                            string arrayInput = Console.ReadLine();
                            int[] array = arrayInput.Split(' ').Select(int.Parse).ToArray();

                            int count = CountSequenceOccurrences(array, numbers);
                            Console.WriteLine("Кількість повторень послідовності: " + count);


                            static int CountSequenceOccurrences(int[] array, int[] sequence)
                            {
                                int count = 0;
                                for (int i = 0; i <= array.Length - sequence.Length; i++)
                                {
                                    bool isMatch = true;
                                    for (int j = 0; j < sequence.Length; j++)
                                    {
                                        if (array[i + j] != sequence[j])
                                        {
                                            isMatch = false;
                                            break;
                                        }
                                    }
                                    if (isMatch)
                                    {
                                        count++;
                                    }
                                }
                                return count;
                            }
                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();

                        }
                        break;
                    case 11:
                        {
                            Console.WriteLine("Введіть елементи першого масиву (розділені пробілом):");
                            string input1 = Console.ReadLine();
                            int[] array1 = input1.Split(' ').Select(int.Parse).ToArray();

                            Console.WriteLine("Введіть елементи другого масиву (розділені пробілом):");
                            string input2 = Console.ReadLine();
                            int[] array2 = input2.Split(' ').Select(int.Parse).ToArray();

                            int[] commonElements = GetCommonElements(array1, array2);

                            Console.WriteLine("Загальні елементи без повторень:");
                            foreach (int element in commonElements)
                            {
                                Console.Write(element + " ");
                            }


                            static int[] GetCommonElements(int[] array1, int[] array2)
                            {
                                int[] commonElements = array1.Intersect(array2).ToArray();
                                return commonElements;
                            }

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 12:
                        {

                            Console.WriteLine("Введіть розмірність рядків масиву:");
                            int rows = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введіть розмірність стовпців масиву:");
                            int columns = int.Parse(Console.ReadLine());

                            int[,] array = new int[rows, columns];

                            Console.WriteLine("Введіть елементи двовимірного масиву:");

                            for (int i = 0; i < rows; i++)
                            {
                                for (int j = 0; j < columns; j++)
                                {
                                    Console.Write("-> ");
                                    array[i, j] = int.Parse(Console.ReadLine());
                                }
                            }

                            int min = FindMinimum(array);
                            int max = FindMaximum(array);

                            Console.WriteLine("Мінімальне значення: " + min);
                            Console.WriteLine("Максимальне значення: " + max);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();


                            static int FindMinimum(int[,] array)
                            {
                                int min = array[0, 0];

                                foreach (int element in array)
                                {
                                    if (element < min)
                                    {
                                        min = element;
                                    }
                                }

                                return min;
                            }

                            static int FindMaximum(int[,] array)
                            {
                                int max = array[0, 0];

                                foreach (int element in array)
                                {
                                    if (element > max)
                                    {
                                        max = element;
                                    }
                                }

                                return max;
                            }
                        
                

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();

                        }
                break;
                    case 13:
                        {
                            Console.WriteLine("Введіть речення:");
                            string sentence = Console.ReadLine();

                            int wordCount = CountWords(sentence);

                            Console.WriteLine("Кількість слів у реченні: " + wordCount);
                        

                        static int CountWords(string sentence)
                        {
                            string[] words = sentence.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                            return words.Length;
                        }

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                break;
                    case 14:
                        {
                            Console.WriteLine("Введіть речення:");
                            string sentence = Console.ReadLine();

                            string reversedSentence = ReverseWords(sentence);

                            Console.WriteLine("Після перевороту: " + reversedSentence);
                        

                        static string ReverseWords(string sentence)
                        {
                            string[] words = sentence.Split(' ');

                            for (int i = 0; i < words.Length; i++)
                            {
                                char[] characters = words[i].ToCharArray();
                                Array.Reverse(characters);
                                words[i] = new string(characters);
                            }

                            return string.Join(" ", words);
                        }

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                break;
                    case 15:
                        {

                            Console.WriteLine("Введіть речення:");
                            string sentence = Console.ReadLine();

                            int vowelCount = CountVowels(sentence);

                            Console.WriteLine("Кількість голосних літер у реченні: " + vowelCount);
                        

                        static int CountVowels(string sentence)
                        {
                            int count = 0;
                            string vowels = "aeiouAEIOU";

                            foreach (char c in sentence)
                            {
                                if (vowels.Contains(c))
                                {
                                    count++;
                                }
                            }

                            return count;
                        }

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                break;
                    case 16:
                        {
                            Console.WriteLine("Введіть речення:");
                            string sentence = Console.ReadLine();

                            int vowelCount = CountVowels(sentence);

                            Console.WriteLine("Кількість голосних літер у реченні: " + vowelCount);
                        

                        static int CountVowels(string sentence)
                        {
                            int count = 0;
                            string vowels = "aeiouAEIOU";

                            foreach (char c in sentence)
                            {
                                if (vowels.Contains(c))
                                {
                                    count++;
                                }
                            }

                            return count;
                        }

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                break;

                    default:
                        break;
                }
            } while (switch_on != 0);
        }
    }
}