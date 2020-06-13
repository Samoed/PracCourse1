using System;
using System.Collections.Generic;
using System.IO;

namespace Task_9
{
    public class List
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }

            public Node(int item)
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

        public List(int size)
        {
            head = null;
            tail = null;
            for (int i = 0; i <= size; i++)
                Add(i);
        }

        public int this[int index]
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
        public int Find(int value)
        {
            Node find = head;
            int index = 0;
            for (int i = 1; i <= Length; ++i)
            {
                if (find.Data == value) return i - 2;
                find = find.Next;
            }
            return -1;
        }
        public void Add(int item)
        {
            Node node = new Node(item);

            if (head == null) head = node;
            else tail.Next = node;

            Length++;
            tail = node;
        }

        public void Remove(int index)
        {
            //if (index < 0) throw new ArgumentOutOfRangeException("Индекс", "Индекс должен быть выражен неотрицательным числом");
            //if (index > Length) throw new ArgumentOutOfRangeException("Индекс", "Индекс должен быть меньше или равно числу элементов в листе");

            if (index == 0) head = head.Next;
            else
            {
                Node node = FindNode(index);
                node.Next = node.Next.Next;
            }

            Length--;
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
        public static void Main(string[] args)
        {
            int n = ReadInt(0);
            List arr = new List(n+1);
            for (int i=1;i<n+1;++i)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            int search = arr.Find(4);
            Console.WriteLine(search);
            arr.Remove(4);
            for (int i=1;i<arr.Length;++i)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}