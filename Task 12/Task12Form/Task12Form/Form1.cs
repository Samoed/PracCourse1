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
        private static int countSwapCoc = 0, countCompCoc = 0;
        private static int countSwapHeap = 0, countCompHeap = 0;
        
        private static int countSwapCocUp = 0, countCompCocUp = 0;
        private static int countSwapHeapUp = 0, countCompHeapUp = 0;
        
        private static int countSwapCocDown = 0, countCompCocDown = 0;
        private static int countSwapHeapDown = 0, countCompHeapDown = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d]") && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }
        public static int[] HeapSort(int[] arr, ref int countSwap, ref int countComp)
        {
            int n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                MakeHeap(arr, n, i, ref countSwap, ref countComp);
            for (int i = n - 1; i >= 0; i--)
            {
                Swap(ref arr[0], ref arr[i],ref countSwap);
                MakeHeap(arr, i, 0,ref countSwap,ref countComp);
            }
            return arr;
        }
        static void MakeHeap(int[] arr, int n, int i,ref int countSwap,ref int countComp)
        {
            int largest = i;
            int l = 2 * i + 1; 
            int r = 2 * i + 2; 
            if (l < n && arr[l] > arr[largest])
                largest = l;
            countComp++;
            if (r < n && arr[r] > arr[largest])
                largest = r;
            countComp++;
            if (largest != i)
            {
                Swap(ref arr[i], ref arr[largest],ref countSwap);
                MakeHeap(arr, n, largest,ref countSwap, ref countComp);
            }
            countComp++;
        }

        static void Swap(ref int l, ref int r,ref int count)
        {
            int tmp = l;
            l = r;
            r = tmp;
            count++;
        }
        public static int[] CoctailSort(int[] arr, ref int countComp, ref int countSwap)
        {
            int l = 0, r = arr.Length;
            while (l < r)
            {
                for (int i = l; i < r - 1; ++i)
                {
                    if (arr[i] > arr[i + 1])
                        Swap(ref arr[i], ref arr[i + 1], ref countSwap);
                    countComp++;
                }
                r--;
                for (int i = r; i > l; --i)
                {
                    if (arr[i] < arr[i - 1])
                        Swap(ref arr[i], ref arr[i - 1], ref countSwap);
                    countComp++;
                }
                l++;
            }
            return arr;
        }

        private void ArrRnd()
        {
            countSwapCoc = 0; countCompCoc = 0;
            countSwapHeap = 0; countCompHeap = 0;
            int n = int.Parse(sizeText.Text);
            var arr = new List<int>();
            var rnd = new Random();
            for (int i = 0; i < n; ++i)
                arr.Add(rnd.Next(100));
            var cocktail = arr.ToArray();
            var heap = arr.ToArray();
            cocktail = CoctailSort(cocktail, ref countCompCoc, ref countSwapCoc);
            heap = HeapSort(heap, ref countCompHeap, ref countSwapHeap);
            Show(arr, cocktail, heap);
        }
        private void ArrUp()
        {
            countSwapCocUp = 0; countCompCocUp = 0;
            countSwapHeapUp = 0; countCompHeapUp = 0;
            int n = int.Parse(sizeText.Text);
            var arr = new List<int>();
            for (int i = 0; i < n; ++i)
                arr.Add(i);
            var cocktail = arr.ToArray();
            var heap = arr.ToArray();
            cocktail = CoctailSort(cocktail, ref countCompCocUp, ref countSwapCocUp);
            heap = HeapSort(heap, ref countCompHeapUp, ref countSwapHeapUp);
            ShowUp(arr, cocktail, heap);
        }
        private void ArrDown()
        {
            countSwapCocDown = 0; countCompCocDown = 0;
            countSwapHeapDown = 0; countCompHeapDown = 0;
            int n = int.Parse(sizeText.Text);
            var arr = new List<int>();
            for (int i = 0; i < n; ++i)
                arr.Add(n-i);
            var cocktail = arr.ToArray();
            var heap = arr.ToArray();
            cocktail = CoctailSort(cocktail, ref countCompCocDown, ref countSwapCocDown);
            heap = HeapSort(heap, ref countCompHeapDown, ref countSwapHeapDown);
            ShowDown(arr, cocktail, heap);
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (sizeText.Text == "")
            {
                MessageBox.Show("Заполните поле");
                return;
            }
            ArrRnd();
            ArrUp();
            ArrDown();
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
            countCompCocText.Text = countCompCoc.ToString();
            countSwapCocText.Text = countSwapCoc.ToString();
            
            heapText.Text = heapStr;
            countCompHeapText.Text = countCompHeap.ToString();
            countSwapHeapText.Text = countSwapHeap.ToString();
        }
        private void ShowUp(List<int> arr, int[] cocktail, int[] heap)
        {
            int n = arr.Count;
            string cocktailStr = "", heapStr = "", arrStr = "";
            for (int i = 0; i < n; ++i)
                arrStr += arr[i].ToString() + " ";

            for (int i = 0; i < n; ++i)
                cocktailStr += cocktail[i].ToString() + " ";

            for (int i = 0; i < n; ++i)
                heapStr += heap[i].ToString() + " ";
            arrUpText.Text = arrStr;

            cocktailUpText.Text = cocktailStr;
            countCompCocUpText.Text = countCompCocUp.ToString();
            countSwapCocUpText.Text = countSwapCocUp.ToString();

            heapUpText.Text = heapStr;
            countCompHeapUpText.Text = countCompHeapUp.ToString();
            countSwapHeapUpText.Text = countSwapHeapUp.ToString();
        }
        private void ShowDown(List<int> arr, int[] cocktail, int[] heap)
        {
            int n = arr.Count;
            string cocktailStr = "", heapStr = "", arrStr = "";
            for (int i = 0; i < n; ++i)
                arrStr += arr[i].ToString() + " ";

            for (int i = 0; i < n; ++i)
                cocktailStr += cocktail[i].ToString() + " ";

            for (int i = 0; i < n; ++i)
                heapStr += heap[i].ToString() + " ";
            arrDownText.Text = arrStr;

            cocktailDownText.Text = cocktailStr;
            countCompCocDownText.Text = countCompCocDown.ToString();
            countSwapCocDownText.Text = countSwapCocDown.ToString();

            heapDownText.Text = heapStr;
            countCompHeapDownText.Text = countCompHeapDown.ToString();
            countSwapHeapDownText.Text = countSwapHeapDown.ToString();
        }
    }
}
