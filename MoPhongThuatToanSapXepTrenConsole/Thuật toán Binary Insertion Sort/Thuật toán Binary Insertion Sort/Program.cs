using System;
namespace ThuattoanBinaryInsertionSort
{
    public class ThuatToanBinaryInsertionSort
    {
        public static void Binary_Insertion_Sort(int[] a, int n)
        {
            int left, right, m, i;
            int key;
            for (i = 1; i < n; i++)
            {
                key = a[i];//luu gia tri a[i] tranh bi ghi de khi doi vi vi tri
                left = 0;
                right = i - 1;
                while (left <= right)
                {
                    m = (left + right) / 2;// tim vi tri thich hop cua m
                    if (key < a[m])
                        right = m - 1;
                    else left = m + 1;
                }
                for (int j = i - 1; j >= left; j--)
                    a[j + 1] = a[j]; //doi cac phan tu dung sau key
                a[left] = key; //chen key vao day
            }
        }

        public static void Main()
        {
            int[] arr = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 };
            int n = 10, i;
            Console.WriteLine("Thuat toan sap xep Binary Insertion Sort :");
            Console.Write("Mang truoc khi sap xep: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Binary_Insertion_Sort(arr, n);
            Console.Write("\nMang sau khi sap xep: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}