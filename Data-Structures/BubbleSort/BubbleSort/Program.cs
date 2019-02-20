using System;

namespace BubbleSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[20];
            int x = 20;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = x--;
            }
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
            BubbleSort(arr);
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Sorts an array
        /// </summary>
        /// <param name="arr">Array to be sorted</param>
        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                        Swap(arr, j, j + 1);
                }
            }
        }

        /// <summary>
        /// Swaps provided values
        /// </summary>
        /// <param name="arr">Array where values live</param>
        /// <param name="x">Value to be swapped</param>
        /// <param name="y">Value to be swapped</param>
        public static void Swap(int[] arr, int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
    }
}
