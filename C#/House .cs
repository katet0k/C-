using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Apartment
    {
        public int Number { get; set; }
        public List<string> Residents { get; set; }

        public Apartment(int number)
        {
            Number = number;
            Residents = new List<string>();
        }

        public void AddResident(string resident)
        {
            Residents.Add(resident);
        }
    }

    public class House : IEnumerable<Apartment>
    {
        private List<Apartment> apartments;

        public House()
        {
            apartments = new List<Apartment>();
        }

        public void AddApartment(int number)
        {
            apartments.Add(new Apartment(number));
        }

        public void AddResidentToApartment(int apartmentNumber, string resident)
        {
            Apartment apartment = apartments.Find(a => a.Number == apartmentNumber);
            if (apartment != null)
            {
                apartment.AddResident(resident);
            }
        }

        public IEnumerator<Apartment> GetEnumerator()
        {
            return apartments.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
