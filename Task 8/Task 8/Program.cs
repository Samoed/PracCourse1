using System;
using System.Collections.Generic;

namespace Task_8
{
	public class Program
	{
		static public int n;
		static public List<List<int>> g = new List<List<int>>();
		static public char[] cl;
		static public int[] p;
		static public int cycle_st, cycle_end;

		static bool dfs(int v)
		{
			cl[v] = '1';
			for (int i = 0; i < g[v].Count; ++i)
			{
				int to = g[v][i];
				if (cl[to] == '0')
				{
					p[to] = v;
					if (dfs(to)) return true;
				}
				else if (cl[to] == '1')
				{
					cycle_end = v;
					cycle_st = to;
					return true;
				}
			}
			cl[v] = '2';
			return false;
		}
		public static void Solve(int n,int k)
		{
			p = new int[n];
			cl = new char[n];
			for (int i = 0; i < n; ++i)
			{
				cycle_st = -1;
				for (int j = 0; j < n; ++j)
				{
					p[j] = -1;
					cl[j] = '0';
				}
				if (dfs(i))
				{
					int w = 0;
					for (int j = 0; j < n; ++j)
					{
						if (p[j] != -1) w++;
					}
					if (w == k - 1) break;
				}
			}
		}
		public static void Main(string[] args)
		{
			n = int.Parse(Console.ReadLine());
			int k  = int.Parse(Console.ReadLine());
			g = new List<List<int>>(n);
			for (int i = 0; i < n; ++i)
			{
				g.Add(new List<int>());
				g[i] = new List<int>();
			}
			for (int i = 0; i < n; ++i)
			{
				string[] tmp = Console.ReadLine().Split(' '); 
				for (int j = 0; j < n; ++j)
				{
					int q = Int32.Parse(tmp[j]);
					if (q == 1)
					{
						g[i].Add(j);
					}
				}
			}
			Solve(n, k);
			if (cycle_st == -1)
				Console.WriteLine("Цикла такой длины нет");
			else
			{
				Console.WriteLine("Цикл такой длины есть");
				List<int> cycle = new List<int>();
				cycle.Add(cycle_st);
				for (int v = cycle_end; v != cycle_st; v = p[v])
					cycle.Add(v);
				cycle.Add(cycle_st);
				for (int i = 0; i < cycle.Count; ++i)
					Console.Write(cycle[i] + 1 + " ");
			}
		}
	}
}