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

namespace Task6Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d,\-]") && e.KeyChar != 8)
                e.Handled = true;
        }
        public static double[] Solve(double a1,double a2,ref double a3, double m, double n,out int j)
        {
            List<double> arr = new List<double>();
            double a;
            j = 0;
            while (Math.Abs(a3 * 3 / 2 - a2 * 2 / 3 - a1 / 3) > m)
            {
                a = a3 * 3 / 2.0 - a2 * 2 / 3.0 - a1 / 3.0;
                a1 = a2;
                a2 = a3;
                a3 = a;
                j++;
                arr.Add(a);
            }
            return arr.ToArray();
        }
        private void button_Click(object sender, EventArgs e)
        {
            double a1, a2, a3, m, n;
            int j;
            if (a1Text.Text != "" && a2Text.Text != "" && a3Text.Text != "" && mText.Text != "" && nText.Text != "" &&
                double.TryParse(a1Text.Text, out a1) && double.TryParse(a2Text.Text, out a2) && double.TryParse(a3Text.Text, out a3)
                && double.TryParse(mText.Text, out m) && double.TryParse(nText.Text, out n))
            {
                var ans = Solve(a1, a2,ref a3, m, n, out j);
                ansCompare.Text = a3 == m ? "А и М равны" : "А и М не равны";
                if (j > n)
                {
                    jAns.Text=($"J больше N");
                }
                else if (j < n)
                {
                    jAns.Text = ($"J меньше N");
                }
                else
                {
                    jAns.Text = ($"J равно N");
                }
                string str = "";
                for(int i = 0; i < (ans.Length); ++i)
                {
                    str += ans[i].ToString() + "\r\n";
                }
                order.Text = str;
            }
            else
            {
                MessageBox.Show("Неправильный ввод");
            }
        }
    }
}
