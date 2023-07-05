using System.Globalization;
using System.Text;
using System;

namespace C_
{
    internal class Program
    {

public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }

    public class Builder : Human
    {
        public string Specialization { get; set; }

        public void Build()
        {
            Console.WriteLine($"I am a builder specialized in {Specialization}.");
        }
    }

    public class Sailor : Human
    {
        public string ShipName { get; set; }

        public void Sail()
        {
            Console.WriteLine($"I am a sailor on the ship {ShipName}.");
        }
    }

        public class Pilot : Human
        {
            public string Aircraft { get; set; }

            public void Fly()
            {
                Console.WriteLine($"I am a pilot flying {Aircraft}.");
            }
        }

public class Passport
    {
        public string Name { get; set; }
        public string PassportNumber { get; set; }
        public DateTime ExpirationDate { get; set; }

        public void DisplayInformation()
        {
            Console.WriteLine($"Passport Information:\nName: {Name}\nPassport Number: {PassportNumber}\nExpiration Date: {ExpirationDate}");
        }
    }

    public class ForeignPassport : Passport
    {
        public string VisaInformation { get; set; }
        public string ForeignPassportNumber { get; set; }

        public void DisplayForeignPassportInformation()
        {
            Console.WriteLine($"Foreign Passport Information:\nName: {Name}\nPassport Number: {PassportNumber}\nExpiration Date: {ExpirationDate}\nVisa Information: {VisaInformation}\nForeign Passport Number: {ForeignPassportNumber}");
        }
    }
public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void DisplayInformation()
        {
            Console.WriteLine($"Animal: {Name}");
        }
    }

    public class Tiger : Animal
    {
        public string Color { get; set; }

        public Tiger(string name, string color) : base(name)
        {
            Color = color;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"Color: {Color}");
        }
    }

    public class Crocodile : Animal
    {
        public int TeethCount { get; set; }

        public Crocodile(string name, int teethCount) : base(name)
        {
            TeethCount = teethCount;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"Teeth Count: {TeethCount}");
        }
    }

    public class Kangaroo : Animal
    {
        public double JumpHeight { get; set; }

        public Kangaroo(string name, double jumpHeight) : base(name)
        {
            JumpHeight = jumpHeight;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"Jump Height: {JumpHeight} meters");
        }
    }
public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class RightTriangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public RightTriangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }

    public class Trapezoid : Shape
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Height { get; set; }

        public Trapezoid(double base1, double base2, double height)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * (Base1 + Base2) * Height;
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
                            Builder builder = new Builder();
                            builder.Name = "John";
                            builder.Age = 35;
                            builder.Specialization = "Carpentry";
                            builder.Introduce(); 
                            builder.Build();  

                            Sailor sailor = new Sailor();
                            sailor.Name = "Mary";
                            sailor.Age = 28;
                            sailor.ShipName = "Ocean Voyager";
                            sailor.Introduce();  
                            sailor.Sail();  

                            Pilot pilot = new Pilot();
                            pilot.Name = "Tom";
                            pilot.Age = 40;
                            pilot.Aircraft = "Boeing 747";
                            pilot.Introduce();  
                            pilot.Fly();  

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:
                        {
                        Passport passport = new Passport();
                        passport.Name = "John Doe";
                        passport.PassportNumber = "ABC123";
                        passport.ExpirationDate = new DateTime(2025, 12, 31);
                        passport.DisplayInformation();

                        ForeignPassport foreignPassport = new ForeignPassport();
                        foreignPassport.Name = "Jane Smith";
                        foreignPassport.PassportNumber = "XYZ789";
                        foreignPassport.ExpirationDate = new DateTime(2030, 6, 30);
                        foreignPassport.VisaInformation = "Visa Type: Tourist Visa, Valid until: 06/30/2025";
                        foreignPassport.ForeignPassportNumber = "ZYX987";
                        foreignPassport.DisplayForeignPassportInformation();

                        Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    break;
                    case 3:
                        {
                            Tiger tiger = new Tiger("Siberian Tiger", "Orange and black");
                            tiger.DisplayInformation();

                            Crocodile crocodile = new Crocodile("Nile Crocodile", 80);
                            crocodile.DisplayInformation();

                            Kangaroo kangaroo = new Kangaroo("Red Kangaroo", 3.5);
                            kangaroo.DisplayInformation();

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 4:
                        {
                            Shape[] shapes = new Shape[4];
                            shapes[0] = new Rectangle(5, 3);
                            shapes[1] = new Circle(2);
                            shapes[2] = new RightTriangle(4, 6);
                            shapes[3] = new Trapezoid(3, 5, 2);

                            foreach (Shape shape in shapes)
                            {
                                double area = shape.CalculateArea();
                                Console.WriteLine($"Area: {area}");
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