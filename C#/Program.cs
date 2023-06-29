using System.Drawing;
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
           

            int option;
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
                Console.WriteLine(" |       0 -   exit        |");
                Console.WriteLine("#===========================#");
                Console.Write("Виберіть пункт меню -> ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.Clear();

                switch (option)
                {
                    case 1:
                        {
                            int? num = null;
                            Console.WriteLine("Якщо число кратне 3 (ділиться на 3 без залишку), \r\nвиводится слово Fizz. Якщо число кратне 5, виводится \r\nслово Buzz. Якщо число кратне 3 і 5, виводится Fizz\r\nBuzz. Якщо число не кратне ні 3, ані 5, виводится \r\nтільки число.\n");
                            Console.Write("Введіть число від 1 до 100 -> ");
                            num = Convert.ToInt32(Console.ReadLine());

                            while (num < 1 || num > 100)
                            {
                                Console.Write("Введіть число від 1 до 100 -> ");
                                num = Convert.ToInt32(Console.ReadLine());
                            }

                            if (num % 3 == 0 && num % 5 == 0)
                            {
                                Console.WriteLine("Fizz");
                                Console.WriteLine("Buzz");
                            }
                            else if (num % 3 == 0)
                            {
                                Console.WriteLine("Fizz");
                            }
                            else if (num % 5 == 0)
                            {
                                Console.WriteLine("Buzz");
                            }
                            else
                            {
                                Console.WriteLine(num);
                            }

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;

                    case 2:
                        {

                            Console.WriteLine("Перше число — це значення, друге\nчисло — відсоток, який підраховує додаток\n");
                            double? num1 = null;
                            double? num2 = null;
                            Console.Write("Введіть число -> ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введіть відсоток -> ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write($"{num2} відсотків від {num1} = {(num1 / 100) * num2} \n");

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Створює число, яке містить введені цифри\n");
                            int? num1 = null;
                            int? num2 = null;
                            int? num3 = null;
                            int? num4 = null;

                            Console.Write("Введіть цифру -> ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введіть цифру -> ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введіть цифру -> ");
                            num3 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введіть цифру -> ");
                            num4 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"сформоване число -> {num1}{num2}{num3}{num4} ");


                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();

                        }
                        break;
                    case 4:
                        {

                            Console.WriteLine("Введіть шестизначне число:");
                            int number = Convert.ToInt32(Console.ReadLine());

                            if (number < 100000 || number > 999999)
                            {
                                Console.Write("Помилка! Введіть шестизначне число.");
                                Console.ReadLine();
                                return;
                            }

                            Console.Write("Введіть номери розрядів для заміни цифр (наприклад, 1 і 6):");
                            string input = Console.ReadLine();
                            string[] indices = input.Split(' ');

                            if (indices.Length != 2)
                            {
                                Console.WriteLine("Помилка! Введіть два номери розрядів через пробіл.");
                                Console.ReadLine();
                                return;
                            }

                            int index1 = Convert.ToInt32(indices[0]);
                            int index2 = Convert.ToInt32(indices[1]);

                            if (index1 < 1 || index1 > 6 || index2 < 1 || index2 > 6)
                            {
                                Console.WriteLine("Помилка! Введіть номери розрядів від 1 до 6.");
                                Console.ReadLine();
                                return;
                            }

                            int result = ReplaceDigits(number, index1, index2);
                            Console.WriteLine("Результат: " + result);

                            Console.ReadLine();


                            static int ReplaceDigits(int number, int index1, int index2)
                            {
                                char[] digits = number.ToString().ToCharArray();

                                char temp = digits[index1 - 1];
                                digits[index1 - 1] = digits[index2 - 1];
                                digits[index2 - 1] = temp;

                                return Convert.ToInt32(new string(digits));
                            }

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Додаток відображає назву пори року і дня тижня.\n");
                            Console.WriteLine("Введіть дату у форматі дд.мм.рррр:");
                            string input = Console.ReadLine();
                            DateTime date;

                            if (DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out date))
                            {
                                string season = GetSeason(date);
                                string dayOfWeek = date.ToString("dddd");

                                Console.WriteLine($"{season} {dayOfWeek}");
                            }
                            else
                            {
                                Console.WriteLine("Некоректний формат дати.");
                            }

                            
                        

                        static string GetSeason(DateTime date)
                        {
                            int month = date.Month;

                            if (month >= 3 && month <= 5)
                            {
                                return "Spring";
                            }
                            else if (month >= 6 && month <= 8)
                            {
                                return "Summer";
                            }
                            else if (month >= 9 && month <= 11)
                            {
                                return "Autumn";
                            }
                            else
                            {
                                return "Winter";
                            }

                        }
                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Додаток конвертує температуру з Фаренгейта в Цельсій, або навпаки\n");

                            float? c = null; 
                            float? f = null;
                            int? num = null;
                            do
                            {
                                Console.WriteLine("\n#---------------------------#");
                                Console.WriteLine(" |     1 -  °C -->  °F     |");
                                Console.WriteLine(" |     2 -  °F -->  °C     |");
                                Console.WriteLine(" |     0 -    exit         |");
                                Console.WriteLine("#---------------------------#");
                                num = Convert.ToInt32(Console.ReadLine());

                                switch (num)
                                {
                                    case 1:
                                        {
                                            Console.Write("Введіть температуру в Цельсіях -> ");
                                            c = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine($"°C = {c}\n°F = {c * 9 / 5 + 32}");

                                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                                            Console.ReadLine();
                                            Console.Clear();
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.Write("Введіть температуру в Фаренгейта -> ");
                                            f = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine($"°F = {f}\n°C = {(f - 32) * 5 / 9}");

                                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                                            Console.ReadLine();
                                            Console.Clear();
                                        }
                                        break;

                                    default:
                                        break;
                                }
                            } while (num > 0); 

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();


                        }
                        break;
                    case 7:
                        {

                            Console.WriteLine("Додаток показує усі парні числа у вказаному діапазоні\n");
                            int num1 = 0;
                            int num2 = 0;

                            Console.Write("Введіть число -> ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введіть число -> ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            
                            if(num1 > num2)
                            {
                                int n = num1;
                                num1 = num2;
                                num2 = n;
                            }

                            if(num1 == num2)
                            {
                                Console.WriteLine("\nError");
                            }
                                 
                            for (int i = num1; i < num2; i++)
                            {
                                if(i % 2 == 0)
                                {
                                    Console.WriteLine(i);

                                }
                                else
                                {
                                    Console.WriteLine(" ");
                                }

                            }

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();

                        }
                        break;
                    case 8:
                        {
                            Console.WriteLine("Виведить на екран цитату Б'ярна Страуструпа\n");
                            Console.WriteLine("It's easy to win forgiveness for being wrong; \r\nbeing right is what gets you into real trouble.\r\nBjarne Stroustrup\n"); 

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 9:
                        {
                            int num1 = 0;
                            int num2 = 0;
                            int num3 = 0;
                            int num4 = 0;
                            int num5 = 0;
                            Console.WriteLine("Знаходить суму чисел, максимум і мінімум з п'яти чисел, добуток чисел. ");
                            Console.Write("Введіть число -> ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введіть число -> ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введіть число -> ");
                            num3 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введіть число -> ");
                            num4 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введіть число -> ");
                            num5 = Convert.ToInt32(Console.ReadLine());

                            int[] min = {num1,num2,num3,num4,num5};
                            int[] max = {num1,num2,num3,num4,num5};

                            Console.Write($"\nСумма = {num1 + num2 + num3 + num4 + num5}\nMaМаксимальне число = {max.Max()}\nМінімальне число = {min.Min()}\nДобуток = {num1*num2*num3*num4*num5}\n");

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 10:
                        {
                            Console.WriteLine("Введіть шестизначне число:");
                            int number = int.Parse(Console.ReadLine());

                            int reversedNumber = ReverseNumber(number);

                            Console.WriteLine("Результат: " + reversedNumber);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();


                            static int ReverseNumber(int number)
                            {
                                int reversedNumber = 0;

                                while (number > 0)
                                {
                                    int digit = number % 10;
                                    reversedNumber = reversedNumber * 10 + digit;
                                    number /= 10;
                                }

                                return reversedNumber;
                            }

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 11:
                        {
                            Console.WriteLine("Додаток показує усі числа Фібоначчі з вказаного вами nдіапазону");

                            int num1 = 0;
                            int num2 = 0;

                            Console.Write("Введіть число -> ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введіть число -> ");
                            num2 = Convert.ToInt32(Console.ReadLine());

                            if (num1 > num2)
                            {
                                int n = num1;
                                num1 = num2;
                                num2 = n;
                            }
                            if (num1 == num2)
                            {
                                Console.WriteLine("\nError");
                            }
                            for (int i = 0; i < num2; i++)
                            {
                                i += num1;
                                Console.WriteLine(i);
                            }


                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 12:
                        {
                            Console.WriteLine("Введіть число A:");
                            int A = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Введіть число B (B повинно бути більшим за A):");
                            int B = Convert.ToInt32(Console.ReadLine());

                            if (A >= B)
                            {
                                Console.WriteLine("Помилка: B повинно бути більшим за A.");
                                return;
                            }

                            for (int i = A; i <= B; i++)
                            {
                                for (int j = 0; j < i; j++)
                                {
                                    Console.Write($"{i} ");
                                }
                                Console.WriteLine();
                            }
                                Console.Write("\nНатисніть Enter, щоб продовжити...");
                                Console.ReadLine();
                                Console.Clear();
                            
                        }
                        break;
                    case 13:
                        {
                            Console.WriteLine("Введіть довжину лінії:");
                            int length = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Введіть символ заповнювач:");
                            char fillSymbol = Convert.ToChar(Console.ReadLine());

                            Console.WriteLine("Введіть напрямок лінії (горизонтальна - H, вертикальна - V):");
                            char direction = Convert.ToChar(Console.ReadLine());

                            if (direction == 'H')
                            {
                                for (int i = 0; i < length; i++)
                                {
                                    Console.Write(fillSymbol);
                                }
                            }
                            else if (direction == 'V')
                            {
                                for (int i = 0; i < length; i++)
                                {
                                    Console.WriteLine(fillSymbol);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Помилка: неправильний напрямок лінії.");
                            }
                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;

                    default:
                        break;
                }
            } while (option > 0);

        }
    }
}