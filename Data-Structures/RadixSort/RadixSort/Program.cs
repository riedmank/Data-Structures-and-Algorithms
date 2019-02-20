using System;

namespace RadixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int x = 20;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = x--;
            }
            Print(arr);
            RadixSort(arr);
            Print(arr);
        }

        /// <summary>
        /// Finds the max value
        /// </summary>
        /// <param name="arr">Array to be searched</param>
        /// <returns>Returns max value</returns>
        public static int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        /// <summary>
        /// Counts a bunch of things and does some swaps
        /// </summary>
        /// <param name="arr">Array</param>
        /// <param name="exp">Integer</param>
        public static void CountSort(int[] arr, int exp)
        {
            int[] output = new int[arr.Length];
            int i;
            int[] count = new int[10];
            for (i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }

            for (i = 0; i < arr.Length; i++)
            {
                count[arr[i] / exp % 10]++;
            }

            for (i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (i = arr.Length - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp % 10)] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = output[i];
            }
        }

        /// <summary>
        /// Performs RadixSort
        /// </summary>
        /// <param name="arr">Array to be sorted</param>
        public static void RadixSort(int[] arr)
        {
            int m = GetMax(arr);

            for (int exp = 1; m / exp > 0; exp *= 10)
            {
                CountSort(arr, exp);
            }
        }

        /// <summary>
        /// Prints array of values
        /// </summary>
        /// <param name="arr">Array to be printed</param>
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
