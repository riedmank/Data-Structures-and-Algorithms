using System;

namespace reverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[11];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
            }
            Console.WriteLine("Normal array");
            foreach(int num in myArray)
            {
                Console.WriteLine(num);
            }
            ReverseArray(myArray);
            Console.WriteLine("Reversed array");
            foreach (int num in myArray)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Reverses an array in place
        /// </summary>
        /// <param name="arr">Array to be reversed</param>
        public static void ReverseArray(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }
    }
}
