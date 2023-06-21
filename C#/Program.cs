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
                Console.WriteLine(" |       9 -  case 9       |");
                Console.WriteLine(" |      10 -  case 10      |");
                Console.WriteLine(" |      11 -  case 11      |");
                Console.WriteLine(" |      12 -  case 12      |");
                Console.WriteLine(" |      13 -  case 13      |");
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
                        }
                        break;

                    default:
                        break;
                }
                Console.Write("\nНатисніть Enter, щоб продовжити...");
                Console.ReadLine();
                Console.Clear();
            } while (switch_on != 0);
        }
    }
}