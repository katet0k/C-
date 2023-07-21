using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменник не може дорівнювати нулю.");

            Numerator = numerator;
            Denominator = denominator;
        }
    }

    public static class FractionExtensions
    {
        public static Fraction FindMinFraction(this Fraction[] fractions)
        {
            if (fractions.Length == 0)
                return null;

            return fractions.OrderBy(f => (double)f.Numerator / f.Denominator).First();
        }

        public static Fraction FindMaxFraction(this Fraction[] fractions)
        {
            if (fractions.Length == 0)
                return null;

            return fractions.OrderByDescending(f => (double)f.Numerator / f.Denominator).First();
        }
    }
}
