using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Task_6
{
    internal class Program
    {
        public static int ReadInt(int left = -10000, int right = 10000)
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
        static List<double> arr;
        public static void Rec(int index, double m)
        {
            double a = arr[index - 1] * 3 / 2 - arr[index - 2] * 2 / 3 - arr[index - 3] / 3;
            if (a < m) return;
            arr.Add(a);
            Rec(index + 1, m);
        }
        public static void Main(string[] args)
        {
            arr = new List<double>();
            double a1, a2, a3, a;
            int j = 0;
            Console.WriteLine("Введите а1");
            a1 = ReadInt();
            arr.Add(a1);
            Console.WriteLine("Введите а2");
            a2 = ReadInt();
            arr.Add(a2);
            Console.WriteLine("Введите а3");
            a3 = ReadInt();
            arr.Add(a3);
            Console.WriteLine("Введите M");
            int m = ReadInt();
            Console.WriteLine("Введите N");
            int n = ReadInt();
            Rec(3,m);
            while ((a3 * 3 / 2 - a2 * 2 / 3 - a1 / 3) > m)
            {
                a = a3 * 3 / 2.0 - a2 * 2 / 3.0 - a1 / 3.0;
                a1 = a2;
                a2 = a3;
                a3 = a;
                j++;
            }
            Console.WriteLine(a3.ToString());
            Console.WriteLine($"arr={arr[arr.Count-1]} ans={a3.ToString()}");
            Console.WriteLine($"a={a3} J={j}");
            Console.WriteLine(a3 == m ? "А и М равны" : "А и М не равны");
            if (j > n)
            {
                Console.WriteLine("J больше N");
            }
            else if (j < n)
            {
                Console.WriteLine("J меньше N");
            }
            else
            {
                Console.WriteLine("J равно N");
            }
        }
    }
}