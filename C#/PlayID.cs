using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class PlayID : IDisposable
    {
        // Властивості класу
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public PlayID(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("П'єса: " + Title);
            Console.WriteLine("Автор: " + Author);
            Console.WriteLine("Жанр: " + Genre);
            Console.WriteLine("Рік: " + Year);
        }

        public void Dispose()
        {
        }

        ~PlayID()
        {
        }
    }
}
