using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int x = 20;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = x;
                x--;
            }
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
            SelectionSort(arr);
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Performs Selection Sort on array
        /// </summary>
        /// <param name="arr">Array to be sorted</param>
        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }
                if (min != i)
                    Swap(arr, i, min);
            }
        }

        /// <summary>
        /// Swaps two elements in an array
        /// </summary>
        /// <param name="arr">Array where numbers reside</param>
        /// <param name="x">Index to be swapped</param>
        /// <param name="y">Index to be swapped</param>
        public static void Swap(int[] arr, int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
    }
}
