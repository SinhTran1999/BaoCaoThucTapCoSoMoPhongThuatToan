using System;
namespace ThuattoanShakerSort
{
    public class ThuatToanShakerSort
    {
        public static void HoanVi(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        public static void Shaker_Sort(int[] a, int n)
        {
            int j;
            int left = 0, right = n - 1, k = n - 1;
            while (left < right)
            {
                for (j = right; j > left; j--)
                    if (a[j] < a[j - 1])
                    {
                        HoanVi(ref a[j], ref a[j - 1]);
                        k = j;
                    }
                left = k;
                for (j = left; j < right; j++)
                    if (a[j] > a[j + 1])
                    {
                        HoanVi(ref a[j], ref a[j + 1]);
                        k = j;
                    }
                right = k;
            }
        }

        public static void Main()
        {
            int[] arr = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 };
            int n = 10, i;
            Console.WriteLine("Thuat toan sap xep Shaker Sort");
            Console.Write("Mang truoc khi sap xep: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Shaker_Sort(arr, n);
            Console.Write("\nMang sau khi sap xep: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}