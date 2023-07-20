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
                Console.WriteLine("#===========================#");
                Console.Write("Виберіть пункт меню -> ");
                switch_on = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.Clear();

                switch (switch_on)
                {
                    case 1:
                        {
                            int[] myArray = { 1, 2, 3, 4, 5 };

                            Array arrayObj = new Array(myArray);

                            arrayObj.Show();
                            arrayObj.Show("Це мій масив.");

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:
                        {
                            int[] myIntArray = { 5, 2, 8, 1, 6 };

                            IntArray intArrayObj = new IntArray(myIntArray);

                            Console.WriteLine($"Максимум: {intArrayObj.Max()}");
                            Console.WriteLine($"Мінімум: {intArrayObj.Min()}");
                            Console.WriteLine($"Середнє арифметичне: {intArrayObj.Avg()}");
                            Console.WriteLine($"Пошук числа 8: {intArrayObj.Search(8)}");
                            Console.WriteLine($"Пошук числа 3: {intArrayObj.Search(3)}");

                            intArrayObj.Show();

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 3:
                        {
                            int[] myIntegerArray = { 5, 2, 8, 1, 6 };

                            IntegerArray integerArrayObj = new IntegerArray(myIntegerArray);

                            Console.WriteLine("Початковий масив:");
                            integerArrayObj.Show();

                            Console.WriteLine("\nСортування за зростанням:");
                            integerArrayObj.SortAscending();
                            integerArrayObj.Show();

                            Console.WriteLine("\nСортування за спаданням:");
                            integerArrayObj.SortDescending();
                            integerArrayObj.Show();

                            Console.WriteLine("\nСортування залежно від параметра (за спаданням):");
                            integerArrayObj.SortByParam(false);
                            integerArrayObj.Show();

                            Console.WriteLine("\nСортування залежно від параметра (за зростанням):");
                            integerArrayObj.SortByParam(true);
                            integerArrayObj.Show();

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