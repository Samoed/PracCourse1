using System;
using System.IO;

namespace Generaror_Task_8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 3; i < 100; ++i)
            {
                Random rnd = new Random();
                StreamWriter sw = new StreamWriter($"test{i}.txt");
                sw.WriteLine(i);
                sw.WriteLine(rnd.Next(i));
                int[,] arr = new int[i,i];
                for (int j = 0; j < rnd.Next(i * i); ++j)
                {
                    int w = rnd.Next(i), e = rnd.Next(i);
                    if(w==e) { w = rnd.Next(i); e = rnd.Next(i);}
                    arr[w, e] = 1;
                    arr[e, w] = 1;
                }

                for (int j = 0; j < i; ++j)
                {
                    for (int w = 0; w < i; ++w)
                    {
                        sw.Write(arr[j,w]+" ");
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
        }
    }
}