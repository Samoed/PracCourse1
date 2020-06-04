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

namespace Task9Form
{
    public partial class Form1 : Form
    {
        class MyList
        {
            private List<int> arr = new List<int>();

            public int Size
            {
                get => arr.Count;
            }
            public MyList(int n)
            {
                for (int i = 0; i < n; ++i)
                {
                    arr.Add(i + 1);
                }
            }

            public int this[int index]
            {
                get => arr[index];
            }

            public int Find(int n)
            {
                int ans = -1;
                for (int i = 0; i < arr.Count; ++i)
                {
                    if (arr[i] == n)
                        ans = n;
                }
                return ans;
            }
            public void Remove(int index)
            {
                arr.Remove(index);
            }
        }
        private static MyList arr=null;
        public Form1()
        {
            InitializeComponent();
        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d]") && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }
        private void ShowArr()
        {
            string str = "";
            for(int i = 0; i < arr.Size; ++i)
            {
                str += arr[i].ToString() + " ";
            }
            arrText.Text = str;
        }
        private void initButton_Click(object sender, EventArgs e)
        {
            if (initText.Text == "")
            {
                MessageBox.Show("Заполните поле");
                return;
            }
            int n = int.Parse(initText.Text);
            arr = new MyList(n);
            ShowArr();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (arr == null)
            {
                MessageBox.Show("Инициализируйте массив");
                return;
            }
            if (findText.Text == "")
            {
                MessageBox.Show("Заполните поле");
                return;
            }
            int find = int.Parse(findText.Text);
            var findres = arr.Find(find);
            MessageBox.Show(findres.ToString());
            if (findres == -1)
                MessageBox.Show("Такого элемента нет");
            else
                MessageBox.Show($"Индекс этого элемента {findres}");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (arr == null)
            {
                MessageBox.Show("Инициализируйте массив");
                return;
            }
            if (delText.Text == "")
            {
                MessageBox.Show("Заполните поле");
                return;
            }
            int del = int.Parse(delText.Text);
            arr.Remove(del);
            ShowArr();
        }
    }
}
