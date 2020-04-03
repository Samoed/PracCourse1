using System;

namespace Task_10
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
            int n = ReadInt();
            double[] arr = new double[n];
            for (int i = 0; i < n; ++i)
            {
                arr[i] = ReadD();
            }
            double[] ans = new double[n];
            for (int i = 0; i < n-1; ++i)
            {
                ans[i] = arr[i] - arr[n - 1];
                Console.WriteLine(ans[i]);
            }
        }
    }
}