using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            double x, y;
            if (double.TryParse(xText.Text,out x) && double.TryParse(xText.Text, out y) && xText.Text!="" && yText.Text!="")
            {
                answer.Text = Solve(x, y).ToString();
            }
            else
            {
                MessageBox.Show($"x={x_label.Text} y={y_label.Text}");
            }
        }
        public static double Solve(double x, double y)
        {
            double u = x;
            if (x * x + y * y <= 4 && x * x + y * y >= 1 && y >= 0)
                u = 0;
            return u;
        }
    }
}
