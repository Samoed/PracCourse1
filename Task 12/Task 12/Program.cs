using System;

public class Programm
{
    public static int[] HeapSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = n / 2 - 1; i >= 0; i--)
            MakeHeap(arr, n, i);
        for (int i = n - 1; i >= 0; i--)
        {
            Swap(ref arr[0],ref arr[i]);
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
            Swap(ref arr[i],ref arr[largest]);
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
        while (l<r)
        {
            for (int i = l; i < r-1; ++i)
                if(arr[i]>arr[i+1])
                    Swap(ref arr[i],ref arr[i+1]);
            r--;
            for (int i = r; i >l; --i)
                if(arr[i]<arr[i-1])
                    Swap(ref arr[i],ref arr[i-1]);
            l++;
        }
        return arr;
    }
    public static void Main()
    {
        int[] arr = {12, 11, 13, 5, 6, 7};
        int n = arr.Length;
        arr = HeapSort(arr);
        Console.WriteLine("HeapSort");
        for (int i = 0; i < n; ++i)
        {
            Console.Write(arr[i]+" ");
        }
        Console.WriteLine();
        arr = new []{12, 11, 13, 5, 6, 7};
        arr=CoctailSort(arr);
        Console.WriteLine("CocktaiSort");
        for (int i = 0; i < n; ++i)
        {
            Console.Write(arr[i]+" ");
        }
    }
}
