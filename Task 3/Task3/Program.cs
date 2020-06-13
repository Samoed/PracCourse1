using System;

namespace Task3
{
    public class Program
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
        public static int Solve(int x, int y)
        {
            int u = x;
            if (x * x + y * y <= 4 && x * x + y * y >= 1 && y >= 0)
                u = 0;
            return u;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число x");
            int x = ReadInt();
            Console.WriteLine("Введите число y");
            int y = ReadInt(), u = x;
            if (x * x + y * y <= 4 && x * x + y * y >= 1 && y >= 0)
                u = 0;
            Console.WriteLine(u);
        }
    }
}