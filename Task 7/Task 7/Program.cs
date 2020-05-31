using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task_7
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

	public class HuffmanTree
	{
		private List<Node> nodes = new List<Node>();
		public Node Root { get; set; }
		public Dictionary<char, int> SymbolFrequencies = new Dictionary<char, int>();

		public void BuildHuffmanTree(string source)
		{
			for (int i = 0; i < source.Length; i++)
			{
				if (!SymbolFrequencies.ContainsKey(source[i]))
				{
					SymbolFrequencies.Add(source[i], 0);
				}

				SymbolFrequencies[source[i]]++;
			}

			// Step# 1: Create list of nodes with symbol and frequencies
			foreach (KeyValuePair<char, int> symbol in SymbolFrequencies)
			{
				nodes.Add(new Node{Symbol = symbol.Key, Frequency = symbol.Value});
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

		public Dictionary<char,string> Encode()
		{
			Dictionary<char, string> encode = new Dictionary<char, string>();
			List<bool> encodedSource = new List<bool>();
			foreach (var tmp in SymbolFrequencies)
			{
				List<bool> encodedSymbol = Root.Traverse(tmp.Key, new List<bool>());
				encodedSource.AddRange(encodedSymbol);
				string str = "";
				foreach (bool bit in new BitArray(encodedSymbol.ToArray()))
					str+=bit ? "1" : "0";
				string ans = "";
				for (int i = str.Length - 1; i >= 0; --i)
					ans += str[i];
				encode.Add(tmp.Key,ans);
			}

			BitArray bits = new BitArray(encodedSource.ToArray());
			return encode;
		}

		public string Decode(BitArray bits)
		{
			Node current = Root;
			string decoded = "";
			foreach (bool bit in bits)
			{
				if (bit)
				{
					if (current.Right != null)
					{
						current = current.Right;
					}
				}
				else
				{
					if (current.Left != null)
					{
						current = current.Left;
					}
				}
				// Every leaf node is a symbol so once you reach there then add it to decoded and then reset the current to the root of huffman tree
				if (IsLeaf(current))
				{
					decoded += current.Symbol;
					current = Root;
				}
			}
			return decoded;
		}

		public bool IsLeaf(Node node)
		{
			return node.Left == null && node.Right == null;
		}
	}

	internal class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Введите строку");
			string input = Console.ReadLine();
			HuffmanTree huffmanTree = new HuffmanTree();
			huffmanTree.BuildHuffmanTree(input);

			// Encode
			var encoded = huffmanTree.Encode();
			foreach (var tmp in encoded)
			{
				Console.Write($"Символ {tmp.Key} код {tmp.Value}\n");
			}

			Console.WriteLine();

			// Decode
			string decoded = huffmanTree.Decode(encoded);
			Console.WriteLine("Decoded: " + decoded);
		}
	}
}