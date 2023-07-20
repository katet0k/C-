using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    // Інтерфейс ISort з методами SortAscending(), SortDescending() та SortByParam(bool isAscending)
    public interface ISort
    {
        void SortAscending();
        void SortDescending();
        void SortByParam(bool isAscending);
    }

    // Розширення класу IntegerArray, що імплементує ISort
    public class IntegerArray : IOutput, IMath, ISort
    {
        private List<int> elements;

        public IntegerArray(int[] elements)
        {
            this.elements = new List<int>(elements);
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

        public int Max()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Масив порожній.");

            int max = elements[0];
            foreach (int element in elements)
            {
                if (element > max)
                    max = element;
            }
            return max;
        }

        public int Min()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Масив порожній.");

            int min = elements[0];
            foreach (int element in elements)
            {
                if (element < min)
                    min = element;
            }
            return min;
        }

        public float Avg()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Масив порожній.");

            float sum = 0;
            foreach (int element in elements)
            {
                sum += element;
            }
            return sum / elements.Count;
        }

        public bool Search(int valueToSearch)
        {
            return elements.Contains(valueToSearch);
        }

        public void SortAscending()
        {
            elements.Sort();
        }

        public void SortDescending()
        {
            elements.Sort();
            elements.Reverse();
        }

        public void SortByParam(bool isAscending)
        {
            if (isAscending)
            {
                SortAscending();
            }
            else
            {
                SortDescending();
            }
        }
    }
}
