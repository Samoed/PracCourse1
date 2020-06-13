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
    public class List
    {
        public class Node
        {
            public double Data { get; set; }
            public Node Next { get; set; }

            public Node(double item)
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
        public List(double[] arr)
        {
            head = null;
            tail = null;
            for (int i = 0; i < arr.Length; i++)
                Add(arr[i]);
        }

        public double this[int index]
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
        public void Add(double item)
        {
            Node node = new Node(item);

            if (head == null) head = node;
            else tail.Next = node;

            Length++;
            tail = node;
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
    public partial class Form1 : Form
    {
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
        public static List Solve(int n,List arr)
        {
            List ans = new List();
            for (int i = 0; i < n - 1; ++i)
            {
                ans.Add(arr[i] - arr[n - 1]);
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
            double[] tmp = new double[n];
            for (int i = 0; i < n; ++i)
            {
                tmp[i] = rnd.Next(100);
            }
            arr = new List(tmp);
            var arrAns = Solve(n, arr);
            string s = "";
            string sAns = "";
            for (int i = 1; i < n; ++i)
                s += arr[i].ToString() + " ";

            for (int i = 1; i < n-1; ++i)
                sAns += arrAns[i].ToString() + " ";
            arrText.Text = s;
            ansText.Text = sAns;
                
        }
    }
}
