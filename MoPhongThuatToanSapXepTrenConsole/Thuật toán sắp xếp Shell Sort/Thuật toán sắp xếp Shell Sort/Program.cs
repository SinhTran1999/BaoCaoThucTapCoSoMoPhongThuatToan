using System;
namespace ThuattoanShellSort
{
    public class ThuatToanShellSort
    {

        public static void ShellSort(int[] a, int n, int devideBy)
        {
            int i;
            int j;
            int x;
            int gap;
            for (gap = n / devideBy; gap > 0; gap /= devideBy)
            {
                for ( i = gap; i < n; i++)
                {
                    x = a[i];
                    j = i - gap;
                    while (x < a[j] && (j >= 0))
                    {
                        a[j + gap] = a[j];
                        j = j - gap;
                    }
                    a[j + gap] = x;
                }
            }
        }
        public static void Main()
        {
            int[] arr = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 };
            int n = 10, i;
            Console.WriteLine("Thuat toan sap xep Shell Sort :");
            Console.Write("Mang truoc khi sap xep: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            ShellSort(arr, n, 2);
            Console.Write("\nMang sau khi sap xep: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}