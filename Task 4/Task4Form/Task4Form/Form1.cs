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

namespace Task4Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\-,\d]") && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            double eps;
            if (double.TryParse(epsText.Text, out eps) && epsText.Text != "")
            {
                answer.Text = Solve(eps).ToString();
            }
            else
            {
                MessageBox.Show($"Неправильные данные");
            }
        }
        static double F(double x)
        {
            return x + Math.Log(x + 0.5) - 0.5;
        }
        public static double Solve(double eps)
        {
            double l = 0, r = 2;
            while (F(l) + eps < F(r))
            {
                double mid = (l + r) / 2;
                if (F(mid) < 0)
                    l = mid;
                else r = mid;
            }
            return r;
        }
    }
}
