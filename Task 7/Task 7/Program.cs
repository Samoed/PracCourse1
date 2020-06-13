using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task_7
{
	public class HuffmanTree
	{
		public class Node
		{
			public char Symbol { get; set; }
			public int Frequency { get; set; }
			public Node Right { get; set; }
			public Node Left { get; set; }

			// Find the encoded code for a symbol from the current node
			public List<bool> Traverse(char symbol, List<bool> data)
			{
				// Leaf
				if (Right == null && Left == null)
				{
					if (symbol.Equals(Symbol))
					{
						return data;
					}
					return null;
				}
				else
				{
					List<bool> left = null;
					List<bool> right = null;

					if (Left != null)
					{
						List<bool> leftPathData = new List<bool>();
						leftPathData.AddRange(data);
						leftPathData.Add(false);

						left = Left.Traverse(symbol, leftPathData);
					}

					if (Right != null)
					{
						List<bool> rightPathData = new List<bool>();
						rightPathData.AddRange(data);
						rightPathData.Add(true);
						right = Right.Traverse(symbol, rightPathData);
					}
					if (left != null)
					{
						return left;
					}
					else
					{
						return right;
					}
				}
			}
		}
		private List<Node> nodes = new List<Node>();
		public Node Root { get; set; }
		public Dictionary<char, int> SymbolFrequencies = new Dictionary<char, int>();
		private int[] frequancies = new int[0];
		public void BuildHuffmanTree(int[] source)
		{
			frequancies = source;
			for (int i = 0; i < frequancies.Length; ++i)
			{
				SymbolFrequencies.Add((char)i, frequancies[i]);
				nodes.Add(new Node { Symbol = (char)i, Frequency = frequancies[i] });
			}
			// Generate root nodes for the lowest frequencies and add it to the end of ordered nodes till only 1 node is left as main root of the complete huffman tree
			while (nodes.Count >= 2)
			{
				// Step# 2: Sort the list of nodes based on its frequencies in ascending order
				List<Node> orderedNodes = nodes.OrderBy(node => node.Frequency).ToList();

				if (orderedNodes.Count >= 2)
				{
					// Take first two items
					List<Node> taken = orderedNodes.Take(2).ToList();

					// Create a parent node by combining the frequencies
					Node parent = new Node
					{
						Symbol = '*',
						Frequency = taken[0].Frequency + taken[1].Frequency,
						Left = taken[0],
						Right = taken[1]
					};
					//Remove left and right nodes and add their parent to the end of nodes list
					nodes.Remove(taken[0]);
					nodes.Remove(taken[1]);
					nodes.Add(parent);
				}
				Root = nodes.FirstOrDefault();
			}
		}
		public Dictionary<char, string> Encode()
		{
			Dictionary<char, string> encode = new Dictionary<char, string>();
			List<bool> encodedSource = new List<bool>();
			foreach (var tmp in SymbolFrequencies)
			{
				List<bool> encodedSymbol = Root.Traverse(tmp.Key, new List<bool>());
				encodedSource.AddRange(encodedSymbol);
				string str = "";
				foreach (bool bit in new BitArray(encodedSymbol.ToArray()))
					str += bit ? "1" : "0";
				string ans = "";
				for (int i = str.Length - 1; i >= 0; --i)
					ans += str[i];
				encode.Add(tmp.Key, ans);
			}
			return encode;
		}
	}
	public class Program
	{
		public static int ReadInt(int left = -10000, int right = 10000)
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

		private static int size = 0;
		public static int[] frequency = null;
		
		public static Dictionary<char, string> Solve(int[] frequency)
		{
			HuffmanTree tree = new HuffmanTree();
			tree.BuildHuffmanTree(frequency);
			var dict = tree.Encode();
			return dict;
		}
		public static void Main(string[] args)
		{
			Console.WriteLine("Введите количество символов");
			int n = ReadInt(0);
			frequency = new int[n];
			for (int i = 0; i < n; ++i)
			{
				Console.WriteLine($"Введите частоту {i+1} символа");
				frequency[i] = ReadInt(0);
			}
			var dict = Solve(frequency);
			foreach (var tmp in dict)
				Console.WriteLine(tmp.Value);
		}
	}
}