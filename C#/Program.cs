using System.Globalization;
using System.Text;
using System.Linq;

namespace C_
{
    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }

    public class Array : ICalc
    {
        private int[] numbers;

        public Array(int[] numbers)
        {
            this.numbers = numbers;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (number < valueToCompare)
                    count++;
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (number > valueToCompare)
                    count++;
            }
            return count;
        }
    }

    interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }

    class ArrayContainer : IOutput2
    {
        private int[] data;

        public ArrayContainer(int[] array)
        {
            data = array;
        }

        public void ShowEven()
        {
            Console.WriteLine("Even numbers:");
            foreach (int num in data)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }

        public void ShowOdd()
        {
            Console.WriteLine("Odd numbers:");
            foreach (int num in data)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }

    public interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }

    public class Array1 : ICalc2
    {
        private int[] data;

        public Array1(int[] values)
        {
            data = values;
        }

        public int CountDistinct()
        {
            HashSet<int> distinctValues = new HashSet<int>(data);
            return distinctValues.Count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (int value in data)
            {
                if (value == valueToCompare)
                {
                    count++;
                }
            }
            return count;
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
                Console.WriteLine("#===========================#");
                Console.Write("Виберіть пункт меню -> ");
                switch_on = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.Clear();

                switch (switch_on)
                {
                    case 1:
                        {
                            int[] numbers = { 1, 5, 2, 7, 3, 9, 4, 6 };
                            Array array = new Array(numbers);

                            int lessCount = array.Less(5);
                            Console.WriteLine($"Number of elements less than 5: {lessCount}");

                            int greaterCount = array.Greater(5);
                            Console.WriteLine($"Number of elements greater than 5: {greaterCount}");

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        {
                            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                            ArrayContainer container = new ArrayContainer(array);
                            container.ShowEven();
                            container.ShowOdd();

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                        case 3:
                        {
                            int[] values = { 1, 2, 3, 4, 5, 3, 2, 1 };
                            Array1 array = new Array1(values);

                            int distinctCount = array.CountDistinct();
                            Console.WriteLine("Distinct count: " + distinctCount);

                            int valueToCompare = 2;
                            int equalToValueCount = array.EqualToValue(valueToCompare);
                            Console.WriteLine("Count equal to " + valueToCompare + ": " + equalToValueCount);


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