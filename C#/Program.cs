using System.Globalization;
using System.Text;
using System;
class Website
{
    private string name;
    private string path;
    private string description;
    private string ipAddress;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetPath(string path)
    {
        this.path = path;
    }

    public string GetPath()
    {
        return path;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetIpAddress(string ipAddress)
    {
        this.ipAddress = ipAddress;
    }

    public string GetIpAddress()
    {
        return ipAddress;
    }

    public void InputData()
    {
        Console.WriteLine("Введіть назву сайту:");
        name = Console.ReadLine();

        Console.WriteLine("Введіть шлях до сайту:");
        path = Console.ReadLine();

        Console.WriteLine("Введіть опис сайту:");
        description = Console.ReadLine();

        Console.WriteLine("Введіть IP-адресу сайту:");
        ipAddress = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine("Назва сайту: " + name);
        Console.WriteLine("Шлях до сайту: " + path);
        Console.WriteLine("Опис сайту: " + description);
        Console.WriteLine("IP-адреса сайту: " + ipAddress);
    }
}

class Journal
{
    private string name;
    private int yearFounded;
    private string description;
    private string contactPhone;
    private string email;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetYearFounded(int yearFounded)
    {
        this.yearFounded = yearFounded;
    }

    public int GetYearFounded()
    {
        return yearFounded;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetContactPhone(string contactPhone)
    {
        this.contactPhone = contactPhone;
    }

    public string GetContactPhone()
    {
        return contactPhone;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }

    public string GetEmail()
    {
        return email;
    }

    public void InputData()
    {
        Console.WriteLine("Введіть назву журналу:");
        name = Console.ReadLine();

        Console.WriteLine("Введіть рік заснування:");
        yearFounded = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть опис журналу:");
        description = Console.ReadLine();

        Console.WriteLine("Введіть контактний телефон:");
        contactPhone = Console.ReadLine();

        Console.WriteLine("Введіть email:");
        email = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine("Назва журналу: " + name);
        Console.WriteLine("Рік заснування: " + yearFounded);
        Console.WriteLine("Опис журналу: " + description);
        Console.WriteLine("Контактний телефон: " + contactPhone);
        Console.WriteLine("Email: " + email);
    }
}


class Shop
{
    private string name;
    private string address;
    private string profileDescription;
    private string contactPhone;
    private string email;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetAddress(string address)
    {
        this.address = address;
    }

    public string GetAddress()
    {
        return address;
    }

    public void SetProfileDescription(string profileDescription)
    {
        this.profileDescription = profileDescription;
    }

    public string GetProfileDescription()
    {
        return profileDescription;
    }

    public void SetContactPhone(string contactPhone)
    {
        this.contactPhone = contactPhone;
    }

    public string GetContactPhone()
    {
        return contactPhone;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }

    public string GetEmail()
    {
        return email;
    }

    public void InputData()
    {
        Console.WriteLine("Введіть назву магазину:");
        name = Console.ReadLine();

        Console.WriteLine("Введіть адресу магазину:");
        address = Console.ReadLine();

        Console.WriteLine("Введіть опис профілю магазину:");
        profileDescription = Console.ReadLine();

        Console.WriteLine("Введіть контактний телефон:");
        contactPhone = Console.ReadLine();

        Console.WriteLine("Введіть email:");
        email = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine("Назва магазину: " + name);
        Console.WriteLine("Адреса: " + address);
        Console.WriteLine("Опис профілю магазину: " + profileDescription);
        Console.WriteLine("Контактний телефон: " + contactPhone);
        Console.WriteLine("Email: " + email);
    }
}
class City
{
    private string cityName;
    private string countryName;
    private int population;
    private int areaCode;
    private string[] districts;

    public void SetCityName(string name)
    {
        cityName = name;
    }

    public string GetCityName()
    {
        return cityName;
    }

    public void SetCountryName(string name)
    {
        countryName = name;
    }

    public string GetCountryName()
    {
        return countryName;
    }

    public void SetPopulation(int value)
    {
        population = value;
    }

