using System.Globalization;
using System.Text;

namespace C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("uk-UA");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            Console.OutputEncoding = Encoding.UTF8;

            int switch_on;

            do
            {
                Console.WriteLine("\n#===========================#");
                Console.WriteLine(" |       1 -  case 1       |");
                Console.WriteLine(" |       2 -  case 2       |");
                Console.WriteLine(" |       3 -  case 3       |");
                Console.WriteLine(" |       4 -  case 4       |");
                Console.WriteLine(" |       5 -  case 5       |");
                Console.WriteLine(" |       6 -  case 6       |");
                Console.WriteLine(" |       7 -  case 7       |");
                Console.WriteLine(" |       8 -  case 8       |");
                Console.WriteLine(" |       9 -  case 9       |");
                Console.WriteLine(" |      10 -  case 10       |");
                Console.WriteLine("#===========================#");
                Console.Write("Виберіть пункт меню -> ");
                switch_on = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.Clear();

                switch (switch_on)
                {
                    case 1:
                        {
                            Maximum<int> intMax = new Maximum<int>();
                            int maxInt = intMax.FindMaximum(5, 10, 7);
                            Console.WriteLine("Максимальне ціле число: " + maxInt);

                            Maximum<double> doubleMax = new Maximum<double>();
                            double maxDouble = doubleMax.FindMaximum(3.14, 2.71, 1.618);
                            Console.WriteLine("Максимальний дробових чисел: " + maxDouble);

                            Maximum<string> stringMax = new Maximum<string>();
                            string maxString = stringMax.FindMaximum("apple", "banana", "cherry");
                            Console.WriteLine("Максимальний рядок: " + maxString);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        {
                            Minimum<int> intMin = new Minimum<int>();
                            int minInt = intMin.FindMinimum(5, 10, 7);
                            Console.WriteLine("Мінімальне ціле число: " + minInt);

                            Minimum<double> doubleMin = new Minimum<double>();
                            double minDouble = doubleMin.FindMinimum(3.14, 2.71, 1.618);
                            Console.WriteLine("Мінімальний дробових чисел: " + minDouble);

                            Minimum<string> stringMin = new Minimum<string>();
                            string minString = stringMin.FindMinimum("apple", "banana", "cherry");
                            Console.WriteLine("Мінімальний рядок: " + minString);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        {
                            int[] intArray = { 1, 2, 3, 4, 5 };
                            Sum<int> intSum = new Sum<int>();
                            int intSum1 = intSum.CalculateSum(intArray);
                            Console.WriteLine("Сума цілих чисел: " + intSum1);

                            double[] doubleArray = { 1.5, 2.5, 3.5, 4.5, 5.5 };
                            Sum<double> doubleSum = new Sum<double>();
                            double doubleSum1 = doubleSum.CalculateSum(doubleArray);
                            Console.WriteLine("Сума дробових чисел: " + doubleSum1);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 4:
                        {
                            Stack<int> stack = new Stack<int>();

                            stack.Push(1);
                            stack.Push(2);
                            stack.Push(3);

                            Console.WriteLine("Елементи стеку:");
                            while (stack.Count > 0)
                            {
                                int item = stack.Pop();
                                Console.WriteLine(item);
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 5:
                        {
                            Queue<int> queue = new Queue<int>();

                            queue.Enqueue(1);
                            queue.Enqueue(2);
                            queue.Enqueue(3);

                            Console.WriteLine("Елементи черги:");
                            while (queue.Count > 0)
                            {
                                int item = queue.Dequeue();
                                Console.WriteLine(item);
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 6:
                        {

                            int a = 5;
                            int b = 10;

                            Console.WriteLine("До обміну: a = " + a + ", b = " + b);

                            SwapUtility.Swap(ref a, ref b);

                            Console.WriteLine("Після обміну: a = " + a + ", b = " + b);

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 7:
                        {
                            PriorityQueue<int> priorityQueue = new PriorityQueue<int>();

                            priorityQueue.Enqueue(3);
                            priorityQueue.Enqueue(7);
                            priorityQueue.Enqueue(1);
                            priorityQueue.Enqueue(5);

                            Console.WriteLine("Елементи черги з пріоритетами:");
                            while (priorityQueue.Count > 0)
                            {
                                int item = priorityQueue.Dequeue();
                                Console.WriteLine(item);
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 8:
                        {
                            CircularQueue<int> circularQueue = new CircularQueue<int>(5);

                            circularQueue.Enqueue(1);
                            circularQueue.Enqueue(2);
                            circularQueue.Enqueue(3);

                            Console.WriteLine("Елементи кільцевої черги:");
                            while (circularQueue.Count > 0)
                            {
                                int item = circularQueue.Dequeue();
                                Console.WriteLine(item);
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 9:
                        {

                            SinglyLinkedList<int>.Node node1 = new SinglyLinkedList<int>.Node(1);
                            SinglyLinkedList<int>.Node node2 = new SinglyLinkedList<int>.Node(2);
                            SinglyLinkedList<int>.Node node3 = new SinglyLinkedList<int>.Node(3);

                            node1.Next = node2;
                            node2.Next = node3;

                            Console.WriteLine("Елементи однозв'язного списку:");
                            var currentNode = node1;
                            while (currentNode != null)
                            {
                                Console.WriteLine(currentNode.Value);
                                currentNode = currentNode.Next;
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 10:
                        {
                            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

                            list.AddLast(1);
                            list.AddLast(2);
                            list.AddLast(3);

                            Console.WriteLine("Елементи двозв'язного списку:");
                            var currentNode = list.Head;
                            while (currentNode != null)
                            {
                                Console.WriteLine(currentNode.Value);
                                currentNode = currentNode.Next;
                            }

                            Console.Write("\nНатисніть будь-яку клавішу, щоб продовжити...");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        break;

                    default:

                        break;
                }
            } while (switch_on != 0);
        }
    }
}