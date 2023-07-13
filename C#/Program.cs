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
                            Oceanarium oceanarium = new Oceanarium();
                            oceanarium.AddCreature("Дельфін", "Делфініди");
                            oceanarium.AddCreature("Акула", "Хрящові риби");
                            oceanarium.AddCreature("Кит", "Китові");
                            oceanarium.AddCreature("Морський коник", "Коникові");

                            foreach (MarineCreature creature in oceanarium)
                            {
                                Console.WriteLine("Назва: " + creature.Name);
                                Console.WriteLine("Вид: " + creature.Species);
                                Console.WriteLine();
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        {
                            FootballTeam team = new FootballTeam();
                            team.AddPlayer("Іван", 7);
                            team.AddPlayer("Роман", 10);
                            team.AddPlayer("Григорій", 4);
                            team.AddPlayer("Леонід", 9);

                            foreach (FootballPlayer player in team)
                            {
                                Console.WriteLine("Гравець: " + player.Name);
                                Console.WriteLine("Номер: " + player.Number);
                                Console.WriteLine();
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        {
                            Cafe cafe = new Cafe();
                            cafe.AddWorker("Джон", "Бариста");
                            cafe.AddWorker("Майкл", "Офіціант");
                            cafe.AddWorker("Девід", "Шеф-кухар");
                            cafe.AddWorker("Емілі", "Бармен");

                            foreach (CafeWorker worker in cafe)
                            {
                                Console.WriteLine("Працівник: " + worker.Name);
                                Console.WriteLine("Посада: " + worker.Position);
                                Console.WriteLine();
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 4:
                        {
                            Alphabet alphabet = new Alphabet();

                            foreach (char letter in alphabet)
                            {
                                Console.WriteLine(letter);
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 5:
                        {
                            House house = new House();

                            house.AddApartment(101);
                            house.AddResidentToApartment(101, "Іван");
                            house.AddResidentToApartment(101, "Надія");

                            house.AddApartment(202);
                            house.AddResidentToApartment(202, "Микола");

                            foreach (Apartment apartment in house)
                            {
                                Console.WriteLine("Квартира №" + apartment.Number);
                                Console.WriteLine("Мешканці:");
                                foreach (string resident in apartment.Residents)
                                {
                                    Console.WriteLine(resident);
                                }
                                Console.WriteLine();
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 6:
                        {
                            Garage garage = new Garage();
                            garage.AddCar("Toyota", "Camry");
                            garage.AddCar("Honda", "Civic");
                            garage.AddCar("Ford", "Mustang");

                            foreach (Car car in garage)
                            {
                                Console.WriteLine("Марка: " + car.Make);
                                Console.WriteLine("Модель: " + car.Model);
                                Console.WriteLine();
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