    public int GetPopulation()
    {
        return population;
    }

    public void SetAreaCode(int code)
    {
        areaCode = code;
    }

    public int GetAreaCode()
    {
        return areaCode;
    }

    public void SetDistricts(string[] districtsArray)
    {
        districts = districtsArray;
    }

    public string[] GetDistricts()
    {
        return districts;
    }

    public void InputCityData()
    {
        Console.WriteLine("Введіть назву міста:");
        cityName = Console.ReadLine();

        Console.WriteLine("Введіть назву країни:");
        countryName = Console.ReadLine();

        Console.WriteLine("Введіть кількість жителів у місті:");
        population = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть телефонний код міста:");
        areaCode = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть назви районів міста (через кому):");
        string districtsString = Console.ReadLine();
        districts = districtsString.Split(',');
    }

    public void PrintCityData()
    {
        Console.WriteLine("Назва міста: " + cityName);
        Console.WriteLine("Назва країни: " + countryName);
        Console.WriteLine("Кількість жителів: " + population);
        Console.WriteLine("Телефонний код: " + areaCode);
        Console.WriteLine("Райони міста: " + string.Join(", ", districts));
    }
}
class Employee
{
    private string fullName;
    private DateTime birthDate;
    private string contactPhone;
    private string workEmail;
    private string position;
    private string jobDescription;

    public void SetFullName(string name)
    {
        fullName = name;
    }

    public string GetFullName()
    {
        return fullName;
    }

    public void SetBirthDate(DateTime date)
    {
        birthDate = date;
    }

    public DateTime GetBirthDate()
    {
        return birthDate;
    }

    public void SetContactPhone(string phone)
    {
        contactPhone = phone;
    }

    public string GetContactPhone()
    {
        return contactPhone;
    }

    public void SetWorkEmail(string email)
    {
        workEmail = email;
    }

    public string GetWorkEmail()
    {
        return workEmail;
    }

    public void SetPosition(string positionName)
    {
        position = positionName;
    }

    public string GetPosition()
    {
        return position;
    }

    public void SetJobDescription(string description)
    {
        jobDescription = description;
    }

    public string GetJobDescription()
    {
        return jobDescription;
    }

    public void InputEmployeeData()
    {
        Console.WriteLine("Введіть ПІБ співробітника:");
        fullName = Console.ReadLine();

        Console.WriteLine("Введіть дату народження співробітника (у форматі дд/мм/рррр):");
        string birthDateStr = Console.ReadLine();
        birthDate = DateTime.Parse(birthDateStr);

        Console.WriteLine("Введіть контактний телефон співробітника:");
        contactPhone = Console.ReadLine();

        Console.WriteLine("Введіть робочий email співробітника:");
        workEmail = Console.ReadLine();

        Console.WriteLine("Введіть посаду співробітника:");
        position = Console.ReadLine();

        Console.WriteLine("Введіть опис службових обов'язків співробітника:");
        jobDescription = Console.ReadLine();
    }

