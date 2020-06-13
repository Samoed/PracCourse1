using System;
using System.Net;

namespace Task_11
{
    public class Program
    {
        public static string Code(string s)
        {
            string code = s[0].ToString();
            for (int i = 1; i < s.Length; ++i)
            {
                code += s[i] == s[i - 1] ? 1 : 0;
            }
            return code;
        }
        public static string Encode(string code)
        {
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
            return encode;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность 0 и 1 без пробелов в одну строку");
            string s = Console.ReadLine();
            var code = Code(s);
            Console.WriteLine($"Зашифрованная последовательность {code}");
            var encode = Encode(code);
            Console.WriteLine($"Расшифрованная последовательность {encode}");
        }
    }
}