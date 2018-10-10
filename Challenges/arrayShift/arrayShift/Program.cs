using System;

namespace arrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays created for testing insert into array: odd and even length array
            int[] testOne = { 1, 2, 4, 5 };
            int[] testTwo = { 1, 2, 4 };

            // Test value to insert
            int test = 3;

            // Array created for testing remove from array: odd and even length array
            int[] testThree = { 1, 2, 10, 3, 4 };
            int[] testFour = { 1, 2, 3, 10, 4, 5 };

            // Assigning array results
            int[] resultOne = ArrayShift(testOne, test);
            int[] resultTwo = ArrayShift(testTwo, test);
            int[] resultThree = ArrayRemove(testThree);
            int[] resultFour = ArrayRemove(testFour);

            // Printing results
            Console.WriteLine("First array:");
            foreach (int num in resultOne)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Second array:");
            foreach (int num in resultTwo)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Remove test One:");
            foreach (int num in resultThree)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Remove test Two:");
            foreach (int num in resultFour)
            {
                Console.WriteLine(num);
            }
        }

        // Adds user value into the array at the middle index
        static int[] ArrayShift(int[] arr, int num)
        {
            // Create new array
            int[] newArray = new int[arr.Length + 1];
            // Find middle value
            int middle = arr.Length % 2 != 0 ? (arr.Length / 2) + 1 : arr.Length / 2;
            // Insert old array into new array with new value in the middle index
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i == middle) newArray[i] = num;
                else if (i < middle) newArray[i] = arr[i];
                else newArray[i] = arr[i - 1];
            }
            return newArray;
        }

        // Removes the value at the middle index
        static int[] ArrayRemove(int[] arr)
        {
            // Create new array
            int[] newArray = new int[arr.Length - 1];
            // Find middle value
            int middle = newArray.Length % 2 != 0 ? (newArray.Length / 2) + 1 : newArray.Length / 2;
            // Insert old array into new array with middle value removed
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < middle) newArray[i] = arr[i];
                else if (i == middle) continue;
                else newArray[i - 1] = arr[i];
            }
            return newArray;
        }
    }
}
