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

namespace Task10Form
{
    public partial class Form1 : Form
    {
        private static List<int> arr=null;
        public Form1()
        {
            InitializeComponent();
        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d]") && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }
        public static List<int> Solve(int n,List<int> arr)
        {
            List<int> ans = new List<int>();
            for (int i = 0; i < n - 1; ++i)
            {
                ans.Add( arr[i] - arr[n - 1]);
            }
            return ans;
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (sizeText.Text == "")
            {
                MessageBox.Show("Заполните поле");
                return;
            }
            int n = int.Parse(sizeText.Text);
            if (n <= 2)
            {
                MessageBox.Show("Размер массива должен быть больше 2");
                return;
            }
            Random rnd = new Random();
            arr = new List<int>();
            for (int i = 0; i < n; ++i)
            {
                arr.Add(rnd.Next(100));
            }
            var arrAns = Solve(n, arr);
            string s = "";
            string sAns = "";
            for (int i = 0; i < n; ++i)
                s += arr[i].ToString() + " ";

            for (int i = 0; i < n-1; ++i)
                sAns += arrAns[i].ToString() + " ";
            arrText.Text = s;
            ansText.Text = sAns;
                
        }
    }
}
