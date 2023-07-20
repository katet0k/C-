using System.Globalization;
using System.Text;

namespace C_
{
    class Employee
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
    }
    class Patient
    {
        public string Name { get; set; }
    }
    internal class Program
    {
        static List<Employee> employees = new List<Employee>();
        static LinkedList<Book> books = new LinkedList<Book>();
        static Queue<Patient> queue = new Queue<Patient>();
        static int maxQueueSize = 3;

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
                Console.WriteLine("#===========================#");
                Console.Write("Виберіть пункт меню -> ");
                switch_on = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.Clear();

                switch (switch_on)
                {
                    case 1:
                        {
                            string option;

                            do
                            {
                                Console.WriteLine("Облік співробітників");
                                Console.WriteLine("1. Додати співробітника");
                                Console.WriteLine("2. Видалити співробітника");
                                Console.WriteLine("3. Змінити інформацію про співробітника");
                                Console.WriteLine("4. Пошук співробітників за параметрами");
                                Console.WriteLine("5. Сортування співробітників за параметрами");
                                Console.WriteLine("0. Вийти з програми");

                                Console.Write("Виберіть опцію: ");
                                option = Console.ReadLine();
                                Console.WriteLine();

                                switch (option)
                                {

                                    case "1":
                                        { AddEmployee(); }
                                        break;
                                    case "2":
                                        { RemoveEmployee(); }
                                        break;
                                    case "3":
                                        { UpdateEmployee(); }
                                        break;
                                    case "4":
                                        { SearchEmployees(); }
                                        break;
                                    case "5":
                                        { SortEmployees(); }
                                        break;
                                    default:
                                        Console.WriteLine("Недійсна опція. Спробуйте ще раз.");
                                        break;
                                }

                                Console.WriteLine();
                            } while (option != "0");
                        }

                        static void AddEmployee()
                        {
                            Console.WriteLine("Додавання співробітника");
                            Console.Write("П.І.Б.: ");
                            string fullName = Console.ReadLine();
                            Console.Write("Посада: ");
                            string position = Console.ReadLine();
                            Console.Write("Заробітна плата: ");
                            decimal salary = decimal.Parse(Console.ReadLine());
                            Console.Write("Корпоративний email: ");
                            string email = Console.ReadLine();

                            Employee newEmployee = new Employee
                            {
                                FullName = fullName,
                                Position = position,
                                Salary = salary,
                                Email = email
                            };

                            employees.Add(newEmployee);

                            Console.WriteLine("Співробітник доданий успішно.");
                        }
                        break;

                        static void RemoveEmployee()
                        {
                            Console.WriteLine("Видалення співробітника");
                            Console.Write("Введіть індекс співробітника для видалення: ");
                            int index = int.Parse(Console.ReadLine());

                            if (index >= 0 && index < employees.Count)
                            {
                                employees.RemoveAt(index);
                                Console.WriteLine("Співробітник видалений успішно.");
                            }
                            else
                            {
                                Console.WriteLine("Недійсний індекс співробітника.");
                            }
                        }

                        static void UpdateEmployee()
                        {
                            Console.WriteLine("Зміна інформації про співробітника");
                            Console.Write("Введіть індекс співробітника для зміни: ");
                            int index = int.Parse(Console.ReadLine());

                            if (index >= 0 && index < employees.Count)
                            {
                                Employee employee = employees[index];

                                Console.Write("Нове П.І.Б.: ");
                                string fullName = Console.ReadLine();
                                Console.Write("Нова посада: ");
                                string position = Console.ReadLine();
                                Console.Write("Нова заробітна плата: ");
                                decimal salary = decimal.Parse(Console.ReadLine());
                                Console.Write("Новий корпоративний email: ");
                                string email = Console.ReadLine();

                                employee.FullName = fullName;
                                employee.Position = position;
                                employee.Salary = salary;
                                employee.Email = email;

                                Console.WriteLine("Інформація про співробітника змінена успішно.");
                            }
                            else
                            {
                                Console.WriteLine("Недійсний індекс співробітника.");
                            }
                        }

                        static void SearchEmployees()
                        {
                            Console.WriteLine("Пошук співробітників за параметрами");
                            Console.WriteLine("1. Пошук за П.І.Б.");
                            Console.WriteLine("2. Пошук за посадою");
                            Console.WriteLine("3. Пошук за заробітною платою");
                            Console.WriteLine("4. Пошук за email");
                            Console.Write("Виберіть опцію: ");
                            string option = Console.ReadLine();
                            Console.Write("Введіть критерій пошуку: ");
                            string searchCriteria = Console.ReadLine();

                            List<Employee> searchResults = new List<Employee>();

                            switch (option)
                            {
                                case "1":
                                    { searchResults = employees.FindAll(e => e.FullName.Contains(searchCriteria)); }
                                    break;
                                case "2":
                                    { searchResults = employees.FindAll(e => e.Position.Contains(searchCriteria)); }
                                    break;
                                case "3":
                                    {
                                        decimal searchSalary = decimal.Parse(searchCriteria);
                                        searchResults = employees.FindAll(e => e.Salary == searchSalary);
                                    }
                                    break;
                                case "4":
                                    { searchResults = employees.FindAll(e => e.Email.Contains(searchCriteria)); }
                                    break;
                                default:
                                    Console.WriteLine("Недійсна опція. Спробуйте ще раз.");
                                    return;
                            }

                            Console.WriteLine("Результати пошуку:");

                            if (searchResults.Count > 0)
                            {
                                for (int i = 0; i < searchResults.Count; i++)
                                {
                                    Console.WriteLine($"Співробітник #{i + 1}:");
                                    Console.WriteLine($"П.І.Б.: {searchResults[i].FullName}");
                                    Console.WriteLine($"Посада: {searchResults[i].Position}");
                                    Console.WriteLine($"Заробітна плата: {searchResults[i].Salary}");
                                    Console.WriteLine($"Корпоративний email: {searchResults[i].Email}");
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Немає результатів для заданих параметрів пошуку.");
                            }
                        }

                        static void SortEmployees()
                        {
                            Console.WriteLine("Сортування співробітників за параметрами");
                            Console.WriteLine("1. Сортування за П.І.Б.");
                            Console.WriteLine("2. Сортування за посадою");
                            Console.WriteLine("3. Сортування за заробітною платою");
                            Console.WriteLine("4. Сортування за email");
                            Console.Write("Виберіть опцію: ");
                            string option = Console.ReadLine();

                            switch (option)
                            {
                                case "1":
                                    { employees.Sort((e1, e2) => e1.FullName.CompareTo(e2.FullName)); }
                                    break;
                                case "2":
                                    { employees.Sort((e1, e2) => e1.Position.CompareTo(e2.Position)); }
                                    break;
                                case "3":
                                    { employees.Sort((e1, e2) => e1.Salary.CompareTo(e2.Salary)); }
                                    break;
                                case "4":
                                    { employees.Sort((e1, e2) => e1.Email.CompareTo(e2.Email)); }
                                    break;
                                default:
                                    Console.WriteLine("Недійсна опція. Спробуйте ще раз.");
                                    return;
                            }

                            Console.WriteLine("Список співробітників після сортування:");

                            for (int i = 0; i < employees.Count; i++)
                            {
                                Console.WriteLine($"Співробітник #{i + 1}:");
                                Console.WriteLine($"П.І.Б.: {employees[i].FullName}");
                                Console.WriteLine($"Посада: {employees[i].Position}");
                                Console.WriteLine($"Заробітна плата: {employees[i].Salary}");
                                Console.WriteLine($"Корпоративний email: {employees[i].Email}");
                                Console.WriteLine();
                            }
                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    case 2:
                        {
                            string option;
                            do
                            {
                                Console.WriteLine("Облік книг");
                                Console.WriteLine("1. Додати книгу");
                                Console.WriteLine("2. Видалити книгу");
                                Console.WriteLine("3. Змінити інформацію про книгу");
                                Console.WriteLine("4. Пошук книг за параметрами");
                                Console.WriteLine("5. Вставити книгу у початок списку");
                                Console.WriteLine("6. Вставити книгу у кінець списку");
                                Console.WriteLine("7. Вставити книгу у певну позицію");
                                Console.WriteLine("8. Видалити книгу з початку списку");
                                Console.WriteLine("9. Видалити книгу з кінця списку");
                                Console.WriteLine("10. Видалити книгу з певної позиції");
                                Console.WriteLine("11. Вийти з програми");

                                Console.Write("Виберіть опцію: ");
                                option = Console.ReadLine();
                                Console.WriteLine();

                                switch (option)
                                {
                                    case "1":
                                        AddBook();
                                        break;
                                    case "2":
                                        RemoveBook();
                                        break;
                                    case "3":
                                        UpdateBook();
                                        break;
                                    case "4":
                                        SearchBooks();
                                        break;
                                    case "5":
                                        InsertBookAtBeginning();
                                        break;
                                    case "6":
                                        InsertBookAtEnd();
                                        break;
                                    case "7":
                                        InsertBookAtPosition();
                                        break;
                                    case "8":
                                        RemoveBookFromBeginning();
                                        break;
                                    case "9":
                                        RemoveBookFromEnd();
                                        break;
                                    case "10":
                                        RemoveBookFromPosition();
                                        break;
                                    case "0":
                                        break;
                                    default:
                                        Console.WriteLine("Недійсна опція. Спробуйте ще раз.");
                                        break;
                                }

                                Console.WriteLine();
                            }
                            while (option != "0");
                        }
                        break;

                        static void AddBook()
                        {
                            Console.WriteLine("Додавання книги");
                            Console.Write("Назва книги: ");
                            string title = Console.ReadLine();
                            Console.Write("П.І.Б. автора: ");
                            string author = Console.ReadLine();
                            Console.Write("Жанр книги: ");
                            string genre = Console.ReadLine();
                            Console.Write("Рік видання: ");
                            int year = int.Parse(Console.ReadLine());

                            Book newBook = new Book
                            {
                                Title = title,
                                Author = author,
                                Genre = genre,
                                Year = year
                            };

                            books.AddLast(newBook);

                            Console.WriteLine("Книга додана успішно.");
                        }

                        static void RemoveBook()
                        {
                            Console.WriteLine("Видалення книги");
                            Console.Write("Введіть індекс книги для видалення: ");
                            int index = int.Parse(Console.ReadLine());

                            if (index >= 0 && index < books.Count)
                            {
                                LinkedListNode<Book> node = GetBookNodeByIndex(index);
                                books.Remove(node);
                                Console.WriteLine("Книга видалена успішно.");
                            }
                            else
                            {
                                Console.WriteLine("Недійсний індекс книги.");
                            }
                        }

                        static void UpdateBook()
                        {
                            Console.WriteLine("Зміна інформації про книгу");
                            Console.Write("Введіть індекс книги для зміни: ");
                            int index = int.Parse(Console.ReadLine());

                            if (index >= 0 && index < books.Count)
                            {
                                LinkedListNode<Book> node = GetBookNodeByIndex(index);
                                Book book = node.Value;

                                Console.Write("Нова назва книги: ");
                                string title = Console.ReadLine();
                                Console.Write("Нове П.І.Б. автора: ");
                                string author = Console.ReadLine();
                                Console.Write("Новий жанр книги: ");
                                string genre = Console.ReadLine();
                                Console.Write("Новий рік видання: ");
                                int year = int.Parse(Console.ReadLine());

                                book.Title = title;
                                book.Author = author;
                                book.Genre = genre;
                                book.Year = year;

                                Console.WriteLine("Інформація про книгу змінена успішно.");
                            }
                            else
                            {
                                Console.WriteLine("Недійсний індекс книги.");
                            }
                        }

                        static void SearchBooks()
                        {
                            Console.WriteLine("Пошук книг за параметрами");
                            Console.WriteLine("1. Пошук за назвою книги");
                            Console.WriteLine("2. Пошук за П.І.Б. автора");
                            Console.WriteLine("3. Пошук за жанром книги");
                            Console.WriteLine("4. Пошук за роком видання");
                            Console.Write("Виберіть опцію: ");
                            string option = Console.ReadLine();
                            Console.Write("Введіть критерій пошуку: ");
                            string searchCriteria = Console.ReadLine();

                            List<Book> searchResults = new List<Book>();

                            foreach (Book book in books)
                            {
                                bool match = false;

                                switch (option)
                                {
                                    case "1":
                                        match = book.Title.Contains(searchCriteria);
                                        break;
                                    case "2":
                                        match = book.Author.Contains(searchCriteria);
                                        break;
                                    case "3":
                                        match = book.Genre.Contains(searchCriteria);
                                        break;
                                    case "4":
                                        int searchYear = int.Parse(searchCriteria);
                                        match = book.Year == searchYear;
                                        break;
                                    default:
                                        Console.WriteLine("Недійсна опція. Спробуйте ще раз.");
                                        return;
                                }

                                if (match)
                                {
                                    searchResults.Add(book);
                                }
                            }

                            Console.WriteLine("Результати пошуку:");

                            if (searchResults.Count > 0)
                            {
                                for (int i = 0; i < searchResults.Count; i++)
                                {
                                    Console.WriteLine($"Книга #{i + 1}:");
                                    Console.WriteLine($"Назва книги: {searchResults[i].Title}");
                                    Console.WriteLine($"П.І.Б. автора: {searchResults[i].Author}");
                                    Console.WriteLine($"Жанр книги: {searchResults[i].Genre}");
                                    Console.WriteLine($"Рік видання: {searchResults[i].Year}");
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Немає результатів для заданих параметрів пошуку.");
                            }
                        }

                        static void InsertBookAtBeginning()
                        {
                            Console.WriteLine("Вставка книги у початок списку");
                            Console.Write("Назва книги: ");
                            string title = Console.ReadLine();
                            Console.Write("П.І.Б. автора: ");
                            string author = Console.ReadLine();
                            Console.Write("Жанр книги: ");
                            string genre = Console.ReadLine();
                            Console.Write("Рік видання: ");
                            int year = int.Parse(Console.ReadLine());

                            Book newBook = new Book
                            {
                                Title = title,
                                Author = author,
                                Genre = genre,
                                Year = year
                            };

                            books.AddFirst(newBook);

                            Console.WriteLine("Книга вставлена успішно у початок списку.");
                        }

                        static void InsertBookAtEnd()
                        {
                            Console.WriteLine("Вставка книги у кінець списку");
                            Console.Write("Назва книги: ");
                            string title = Console.ReadLine();
                            Console.Write("П.І.Б. автора: ");
                            string author = Console.ReadLine();
                            Console.Write("Жанр книги: ");
                            string genre = Console.ReadLine();
                            Console.Write("Рік видання: ");
                            int year = int.Parse(Console.ReadLine());

                            Book newBook = new Book
                            {
                                Title = title,
                                Author = author,
                                Genre = genre,
                                Year = year
                            };

                            books.AddLast(newBook);

                            Console.WriteLine("Книга вставлена успішно у кінець списку.");
                        }

                        static void InsertBookAtPosition()
                        {
                            Console.WriteLine("Вставка книги у певну позицію");
                            Console.Write("Введіть індекс позиції для вставки: ");
                            int index = int.Parse(Console.ReadLine());

                            if (index >= 0 && index <= books.Count)
                            {
                                Console.Write("Назва книги: ");
                                string title = Console.ReadLine();
                                Console.Write("П.І.Б. автора: ");
                                string author = Console.ReadLine();
                                Console.Write("Жанр книги: ");
                                string genre = Console.ReadLine();
                                Console.Write("Рік видання: ");
                                int year = int.Parse(Console.ReadLine());

                                Book newBook = new Book
                                {
                                    Title = title,
                                    Author = author,
                                    Genre = genre,
                                    Year = year
                                };

                                LinkedListNode<Book> node = GetBookNodeByIndex(index);
                                books.AddBefore(node, newBook);

                                Console.WriteLine("Книга вставлена успішно.");
                            }
                            else
                            {
                                Console.WriteLine("Недійсний індекс позиції.");
                            }
                        }

                        static void RemoveBookFromBeginning()
                        {
                            if (books.First != null)
                            {
                                books.RemoveFirst();
                                Console.WriteLine("Книга видалена успішно з початку списку.");
                            }
                            else
                            {
                                Console.WriteLine("Список книг порожній.");
                            }
                        }

                        static void RemoveBookFromEnd()
                        {
                            if (books.Last != null)
                            {
                                books.RemoveLast();
                                Console.WriteLine("Книга видалена успішно з кінця списку.");
                            }
                            else
                            {
                                Console.WriteLine("Список книг порожній.");
                            }
                        }

                        static void RemoveBookFromPosition()
                        {
                            Console.WriteLine("Видалення книги з певної позиції");
                            Console.Write("Введіть індекс позиції для видалення: ");
                            int index = int.Parse(Console.ReadLine());

                            if (index >= 0 && index < books.Count)
                            {
                                LinkedListNode<Book> node = GetBookNodeByIndex(index);
                                books.Remove(node);
                                Console.WriteLine("Книга видалена успішно.");
                            }
                            else
                            {
                                Console.WriteLine("Недійсний індекс позиції.");
                            }
                        }

                        static LinkedListNode<Book> GetBookNodeByIndex(int index)
                        {
                            LinkedListNode<Book> currentNode = books.First;

                            for (int i = 0; i < index; i++)
                            {
                                currentNode = currentNode.Next;
                            }

                            return currentNode;
                        }

                    case 3:
                        {
                            bool exit = false;

                            while (!exit)
                            {
                                Console.WriteLine("Додаток-емуляція черги в поліклініку");
                                Console.WriteLine("1. Додати пацієнта до черги");
                                Console.WriteLine("2. Прийняти пацієнта до лікаря");
                                Console.WriteLine("3. Вийти з програми");

                                Console.Write("Виберіть опцію: ");
                                string option = Console.ReadLine();
                                Console.WriteLine();

                                switch (option)
                                {
                                    case "1":
                                        AddPatientToQueue();
                                        break;
                                    case "2":
                                        ProcessPatient();
                                        break;
                                    case "3":
                                        exit = true;
                                        break;
                                    default:
                                        Console.WriteLine("Недійсна опція. Спробуйте ще раз.");
                                        break;
                                }

                                Console.WriteLine();
                            }
                        }

                        static void AddPatientToQueue()
                        {
                            if (queue.Count >= maxQueueSize)
                            {
                                Console.WriteLine("Черга заповнена. Пацієнт не може бути доданий.");
                                return;
                            }

                            Console.Write("Введіть ім'я пацієнта: ");
                            string name = Console.ReadLine();

                            Patient patient = new Patient { Name = name };
                            queue.Enqueue(patient);

                            Console.WriteLine($"Пацієнт {name} доданий до черги.");
                        }

                        static void ProcessPatient()
                        {
                            if (queue.Count == 0)
                            {
                                Console.WriteLine("Черга порожня. Немає пацієнтів для обслуговування.");
                                return;
                            }

                            Patient patient = queue.Dequeue();
                            Console.WriteLine($"Пацієнт {patient.Name} прийнятий до лікаря.");
                        }
                
                        break;
                    default:
                        break;
                }
            } while (switch_on != 0);
        }
    }
}