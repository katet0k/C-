using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Shop : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ShopType Type { get; set; }

        public enum ShopType
        {
            Grocery,
            Household,
            Clothing,
            Footwear
        }

        public Shop(string name, string address, ShopType type)
        {
            Name = name;
            Address = address;
            Type = type;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Назва магазину: " + Name);
            Console.WriteLine("Адреса магазину: " + Address);
            Console.WriteLine("Тип магазину: " + Type);
        }

        public void Dispose()
        {
        }

        ~Shop()
        {
        }
    }
}
