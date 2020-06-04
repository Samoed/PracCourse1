using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7Form
{
    public partial class Form1 : Form
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

		private int size = 0;
        public int[] frequency = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void KeyPressInt(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d]") && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }
        private void KeyPressDouble(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d]") && e.KeyChar != 8)
                e.Handled = true;
        }
        private void sizeButton_Click(object sender, EventArgs e)
        {
            if (sizeText.Text == "")
            {
                MessageBox.Show($"Заполните поле");
                return;
            }
            size = int.Parse(sizeText.Text);
            table.Controls.Clear();
            table.ColumnCount = 3;
            table.RowCount = 2;
            for(int i=0;i<size;++i)
                table.RowStyles.Add(new RowStyle());
            var label1 = new Label();
            var label2 = new Label();
            var label3 = new Label();
            label1.Text = "Символ";
            label2.Text = "Частота встречаемости символа";
            label3.Text = "Код символа";
            table.Controls.Add(label1, 0, 0);
            table.Controls.Add(label2, 1, 0);
            table.Controls.Add(label3, 2, 0);
            for(int i = 1; i <= size; ++i)
            {
                var symbol = new TextBox();
                var frequency = new TextBox();
                var codes = new TextBox();
                frequency.KeyPress += new KeyPressEventHandler(KeyPressDouble);
                codes.ReadOnly = true;
                table.Controls.Add(symbol, 0, i);
                table.Controls.Add(frequency, 1, i);
                table.Controls.Add(codes, 2, i);
            }
        }
        private bool HandleInput()
        {
            double sum = 0;
            bool ok = true;
            for(int i = 0; i < size && ok; ++i)
            {
                if (table.Controls[3+i * 3].Text == "" && table.Controls[3+i * 3+1].Text == "")
                {
                    ok = false;
                    MessageBox.Show($"Заполните все поля");
                }
                double tmp=double.Parse(table.Controls[3+i * 3 + 1].Text);
                sum += tmp;
            }
            return ok;
        }
		public static Dictionary<char,string> Solve(int[] frequency)
		{
			HuffmanTree tree = new HuffmanTree();
			tree.BuildHuffmanTree(frequency);
			var dict = tree.Encode();
			return dict;
		}
        private void tableButton_Click(object sender, EventArgs e)
        {
            if (!HandleInput())
                return;
            frequency = new int[size];
            string str = "";
            for (int i = 0; i < size; ++i)
            {
                frequency[i] = int.Parse(table.Controls[(i+1) * 3 + 1].Text);
            }
			var dict=Solve(frequency);
			int iter = 0;
			string stR = "";
			foreach(var tmp in dict)
			{
				table.Controls[(iter + 1) * 3 + 2].Text = tmp.Value;
				stR += tmp.Value;
				iter++;
			}
			//MessageBox.Show(stR);
        }
    }
}
