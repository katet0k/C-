using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Stack<T>
    {
        private List<T> items;

        public Stack()
        {
            items = new List<T>();
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Стек порожній");
            }

            int lastIndex = items.Count - 1;
            T poppedItem = items[lastIndex];
            items.RemoveAt(lastIndex);

            return poppedItem;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Стек порожній");
            }

            return items[items.Count - 1];
        }

        public int Count
        {
            get { return items.Count; }
        }
    }
}
