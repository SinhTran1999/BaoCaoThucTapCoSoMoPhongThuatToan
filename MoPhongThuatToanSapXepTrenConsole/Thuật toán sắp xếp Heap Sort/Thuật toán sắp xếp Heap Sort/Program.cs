using System;
namespace ThuattoanHeapSort
{
    public class ThuatToanHeapSort
    {
        public static void HoanVi(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void Heapifi(int[] a, int n, int i)
        {
            while (i <= (n / 2 - 1))
            {
                int left = 2 * i + 1;
                int right = 2 * i + 2;
                int max = left;
                if (right < n && a[right] > a[max])
                {
                    max = right;
                }
                if (a[i] < a[max])
                {
                    HoanVi(ref a[i], ref a[max]);
                }
                i = max;
            }
        }
        //Tao cay
        public static void BuiltHeap(int[] a, int n)
        {
            for (int i = (n / 2 - 1); i >= 0; i--)
            {
                Heapifi(a, n, i);
            }
        }
        //ham sap xep 
        public static void HeapSort(int[] a, int n)
        {
            BuiltHeap(a, n);
            for (int i = n - 1; i >= 0; i--)
            {
                HoanVi(ref a[0], ref a[i]);
                Heapifi(a, i, 0);

            }
        }

        public static void Main()
        {
            int[] arr = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 };
            int n = 10, i;
            Console.WriteLine("Thuat toan sap xep Heap Sort :");
            Console.Write("Mang truoc khi sap xep: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            HeapSort(arr, n);
            Console.Write("\nMang sau khi sap xep: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}