using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    class EmployeeManagementApp
    {
        private Dictionary<string, string> employeeCredentials;

        public EmployeeManagementApp()
        {
            employeeCredentials = new Dictionary<string, string>();
        }

        public void AddEmployee(string username, string password)
        {
            if (!employeeCredentials.ContainsKey(username))
            {
                employeeCredentials.Add(username, password);
                Console.WriteLine("Співробітник доданий успішно.");
            }
            else
            {
                Console.WriteLine("Співробітник з таким логіном вже існує.");
            }
        }

        public void RemoveEmployee(string username)
        {
            if (employeeCredentials.ContainsKey(username))
            {
                employeeCredentials.Remove(username);
                Console.WriteLine("Співробітник видалений успішно.");
            }
            else
            {
                Console.WriteLine("Співробітник з таким логіном не знайдений.");
            }
        }

        public void UpdateEmployeeCredentials(string username, string newPassword)
        {
            if (employeeCredentials.ContainsKey(username))
            {
                employeeCredentials[username] = newPassword;
                Console.WriteLine("Інформацію оновлено успішно.");
            }
            else
            {
                Console.WriteLine("Співробітник з таким логіном не знайдений.");
            }
        }

        public string GetEmployeePassword(string username)
        {
            if (employeeCredentials.ContainsKey(username))
            {
                return employeeCredentials[username];
            }
            else
            {
                return "Співробітник з таким логіном не знайдений.";
            }
        }
    }

    class EnglishFrenchDictionary
    {
        private Dictionary<string, List<string>> dictionary;

        public EnglishFrenchDictionary()
        {
            dictionary = new Dictionary<string, List<string>>();
        }

        public void AddWord(string englishWord, List<string> frenchTranslations)
        {
            if (!dictionary.ContainsKey(englishWord))
            {
                dictionary.Add(englishWord, frenchTranslations);
                Console.WriteLine("Слово додано успішно.");
            }
            else
            {
                Console.WriteLine("Слово вже існує в словнику.");
            }
        }

        public void RemoveWord(string englishWord)
        {
            if (dictionary.ContainsKey(englishWord))
            {
                dictionary.Remove(englishWord);
                Console.WriteLine("Слово видалено успішно.");
            }
            else
            {
                Console.WriteLine("Слово не знайдено в словнику.");
            }
        }

        public void RemoveTranslation(string englishWord, string frenchTranslation)
        {
            if (dictionary.ContainsKey(englishWord))
            {
                if (dictionary[englishWord].Contains(frenchTranslation))
                {
                    dictionary[englishWord].Remove(frenchTranslation);
                    Console.WriteLine("Переклад видалено успішно.");
                }
                else
                {
                    Console.WriteLine("Переклад не знайдено для даного слова.");
                }
            }
            else
            {
                Console.WriteLine("Слово не знайдено в словнику.");
            }
        }

        public void UpdateWord(string englishWord, string newEnglishWord)
        {
            if (dictionary.ContainsKey(englishWord))
            {
                List<string> translations = dictionary[englishWord];
                dictionary.Remove(englishWord);
                dictionary.Add(newEnglishWord, translations);
                Console.WriteLine("Слово оновлено успішно.");
            }
            else
            {
                Console.WriteLine("Слово не знайдено в словнику.");
            }
        }

        public void UpdateTranslation(string englishWord, string oldFrenchTranslation, string newFrenchTranslation)
        {
            if (dictionary.ContainsKey(englishWord))
            {
                List<string> translations = dictionary[englishWord];
                if (translations.Contains(oldFrenchTranslation))
                {
                    int index = translations.IndexOf(oldFrenchTranslation);
                    translations[index] = newFrenchTranslation;
                    Console.WriteLine("Переклад оновлено успішно.");
                }
                else
                {
                    Console.WriteLine("Старий переклад не знайдено для даного слова.");
                }
            }
            else
            {
                Console.WriteLine("Слово не знайдено в словнику.");
            }
        }

        public void SearchTranslation(string englishWord)
        {
            if (dictionary.ContainsKey(englishWord))
            {
                List<string> translations = dictionary[englishWord];
                Console.WriteLine($"Переклад для слова '{englishWord}':");
                foreach (string translation in translations)
                {
                    Console.WriteLine(translation);
                }
            }
            else
            {
                Console.WriteLine("Слово не знайдено в словнику.");
            }
        }
    }
    class Cafe
    {
        private Queue<string> queue;
        private Dictionary<string, string> reservations;

        public Cafe()
        {
            queue = new Queue<string>();
            reservations = new Dictionary<string, string>();
        }

        public void AddToQueue(string visitorName)
        {
            if (reservations.ContainsValue(visitorName))
            {
                Console.WriteLine($"{visitorName} має зарезервований столик і може зайти позачергово.");
                return;
            }

            queue.Enqueue(visitorName);
            Console.WriteLine($"{visitorName} доданий до черги.");
        }

        public void FreeTable()
        {
            if (queue.Count > 0)
            {
                string visitorName = queue.Dequeue();
                Console.WriteLine($"{visitorName} зайшов до кафе і зайняв столик.");
            }
            else
            {
                Console.WriteLine("В черзі немає жодного відвідувача.");
            }
        }

        public void ReserveTable(string visitorName, string reservedTable)
        {
            if (!reservations.ContainsKey(reservedTable))
            {
                reservations.Add(reservedTable, visitorName);
                Console.WriteLine($"{visitorName} зарезервував столик {reservedTable}.");
            }
            else
            {
                Console.WriteLine($"Столик {reservedTable} вже зарезервований.");
            }
        }
    }
}
