using System.Globalization;
using System.Text;

namespace C_
{
    public class Journal
    {
        private int numberOfEmployees;

        public int NumberOfEmployees
        {
            get { return numberOfEmployees; }
            set { numberOfEmployees = value; }
        }

        public void IncreaseNumberOfEmployees(int amount)
        {
            numberOfEmployees += amount;
        }

        public void DecreaseNumberOfEmployees(int amount)
        {
            numberOfEmployees -= amount;
            if (numberOfEmployees < 0)
                numberOfEmployees = 0;
        }

        public bool Equals(Journal other)
        {
            if (other == null)
                return false;
            return numberOfEmployees == other.numberOfEmployees;
        }
    }

    public class Store
    {
        private double area;

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public void IncreaseArea(double size)
        {
            area += size;
        }

        public void DecreaseArea(double size)
        {
            area -= size;
            if (area < 0)
                area = 0;
        }

        public bool Equals(Store other)
        {
            if (other == null)
                return false;
            return area == other.area;
        }
    }

    public class ReadingList
    {
        private List<string> books;

        public ReadingList()
        {
            books = new List<string>();
        }

        public int Count
        {
            get { return books.Count; }
        }

        public string this[int index]
        {
            get { return books[index]; }
        }

        public void AddBook(string book)
        {
            books.Add(book);
        }

        public void RemoveBook(string book)
        {
            books.Remove(book);
        }

        public bool ContainsBook(string book)
        {
            return books.Contains(book);
        }

        public static ReadingList operator +(ReadingList list, string book)
        {
            list.AddBook(book);
            return list;
        }

        public static ReadingList operator -(ReadingList list, string book)
        {
            list.RemoveBook(book);
            return list;
        }
    }

    public class Employee
    {
        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public void IncreaseSalary(double amount)
        {
            salary += amount;
        }

        public void DecreaseSalary(double amount)
        {
            salary -= amount;
            if (salary < 0)
                salary = 0;
        }

        public bool Equals(Employee other)
        {
            if (other == null)
                return false;
            return salary == other.salary;
        }
    }

    public class Matrix
    {
        private int[,] data;
        public int Rows { get; }
        public int Columns { get; }

        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            data = new int[rows, columns];
        }

        public int this[int row, int column]
        {
            get { return data[row, column]; }
            set { data[row, column] = value; }
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
                throw new ArgumentException("Matrices must have the same dimensions.");

            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
                throw new ArgumentException("Matrices must have the same dimensions.");

            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Columns != matrix2.Rows)
                throw new ArgumentException("Number of columns in the first matrix must be equal to the number of rows in the second matrix.");

