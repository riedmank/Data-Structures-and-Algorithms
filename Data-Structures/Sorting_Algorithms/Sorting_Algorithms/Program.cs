using System;

namespace Sorting_Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Unsorted Array:");
            int[] arr1 = new int[] { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
            foreach (int item in arr1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine("Sort Array using Insertion Sort:");
            int[] insertionResult = InsertionSort(arr1);
            foreach (int item in insertionResult)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            int[] arr2 = new int[] { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Console.WriteLine("Unsorted Array:");
            foreach (int item in arr2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine("Sort Array using Quick Sort:");
            QuickSort(arr2, 0, arr2.Length - 1);
            foreach (int item in arr2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Performs insertion sort
        /// </summary>
        /// <param name="myArray">Unsorted array</param>
        /// <returns>Returns a sorted array</returns>
        public static int[] InsertionSort(int[] myArray)
        {
            for (int i = 1; i < myArray.Length; i++)
            {
                int temp = myArray[i];
                int j = i - 1;

                while (j >= 0 && temp < myArray[j])
                {
                    myArray[j + 1] = myArray[j];
                    j--;
                }
                myArray[j + 1] = temp;
            }
            return myArray;
        }


        /// <summary>
        /// Quick sort algorithm
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);

                QuickSort(arr, left, position - 1);

                QuickSort(arr, position + 1, right);
            }
        }

        /// <summary>
        /// Partitions the specified arr.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>Returns lowest value + 1</returns>
        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }
            Swap(arr, right, low + 1);
            return low + 1;
        }

        /// <summary>
        /// Swaps the specified arr.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="i">The i.</param>
        /// <param name="low">The low.</param>
        public static void Swap(int[] arr, int i, int low)
        {
            int temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}
