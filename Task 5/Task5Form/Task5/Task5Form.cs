using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private static double[,] matr = new double[10, 10];

        public Form1()
        {
            InitializeComponent();
        }

        private void Task5Form_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    TextBox text = new TextBox();
                    text.KeyPress += new KeyPressEventHandler(KeyPress);
                    table.Controls.Add(text, i, j);
                }
            }
            for (int i = 0; i < 10; i++)
            {
                TextBox text = new TextBox();
                text.ReadOnly = true;
                resultPanel.Controls.Add(text, 0, i);
            }
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d,\-]") && e.KeyChar != 8 && e.KeyChar!=46)
                e.Handled = true;
        }

        private void rndButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table.Controls.Count; i++)
                table.Controls[i].Text = rand.Next(100).ToString();
        }

        private bool HandleInputs()
        {
            bool ok = true;
            string error = "";
            for (int i = 0; i < table.Controls.Count && ok; i++)
            {
                ok = double.TryParse(table.Controls[i].Text, out matr[i % 10, i / 10]);

                if (!ok)
                    error = $"Данные в строке {i / 10 + 1}, столбце {i % 10 + 1} введены некорректно";
            }

            if (!ok)
                MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            return ok;
        }
        public static int[] Solve(double[,] matr)
        {
            int[] ans = new int[matr.GetLength(0)];
            for (int i = 0; i < matr.GetLength(0); ++i)
            {
                bool fl1 = true, fl2 = true;
                for (int j = 0; j < matr.GetLength(1)-1; ++j)
                {
                    if (matr[i, j] < matr[i, j + 1] && fl1)
                    {
                        fl2 = false;
                    }
                    else if (matr[i, j] > matr[i, j + 1] && fl2)
                    {
                        fl1 = false;
                    }
                    else
                    {
                        fl1 = false;
                        fl2 = false;
                    }
                }

                if (fl1 || fl2) ans[i] = 1;
            }
            return ans;
        }
        private void goButton_Click(object sender, EventArgs e)
        {
            if (!HandleInputs())
                return;
            var ans = Solve(matr);
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                resultPanel.Controls[i].Text = ans[i].ToString();
            }
        }
    }
}
