using System;
using System.Globalization;
using System.Text;

namespace C_
{

    public struct DailyTemperature
    {
        public DateTime Date { get; set; }
        public double HighestTemperature { get; set; }
        public double LowestTemperature { get; set; }

        public double TemperatureRange => HighestTemperature - LowestTemperature;
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
                Console.WriteLine(" |      14 -  case 14      |");
                Console.WriteLine(" |      15 -  case 15      |");
                Console.WriteLine(" |      16 -  case 16      |");
                Console.WriteLine("#===========================#");
                Console.Write("Виберіть пункт меню -> ");
                switch_on = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.Clear();

                switch (switch_on)
                {
                    case 1:
                        {
                            int[] testNumbers = { 5, 8, 13, 21, 34, 55, 100, 200, 250, 1000, 144, 145, 500 };

                            foreach (int number in testNumbers)
                            {
                                if (number.IsFibonacci())
                                    Console.WriteLine($"{number} є числом Фібоначчі.");
                                else
                                    Console.WriteLine($"{number} не є числом Фібоначчі.");
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:
                        {
                            string[] testStrings = {
            "Hello, world!",
            "This is a test string.",
            " Extension methods are useful.",
            "",
            "  Spaces  between   words    should not affect the count.  ",
            "Привіт, світ!"
        };

                            foreach (string str in testStrings)
                            {
                                int wordCount = str.WordCount();
                                Console.WriteLine($"Рядок: '{str}'\nКількість слів: {wordCount}\n");
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 3:
                        {
                            string[] testStrings = {
            "Hello, world!",
            "This is a test string.",
            " Extension methods are useful.",
            "",
            "  Spaces  between   words    should not affect the count.  ",
            "Привіт, світ!",
            "SingleWord",
            "Another_Single_Word"
        };

                            foreach (string str in testStrings)
                            {
                                int lengthOfLastWord1 = str.LengthOfLastWord1();
                                Console.WriteLine($"Рядок: '{str}'\nДовжина останнього слова: {lengthOfLastWord1}\n");
                            }
                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 4:
                        {
                            string[] testStrings = {
            "{}[]",
            "(())",
            "[{}]",
            "[}",
            "[[{]}]"
        };

                            foreach (string str in testStrings)
                            {
                                bool isValid = str.AreBracketsValid();
                                Console.WriteLine($"Рядок: '{str}'\nВалідність дужок: {isValid}\n");

                                Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 5:
                        {
                            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                            int[] evenNumbers = numbers.Filter(x => x % 2 == 0);
                            Console.WriteLine("Парні числа:");
                            Console.WriteLine(string.Join(", ", evenNumbers));

                            int[] oddNumbers = numbers.Filter(x => x % 2 != 0);
                            Console.WriteLine("\nНепарні числа:");
                            Console.WriteLine(string.Join(", ", oddNumbers));

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 6:
                        {
                            DailyTemperature[] temperatures = {
            new DailyTemperature { Date = new DateTime(2023, 7, 18), HighestTemperature = 30.5, LowestTemperature = 20.5 },
            new DailyTemperature { Date = new DateTime(2023, 7, 19), HighestTemperature = 32.0, LowestTemperature = 22.0 },
            new DailyTemperature { Date = new DateTime(2023, 7, 20), HighestTemperature = 31.0, LowestTemperature = 18.0 }
        };

                            int dayIndexWithMaxRange = FindDayWithMaxTemperatureRange(temperatures);
                            Console.WriteLine($"День з максимальною різницею між найвищою та найнижчою температурою: {temperatures[dayIndexWithMaxRange].Date:yyyy-MM-dd}");

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                        static int FindDayWithMaxTemperatureRange(DailyTemperature[] temperatures)
                        {
                            int maxRangeIndex = 0;
                            double maxRange = temperatures[0].TemperatureRange;

                            for (int i = 1; i < temperatures.Length; i++)
                            {
                                double range = temperatures[i].TemperatureRange;
                                if (range > maxRange)
                                {
                                    maxRange = range;
                                    maxRangeIndex = i;
                                }
                            }

                            return maxRangeIndex;
                        }

                    case 7:
                        {
                            StudentGrades[] students = {
            new StudentGrades { StudentName = "John Doe", Grades = new double[] { 89.5, 95.0, 78.5, 82.0 } },
            new StudentGrades { StudentName = "Jane Smith", Grades = new double[] { 92.0, 88.5, 95.5, 87.0 } },
            new StudentGrades { StudentName = "Michael Johnson", Grades = new double[] { 78.0, 85.5, 76.5, 89.0 } }
        };

                            StudentGrades studentWithMaxGrade = students.OrderByDescending(s => s.MaxGrade).First();
                            Console.WriteLine($"Студент з максимальною оцінкою: {studentWithMaxGrade.StudentName}, Оцінка: {studentWithMaxGrade.MaxGrade}");

                            StudentGrades studentWithAverageMaxGrade = students.OrderByDescending(s => s.AverageGrade).First();
                            Console.WriteLine($"Студент з найвищою середньою оцінкою: {studentWithAverageMaxGrade.StudentName}, Середня оцінка: {studentWithAverageMaxGrade.AverageGrade}");

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 8:
                        {
                            int[] testNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                            foreach (int number in testNumbers)
                            {
                                bool isOdd = number.IsOdd();
                                Console.WriteLine($"{number} є непарним: {isOdd}");
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 9:
                        {
                            int[] testNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                            foreach (int number in testNumbers)
                            {
                                bool isEven = number.IsEven();
                                Console.WriteLine($"{number} є парним: {isEven}");
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 10:
                        {
                            int[] testNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

                            foreach (int number in testNumbers)
                            {
                                bool isPrime = number.IsPrime();
                                Console.WriteLine($"{number} є простим числом: {isPrime}");
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 11:
                        {
                            string[] testStrings = {
            "Hello, world!",
            "This is a test string.",
            "Extension methods are useful.",
            "",
            "The quick brown fox jumps over the lazy dog.",
            "Привіт, світ!"
        };

                            foreach (string str in testStrings)
                            {
                                int vowelCount = str.CountVowels();
                                Console.WriteLine($"Рядок: '{str}'\nКількість голосних: {vowelCount}\n");
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 12:
                        {

                            string[] testStrings = {
            "Hello, world!",
            "This is a test string.",
            "Extension methods are useful.",
            "",
            "The quick brown fox jumps over the lazy dog.",
            "Привіт, світ!"
        };

                            foreach (string str in testStrings)
                            {
                                int consonantCount = str.CountConsonants();
                                Console.WriteLine($"Рядок: '{str}'\nКількість приголосних: {consonantCount}\n");
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 13:
                        {
                            string[] testStrings = {
            "Hello, world! This is a test string.",
            "Extension methods are useful.",
            "",
            "The quick brown fox jumps over the lazy dog. The end!",
            "Привіт, світ! Як справи?"
        };

                            foreach (string str in testStrings)
                            {
                                int sentenceCount = str.CountSentences();
                                Console.WriteLine($"Рядок: '{str}'\nКількість пропозицій: {sentenceCount}\n");
                            }


                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 14:
                        {

                            Person[] people = {
            new Person { FirstName = "John", LastName = "Doe", Age = 25 },
            new Person { FirstName = "Jane", LastName = "Smith", Age = 30 },
            new Person { FirstName = "Michael", LastName = "Johnson", Age = 22 },
            new Person { FirstName = "Emily", LastName = "Williams", Age = 28 }
        };

                            Person personWithMinAge = people.FindPersonWithMinAge();
                            Console.WriteLine($"Людина з мінімальним віком: {personWithMinAge.FirstName} {personWithMinAge.LastName}, Вік: {personWithMinAge.Age}");

                            Person personWithMaxAge = people.FindPersonWithMaxAge();
                            Console.WriteLine($"Людина з максимальним віком: {personWithMaxAge.FirstName} {personWithMaxAge.LastName}, Вік: {personWithMaxAge.Age}");

                            double averageAge = people.AverageAge();
                            Console.WriteLine($"Середній вік людей: {averageAge}");
                        
                        Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 15:
                        {
                            Point3D[] points = {
            new Point3D(0, 0, 0),
            new Point3D(1, 2, 3),
            new Point3D(-2, 5, 7),
            new Point3D(3, -1, 2)
        };

                            double maxDistance = 0;
                            Point3D point1 = null;
                            Point3D point2 = null;

                            for (int i = 0; i < points.Length; i++)
                            {
                                for (int j = i + 1; j < points.Length; j++)
                                {
                                    double distance = points[i].DistanceTo(points[j]);
                                    if (distance > maxDistance)
                                    {
                                        maxDistance = distance;
                                        point1 = points[i];
                                        point2 = points[j];
                                    }
                                }
                            }

                            Console.WriteLine($"Максимальна відстань між точками: {maxDistance}");
                            Console.WriteLine($"Точка 1: ({point1.X}, {point1.Y}, {point1.Z})");
                            Console.WriteLine($"Точка 2: ({point2.X}, {point2.Y}, {point2.Z})");
                        
              
                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;


                    case 16:
                        {
                            Fraction[] fractions = {
            new Fraction(1, 2),
            new Fraction(3, 4),
            new Fraction(2, 5),
            new Fraction(7, 3),
            new Fraction(5, 6)
        };

                            Fraction minFraction = fractions.FindMinFraction();
                            Fraction maxFraction = fractions.FindMaxFraction();

                            Console.WriteLine($"Мінімальний дріб: {minFraction.Numerator}/{minFraction.Denominator}");
                            Console.WriteLine($"Максимальний дріб: {maxFraction.Numerator}/{maxFraction.Denominator}");

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