    public void PrintEmployeeData()
    {
        Console.WriteLine("ПІБ співробітника: " + fullName);
        Console.WriteLine("Дата народження: " + birthDate.ToString("dd/MM/yyyy"));
        Console.WriteLine("Контактний телефон: " + contactPhone);
        Console.WriteLine("Робочий email: " + workEmail);
        Console.WriteLine("Посада: " + position);
        Console.WriteLine("Опис службових обов'язків: " + jobDescription);
    }
}


class Aircraft
{
    private string name;
    private string manufacturer;
    private int year;
    private string type;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Manufacturer
    {
        get { return manufacturer; }
        set { manufacturer = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public Aircraft(string name, string manufacturer, int year, string type)
    {
        this.name = name;
        this.manufacturer = manufacturer;
        this.year = year;
        this.type = type;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Aircraft Information:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Manufacturer: " + manufacturer);
        Console.WriteLine("Year: " + year);
        Console.WriteLine("Type: " + type);
    }
}

class Matrix
{
    private int[,] data;
    private int rows;
    private int columns;

    public Matrix(int rows, int columns)
    {
        this.rows = rows;
        this.columns = columns;
        data = new int[rows, columns];
    }

    public void SetData()
    {
        Console.WriteLine("Enter matrix elements:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Element[{0},{1}]: ", i, j);
                data[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public void DisplayData()
    {
        Console.WriteLine("Matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(data[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public int FindMax()
    {
        int max = data[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (data[i, j] > max)
                {
                    max = data[i, j];
                }
            }
        }
        return max;
    }

    public int FindMin()
    {
        int min = data[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (data[i, j] < min)
                {
                    min = data[i, j];
                }
            }
        }
        return min;
    }
}


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
                            Console.WriteLine("Введіть довжину сторони квадрата:");
                            int sideLength = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введіть символ для відображення квадрата:");
                            char symbol = char.Parse(Console.ReadLine());

                            DisplaySquare(sideLength, symbol);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();


                            static void DisplaySquare(int sideLength, char symbol)
                            {
                                for (int i = 0; i < sideLength; i++)
                                {
                                    for (int j = 0; j < sideLength; j++)
                                    {
                                        Console.Write(symbol + " ");
                                    }
                                    Console.WriteLine();
                                }
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Введіть число для перевірки:");
                            int number = int.Parse(Console.ReadLine());

                            bool isPalindrome = IsPalindrome(number);

                            Console.WriteLine("Число є паліндромом: " + isPalindrome);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();


                            static bool IsPalindrome(int number)
                            {
                                int originalNumber = number;
                                int reversedNumber = 0;

                                while (number > 0)
                                {
                                    int digit = number % 10;
                                    reversedNumber = reversedNumber * 10 + digit;
                                    number /= 10;
                                }

                                return originalNumber == reversedNumber;
                            }

                        }

                        break;
                    case 3:
                        {


                            Console.WriteLine("Введіть елементи оригінального масиву (через пробіл):");
                            int[] originalArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                            Console.WriteLine("Введіть елементи масиву для фільтрації (через пробіл):");
                            int[] filterArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                            int[] resultArray = FilterArray(originalArray, filterArray);

                            Console.WriteLine("Результат фільтрації:");
                            foreach (int element in resultArray)
                            {
                                Console.Write(element + " ");
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();


                            static int[] FilterArray(int[] originalArray, int[] filterArray)
                            {
                                return originalArray.Where(x => !filterArray.Contains(x)).ToArray();
                            }
                        }
                        break;
                    case 4:
                        {
                            Website website = new Website();

                            website.InputData();

                            Console.WriteLine("\nДані про веб-сайт:");
                            website.DisplayData();

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 5:
                        {
                            Journal journal = new Journal();

                            journal.InputData();

                            Console.WriteLine("\nДані про журнал:");
                            journal.DisplayData();

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 6:
                        {
                            Shop shop = new Shop();

                            shop.InputData();

                            Console.WriteLine("\nДані про магазин:");
                            shop.DisplayData();

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 7:
                        {
                            static int GetProductInRange(int start, int end)
                            {
                                int product = 1;

                                for (int i = start; i <= end; i++)
                                {
                                    product *= i;
                                }

                                return product;
                            }
                            Console.WriteLine("Введіть початок діапазону:");
                            int start = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введіть кінець діапазону:");
                            int end = int.Parse(Console.ReadLine());

                            int product = GetProductInRange(start, end);

                            Console.WriteLine("Добуток чисел у діапазоні [{0}, {1}] дорівнює {2}", start, end, product);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        break;
                    case 8:
                        {
                            static bool IsFibonacciNumber(int number)
                            {
                                if (number == 0 || number == 1)
                                {
                                    return true;
                                }

                                int a = 0;
                                int b = 1;
                                int c = a + b;

                                while (c <= number)
                                {
                                    if (c == number)
                                    {
                                        return true;
                                    }

                                    a = b;
                                    b = c;
                                    c = a + b;
                                }

                                return false;
                            }
                            Console.WriteLine("Введіть число:");
                            int number = int.Parse(Console.ReadLine());

                            bool isFibonacci = IsFibonacciNumber(number);

                            if (isFibonacci)
                            {
                                Console.WriteLine("Число {0} є числом Фібоначчі", number);
                            }
                            else
                            {
                                Console.WriteLine("Число {0} не є числом Фібоначчі", number);
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 9:
                        {
                            Console.WriteLine("Введіть елементи масиву (через пробіл):");
                            string input = Console.ReadLine();
                            int[] array = Array.ConvertAll(input.Split(' '), int.Parse);

                            Console.WriteLine("Виберіть тип сортування:");
                            Console.WriteLine("1 - За зростанням");
                            Console.WriteLine("2 - За спаданням");
                            int choice = int.Parse(Console.ReadLine());

                            if (choice == 1)
                            {
                                BubbleSortAscending(array);
                                Console.WriteLine("Масив, відсортований за зростанням:");
                            }
                            else if (choice == 2)
                            {
                                BubbleSortDescending(array);
                                Console.WriteLine("Масив, відсортований за спаданням:");
                            }
                            else
                            {
                                Console.WriteLine("Неправильний вибір типу сортування.");
                                return;
                            }

                            PrintArray(array);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();


                            static void BubbleSortAscending(int[] array)
                            {
                                int n = array.Length;
                                bool swapped;

                                for (int i = 0; i < n - 1; i++)
                                {
                                    swapped = false;

                                    for (int j = 0; j < n - i - 1; j++)
                                    {
                                        if (array[j] > array[j + 1])
                                        {
                                            Swap(ref array[j], ref array[j + 1]);
                                            swapped = true;
                                        }
                                    }

                                    if (!swapped)
                                    {
                                        break;
                                    }
                                }
                            }

                            static void BubbleSortDescending(int[] array)
                            {
                                int n = array.Length;
                                bool swapped;

                                for (int i = 0; i < n - 1; i++)
                                {
                                    swapped = false;

                                    for (int j = 0; j < n - i - 1; j++)
                                    {
                                        if (array[j] < array[j + 1])
                                        {
                                            Swap(ref array[j], ref array[j + 1]);
                                            swapped = true;
                                        }
                                    }

                                    if (!swapped)
                                    {
                                        break;
                                    }
                                }
                            }

                            static void Swap(ref int a, ref int b)
                            {
                                int temp = a;
                                a = b;
                                b = temp;
                            }

                            static void PrintArray(int[] array)
                            {
                                Console.WriteLine(string.Join(" ", array));
                            }
                        }
                        break;
                    case 10:
                        {
                            City city = new City();

                            city.InputCityData();

                            Console.WriteLine("\nДані про місто:");
                            city.PrintCityData();

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                        }
                        break;
                    case 11:
                        {
                            Employee employee = new Employee();

                            employee.InputEmployeeData();

                            Console.WriteLine("\nДані про співробітника:");
                            employee.PrintEmployeeData();

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                        }
                        break;
                    case 12:
                        {
                            Aircraft aircraft = new Aircraft("Boeing 747", "Boeing", 1969, "Passenger");

                            aircraft.DisplayInfo();

                            aircraft.Name = "Airbus A380";
                            aircraft.Year = 2005;

                            aircraft.DisplayInfo(); 
                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                        }
                        break;

                    case 13:
                        {
                            Console.Write("Введіть кількість рядків:");
                            int rows = int.Parse(Console.ReadLine());

                            Console.Write("Введіть кількість колонок: ");
                            int columns = int.Parse(Console.ReadLine());

                            Matrix matrix = new Matrix(rows, columns);

                            matrix.SetData();
                            matrix.DisplayData();

                            int max = matrix.FindMax();
                            int min = matrix.FindMin();

                            Console.WriteLine("Максимальний елемент: " + max);
                            Console.WriteLine("Мінімальний елемент: " + min);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();

                        }
                        break;
                    default:
                        break;
                }

            } while (switch_on != 0);
        }
    }
}