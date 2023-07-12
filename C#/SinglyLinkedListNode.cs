using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class SinglyLinkedList<T>
    {
        public class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }

        private Node head;
        private int count;

        public int Count => count;
        public Node Head => head;

        public SinglyLinkedList()
        {
            head = null;
            count = 0;
        }

        public void AddFirst(T item)
        {
            Node newNode = new Node(item);
            newNode.Next = head;
            head = newNode;
            count++;
        }

        public void AddLast(T item)
        {
            Node newNode = new Node(item);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node currentNode = head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = newNode;
            }

            count++;
        }

        public bool Remove(T item)
        {
            if (head == null)
            {
                return false;
            }

            if (head.Value.Equals(item))
            {
                head = head.Next;
                count--;
                return true;
            }

            Node currentNode = head;
            while (currentNode.Next != null)
            {
                if (currentNode.Next.Value.Equals(item))
                {
                    currentNode.Next = currentNode.Next.Next;
                    count--;
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }

        public bool Contains(T item)
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(item))
                {
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }
    }
}