using System;
using System.Runtime.ConstrainedExecution;

namespace Task2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int[,] arr = new int[200,200];
            int x = 100, y = 100, q = 0, ans=-1, e=0;
            arr[x, y] = 1;
            for (int i = 0; i < s.Length && ans==-1; ++i)
            {
                //0 - 0
                //1 - 90
                //2 - 180
                //3 - 270
                q %= 4;
                switch (s[i])
                {
                    case 'S':
                        e++;
                        switch (q)
                        {
                            case 0:
                                y++;
                                break;
                            case 1:
                                x++;
                                break;
                            case 2:
                                y--;
                                break;
                            case 3:
                                x--;
                                break;
                        }
                        if (arr[x,y] == 1)
                            ans = e;
                        arr[x, y] = 1;
                        //Console.WriteLine($"x={x} y={y}");
                        break;
                    case 'L':
                        if (q == 0) q = 3;
                        else q--;
                        break;
                    case 'R':
                        q++;
                        break;
                }
            }
            Console.WriteLine(ans);
        }
    }
}