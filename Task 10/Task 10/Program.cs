using System;

namespace Task_10
{
    public class List
    {
        public class Node
        {
            public double Data { get; set; }
            public Node Next { get; set; }

            public Node(double item)
            {
                Data = item;
                Next = null;
            }
        }

        public int Length { get; protected set; }
        private Node head;
        private Node tail;

        public List()
        {
            Length = 0;
            head = null;
            tail = null;
        }
        public List(double[] arr)
        {
            head = null;
            tail = null;
            for (int i = 0; i < arr.Length; i++)
                Add(arr[i]);
        }

        public double this[int index]
        {
            get
            {
                if (index < 0 || index > Length) throw new IndexOutOfRangeException();
                return FindNode(index).Next.Data;
            }

            set
            {
                if (index < 0 || index > Length) throw new IndexOutOfRangeException();

                Node node = FindNode(index).Next;
                node.Data = value;
            }
        }

        public Node FindNode(int index)
        {
            Node find = head;
            index--;
            int ind = 0;
            while (ind < index)
            {
                find = find.Next;
                ind++;
            }
            return find;
        }
        public void Add(double item)
        {
            Node node = new Node(item);

            if (head == null) head = node;
            else tail.Next = node;

            Length++;
            tail = node;
        }

        public void Clear()
        {
            Node node = head;

            while (node != null)
            {
                Node prev = node;
                node = node.Next;
                prev.Next = null;
            }

            head = null;
            tail = null;
            Length = 0;
        }
    }
    internal class Program
    {
        public static int ReadInt(int left = -100, int right = 100)
        {
            bool ok = false;
            int number = 0;
            do
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number >= left && number <= right) ok = true;
                    else
                    {
                        Console.WriteLine($"Ошибка. Число выход за границы. Введите число большее {left} и меньшее {right}");
                        ok = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка. Введено не целое число. Введите целое число.");
                    ok = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Ошибка. Число выход за границы. Введите число большее {left} и меньшее {right}");
                    ok = false;
                }
            } while (!ok);
            return number;
        }
        public static double ReadD(int left = -100, int right = 100)
        {
            bool ok = false;
            double number = 0;
            do
            {
                try
                {
                    number = double.Parse(Console.ReadLine());
                    if (number >= left && number <= right) ok = true;
                    else
                    {
                        Console.WriteLine($"Ошибка. Число выход за границы. Введите число большее {left} и меньшее {right}");
                        ok = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка. Введено не действительное число. Введите действительное число.");
                    ok = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Ошибка. Число выход за границы. Введите число большее {left} и меньшее {right}");
                    ok = false;
                }
            } while (!ok);
            return number;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = ReadInt();
            double[] arr = new double[n];
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine($"Введите {i+1} элемент");
                arr[i] = ReadD();
            }
            List ans = new List(arr);
            for (int i = 0; i < n-1; ++i)
            {
                ans[i] = arr[i] - arr[n - 1];
                Console.Write(ans[i]+" ");
            }
        }
    }
}