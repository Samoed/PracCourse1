using System;
using System.Collections.Concurrent;

namespace Task_5
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
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы");
            int n = ReadInt(2);
            int[,] a= new int[n,n];
            int[] ans = new int[n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.WriteLine($"Введите {i*3+j+1} элемент матрицы");
                    a[i, j] = ReadInt();
                }
            }
            for (int i = 0; i < n; ++i)
            {
                bool fl1 = true, fl2 = true;
                for (int j = 0; j < n-1; ++j)
                {
                    if (a[i, j] < a[i, j + 1] && fl1)
                    {
                        fl2 = false;
                    }
                    else if (a[i, j] > a[i, j + 1] && fl2)
                    {
                        fl1 = false;
                    }
                    else
                    {
                        fl1 = false;
                        fl2 = false;
                    }
                }

                if (fl1 || fl2) ans[i] = 1;
            }
            foreach (var tmp in ans)
            {
                Console.Write(tmp+" ");
            }
        }
    }
}