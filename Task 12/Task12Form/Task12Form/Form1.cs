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

namespace Task12Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d]") && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }
        public static int[] HeapSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                MakeHeap(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                Swap(ref arr[0], ref arr[i]);
                MakeHeap(arr, i, 0);
            }
            return arr;
        }
        static void MakeHeap(int[] arr, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1; 
            int r = 2 * i + 2; 
            if (l < n && arr[l] > arr[largest])
                largest = l;
            if (r < n && arr[r] > arr[largest])
                largest = r;
            if (largest != i)
            {
                Swap(ref arr[i], ref arr[largest]);
                MakeHeap(arr, n, largest);
            }
        }

        static void Swap(ref int l, ref int r)
        {
            int tmp = l;
            l = r;
            r = tmp;
        }
        public static int[] CoctailSort(int[] arr)
        {
            int l = 0, r = arr.Length;
            while (l < r)
            {
                for (int i = l; i < r - 1; ++i)
                    if (arr[i] > arr[i + 1])
                        Swap(ref arr[i], ref arr[i + 1]);
                r--;
                for (int i = r; i > l; --i)
                    if (arr[i] < arr[i - 1])
                        Swap(ref arr[i], ref arr[i - 1]);
                l++;
            }
            return arr;
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (sizeText.Text == "")
            {
                MessageBox.Show("Заполните поле");
                return;
            }
            int n = int.Parse(sizeText.Text);
            var arr = new List<int>();
            var rnd = new Random();
            for (int i = 0; i < n; ++i)
                arr.Add(rnd.Next(100));
            var cocktail = arr.ToArray();
            var heap = arr.ToArray();
            cocktail = CoctailSort(cocktail);
            heap = HeapSort(heap);
            Show(arr, cocktail, heap);
        }
        private void Show(List<int> arr,int[] cocktail,int[] heap)
        {
            int n = arr.Count;
            string cocktailStr = "", heapStr = "", arrStr = "";
            for (int i = 0; i < n; ++i)
                arrStr += arr[i].ToString() + " ";
            for (int i = 0; i < n; ++i)
                cocktailStr += cocktail[i].ToString() + " ";
            for (int i = 0; i < n; ++i)
                heapStr += heap[i].ToString() + " ";
            arrText.Text = arrStr;
            cocktailText.Text = cocktailStr;
            heapText.Text = heapStr;
        }
    }
}
