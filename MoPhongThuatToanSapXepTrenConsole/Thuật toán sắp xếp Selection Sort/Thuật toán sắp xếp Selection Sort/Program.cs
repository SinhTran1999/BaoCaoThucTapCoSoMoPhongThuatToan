using System;
namespace ThuattoanSelectionSort
{
    public class ThuatToanSelectionSort
    {
        public static void HoanVi(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        public static void SelectionSort(int[] a, int n)
        {
            int min;
            for (int i = 0; i < n - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }
                HoanVi(ref a[i], ref a[min]);
            }
        }

        public static void Main()
        {
            int[] arr = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 };
            int n = 10, i;
            Console.WriteLine("Thuat toan sap xep Selection Sort");
            Console.Write("Mang truoc khi sap xep: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            SelectionSort(arr, n);
            Console.Write("\nMang sau khi sap xep: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}