            Matrix result = new Matrix(matrix1.Rows, matrix2.Columns);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix2.Columns; j++)
                {
                    for (int k = 0; k < matrix1.Columns; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix matrix, int scalar)
        {
            Matrix result = new Matrix(matrix.Rows, matrix.Columns);
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }

            return result;
        }

        public static bool operator ==(Matrix matrix1, Matrix matrix2)
        {
            if (ReferenceEquals(matrix1, matrix2))
                return true;

            if (matrix1 is null || matrix2 is null)
                return false;

            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
                return false;

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                        return false;
                }
            }

            return true;
        }

        public static bool operator !=(Matrix matrix1, Matrix matrix2)
        {
            return !(matrix1 == matrix2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Matrix otherMatrix)
                return this == otherMatrix;

            return false;
        }
    }

    public class City
    {
        private int population;

        public int Population
        {
            get { return population; }
            set { population = value; }
        }

        public static City operator +(City city, int increase)
        {
            city.Population += increase;
            return city;
        }

        public static City operator -(City city, int decrease)
        {
            city.Population -= decrease;
            if (city.Population < 0)
                city.Population = 0;
            return city;
        }

        public static bool operator ==(City city1, City city2)
        {
            if (ReferenceEquals(city1, city2))
                return true;

            if (city1 is null || city2 is null)
                return false;

            return city1.Population == city2.Population;
        }

        public static bool operator !=(City city1, City city2)
        {
            return !(city1 == city2);
        }

        public static bool operator <(City city1, City city2)
        {
            if (city1 is null || city2 is null)
                return false;

            return city1.Population < city2.Population;
        }

        public static bool operator >(City city1, City city2)
        {
            if (city1 is null || city2 is null)
                return false;

            return city1.Population > city2.Population;
        }

        public override bool Equals(object obj)
        {
            if (obj is City otherCity)
                return this == otherCity;

            return false;
        }
    }
    public class CreditCard
    {
        private int cvc;
        private decimal balance;

        public int CVC
        {
            get { return cvc; }
            set { cvc = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public static CreditCard operator +(CreditCard card, decimal amount)
        {
            card.Balance += amount;
            return card;
        }

        public static CreditCard operator -(CreditCard card, decimal amount)
        {
            card.Balance -= amount;
            return card;
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            if (ReferenceEquals(card1, card2))
                return true;

            if (card1 is null || card2 is null)
                return false;

            return card1.CVC == card2.CVC;
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return !(card1 == card2);
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            if (card1 is null || card2 is null)
                return false;

            return card1.Balance < card2.Balance;
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            if (card1 is null || card2 is null)
                return false;

            return card1.Balance > card2.Balance;
        }

        public override bool Equals(object obj)
        {
            if (obj is CreditCard otherCard)
                return this == otherCard;

            return false;
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
                Console.WriteLine("#===========================#");
                Console.Write("Виберіть пункт меню -> ");
                switch_on = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.Clear();

                switch (switch_on)
                {
                    case 1:
                        {
                            Journal journal1 = new Journal();
                            journal1.NumberOfEmployees = 10;

                            journal1.IncreaseNumberOfEmployees(5);
                            Console.WriteLine(journal1.NumberOfEmployees); 

                            journal1.DecreaseNumberOfEmployees(3);
                            Console.WriteLine(journal1.NumberOfEmployees); 

                            Journal journal2 = new Journal();
                            journal2.NumberOfEmployees = 12;

                            bool isEqual = journal1.Equals(journal2);
                            Console.WriteLine(isEqual); 

                            bool isLess = journal1.NumberOfEmployees < journal2.NumberOfEmployees;
                            bool isGreater = journal1.NumberOfEmployees > journal2.NumberOfEmployees;
                            Console.WriteLine(isLess); 
                            Console.WriteLine(isGreater);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        {
                            Store store1 = new Store();
                            store1.Area = 100.0;

                            store1.IncreaseArea(50.0);
                            Console.WriteLine(store1.Area); 

                            store1.DecreaseArea(30.0);
                            Console.WriteLine(store1.Area); 

                            Store store2 = new Store();
                            store2.Area = 120.0;

                            bool isEqual = store1.Equals(store2);
                            Console.WriteLine(isEqual); 

                            bool isLess = store1.Area < store2.Area;
                            bool isGreater = store1.Area > store2.Area;
                            Console.WriteLine(isLess); 
                            Console.WriteLine(isGreater);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 3:
                        {
                            ReadingList myList = new ReadingList();

                            myList += "Book 1";
                            myList += "Book 2";
                            myList += "Book 3";

                            myList -= "Book 2";

                            bool containsBook = myList.ContainsBook("Book 3");
                            Console.WriteLine("Contains Book 3: " + containsBook); 

                            int count = myList.Count;
                            Console.WriteLine("Number of books: " + count); 

                            string book = myList[0];
                            Console.WriteLine("Book at index 0: " + book);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 4:
                        {

                            Employee employee1 = new Employee();
                            employee1.Salary = 1000.0;

                            employee1.IncreaseSalary(500.0);
                            Console.WriteLine(employee1.Salary); 

                            employee1.DecreaseSalary(300.0);
                            Console.WriteLine(employee1.Salary); 

                            Employee employee2 = new Employee();
                            employee2.Salary = 1200.0;

                            bool isEqual = employee1.Equals(employee2);
                            Console.WriteLine(isEqual); 

                            bool isLess = employee1.Salary < employee2.Salary;
                            bool isGreater = employee1.Salary > employee2.Salary;
                            Console.WriteLine(isLess); 
                            Console.WriteLine(isGreater);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 5:
                        {
                            Matrix matrix1 = new Matrix(2, 2);
                            matrix1[0, 0] = 1;
                            matrix1[0, 1] = 2;
                            matrix1[1, 0] = 3;
                            matrix1[1, 1] = 4;

                            Matrix matrix2 = new Matrix(2, 2);
                            matrix2[0, 0] = 5;
                            matrix2[0, 1] = 6;
                            matrix2[1, 0] = 7;
                            matrix2[1, 1] = 8;

                            Matrix matrix3 = matrix1 + matrix2;
                            Matrix matrix4 = matrix1 - matrix2;
                            Matrix matrix5 = matrix1 * matrix2;
                            Matrix matrix6 = matrix1 * 2;

                            bool isEqual = matrix1 == matrix2;
                            bool isNotEqual = matrix1 != matrix2;
                            bool isMatrix3EqualToMatrix5 = matrix3 == matrix5;

                            Console.WriteLine(matrix3[0, 0]);                           
                            Console.WriteLine(matrix4[1, 1]);
                            Console.WriteLine(matrix5[1, 0]);
                            Console.WriteLine(matrix6[0, 1]);

                            Console.WriteLine(isEqual); 
                            Console.WriteLine(isNotEqual); 
                            Console.WriteLine(isMatrix3EqualToMatrix5);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 6:
                        {
                            City city1 = new City();
                            city1.Population = 10000;

                            City city2 = new City();
                            city2.Population = 20000;

                            City city3 = city1 + 5000;
                            City city4 = city2 - 10000;

                            bool isEqual = city1 == city2;
                            bool isNotEqual = city1 != city2;
                            bool isCity1Smaller = city1 < city2;
                            bool isCity2Larger = city2 > city1;

                            Console.WriteLine(city3.Population); 
                            Console.WriteLine(city4.Population); 

                            Console.WriteLine(isEqual); 
                            Console.WriteLine(isNotEqual); 
                            Console.WriteLine(isCity1Smaller); 
                            Console.WriteLine(isCity2Larger); 

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 7:
                        {
                            CreditCard card1 = new CreditCard();
                            card1.CVC = 123;
                            card1.Balance = 1000;

                            CreditCard card2 = new CreditCard();
                            card2.CVC = 456;
                            card2.Balance = 2000;

                            CreditCard card3 = card1 + 500;
                            CreditCard card4 = card2 - 1000;

                            bool isEqual = card1 == card2;
                            bool isNotEqual = card1 != card2;
                            bool isCard1Smaller = card1 < card2;
                            bool isCard2Larger = card2 > card1;

                            Console.WriteLine(card1.Balance); 
                            Console.WriteLine(card2.Balance); 
                            Console.WriteLine(card3.Balance); 
                            Console.WriteLine(card4.Balance); 

                            Console.WriteLine(isEqual); 
                            Console.WriteLine(isNotEqual); 
                            Console.WriteLine(isCard1Smaller); 
                            Console.WriteLine(isCard2Larger); 


                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }
            }while (switch_on != 0);
           
        }
    }
}