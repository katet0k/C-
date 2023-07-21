using System.Globalization;
using System.Text;

namespace C_
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string SchoolName { get; set; }
    }
    class Employee
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
    }

    class Firm
    {
        public string FirmName { get; set; }
        public DateTime FoundingDate { get; set; }
        public string BusinessProfile { get; set; }
        public string DirectorName { get; set; }
        public int EmployeeCount { get; set; }
        public string Address { get; set; }
        public List<Employee> Employees { get; set; } 

        public Firm()
        {
            Employees = new List<Employee>();
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
                Console.WriteLine("#===========================#");
                Console.Write("Виберіть пункт меню -> ");
                switch_on = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.Clear();

                switch (switch_on)
                {
                    case 1:
                        {
                            int[] numbers = { 12, 7, 5, 24, 16, 9, 14, 8, 21, 36, 42 };

                            // Отримати весь масив цілих
                            Console.WriteLine("Весь масив цілих: ");
                            foreach (int num in numbers)
                            {
                                Console.Write(num + " ");
                            }
                            Console.WriteLine("\n");

                            // Отримати парні цілі
                            var evenNumbers = numbers.Where(num => num % 2 == 0).ToArray();
                            Console.WriteLine("Парні цілі: ");
                            foreach (int num in evenNumbers)
                            {
                                Console.Write(num + " ");
                            }
                            Console.WriteLine("\n");

                            // Отримати непарні цілі
                            var oddNumbers = numbers.Where(num => num % 2 != 0).ToArray();
                            Console.WriteLine("Непарні цілі: ");
                            foreach (int num in oddNumbers)
                            {
                                Console.Write(num + " ");
                            }
                            Console.WriteLine("\n");

                            // Отримати значення більше заданого
                            int targetValue = 20;
                            var greaterThanTarget = numbers.Where(num => num > targetValue).ToArray();
                            Console.WriteLine($"Значення більше {targetValue}: ");
                            foreach (int num in greaterThanTarget)
                            {
                                Console.Write(num + " ");
                            }
                            Console.WriteLine("\n");

                            // Отримати числа в заданому діапазоні
                            int lowerBound = 10;
                            int upperBound = 30;
                            var numbersInRange = numbers.Where(num => num >= lowerBound && num <= upperBound).ToArray();
                            Console.WriteLine($"Числа у діапазоні від {lowerBound} до {upperBound}: ");
                            foreach (int num in numbersInRange)
                            {
                                Console.Write(num + " ");
                            }
                            Console.WriteLine("\n");

                            // Отримати числа, кратні семи та відсортовані за зростанням
                            var multiplesOfSeven = numbers.Where(num => num % 7 == 0).OrderBy(num => num).ToArray();
                            Console.WriteLine("Числа, кратні семи та відсортовані за зростанням: ");
                            foreach (int num in multiplesOfSeven)
                            {
                                Console.Write(num + " ");
                            }
                            Console.WriteLine("\n");

                            // Отримати числа, кратні восьми та відсортовані за спаданням
                            var multiplesOfEight = numbers.Where(num => num % 8 == 0).OrderByDescending(num => num).ToArray();
                            Console.WriteLine("Числа, кратні восьми та відсортовані за спаданням: ");
                            foreach (int num in multiplesOfEight)
                            {
                                Console.Write(num + " ");
                            }
                            Console.WriteLine("\n");
                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:
                        {
                            string[] cities = { "Kyiv", "Lviv", "New York", "London", "Amsterdam", "Berlin", "Munich", "Oslo" };

                            // Отримати весь масив міст
                            Console.WriteLine("Весь масив міст: ");
                            foreach (string city in cities)
                            {
                                Console.Write(city + " ");
                            }
                            Console.WriteLine("\n");

                            // Отримати міста з довжиною назви, що дорівнює заданому
                            int targetLength = 6;
                            var citiesWithTargetLength = cities.Where(city => city.Length == targetLength).ToArray();
                            Console.WriteLine($"Міста з довжиною назви {targetLength}: ");
                            foreach (string city in citiesWithTargetLength)
                            {
                                Console.Write(city + " ");
                            }
                            Console.WriteLine("\n");

                            // Отримати міста, назви яких починаються з літери A
                            var citiesStartingWithA = cities.Where(city => city.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToArray();
                            Console.WriteLine("Міста, назви яких починаються з літери A: ");
                            foreach (string city in citiesStartingWithA)
                            {
                                Console.Write(city + " ");
                            }
                            Console.WriteLine("\n");

                            // Отримати міста, назви яких закінчуються літерою M
                            var citiesEndingWithM = cities.Where(city => city.EndsWith("M", StringComparison.OrdinalIgnoreCase)).ToArray();
                            Console.WriteLine("Міста, назви яких закінчуються літерою M: ");
                            foreach (string city in citiesEndingWithM)
                            {
                                Console.Write(city + " ");
                            }
                            Console.WriteLine("\n");

                            // Отримати міста, назви яких починаються з літери N і закінчуються літерою K
                            var citiesStartingWithNAndEndingWithK = cities.Where(city => city.StartsWith("N", StringComparison.OrdinalIgnoreCase) && city.EndsWith("K", StringComparison.OrdinalIgnoreCase)).ToArray();
                            Console.WriteLine("Міста, назви яких починаються з літери N і закінчуються літерою K: ");
                            foreach (string city in citiesStartingWithNAndEndingWithK)
                            {
                                Console.Write(city + " ");
                            }
                            Console.WriteLine("\n");

                            // Отримати міста, назви яких починаються з Ne та відсортувати за спаданням
                            var citiesStartingWithNe = cities.Where(city => city.StartsWith("Ne", StringComparison.OrdinalIgnoreCase)).OrderByDescending(city => city).ToArray();
                            Console.WriteLine("Міста, назви яких починаються з Ne та відсортовані за спаданням: ");
                            foreach (string city in citiesStartingWithNe)
                            {
                                Console.Write(city + " ");
                            }
                            Console.WriteLine("\n");
                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        {
                            Student[] students = {
            new Student { FirstName = "John", LastName = "Doe", Age = 21, SchoolName = "MIT" },
            new Student { FirstName = "Boris", LastName = "Johnson", Age = 20, SchoolName = "Oxford" },
            new Student { FirstName = "Alice", LastName = "Smith", Age = 18, SchoolName = "Harvard" },
            new Student { FirstName = "Brooklyn", LastName = "Jones", Age = 19, SchoolName = "Oxford" },
            new Student { FirstName = "Boris", LastName = "Brown", Age = 22, SchoolName = "MIT" }
        };

                            // Отримати весь масив студентів
                            Console.WriteLine("Весь масив студентів:");
                            foreach (var student in students)
                            {
                                Console.WriteLine($"{student.FirstName} {student.LastName}, {student.Age} років, {student.SchoolName}");
                            }
                            Console.WriteLine("\n");

                            // Отримати список студентів з ім'ям Boris
                            var studentsWithFirstNameBoris = students.Where(student => student.FirstName == "Boris").ToList();
                            Console.WriteLine("Список студентів з ім'ям Boris:");
                            foreach (var student in studentsWithFirstNameBoris)
                            {
                                Console.WriteLine($"{student.FirstName} {student.LastName}, {student.Age} років, {student.SchoolName}");
                            }
                            Console.WriteLine("\n");

                            // Отримати список студентів з прізвищем, яке починається з Bro
                            var studentsWithLastNameStartingWithBro = students.Where(student => student.LastName.StartsWith("Bro")).ToList();
                            Console.WriteLine("Список студентів з прізвищем, яке починається з Bro:");
                            foreach (var student in studentsWithLastNameStartingWithBro)
                            {
                                Console.WriteLine($"{student.FirstName} {student.LastName}, {student.Age} років, {student.SchoolName}");
                            }
                            Console.WriteLine("\n");

                            // Отримати список студентів, старших 19 років
                            var studentsAbove19YearsOld = students.Where(student => student.Age > 19).ToList();
                            Console.WriteLine("Список студентів, старших 19 років:");
                            foreach (var student in studentsAbove19YearsOld)
                            {
                                Console.WriteLine($"{student.FirstName} {student.LastName}, {student.Age} років, {student.SchoolName}");
                            }
                            Console.WriteLine("\n");

                            // Отримати список студентів, старших 20 років і молодших 23 років
                            var studentsBetween20And23YearsOld = students.Where(student => student.Age >= 20 && student.Age <= 23).ToList();
                            Console.WriteLine("Список студентів, старших 20 років і молодших 23 років:");
                            foreach (var student in studentsBetween20And23YearsOld)
                            {
                                Console.WriteLine($"{student.FirstName} {student.LastName}, {student.Age} років, {student.SchoolName}");
                            }
                            Console.WriteLine("\n");

                            // Отримати список студентів, які навчаються в MIT
                            var studentsAtMIT = students.Where(student => student.SchoolName == "MIT").ToList();
                            Console.WriteLine("Список студентів, які навчаються в MIT:");
                            foreach (var student in studentsAtMIT)
                            {
                                Console.WriteLine($"{student.FirstName} {student.LastName}, {student.Age} років, {student.SchoolName}");
                            }
                            Console.WriteLine("\n");

                            // Отримати список студентів, які навчаються в Oxford, і вік яких старше 18 років
                            var studentsAtOxfordAbove18YearsOld = students
                                .Where(student => student.SchoolName == "Oxford" && student.Age > 18)
                                .OrderByDescending(student => student.Age)
                                .ToList();
                            Console.WriteLine("Список студентів, які навчаються в Oxford, і вік яких старше 18 років (відсортовані за віком, за спаданням):");
                            foreach (var student in studentsAtOxfordAbove18YearsOld)
                            {
                                Console.WriteLine($"{student.FirstName} {student.LastName}, {student.Age} років, {student.SchoolName}");
                            }
                            Console.WriteLine("\n");
                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        break;
                    case 4:
                        {
                            Firm[] firms = {
            new Firm { FirmName = "Food Corporation", FoundingDate = new DateTime(1998, 5, 15), BusinessProfile = "Food", DirectorName = "John White", EmployeeCount = 150, Address = "London" },
            new Firm { FirmName = "Tech Solutions", FoundingDate = new DateTime(2005, 10, 25), BusinessProfile = "IT", DirectorName = "Alice Black", EmployeeCount = 250, Address = "New York" },
            new Firm { FirmName = "Marketing Master", FoundingDate = new DateTime(2010, 3, 8), BusinessProfile = "Marketing", DirectorName = "Tom Green", EmployeeCount = 80, Address = "London" },
            new Firm { FirmName = "White Architects", FoundingDate = new DateTime(2017, 9, 18), BusinessProfile = "Architecture", DirectorName = "Richard White", EmployeeCount = 120, Address = "Paris" },
            new Firm { FirmName = "Green IT Solutions", FoundingDate = new DateTime(2019, 7, 5), BusinessProfile = "IT", DirectorName = "Emily Green", EmployeeCount = 300, Address = "London" }
        };

                            // Отримати інформацію про всі фірми
                            Console.WriteLine("Інформація про всі фірми:");
                            foreach (var firm in firms)
                            {
                                Console.WriteLine($"Назва: {firm.FirmName}, Засновано: {firm.FoundingDate.ToShortDateString()}, Галузь: {firm.BusinessProfile}, Директор: {firm.DirectorName}, Кількість працівників: {firm.EmployeeCount}, Адреса: {firm.Address}");
                            }
                            Console.WriteLine("\n");

                            // Отримати фірми, які мають у назві слово "Food"
                            var firmsWithFoodInName = firms.Where(firm => firm.FirmName.Contains("Food")).ToList();
                            Console.WriteLine("Фірми, які мають у назві слово \"Food\":");
                            foreach (var firm in firmsWithFoodInName)
                            {
                                Console.WriteLine($"Назва: {firm.FirmName}, Засновано: {firm.FoundingDate.ToShortDateString()}, Галузь: {firm.BusinessProfile}, Директор: {firm.DirectorName}, Кількість працівників: {firm.EmployeeCount}, Адреса: {firm.Address}");
                            }
                            Console.WriteLine("\n");

                            // Отримати фірми, які працюють у галузі маркетингу
                            var firmsInMarketing = firms.Where(firm => firm.BusinessProfile == "Marketing").ToList();
                            Console.WriteLine("Фірми, які працюють у галузі маркетингу:");
                            foreach (var firm in firmsInMarketing)
                            {
                                Console.WriteLine($"Назва: {firm.FirmName}, Засновано: {firm.FoundingDate.ToShortDateString()}, Галузь: {firm.BusinessProfile}, Директор: {firm.DirectorName}, Кількість працівників: {firm.EmployeeCount}, Адреса: {firm.Address}");
                            }
                            Console.WriteLine("\n");

                            // Отримати фірми, які працюють у галузі маркетингу або IT
                            var firmsInMarketingOrIT = firms.Where(firm => firm.BusinessProfile == "Marketing" || firm.BusinessProfile == "IT").ToList();
                            Console.WriteLine("Фірми, які працюють у галузі маркетингу або IT:");
                            foreach (var firm in firmsInMarketingOrIT)
                            {
                                Console.WriteLine($"Назва: {firm.FirmName}, Засновано: {firm.FoundingDate.ToShortDateString()}, Галузь: {firm.BusinessProfile}, Директор: {firm.DirectorName}, Кількість працівників: {firm.EmployeeCount}, Адреса: {firm.Address}");
                            }
                            Console.WriteLine("\n");

                            // Отримати фірми з кількістю працівників більшою, ніж 100
                            var firmsWithMoreThan100Employees = firms.Where(firm => firm.EmployeeCount > 100).ToList();
                            Console.WriteLine("Фірми з кількістю працівників більшою, ніж 100:");
                            foreach (var firm in firmsWithMoreThan100Employees)
                            {
                                Console.WriteLine($"Назва: {firm.FirmName}, Засновано: {firm.FoundingDate.ToShortDateString()}, Галузь: {firm.BusinessProfile}, Директор: {firm.DirectorName}, Кількість працівників: {firm.EmployeeCount}, Адреса: {firm.Address}");
                            }
                            Console.WriteLine("\n");

                            // Отримати фірми з кількістю працівників у діапазоні від 100 до 300
                            var firmsWithEmployeesBetween100And300 = firms.Where(firm => firm.EmployeeCount >= 100 && firm.EmployeeCount <= 300).ToList();
                            Console.WriteLine("Фірми з кількістю працівників у діапазоні від 100 до 300:");
                            foreach (var firm in firmsWithEmployeesBetween100And300)
                            {
                                Console.WriteLine($"Назва: {firm.FirmName}, Засновано: {firm.FoundingDate.ToShortDateString()}, Галузь: {firm.BusinessProfile}, Директор: {firm.DirectorName}, Кількість працівників: {firm.EmployeeCount}, Адреса: {firm.Address}");
                            }
                            Console.WriteLine("\n");

                            // Отримати фірми, які знаходяться в Лондоні
                            var firmsInLondon = firms.Where(firm => firm.Address == "London").ToList();
                            Console.WriteLine("Фірми, які знаходяться в Лондоні:");
                            foreach (var firm in firmsInLondon)
                            {
                                Console.WriteLine($"Назва: {firm.FirmName}, Засновано: {firm.FoundingDate.ToShortDateString()}, Галузь: {firm.BusinessProfile}, Директор: {firm.DirectorName}, Кількість працівників: {firm.EmployeeCount}, Адреса: {firm.Address}");
                            }
                            Console.WriteLine("\n");

                            // Отримати фірми, в яких прізвище директора White
                            var firmsWithDirectorLastNameWhite = firms.Where(firm => firm.DirectorName.EndsWith("White")).ToList();
                            Console.WriteLine("Фірми, в яких прізвище директора White:");
                            foreach (var firm in firmsWithDirectorLastNameWhite)
                            {
                                Console.WriteLine($"Назва: {firm.FirmName}, Засновано: {firm.FoundingDate.ToShortDateString()}, Галузь: {firm.BusinessProfile}, Директор: {firm.DirectorName}, Кількість працівників: {firm.EmployeeCount}, Адреса: {firm.Address}");
                            }
                            Console.WriteLine("\n");

                            // Отримати фірми, які засновані більше двох років тому
                            var firmsFoundedMoreThanTwoYearsAgo = firms.Where(firm => DateTime.Now.Year - firm.FoundingDate.Year > 2).ToList();
                            Console.WriteLine("Фірми, які засновані більше двох років тому:");
                            foreach (var firm in firmsFoundedMoreThanTwoYearsAgo)
                            {
                                Console.WriteLine($"Назва: {firm.FirmName}, Засновано: {firm.FoundingDate.ToShortDateString()}, Галузь: {firm.BusinessProfile}, Директор: {firm.DirectorName}, Кількість працівників: {firm.EmployeeCount}, Адреса: {firm.Address}");
                            }
                            Console.WriteLine("\n");

                            // Отримати фірми з дня заснування яких минуло 123 дні
                            var firmsFounded123DaysAgo = firms.Where(firm => (DateTime.Now - firm.FoundingDate).TotalDays == 123).ToList();
                            Console.WriteLine("Фірми, з дня заснування яких минуло 123 дні:");
                            foreach (var firm in firmsFounded123DaysAgo)
                            {
                                Console.WriteLine($"Назва: {firm.FirmName}, Засновано: {firm.FoundingDate.ToShortDateString()}, Галузь: {firm.BusinessProfile}, Директор: {firm.DirectorName}, Кількість працівників: {firm.EmployeeCount}, Адреса: {firm.Address}");
                            }
                            Console.WriteLine("\n");

                            // Отримати фірми, в яких прізвище директора Black і мають у назві фірми слово "White"
                            var firmsWithBlackDirectorAndWhiteInName = firms.Where(firm => firm.DirectorName.EndsWith("Black") && firm.FirmName.Contains("White")).ToList();
                            Console.WriteLine("Фірми, в яких прізвище директора Black і мають у назві фірми слово \"White\":");
                            foreach (var firm in firmsWithBlackDirectorAndWhiteInName)
                            {
                                Console.WriteLine($"Назва: {firm.FirmName}, Засновано: {firm.FoundingDate.ToShortDateString()}, Галузь: {firm.BusinessProfile}, Директор: {firm.DirectorName}, Кількість працівників: {firm.EmployeeCount}, Адреса: {firm.Address}");
                            }
                            Console.WriteLine("\n");
                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        break;
                    case 5:
                        {
                            Firm[] firms = {
            new Firm { FirmName = "Food Corporation", FoundingDate = new DateTime(1998, 5, 15), BusinessProfile = "Food", DirectorName = "John White", EmployeeCount = 150, Address = "London" },
            new Firm { FirmName = "Tech Solutions", FoundingDate = new DateTime(2005, 10, 25), BusinessProfile = "IT", DirectorName = "Alice Black", EmployeeCount = 250, Address = "New York" },
            new Firm { FirmName = "Marketing Master", FoundingDate = new DateTime(2010, 3, 8), BusinessProfile = "Marketing", DirectorName = "Tom Green", EmployeeCount = 80, Address = "London" },
            new Firm { FirmName = "White Architects", FoundingDate = new DateTime(2017, 9, 18), BusinessProfile = "Architecture", DirectorName = "Richard White", EmployeeCount = 120, Address = "Paris" },
            new Firm { FirmName = "Green IT Solutions", FoundingDate = new DateTime(2019, 7, 5), BusinessProfile = "IT", DirectorName = "Emily Green", EmployeeCount = 300, Address = "London" }
        };

                            // Отримати інформацію про всі фірми
                            Console.WriteLine("Інформація про всі фірми:");
                            foreach (var firm in firms)
                            {
                                Console.WriteLine($"Назва: {firm.FirmName}, Засновано: {firm.FoundingDate.ToShortDateString()}, Галузь: {firm.BusinessProfile}, Директор: {firm.DirectorName}, Кількість працівників: {firm.EmployeeCount}, Адреса: {firm.Address}");
                            }
                            Console.WriteLine("\n");

                            // Отримати фірми, які мають у назві слово "Food"
                            var firmsWithFoodInName = firms.Where(firm => firm.FirmName.Contains("Food")).ToList();
                            PrintFirms("Фірми, які мають у назві слово \"Food\":", firmsWithFoodInName);

                            // Отримати фірми, які працюють у галузі маркетингу
                            var firmsInMarketing = firms.Where(firm => firm.BusinessProfile == "Marketing").ToList();
                            PrintFirms("Фірми, які працюють у галузі маркетингу:", firmsInMarketing);

                            // Отримати фірми, які працюють у галузі маркетингу або IT
                            var firmsInMarketingOrIT = firms.Where(firm => firm.BusinessProfile == "Marketing" || firm.BusinessProfile == "IT").ToList();
                            PrintFirms("Фірми, які працюють у галузі маркетингу або IT:", firmsInMarketingOrIT);

                            // Отримати фірми з кількістю працівників більшою, ніж 100
                            var firmsWithMoreThan100Employees = firms.Where(firm => firm.EmployeeCount > 100).ToList();
                            PrintFirms("Фірми з кількістю працівників більшою, ніж 100:", firmsWithMoreThan100Employees);

                            // Отримати фірми з кількістю працівників у діапазоні від 100 до 300
                            var firmsWithEmployeesBetween100And300 = firms.Where(firm => firm.EmployeeCount >= 100 && firm.EmployeeCount <= 300).ToList();
                            PrintFirms("Фірми з кількістю працівників у діапазоні від 100 до 300:", firmsWithEmployeesBetween100And300);

                            // Отримати фірми, які знаходяться в Лондоні
                            var firmsInLondon = firms.Where(firm => firm.Address == "London").ToList();
                            PrintFirms("Фірми, які знаходяться в Лондоні:", firmsInLondon);

                            // Отримати фірми, в яких прізвище директора White
                            var firmsWithDirectorLastNameWhite = firms.Where(firm => firm.DirectorName.EndsWith("White")).ToList();
                            PrintFirms("Фірми, в яких прізвище директора White:", firmsWithDirectorLastNameWhite);

                            // Отримати фірми, які засновані більше двох років тому
                            var firmsFoundedMoreThanTwoYearsAgo = firms.Where(firm => DateTime.Now.Year - firm.FoundingDate.Year > 2).ToList();
                            PrintFirms("Фірми, які засновані більше двох років тому:", firmsFoundedMoreThanTwoYearsAgo);

                            // Отримати фірми з дня заснування яких минуло 123 дні
                            var firmsFounded123DaysAgo = firms.Where(firm => (DateTime.Now - firm.FoundingDate).TotalDays == 123).ToList();
                            PrintFirms("Фірми, з дня заснування яких минуло 123 дні:", firmsFounded123DaysAgo);

                            // Отримати фірми, в яких прізвище директора Black і мають у назві фірми слово "White"
                            var firmsWithBlackDirectorAndWhiteInName = firms.Where(firm => firm.DirectorName.EndsWith("Black") && firm.FirmName.Contains("White")).ToList();
                            PrintFirms("Фірми, в яких прізвище директора Black і мають у назві фірми слово \"White\":", firmsWithBlackDirectorAndWhiteInName);

                            Console.WriteLine("\n");
                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                        static void PrintFirms(string message, List<Firm> firms)
                        {
                            Console.WriteLine(message);
                            foreach (var firm in firms)
                            {
                                Console.WriteLine($"Назва: {firm.FirmName}, Засновано: {firm.FoundingDate.ToShortDateString()}, Галузь: {firm.BusinessProfile}, Директор: {firm.DirectorName}, Кількість працівників: {firm.EmployeeCount}, Адреса: {firm.Address}");
                            }
                            Console.WriteLine("\n");
                        }

               
       
                    case 6:
                        {
                            Firm[] firms = {
            new Firm { FirmName = "Food Corporation", FoundingDate = new DateTime(1998, 5, 15), BusinessProfile = "Food", DirectorName = "John White", EmployeeCount = 150, Address = "London" },
            new Firm { FirmName = "Tech Solutions", FoundingDate = new DateTime(2005, 10, 25), BusinessProfile = "IT", DirectorName = "Alice Black", EmployeeCount = 250, Address = "New York" },
            new Firm { FirmName = "Marketing Master", FoundingDate = new DateTime(2010, 3, 8), BusinessProfile = "Marketing", DirectorName = "Tom Green", EmployeeCount = 80, Address = "London" },
            new Firm { FirmName = "White Architects", FoundingDate = new DateTime(2017, 9, 18), BusinessProfile = "Architecture", DirectorName = "Richard White", EmployeeCount = 120, Address = "Paris" },
            new Firm { FirmName = "Green IT Solutions", FoundingDate = new DateTime(2019, 7, 5), BusinessProfile = "IT", DirectorName = "Emily Green", EmployeeCount = 300, Address = "London" }
        };

                            // Додавання працівників для кожної фірми
                            firms[0].Employees.Add(new Employee { FullName = "John Doe", Position = "Manager", ContactPhone = "2301234567", Email = "john.doe@foodcorp.com", Salary = 50000 });
                            firms[0].Employees.Add(new Employee { FullName = "Jane Smith", Position = "Chef", ContactPhone = "2312345678", Email = "jane.smith@foodcorp.com", Salary = 40000 });
                            firms[1].Employees.Add(new Employee { FullName = "Alice Brown", Position = "Developer", ContactPhone = "2345678901", Email = "alice.brown@techsolutions.com", Salary = 60000 });
                            firms[1].Employees.Add(new Employee { FullName = "Bob Johnson", Position = "Project Manager", ContactPhone = "2398765432", Email = "bob.johnson@techsolutions.com", Salary = 70000 });
                            firms[2].Employees.Add(new Employee { FullName = "Tom Lee", Position = "Marketing Specialist", ContactPhone = "2309876543", Email = "tom.lee@marketingmaster.com", Salary = 55000 });
                            firms[3].Employees.Add(new Employee { FullName = "Richard Davis", Position = "Architect", ContactPhone = "2323456789", Email = "richard.davis@whitearchitects.com", Salary = 65000 });
                            firms[4].Employees.Add(new Employee { FullName = "Emily Wilson", Position = "IT Manager", ContactPhone = "2387654321", Email = "emily.wilson@greenit.com", Salary = 75000 });

                            // Отримати список усіх працівників певної фірми
                            string firmNameToFindEmployees = "Tech Solutions";
                            var employeesOfFirm = firms.FirstOrDefault(firm => firm.FirmName == firmNameToFindEmployees)?.Employees;
                            PrintEmployees($"Список працівників фірми {firmNameToFindEmployees}:", employeesOfFirm);

                            // Отримати список усіх працівників певної фірми, в яких заробітна плата більша заданої
                            double minSalary = 60000;
                            var employeesWithHigherSalary = firms.Where(firm => firm.Employees.Any(employee => employee.Salary > minSalary))
                                                                 .SelectMany(firm => firm.Employees)
                                                                 .ToList();
                            PrintEmployees($"Список працівників фірм з заробітною платою більше {minSalary}:", employeesWithHigherSalary);

                            // Отримати список працівників усіх фірм, в яких є посада «Менеджер»
                            string positionToFind = "Manager";
                            var employeesWithPosition = firms.SelectMany(firm => firm.Employees)
                                                             .Where(employee => employee.Position == positionToFind)
                                                             .ToList();
                            PrintEmployees($"Список працівників з посадою {positionToFind}:", employeesWithPosition);

                            // Отримати список працівників, в яких телефон починається з «23»
                            string phoneStartsWith = "23";
                            var employeesWithPhoneStartsWith = firms.SelectMany(firm => firm.Employees)
                                                                    .Where(employee => employee.ContactPhone.StartsWith(phoneStartsWith))
                                                                    .ToList();
                            PrintEmployees($"Список працівників з номером телефону, що починається з {phoneStartsWith}:", employeesWithPhoneStartsWith);

                            // Отримати список працівників, в яких Email починається з «di»
                            string emailStartsWith = "di";
                            var employeesWithEmailStartsWith = firms.SelectMany(firm => firm.Employees)
                                                                    .Where(employee => employee.Email.StartsWith(emailStartsWith, StringComparison.OrdinalIgnoreCase))
                                                                    .ToList();
                            PrintEmployees($"Список працівників з Email, що починається з {emailStartsWith}:", employeesWithEmailStartsWith);

                            // Отримати список працівників з ім'ям "Lione"
                            string employeeNameToFind = "Lione";
                            var employeesWithName = firms.SelectMany(firm => firm.Employees)
                                                         .Where(employee => employee.FullName.Contains(employeeNameToFind, StringComparison.OrdinalIgnoreCase))
                                                         .ToList();
                            PrintEmployees($"Список працівників з ім'ям {employeeNameToFind}:", employeesWithName);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                        static void PrintEmployees(string message, List<Employee> employees)
                        {
                            Console.WriteLine(message);
                            foreach (var employee in employees)
                            {
                                Console.WriteLine($"ПІБ: {employee.FullName}, Посада: {employee.Position}, Телефон: {employee.ContactPhone}, Email: {employee.Email}, Заробітна плата: {employee.Salary}");
                            }
                            Console.WriteLine();
                        }
                       
                    default:
                        break;
                }
            } while (switch_on != 0);
        }
    }

}