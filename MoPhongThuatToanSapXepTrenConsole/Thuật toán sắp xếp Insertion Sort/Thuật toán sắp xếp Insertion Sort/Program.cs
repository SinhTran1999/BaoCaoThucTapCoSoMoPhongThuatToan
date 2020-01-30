using System;
namespace ThuattoanInsertionSort
{
    public class ThuatToanInsertionSort
    {
        public static void InsertionSort(int[] a, int n)
        {
            int pos;
            int x;
            for (int i = 1; i < n; i++)
            {
                x = a[i];
                pos = i - 1;
                while ((pos >= 0) && (a[pos] > x))
                {
                    a[pos + 1] = a[pos];
                    pos--;
                }
                a[pos + 1] = x;

            }

        }

        public static void Main()
        {
            int[] arr = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 };
            int n = 10, i;
            Console.WriteLine("Thuat toan sap xep Insertion Sort :");
            Console.Write("Mang truoc khi sap xep: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            InsertionSort(arr, n);
            Console.Write("\nMang sau khi sap xep: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}