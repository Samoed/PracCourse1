using System;

namespace Task1
{
  internal class Program
  {
      static bool Chek(int q,int x, int y, int[,] arr)
      {
          bool fl;
          if (q == 1)
          {
             return arr[x + 1, y] == 0 && arr[x, y + 1] == 0 && arr[x+1, y+1] == 0;
          }
          if (q == 2)
          {
              return arr[x, y] == 0 && arr[x + 1, y] == 0 && arr[x+1, y+1] == 0;
          }
          if (q == 3)
          {
              return arr[x, y] == 0 && arr[x, y + 1] == 0 && arr[x+1, y+1] == 0;
          }
          return arr[x, y] == 0 && arr[x + 1, y] == 0 && arr[x, y + 1] == 0;
          
      }
    public static void Main(string[] args)
    {
        string[] str=Console.ReadLine().Split(' ');
        int n=int.Parse(str[0]);
        int m=int.Parse(str[1]);
        int[,] arr = new int[n,m];
        int q = int.Parse(Console.ReadLine());
        for (int i = 0; i < q; ++i)
        {
            str=(Console.ReadLine().Split(' '));
            int t = int.Parse(str[0]);
            int x = int.Parse(str[1]);
            int y = int.Parse(str[2]);
            x--;y--;
			if (x < n-1 && y < m-1 && x>=0 && y>=0)
				switch (t)
				{
					case 1:
						if (Chek(t,x,y,arr)){
							arr[x+1, y] = 1;
							arr[x, y+1] = 1;
							arr[x+1, y+1] = 1;
						}
						break;
					case 2:						
						if (Chek(t,x, y, arr))
						{
							arr[x, y] = 1;
							arr[x + 1, y] = 1;
							arr[x + 1, y + 1] = 1;
						}					
						break;
					case 3:
						if (Chek(t,x, y, arr))
						{
							arr[x, y] = 1;
							arr[x, y + 1] = 1;
							arr[x + 1, y + 1] = 1;
						}
						break;
					case 4:
						if (Chek(t,x, y, arr))
						{
							arr[x, y] = 1;
							arr[x + 1, y] = 1;
							arr[x, y + 1] = 1;
						}				
						break;
				}
        }

        int ans = 0;
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < m; ++j)
            {
                ans += arr[i, j];
            }
        }
        Console.WriteLine(ans);
    }
  }
}