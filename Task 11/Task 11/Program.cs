using System;
using System.Net;

namespace Task_11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность 0 и 1 без пробелов в одну строку");
            string s = Console.ReadLine();
            string code=s[0].ToString();
            for (int i = 1; i < s.Length; ++i)
            {
                code += s[i] == s[i - 1] ? 1 : 0;
            }
            Console.WriteLine($"Зашифрованная последовательность {code}");
            string encode = code[0].ToString();
            for (int i = 1; i < code.Length; ++i)
            {
                if (code[i] == '1')
                {
                    encode += encode[i - 1];
                }
                else
                {
                    encode += encode[i - 1] == '1' ? 0 : 1;
                }
            }
            Console.WriteLine($"Расшифрованная последовательность {encode}");
        }
    }
}