using System;

namespace BinarySearch
{
    public class Program
    {
        public static int[] testArrayOne = { 4, 8, 15, 16, 23, 42, 54, 77, 99, 123 };
        public static int[] testArrayTwo = { 11, 22, 33, 44, 55, 66, 77, 88, 99, 111 };
        public static void Main(string[] args)
        {
            Console.WriteLine($"Search One: {ArrayBinarySearch(testArrayOne, 15)}");
            Console.WriteLine($"Search Two: {ArrayBinarySearch(testArrayTwo, 11)}");
        }
        /// <summary>
        /// Searches for a target value inside a sorted array
        /// </summary>
        /// <param name="arr">A sorted array</param>
        /// <param name="target">An integer</param>
        /// <returns>Returns the index of the target value or -1</returns>
        public static int ArrayBinarySearch(int[] arr, int target)
        {
            int start = - 1;
            int end = arr.Length;
            while(start < end)
            {
                int mid = (start + end) / 2;
                if (arr[mid] == target) return mid;
                else if (arr[mid] < target) start = mid + 1;
                else end = mid - 1;
            }
            return -1;
        }
    }
}
