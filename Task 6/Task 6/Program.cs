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

        public static void Main(string[] args)
        {
            List<double> arr = new List<double>();
            double a1, a2, a3, a;
            int j = 0;
            Console.WriteLine("Введите а1");
            a1 = ReadInt();
            Console.WriteLine("Введите а2");
            a2 = ReadInt();
            Console.WriteLine("Введите а3");
            a3 = ReadInt();
            Console.WriteLine("Введите M");
            int m = ReadInt();
            Console.WriteLine("Введите N");
            int n = ReadInt();
            while (Math.Abs(a3 * 3 / 2 - a2 * 2 / 3 - a1 / 3) > m)
            {
                a = a3 * 3 / 2.0 - a2 * 2 / 3.0 - a1 / 3.0;
                a1 = a2;
                a2 = a3;
                a3 = a;
                j++;
            }
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