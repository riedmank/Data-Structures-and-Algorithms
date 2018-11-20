using System;

namespace Sorting_Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Unsorted Array:");
            int[] arr = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sorted Array:");
            int[] result = InsertionSort(arr);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
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
    }
}
