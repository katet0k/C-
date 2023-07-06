using System.Globalization;
using System.Text;
using System;


namespace C_
{

    using System;
    using System.Collections.Generic;

    public class ArrayOperations
    {
        public delegate bool NumberFilterDelegate(int number);

        public static List<int> FilterArray(int[] array, NumberFilterDelegate filterDelegate)
        {
            List<int> result = new List<int>();

            foreach (int number in array)
            {
                if (filterDelegate(number))
                {
                    result.Add(number);
                }
            }

            return result;
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static List<int> GetFibonacciNumbers(int limit)
        {
            List<int> fibonacciNumbers = new List<int>();

            int previous = 0;
            int current = 1;

            while (current <= limit)
            {
                fibonacciNumbers.Add(current);

                int next = previous + current;
                previous = current;
                current = next;
            }

            return fibonacciNumbers;
        }
    }

public class CreditCard
    {
        public event Action<double> AccountReplenished;
        public event Action<double> MoneySpent;
        public event Action CreditStarted;
        public event Action<double> CreditLimitReached;
        public event Action PinChanged;

        public string CardNumber { get; }
        public string CardHolderName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string PIN { get; private set; }
        public double CreditLimit { get; }
        public double AccountBalance { get; private set; }

        public CreditCard(string cardNumber, string cardHolderName, DateTime expiryDate, string pin, double creditLimit)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            ExpiryDate = expiryDate;
            PIN = pin;
            CreditLimit = creditLimit;
        }

        public void ReplenishAccount(double amount)
        {
            AccountBalance += amount;
            AccountReplenished?.Invoke(amount);
        }

        public void SpendMoney(double amount)
        {
            if (amount <= AccountBalance)
            {
                AccountBalance -= amount;
                MoneySpent?.Invoke(amount);
            }
            else if (amount <= AccountBalance + CreditLimit)
            {
                AccountBalance -= amount;
                CreditStarted?.Invoke();
                MoneySpent?.Invoke(amount);
            }
            else
            {
                CreditLimitReached?.Invoke(amount);
            }
        }

        public void ChangePIN(string newPin)
        {
            PIN = newPin;
            PinChanged?.Invoke();
        }
    }

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
                            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                            List<int> evenNumbers = ArrayOperations.FilterArray(numbers, ArrayOperations.IsEven);
                            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));

                            List<int> oddNumbers = ArrayOperations.FilterArray(numbers, ArrayOperations.IsOdd);
                            Console.WriteLine("Odd Numbers: " + string.Join(", ", oddNumbers));

                            List<int> primeNumbers = ArrayOperations.FilterArray(numbers, ArrayOperations.IsPrime);
                            Console.WriteLine("Prime Numbers: " + string.Join(", ", primeNumbers));

                            List<int> fibonacciNumbers = ArrayOperations.GetFibonacciNumbers(100);
                            Console.WriteLine("Fibonacci Numbers: " + string.Join(", ", fibonacciNumbers));


                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        {
                            Action displayTime = () =>
                            {
                                DateTime currentTime = DateTime.Now;
                                Console.WriteLine("Current Time: " + currentTime.ToString("HH:mm:ss"));
                            };

                            Action displayDate = () =>
                            {
                                DateTime currentDate = DateTime.Now;
                                Console.WriteLine("Current Date: " + currentDate.ToString("yyyy-MM-dd"));
                            };

                            Action displayDayOfWeek = () =>
                            {
                                DateTime currentDate = DateTime.Now;
                                Console.WriteLine("Current Day of Week: " + currentDate.ToString("dddd"));
                            };

                            Predicate<double> isPositive = number => number > 0;

                            Func<double, double, double, double> calculateTriangleArea = (baseLength, height, _) => 0.5 * baseLength * height;

                            Func<double, double, double> calculateRectangleArea = (length, width) => length * width;

                            displayTime();
                            displayDate();
                            displayDayOfWeek();

                            double baseLength = 5;
                            double height = 3;
                            double triangleArea = calculateTriangleArea(baseLength, height, 0);
                            Console.WriteLine("Triangle Area: " + triangleArea);

                            double length = 4;
                            double width = 6;
                            double rectangleArea = calculateRectangleArea(length, width);
                            Console.WriteLine("Rectangle Area: " + rectangleArea);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        break;
                    case 3:
                        {
                            CreditCard card = new CreditCard("1234567890123456", "John Doe", DateTime.Now.AddYears(5), "1234", 5000);

                            card.AccountReplenished += amount => Console.WriteLine("Account replenished: +" + amount);
                            card.MoneySpent += amount => Console.WriteLine("Money spent: -" + amount);
                            card.CreditStarted += () => Console.WriteLine("Credit started");
                            card.CreditLimitReached += amount => Console.WriteLine("Credit limit reached: " + amount);
                            card.PinChanged += () => Console.WriteLine("PIN changed");

                            card.ReplenishAccount(1000);
                            card.SpendMoney(800);
                            card.SpendMoney(3000);
                            card.SpendMoney(2000);
                            card.ChangePIN("5678");

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