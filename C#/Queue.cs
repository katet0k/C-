using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Queue<T>
    {
        private LinkedList<T> items;

        public Queue()
        {
            items = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            items.AddLast(item);
        }

        public T Dequeue()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Черга порожня");
            }

            T dequeuedItem = items.First.Value;
            items.RemoveFirst();

            return dequeuedItem;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Черга порожня");
            }

            return items.First.Value;
        }

        public int Count
        {
            get { return items.Count; }
        }
    }

}
