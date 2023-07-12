using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class CircularQueue<T>
    {
        private T[] items;
        private int head;
        private int tail;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public CircularQueue(int capacity)
        {
            items = new T[capacity];
            head = 0;
            tail = -1;
            count = 0;
        }

        public void Enqueue(T item)
        {
            if (count == items.Length)
            {
                throw new InvalidOperationException("Кільцева черга переповнена");
            }

            tail = (tail + 1) % items.Length;
            items[tail] = item;
            count++;
        }

        public T Dequeue()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Кільцева черга порожня");
            }

            T dequeuedItem = items[head];
            head = (head + 1) % items.Length;
            count--;

            return dequeuedItem;
        }

        public T Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Кільцева черга порожня");
            }

            return items[head];
        }
    }
}
