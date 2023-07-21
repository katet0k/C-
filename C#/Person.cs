using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public static class PersonExtensions
    {
        public static double AverageAge(this Person[] people)
        {
            if (people.Length == 0)
                return 0;

            return people.Average(p => p.Age);
        }

        public static Person FindPersonWithMinAge(this Person[] people)
        {
            if (people.Length == 0)
                return null;

            return people.OrderBy(p => p.Age).First();
        }

        public static Person FindPersonWithMaxAge(this Person[] people)
        {
            if (people.Length == 0)
                return null;

            return people.OrderByDescending(p => p.Age).First();
        }
    }
}
