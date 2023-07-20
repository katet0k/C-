using System.Globalization;
using System.Text;

namespace C_
{
    class Backpack
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Material { get; set; }
        public double Weight { get; set; }
        public double Capacity { get; set; }
        public double CurrentCapacity { get; private set; }
        public List<Item> Contents { get; private set; }

        public event EventHandler<Item> ItemAdded;

        public Backpack(string color, string brand, string material, double weight, double capacity)
        {
            Color = color;
            Brand = brand;
            Material = material;
            Weight = weight;
            Capacity = capacity;
            Contents = new List<Item>();
        }

        public void AddItem(Item item)
        {
            if (item.Volume + CurrentCapacity > Capacity)
                throw new Exception("Перевищено обсяг рюкзака.");

            Contents.Add(item);
            CurrentCapacity += item.Volume;

            ItemAdded?.Invoke(this, item);
        }
    }

    class Item
    {
        public string Name { get; set; }
        public double Volume { get; set; }

        public Item(string name, double volume)
        {
            Name = name;
            Volume = volume;
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
                Console.WriteLine("#===========================#");
                Console.Write("Виберіть пункт меню -> ");
                switch_on = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.Clear();

                switch (switch_on)
                {
                    case 1:
                        {
                            Func<int, bool> isEven = delegate (int number)
                            {
                                return number % 2 == 0;
                            };

                            int number1 = 10;
                            int number2 = 15;

                            Console.WriteLine($"{number1} є {(isEven(number1) ? "парним" : "непарним")} числом.");
                            Console.WriteLine($"{number2} є {(isEven(number2) ? "парним" : "непарним")} числом.");

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:
                        {
                            Func<int, int> square = delegate (int number)
                            {
                                return number * number;
                            };

                            int number1 = 5;
                            int number2 = 8;

                            Console.WriteLine($"Квадрат числа {number1} дорівнює {square(number1)}");
                            Console.WriteLine($"Квадрат числа {number2} дорівнює {square(number2)}");


                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 3:
                        {
                            Func<int, int> cube = number => number * number * number;

                            int number1 = 3;
                            int number2 = 7;

                            Console.WriteLine($"Куб числа {number1} дорівнює {cube(number1)}");
                            Console.WriteLine($"Куб числа {number2} дорівнює {cube(number2)}");

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 4:
                        {
                            Func<DateTime, bool> isProgrammersDay = date =>
                            {
                                int dayOfYear = date.DayOfYear;
                                return dayOfYear == 256;
                            };

                            DateTime date1 = new DateTime(2023, 9, 13); // 13 вересня 2023 року
                            DateTime date2 = new DateTime(2023, 9, 14); // 14 вересня 2023 року

                            Console.WriteLine($"{date1:d} є {(isProgrammersDay(date1) ? "днем програміста" : "не днем програміста")}");
                            Console.WriteLine($"{date2:d} є {(isProgrammersDay(date2) ? "днем програміста" : "не днем програміста")}");

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 5:
                        {
                            Func<int[], int> findMax = arr =>
                            {
                                int max = arr[0];
                                for (int i = 1; i < arr.Length; i++)
                                {
                                    if (arr[i] > max)
                                        max = arr[i];
                                }
                                return max;
                            };

                            int[] numbers = { 5, 8, 2, 10, 3, 7 };

                            Console.WriteLine($"Максимальне значення в масиві: {findMax(numbers)}");


                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 6:
                        {
                            Func<int[], int> findMin = arr =>
                            {
                                int min = arr[0];
                                for (int i = 1; i < arr.Length; i++)
                                {
                                    if (arr[i] < min)
                                        min = arr[i];
                                }
                                return min;
                            };

                            int[] numbers = { 5, 8, 2, 10, 3, 7 };

                            Console.WriteLine($"Мінімальне значення в масиві: {findMin(numbers)}");

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 7:
                        {
                            Func<int[], int[]> findOddNumbers = arr =>
                            {
                                return Array.FindAll(arr, number => number % 2 != 0);
                            };

                            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                            int[] oddNumbers = findOddNumbers(numbers);

                            Console.WriteLine("Непарні числа в масиві:");
                            foreach (int number in oddNumbers)
                            {
                                Console.Write(number + " ");
                            }
                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;


                    case 8:
                        {
                            Func<string, (int, int, int)> getRGBValue = color =>
                            {
                                switch (color)
                                {
                                    case "red":
                                        return (255, 0, 0);
                                    case "orange":
                                        return (255, 165, 0);
                                    case "yellow":
                                        return (255, 255, 0);
                                    case "green":
                                        return (0, 128, 0);
                                    case "blue":
                                        return (0, 0, 255);
                                    case "indigo":
                                        return (75, 0, 130);
                                    case "violet":
                                        return (148, 0, 211);
                                    default:
                                        return (0, 0, 0); // Повернемо чорний колір як захист від некоректного вводу
                                }
                            };

                            string color1 = "red";
                            string color2 = "blue";
                            string color3 = "pink"; // Некоректний колір

                            (int r1, int g1, int b1) = getRGBValue(color1);
                            (int r2, int g2, int b2) = getRGBValue(color2);
                            (int r3, int g3, int b3) = getRGBValue(color3);

                            Console.WriteLine($"{color1} - RGB: ({r1}, {g1}, {b1})");
                            Console.WriteLine($"{color2} - RGB: ({r2}, {g2}, {b2})");
                            Console.WriteLine($"{color3} - RGB: ({r3}, {g3}, {b3})");
                        
                        Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 9:
                        {
                            Backpack myBackpack = new Backpack("blue", "XYZ", "nylon", 1.2, 20);

                            myBackpack.ItemAdded += (sender, item) =>
                            {
                                Console.WriteLine($"Додано в рюкзак: {item.Name} (Об'єм: {item.Volume} л)");
                            };

                            try
                            {
                                myBackpack.AddItem(new Item("Книга", 2.5));
                                myBackpack.AddItem(new Item("Вода", 1.0));
                                myBackpack.AddItem(new Item("Фотоапарат", 3.0));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }break;

                    case 10:
                        {
                            Func<int[], int> countMultiplesOfSeven = arr =>
                            {
                                int count = 0;
                                foreach (int number in arr)
                                {
                                    if (number % 7 == 0)
                                        count++;
                                }
                                return count;
                            };

                            int[] numbers = { 7, 14, 21, 10, 35, 42, 17 };

                            Console.WriteLine($"Кількість чисел у масиві, кратних семи: {countMultiplesOfSeven(numbers)}");

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }break;

                    case 11:
                        {
                            Func<int[], int> countPositiveNumbers = arr =>
                            {
                                int count = 0;
                                foreach (int number in arr)
                                {
                                    if (number > 0)
                                        count++;
                                }
                                return count;
                            };

                            int[] numbers = { -5, 10, 0, 7, -2, 3, -8, 12 };

                            Console.WriteLine($"Кількість позитивних чисел у масиві: {countPositiveNumbers(numbers)}");

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 12:
                        {    
                            Action<int[]> displayUniqueNegativeNumbers = arr =>
                            {
                                HashSet<int> uniqueNegativeNumbers = new HashSet<int>();
                                foreach (int number in arr)
                                {
                                    if (number < 0)
                                        uniqueNegativeNumbers.Add(number);
                                }

                                Console.WriteLine("Унікальні негативні числа у масиві:");
                                foreach (int number in uniqueNegativeNumbers)
                                {
                                    Console.Write(number + " ");
                                }
                            };

                            int[] numbers = { -5, -2, 3, -8, -2, -1, -5, -7, 3, -1 };

                            displayUniqueNegativeNumbers(numbers);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 13:
                        {
                            Func<string, string, bool> isTextContainsWord = (text, word) =>
                            {
                                return text.Contains(word);
                            };

                            string inputText = "Це текст для тестування лямбда-виразу.";
                            string wordToFind = "текст";

                            if (isTextContainsWord(inputText, wordToFind))
                            {
                                Console.WriteLine($"Текст містить слово '{wordToFind}'.");
                            }
                            else
                            {
                                Console.WriteLine($"Текст не містить слово '{wordToFind}'.");
                            }

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