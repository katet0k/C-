using System.Globalization;
using System.Text;

namespace C_
{
    public struct Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector3D operator *(Vector3D vector, double scalar)
        {
            return new Vector3D(vector.X * scalar, vector.Y * scalar, vector.Z * scalar);
        }

        public static Vector3D operator +(Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D(vector1.X + vector2.X, vector1.Y + vector2.Y, vector1.Z + vector2.Z);
        }

        public static Vector3D operator -(Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D(vector1.X - vector2.X, vector1.Y - vector2.Y, vector1.Z - vector2.Z);
        }
    }

    public struct DecimalNumber
    {
        private int value;

        public DecimalNumber(int value)
        {
            this.value = value;
        }

        public string ToBinary()
        {
            return Convert.ToString(value, 2);
        }

        public string ToOctal()
        {
            return Convert.ToString(value, 8);
        }

        public string ToHexadecimal()
        {
            return Convert.ToString(value, 16);
        }
    }

    public struct RGBColor
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }

        public RGBColor(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public string ToHex()
        {
            return $"#{Red:X2}{Green:X2}{Blue:X2}";
        }

        public void ToHSL(out double hue, out double saturation, out double lightness)
        {
            double r = Red / 255.0;
            double g = Green / 255.0;
            double b = Blue / 255.0;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            double h, s, l;

            if (max == min)
                h = 0;
            else if (max == r)
                h = (60 * (g - b) / (max - min) + 360) % 360;
            else if (max == g)
                h = (60 * (b - r) / (max - min) + 120) % 360;
            else
                h = (60 * (r - g) / (max - min) + 240) % 360;

            l = (max + min) / 2;

            if (max == min)
                s = 0;
            else if (l <= 0.5)
                s = (max - min) / (2 * l);
            else
                s = (max - min) / (2 - 2 * l);

            hue = h;
            saturation = s;
            lightness = l;
        }

        public void ToCMYK(out double cyan, out double magenta, out double yellow, out double key)
        {
            double r = Red / 255.0;
            double g = Green / 255.0;
            double b = Blue / 255.0;

            double k = 1 - Math.Max(r, Math.Max(g, b));

            double c = (1 - r - k) / (1 - k);
            double m = (1 - g - k) / (1 - k);
            double y = (1 - b - k) / (1 - k);

            cyan = c;
            magenta = m;
            yellow = y;
            key = k;
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
                Console.WriteLine("#===========================#");
                Console.Write("Виберіть пункт меню -> ");
                switch_on = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.Clear();

                switch (switch_on)
                {
                    case 1:
                        {
                            Vector3D vector1 = new Vector3D(1, 2, 3);
                            Vector3D vector2 = new Vector3D(4, 5, 6);

                            Vector3D multiplicationResult = vector1 * 2;
                            Vector3D additionResult = vector1 + vector2;
                            Vector3D subtractionResult = vector1 - vector2;

                            Console.WriteLine("Multiplication Result: ({0}, {1}, {2})", multiplicationResult.X, multiplicationResult.Y, multiplicationResult.Z);
                            Console.WriteLine("Addition Result: ({0}, {1}, {2})", additionResult.X, additionResult.Y, additionResult.Z);
                            Console.WriteLine("Subtraction Result: ({0}, {1}, {2})", subtractionResult.X, subtractionResult.Y, subtractionResult.Z);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        {
                            DecimalNumber number = new DecimalNumber(42);

                            string binary = number.ToBinary();
                            string octal = number.ToOctal();
                            string hexadecimal = number.ToHexadecimal();

                            Console.WriteLine("Binary: " + binary);
                            Console.WriteLine("Octal: " + octal);
                            Console.WriteLine("Hexadecimal: " + hexadecimal);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        {
                            RGBColor color = new RGBColor(255, 127, 0);

                            string hex = color.ToHex();
                            Console.WriteLine("Hex: " + hex);

                            color.ToHSL(out double hue, out double saturation, out double lightness);
                            Console.WriteLine("HSL - Hue: " + hue);
                            Console.WriteLine("HSL - Saturation: " + saturation);
                            Console.WriteLine("HSL - Lightness: " + lightness);

                            color.ToCMYK(out double cyan, out double magenta, out double yellow, out double key);
                            Console.WriteLine("CMYK - Cyan: " + cyan);
                            Console.WriteLine("CMYK - Magenta: " + magenta);
                            Console.WriteLine("CMYK - Yellow: " + yellow);
                            Console.WriteLine("CMYK - Key: " + key);

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