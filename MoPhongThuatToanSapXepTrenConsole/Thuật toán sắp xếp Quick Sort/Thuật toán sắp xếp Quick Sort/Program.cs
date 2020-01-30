using System;
namespace ThuattoanQuickSort
{
    public class ThuatToanQuickSort
    {
        public static void HoanVi(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        public static void QuickSort(int[] a, int left, int right)
        {
            int i, j, x;
            i = left;
            j = right;
            x = a[(left + right) / 2];
            do
            {
                while (a[i] < x)
                {
                    i++;
                }
                while (a[j] > x)
                {
                    j--;
                }
                if (i <= j)
                {
                    HoanVi(ref a[i],ref a[j]);
                    i++;
                    j--;
                }
            } while (i <= j);
            if (left < j)
            {
                QuickSort(a, left, j);
            }
            if (right > i)
            {
                QuickSort(a, i, right);
            }
        }

        public static void Main()
        {
            int[] arr = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 };
            int n = 10, i;
            Console.WriteLine("Thuat toan sap xep Quick Sort");
            Console.Write("Mang truoc khi sap xep: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            QuickSort(arr, 0, n-1);
            Console.Write("\nMang sau khi sap xep: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}