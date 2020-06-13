using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task8Form
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private static int[,] matr = new int[10, 10];
        private static int cycle = 0;
        private static int edge = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void Task5Form_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tableLayout.ColumnCount; i++)
            {
                for(int j = 0; j < tableLayout.RowCount; ++j)
                {
                    var text = new TextBox();
                    text.KeyPress += new KeyPressEventHandler(KeyPressBin);
                    text.Name = $"text{i}{j}";
                    text.Text = "0";
                    tableLayout.Controls.Add(text, i, j);
                }
            }
        }

        private void KeyPressBin(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[0-1]") && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }
        private void KeyPressDec(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d]") && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }
        private void rndButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 100; ++i)
                tableLayout.Controls[i].Text = "0";
            Random rnd = new Random();
            
            for(int i = 0; i < edge; ++i)
            {
                int n = rnd.Next(10), m = rnd.Next(10);
                if (n != m)
                {
                    tableLayout.Controls[n * 10 + m].Text = "1";
                    tableLayout.Controls[m * 10 + n].Text = "1";
                }   
            }
        }

        private bool HandleInputs()
        {
            bool ok = true;
            string error = "";
            for (int i = 0; i < tableLayout.Controls.Count && ok; i++)
            {
                ok = int.TryParse(tableLayout.Controls[i].Text, out matr[i / 10, i % 10]);
                if (!ok)
                    error = $"Данные в строке {i / 10 + 1}, столбце {i % 10 + 1} введены некорректно";
            }

            if (!ok)
                MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (cycleText.Text != "")
            {
                cycle = int.Parse(cycleText.Text);
            }
            else
            {
                ok = false;
                MessageBox.Show("Не правильный ввод длины цикла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ok;
        }
        private static List<List<int>> g = new List<List<int>>(); // граф
        private static int n = 10; // число вершин
        private static List<bool> used = new List<bool>();
        private static List<int> p = new List<int>();
        private static int lenCount;
        private static void dfs(int v)
        {
            used[v] = true;
            for (var i = 0; i < g[v].Count; ++i)
            {
                int to = g[v][i];
                if (!used[to])
                {
                    p[v] = to;
                    dfs(to);
                }
            }
        }
        public static string Solve(int[,] matr,int k)
        {
            int n = 10;
            g = new List<List<int>>();
            for (int i = 0; i < n; ++i)
            {
                g.Add(new List<int>());
                g[i] = new List<int>();
            }
            for (int i = 0; i < matr.GetLength(0); ++i)
            {
                for (int j = 0; j < matr.GetLength(1); ++j)
                {
                    if (matr[i, j] == 1)
                        g[i].Add(j);
                }
            }
            var ans = "";
            bool ok = false;
            int beginning = 0;
            List<int> ansPoint = new List<int>();
            for(int i = 0; i < n; ++i)
            {
                used = new List<bool>();
                p = new List<int>();
                ansPoint = new List<int>();
                for(int j = 0; j < n; ++j)
                {
                    used.Add(false);
                    p.Add(-1);
                }
                dfs(i);
                beginning = i;
                var tmp = k;
                for (int v = beginning; v != -1 && tmp > 0; v = p[v], tmp--)
                    ansPoint.Add(v);
                if (ansPoint.Count >= k)
                {
                    ok = true;
                    break;
                }
            }
            
            if (!ok)
                ans+="Цепи такой длины нет";
            else
            {
                for (int v=beginning; v!=-1 && k>0;v=p[v],k--)
                    ans+=(v + 1 + " ");
            }
            return ans;
        }
        private void goButton_Click(object sender, EventArgs e)
        {
            if (!HandleInputs())
                return;
            var ans = Solve(matr,cycle).ToString();
            ansText.Text = ans.ToString();
        }
    }
}
