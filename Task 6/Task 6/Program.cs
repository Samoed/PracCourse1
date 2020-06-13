using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Task_6
{
    public class Program
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
        public static List<double> arr;
        private static void Rec(int index, double m)
        {
            double a = arr[index - 1] * 3 / 2 - arr[index - 2] * 2 / 3 - arr[index - 3] / 3;
            if (a < m) return;
            arr.Add(a);
            Rec(index + 1, m);
        }
        public static double[] Solve(double a1, double a2, double a3, double m, double n, out int j)
        {
            arr = new List<double>();
            double a;
            j = 0;
            arr.Add(a1);
            arr.Add(a2);
            arr.Add(a3);
            Rec(3, m);
            j = arr.Count - 3;
            return arr.ToArray();
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
            Solve(a1, a2, a3, m, n,out j);
            Console.WriteLine($"a={arr[arr.Count - 1]} J={j}");
            Console.WriteLine(arr[arr.Count - 1] == m ? "А и М равны" : "А и М не равны");
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