using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Task_6
{
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

        public static int j = 0,a1,a2,a3;
        
        static int F(int m, int tmp=0)
        {
            if (tmp == 1) return a1;
            if (tmp == 2) return a2;
            if (tmp == 3) return a3;
            /*if (Math.Abs(F(m, tmp + 1)))
            {
                
            }*/
            return 1;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите а1");
            a1 = ReadInt();
            Console.WriteLine("Введите а2");
            a2 = ReadInt();
            Console.WriteLine("Введите а3");
            a3 = ReadInt();
            Console.WriteLine("Введите m");
            int m = ReadInt();
            Console.WriteLine("Введите n");
            int n = ReadInt();
        }
    }
}