using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Show : IDisposable
    {
        // Властивості класу
        public string Title { get; set; }
        public string Theater { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public List<string> Actors { get; set; }

        public Show(string title, string theater, string genre, int duration, List<string> actors)
        {
            Title = title;
            Theater = theater;
            Genre = genre;
            Duration = duration;
            Actors = actors;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Вистава: " + Title);
            Console.WriteLine("Театр: " + Theater);
            Console.WriteLine("Жанр: " + Genre);
            Console.WriteLine("Тривалість: " + Duration + " хв");
            Console.WriteLine("Актори:");
            foreach (string actor in Actors)
            {
                Console.WriteLine("- " + actor);
            }
        }

        public void Dispose()
        {
        }
    }

}
