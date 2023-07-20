using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }

    public class IntArray : IOutput, IMath
    {
        private int[] elements;

        public IntArray(int[] elements)
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

        public int Max()
        {
            if (elements.Length == 0)
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
            if (elements.Length == 0)
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
            if (elements.Length == 0)
                throw new InvalidOperationException("Масив порожній.");

            float sum = 0;
            foreach (int element in elements)
            {
                sum += element;
            }
            return sum / elements.Length;
        }

        public bool Search(int valueToSearch)
        {
            foreach (int element in elements)
            {
                if (element == valueToSearch)
                    return true;
            }
            return false;
        }
    }
}
