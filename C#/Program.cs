using System.Globalization;
using System.Text;

namespace C_
{
    internal class Program
    {
        public class Money
        {
            private int dollars;
            private int cents;

            public int Dollars
            {
                get { return dollars; }
                set { dollars = value; }
            }

            public int Cents
            {
                get { return cents; }
                set { cents = value; }
            }

            public void DisplayAmount()
            {
                Console.WriteLine($"Amount: {dollars}.{cents.ToString().PadLeft(2, '0')}");
            }
        }

        public class Product : Money
        {
            public void DecreasePrice(int amount)
            {
                if (Cents >= amount)
                    Cents -= amount;
                else
                {
                    int remainingAmount = amount - Cents;
                    Cents = 100 - remainingAmount;
                    Dollars--;
                }
            }
        }

        public class Device
        {
            protected string name;
            protected string characteristics;

            public Device(string name, string characteristics)
            {
                this.name = name;
                this.characteristics = characteristics;
            }

            public virtual void Sound()
            {
                Console.WriteLine("Device sound");
            }

            public void Show()
            {
                Console.WriteLine($"Device name: {name}");
            }

            public void Desc()
            {
                Console.WriteLine($"Device description: {characteristics}");
            }
        }

        public class Kettle : Device
        {
            public Kettle(string name, string characteristics) : base(name, characteristics)
            {
            }

            public override void Sound()
            {
                Console.WriteLine("Kettle sound: Whistle");
            }
        }

        public class Microwave : Device
        {
            public Microwave(string name, string characteristics) : base(name, characteristics)
            {
            }

            public override void Sound()
            {
                Console.WriteLine("Microwave sound: Beep");
            }
        }

        public class Car : Device
        {
            public Car(string name, string characteristics) : base(name, characteristics)
            {
            }

            public override void Sound()
            {
                Console.WriteLine("Car sound: Engine noise");
            }
        }

        public class Steamship : Device
        {
            public Steamship(string name, string characteristics) : base(name, characteristics)
            {
            }

            public override void Sound()
            {
                Console.WriteLine("Steamship sound: Steam whistle");
            }
        }

        public class MusicalInstrument
        {
            protected string name;
            protected string characteristics;

            public MusicalInstrument(string name, string characteristics)
            {
                this.name = name;
                this.characteristics = characteristics;
            }

            public virtual void Sound()
            {
                Console.WriteLine("Musical instrument sound");
            }

            public void Show()
            {
                Console.WriteLine($"Musical instrument name: {name}");
            }

            public void Desc()
            {
                Console.WriteLine($"Musical instrument description: {characteristics}");
            }

            public virtual void History()
            {
                Console.WriteLine("No specific history available");
            }
        }

        public class Violin : MusicalInstrument
        {
            public Violin(string name, string characteristics) : base(name, characteristics)
            {
            }

            public override void Sound()
            {
                Console.WriteLine("Violin sound: Sustained and expressive");
            }

            public override void History()
            {
                Console.WriteLine("Violin history: Originated in Italy in the early 16th century");
            }
        }

        public class Trombone : MusicalInstrument
        {
            public Trombone(string name, string characteristics) : base(name, characteristics)
            {
            }

            public override void Sound()
            {
                Console.WriteLine("Trombone sound: Rich and brassy");
            }

            public override void History()
            {
                Console.WriteLine("Trombone history: Developed in the 15th century in Germany");
            }
        }

        public class Ukulele : MusicalInstrument
        {
            public Ukulele(string name, string characteristics) : base(name, characteristics)
            {
            }

            public override void Sound()
            {
                Console.WriteLine("Ukulele sound: Bright and cheerful");
            }

            public override void History()
            {
                Console.WriteLine("Ukulele history: Originated in Hawaii in the 19th century");
            }
        }

        public class Cello : MusicalInstrument
        {
            public Cello(string name, string characteristics) : base(name, characteristics)
            {
            }

            public override void Sound()
            {
                Console.WriteLine("Cello sound: Deep and resonant");
            }

            public override void History()
            {
                Console.WriteLine("Cello history: Evolved in Europe in the 17th century");
            }
        }

public abstract class Worker
    {
        public abstract void Print();
    }

    public class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("President: Manages the organization, makes strategic decisions");
        }
    }

    public class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Security: Ensures safety and security of the organization");
        }
    }

    public class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Manager: Oversees a team or department, responsible for achieving goals");
        }
    }

    public class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Engineer: Designs and develops technical solutions");
        }
    }

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
                Console.WriteLine("#===========================#");
                Console.Write("Виберіть пункт меню -> ");
                switch_on = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.Clear();

                switch (switch_on)
                {
                    case 1:
                        {
                            Product product = new Product();
                            product.Dollars = 10;
                            product.Cents = 50;

                            product.DisplayAmount();

                            product.DecreasePrice(70);

                            product.DisplayAmount();

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        break;
                        case 2:
                        {
                            Device device = new Device("Generic Device", "Generic Characteristics");
                            Kettle kettle = new Kettle("Electric Kettle", "Boils water for tea");
                            Microwave microwave = new Microwave("Microwave Oven", "Heats food using microwaves");
                            Car car = new Car("Sedan Car", "Four-wheeled motor vehicle");
                            Steamship steamship = new Steamship("Steamship", "Powered by steam engine");

                            device.Show(); 
                            device.Desc(); 
                            device.Sound(); 

                            kettle.Show(); 
                            kettle.Desc(); 
                            kettle.Sound(); 

                            microwave.Show();
                            microwave.Desc();
                            microwave.Sound(); 

                            car.Show(); 
                            car.Desc(); 
                            car.Sound(); 

                            steamship.Show();
                            steamship.Desc();
                            steamship.Sound();

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 3:
                        {
                            Violin violin = new Violin("Violin", "String instrument");
                            Trombone trombone = new Trombone("Trombone", "Brass instrument");
                            Ukulele ukulele = new Ukulele("Ukulele", "Plucked string instrument");
                            Cello cello = new Cello("Cello", "String instrument");

                            violin.Show();  
                            violin.Desc();  
                            violin.Sound(); 
                            violin.History(); 

                            trombone.Show();  
                            trombone.Desc();  
                            trombone.Sound();  
                            trombone.History();  

                            ukulele.Show();  
                            ukulele.Desc();  
                            ukulele.Sound();  
                            ukulele.History();  

                            cello.Show(); 
                            cello.Desc();  
                            cello.Sound();  
                            cello.History();

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        break;

                    case 4:
                        {
                            Worker president = new President();
                            Worker security = new Security();
                            Worker manager = new Manager();
                            Worker engineer = new Engineer();

                            president.Print(); 
                            security.Print(); 
                            manager.Print();  
                            engineer.Print();

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