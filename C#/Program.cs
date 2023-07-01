using System.Drawing;
using System.Globalization;
using System.Text;

namespace C_
{
    internal class Program
    {
        public delegate void MessageDelegate(string message);

        public class MessageApp
        {
            public void DisplayMessage(string message)
            {
                Console.WriteLine($"Звичайне повідомлення: {message}");
            }

            public void DisplayUppercaseMessage(string message)
            {
                Console.WriteLine($"Повідомлення у великих літерах: {message.ToUpper()}");
            }

            public void DisplayLowercaseMessage(string message)
            {
                Console.WriteLine($"Повідомлення у малих літерах: {message.ToLower()}");
            }
        }

        public delegate double ArithmeticOperation(double a, double b);

        public class ArithmeticCalculator
        {
            public double Add(double a, double b)
            {
                return a + b;
            }

            public double Subtract(double a, double b)
            {
                return a - b;
            }

            public double Multiply(double a, double b)
            {
                return a * b;
            }
        }

        public class NumberChecker
        {
            public bool IsEven(int number)
            {
                if (number % 2 == 0) {
                    return true;
                }
                else
                {
                    return false;
                }   
            }


            public bool IsPrime(int number)
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

            public bool IsFibonacci(int number)
            {
                int a = 0;
                int b = 1;

                while (a <= number)
                {
                    if (a == number)
                        return true;

                    int temp = a;
                    a = b;
                    b = temp + b;
                }

                return false;
            }
        }

        static void Main(string[] args)
        {
            
            CultureInfo culture = new CultureInfo("uk-UA");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            Console.OutputEncoding = Encoding.UTF8;


            int switch_on;

            do {
                Console.WriteLine("\n#===========================#");
                Console.WriteLine(" |       1 -  case 1       |");
                Console.WriteLine(" |       2 -  case 2       |");
                Console.WriteLine(" |       3 -  case 3       |");
                Console.WriteLine(" |       4 -  case 4       |");
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
                            MessageApp messageApp = new MessageApp();
                            
                            MessageDelegate messageDelegate = messageApp.DisplayMessage;
                            messageDelegate += messageApp.DisplayUppercaseMessage;
                            messageDelegate += messageApp.DisplayLowercaseMessage;

                            messageDelegate("Hello world!");

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                break;

                    case 2:
                        {
                            ArithmeticCalculator calculator = new ArithmeticCalculator();

                            ArithmeticOperation addDelegate = calculator.Add;
                            ArithmeticOperation subtractDelegate = calculator.Subtract;
                            ArithmeticOperation multiplyDelegate = calculator.Multiply;

                            double a = 10;
                            double b = 5;

                            double result = addDelegate(a, b);
                            Console.WriteLine($"{a} + {b} = {result}");

                            result = subtractDelegate(a, b);
                            Console.WriteLine($"{a} - {b} = {result}");

                            result = multiplyDelegate(a, b);
                            Console.WriteLine($"{a} * {b} = {result}");

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;

                    case 3:
                        {
                            NumberChecker checker = new NumberChecker();

                            Predicate<int> isEvenPredicate = checker.IsEven;
                            Predicate<int> isPrimePredicate = checker.IsPrime;
                            Predicate<int> isFibonacciPredicate = checker.IsFibonacci;

                            int number = 11;

                            bool isEven = isEvenPredicate(number);
                            if( isEven == true)
                            {
                                Console.WriteLine($"Число {number} парне");
                            }
                            else
                            {
                                Console.WriteLine($"Число {number} непарне");
                            }
                           

                            bool isPrime = isPrimePredicate(number);
                            if (isPrime == true)
                            {
                                Console.WriteLine($"Число {number} просте");
                            }
                            else
                            {
                                Console.WriteLine($"Число {number} непросте");
                            }

                            bool isFibonacci = isFibonacciPredicate(number);
                            if (isFibonacci == true)
                            {
                                Console.WriteLine($"Число {number} належить до послідовності Фібоначчі");
                            }
                            else
                            {
                                Console.WriteLine($"Число {number} не належить до послідовності Фібоначчі");
                            }

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();

                        }
                break;
                    case 4:
                        {
                            ArithmeticCalculator calculator = new ArithmeticCalculator();

                            ArithmeticOperation addDelegate = calculator.Add;
                            ArithmeticOperation subtractDelegate = calculator.Subtract;
                            ArithmeticOperation multiplyDelegate = calculator.Multiply;

                            double a = 10;
                            double b = 5;

                            double result = addDelegate.Invoke(a, b);
                            Console.WriteLine($"{a} + {b} = {result}");

                            result = subtractDelegate.Invoke(a, b);
                            Console.WriteLine($"{a} - {b} = {result}");

                            result = multiplyDelegate.Invoke(a, b);
                            Console.WriteLine($"{a} * {b} = {result}");

                            Console.Write("\nНатисніть Enter, щоб продовжити...");
                            Console.ReadLine();
                            Console.Clear();

                        }
                        break;

                    default:
                        break;
                }

            }while (switch_on != 0);
        }
    }
}