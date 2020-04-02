using System;

namespace Task_4
{
    internal class Program
    {
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

        static double F(double x)
        {
            return x + Math.Log(x + 0.5) - 0.5;
        }
        public static void Main(string[] args)
        {
            double eps = ReadD();
            double l = 0, r = 2;
            while (F(l)+eps<F(r)){
                double mid = (l+r)/2;
                if (F(mid)<0)
                    l=mid;
                else r = mid;
                Console.WriteLine(F(mid));
            }
            Console.WriteLine(l+" "+F(l));
            Console.WriteLine(r+" "+F(r));
        }
    }
}