using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class PriorityQueue<T>
    {
        private List<T> items;
        private IComparer<T> comparer;

        public int Count
        {
            get { return items.Count; }
        }

        public PriorityQueue()
        {
            items = new List<T>();
            comparer = Comparer<T>.Default;
        }

        public PriorityQueue(IComparer<T> customComparer)
        {
            items = new List<T>();
            comparer = customComparer;
        }

        public void Enqueue(T item)
        {
            items.Add(item);
            int currentIndex = items.Count - 1;

            while (currentIndex > 0)
            {
                int parentIndex = (currentIndex - 1) / 2;

                if (comparer.Compare(items[currentIndex], items[parentIndex]) >= 0)
                    break;

                Swap(currentIndex, parentIndex);
                currentIndex = parentIndex;
            }
        }

        public T Dequeue()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Черга порожня");
            }

            T dequeuedItem = items[0];
            int lastIndex = items.Count - 1;
            items[0] = items[lastIndex];
            items.RemoveAt(lastIndex);

            int currentIndex = 0;
            int leftChildIndex = 1;

            while (leftChildIndex <= lastIndex)
            {
                int rightChildIndex = leftChildIndex + 1;

                if (rightChildIndex <= lastIndex && comparer.Compare(items[rightChildIndex], items[leftChildIndex]) < 0)
                    leftChildIndex = rightChildIndex;

                if (comparer.Compare(items[currentIndex], items[leftChildIndex]) <= 0)
                    break;

                Swap(currentIndex, leftChildIndex);
                currentIndex = leftChildIndex;
                leftChildIndex = 2 * currentIndex + 1;
            }

            return dequeuedItem;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Черга порожня");
            }

            return items[0];
        }

        private void Swap(int indexA, int indexB)
        {
            T temp = items[indexA];
            items[indexA] = items[indexB];
            items[indexB] = temp;
        }
    }
}
