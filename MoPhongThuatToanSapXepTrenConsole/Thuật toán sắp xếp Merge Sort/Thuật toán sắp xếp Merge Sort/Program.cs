using System;

namespace ThuattoanMergeSort
{
    public class ThuatToanMergeSort
    {
        public static void merge(int[] a, int low, int high, int mid) {
            int i, j, k;
            int[] c = new int[10];
            i = low;
            k = low;
            j = mid + 1;
            while (i <= mid && j <= high) {
                if (a[i] < a[j]){
                    c[k] = a[i];
                    k++;
                    i++;
                }
                else{
                    c[k] = a[j];
                    k++;
                    j++;
                }
            }
            while (i <= mid){
                c[k] = a[i];
                k++;
                i++;
            }
            while (j <= high){
                c[k] = a[j];
                k++;
                j++;
            }
            for (i = low; i < k; i++){
                a[i] = c[i];
            }
        }
        public static void merge_sort(int[] a, int low, int high){
            int mid;
            if (low < high)
            {
                mid = (low + high) / 2;
                merge_sort(a, low, mid);
                merge_sort(a, mid + 1, high);
                merge(a, low, high, mid);
            }
        }

        public static void Main()
        {
            int[] arr = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 };
            int n = 10, i;
            Console.WriteLine("Thuat toan sap xep Merge Sort");
            Console.Write("Mang truoc khi sap xep: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            merge_sort(arr, 0, n - 1);
            Console.Write("\nMang sau khi sap xep: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}