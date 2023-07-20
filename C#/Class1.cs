using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public interface IOutput
    {
        void Show();
        void Show(string info);
    }

    public class Array : IOutput
    {
        private int[] elements;

        public Array(int[] elements)
        {
            this.elements = elements;
        }

        public void Show()
        {
            Console.WriteLine("Елементи масиву:");
            foreach (int element in elements)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Show();
            Console.WriteLine($"Інформаційне повідомлення: {info}");
        }
    }







}
