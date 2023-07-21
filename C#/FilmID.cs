using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class FilmID : IDisposable
    {
        // Властивості класу
        public string Title { get; set; }
        public string Studio { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public int Year { get; set; }

        // Конструктор класу
        public FilmID(string title, string studio, string genre, int duration, int year)
        {
            Title = title;
            Studio = studio;
            Genre = genre;
            Duration = duration;
            Year = year;
        }

        // Метод для виведення інформації про фільм
        public void DisplayInfo()
        {
            Console.WriteLine("Фільм: " + Title);
            Console.WriteLine("Кіностудія: " + Studio);
            Console.WriteLine("Жанр: " + Genre);
            Console.WriteLine("Тривалість: " + Duration + " хв");
            Console.WriteLine("Рік: " + Year);
        }

        public void Dispose()
        {
            
        }

        ~FilmID()
        {
           
        }
    }
}
