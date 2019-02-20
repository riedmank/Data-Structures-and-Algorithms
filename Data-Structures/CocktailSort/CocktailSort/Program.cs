using System;

namespace CocktailSort
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
            CocktailSort(arr);
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Sorts an array using Cocktail Sort
        /// </summary>
        /// <param name="arr">Array to be sorted</param>
        public static void CocktailSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                        Swap(arr, j, j + 1);
                }
                for (int k = arr.Length - i - 1; k > i; k--)
                {
                    if (arr[k] < arr[k - 1])
                        Swap(arr, k - 1, k);
                }
            }
        }

        /// <summary>
        /// Swaps two elements in an array
        /// </summary>
        /// <param name="arr">Array where elements reside</param>
        /// <param name="x">Number to be swapped</param>
        /// <param name="y">Number to be swapped</param>
        public static void Swap(int[] arr, int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
    }
}
