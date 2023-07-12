using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class DoublyLinkedList<T>
    {
        public class Node
        {
            public T Value { get; set; }
            public Node Previous { get; set; }
            public Node Next { get; set; }

            public Node(T value)
            {
                Value = value;
                Previous = null;
                Next = null;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        public int Count => count;
        public Node Head => head;
        public Node Tail => tail;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void AddFirst(T item)
        {
            Node newNode = new Node(item);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }

            count++;
        }

        public void AddLast(T item)
        {
            Node newNode = new Node(item);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Previous = tail;
                tail.Next = newNode;
                tail = newNode;
            }

            count++;
        }

        public bool Remove(T item)
        {
            if (head == null)
            {
                return false;
            }

            Node currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(item))
                {
                    if (currentNode == head)
                    {
                        head = head.Next;
                        if (head != null)
                        {
                            head.Previous = null;
                        }
                    }
                    else if (currentNode == tail)
                    {
                        tail = tail.Previous;
                        if (tail != null)
                        {
                            tail.Next = null;
                        }
                    }
                    else
                    {
                        currentNode.Previous.Next = currentNode.Next;
                        currentNode.Next.Previous = currentNode.Previous;
                    }

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
