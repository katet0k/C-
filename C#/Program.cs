using System.Globalization;
using System.Text;

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

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
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