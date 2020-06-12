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
        public class List
        {
            public class Node
            {
                public int Data { get; set; }
                public Node Next { get; set; }

                public Node(int item)
                {
                    Data = item;
                    Next = null;
                }
            }

            public int Length { get; protected set; }
            private Node head;
            private Node tail;

            public List()
            {
                Length = 0;
                head = null;
                tail = null;
            }

            public List(int size)
            {
                head = null;
                tail = null;
                for (int i = 0; i <= size; i++)
                    Add(i);
            }

            public int this[int index]
            {
                get
                {
                    if (index < 0 || index > Length) throw new IndexOutOfRangeException();
                    return FindNode(index).Next.Data;
                }

                set
                {
                    if (index < 0 || index > Length) throw new IndexOutOfRangeException();

                    Node node = FindNode(index).Next;
                    node.Data = value;
                }
            }

            public Node FindNode(int index)
            {
                Node find = head;
                index--;
                int ind = 0;
                while (ind < index)
                {
                    find = find.Next;
                    ind++;
                }
                return find;
            }
            public int Find(int value)
            {
                Node find = head;
                int index = 0;
                for(int i = 1; i <= Length; ++i)
                {
                    if (find.Data == value) return i-2;
                    find = find.Next;
                }
                return -1;
            }
            public void Add(int item)
            {
                Node node = new Node(item);

                if (head == null) head = node;
                else tail.Next = node;

                Length++;
                tail = node;
            }

            public void Remove(int index)
            {
                if (index < 0) throw new ArgumentOutOfRangeException("Индекс", "Индекс должен быть выражен неотрицательным числом");
                if (index > Length) throw new ArgumentOutOfRangeException("Индекс", "Индекс должен быть меньше или равно числу элементов в листе");

                if (index == 0) head = head.Next;
                else
                {
                    Node node = FindNode(index);
                    node.Next = node.Next.Next;
                }

                Length--;
            }

            public void Clear()
            {
                Node node = head;

                while (node != null)
                {
                    Node prev = node;
                    node = node.Next;
                    prev.Next = null;
                }

                head = null;
                tail = null;
                Length = 0;
            }
        }
        private static List arr=null;
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
            for(int i = 1; i < arr.Length; ++i)
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
            arr = new List(n);
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
            if (findres== -1)
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
