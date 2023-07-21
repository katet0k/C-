using System.Globalization;
using System.Text;

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
                Console.WriteLine("#===========================#");
                Console.Write("Виберіть пункт меню -> ");
                switch_on = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.Clear();

                switch (switch_on)
                {
                    case 1:
                        {
                            Film film1 = new Film("Inception", "Warner Bros.", "Sci-Fi", 148, 2010);
                            Film film2 = new Film("The Shawshank Redemption", "Castle Rock Entertainment", "Drama", 142, 1994);

                            film1.DisplayInfo();
                            Console.WriteLine();

                            film2.DisplayInfo();
                            Console.WriteLine();

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                        case 2:
                        {
                            List<string> actorsList = new List<string> { "Actor1", "Actor2", "Actor3" };

                            using (Show show = new Show("Hamlet", "National Theatre", "Tragedy", 180, actorsList))
                            {
                                show.DisplayInfo();
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 3:
                        {
                            using (FilmID film1 = new FilmID("Inception", "Warner Bros.", "Sci-Fi", 148, 2010))
                            {
                                film1.DisplayInfo();
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 4:
                        {
                            Play play1 = new Play("Romeo and Juliet", "William Shakespeare", "Tragedy", 1595);
                            Play play2 = new Play("The Importance of Being Earnest", "Oscar Wilde", "Comedy", 1895);

                            play1.DisplayInfo();
                            Console.WriteLine();

                            play2.DisplayInfo();
                            Console.WriteLine();

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 5:
                        {
                            using (Shop shop1 = new Shop("Supermarket", "123 Main Street", Shop.ShopType.Grocery))
                            {
                                shop1.DisplayInfo();
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 6:
                        {
                            using (PlayID play1 = new PlayID("Romeo and Juliet", "William Shakespeare", "Tragedy", 1595))
                            {
                                play1.DisplayInfo();
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