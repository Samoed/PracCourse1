using System;
using System.Collections.Generic;
using System.IO;

namespace Task_9
{
    class MyList
    {
        private List<int> arr=new List<int>();

        public int Size
        {
            get => arr.Count;
        }
        public MyList(int n)
        {
            for (int i = 0; i < n; ++i)
            {
                arr.Add(i + 1);
            }
        }

        public int this[int index]
        {
            get=>arr[index];
        }

        public int Find(int n)
        {
            int ans = -1;
            for (int i = 0; i < n; ++i)
            {
                if (arr[i] == n)
                    ans = n;
            }
            return ans;
        }
        public void Remove(int index)
        {
            arr.Remove(index);
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
            MyList arr = new MyList(n);
            for (int i=0;i<n;++i)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            int search = arr.Find(4);
            Console.WriteLine(search);
            arr.Remove(4);
            for (int i=0;i<arr.Size;++i)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}