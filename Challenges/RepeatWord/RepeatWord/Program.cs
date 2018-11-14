using System;
using HashTables.Classes;

namespace RepeatWord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string test = "The cheese was only better than the wine.";
            Console.WriteLine($"Sample string: {test}");
            Console.WriteLine($"Word returned: {RepeatWordMethod(test)}");
        }

        /// <summary>
        /// Finds a repeated word in a string
        /// </summary>
        /// <param name="value">User provided string</param>
        /// <returns>Returns the first repeated word</returns>
        public static string RepeatWordMethod(string value)
        {
            HashTable HT = new HashTable();
            string[] values = value.ToLower().Split(" ");
            foreach (string item in values)
            {
                if (!HT.Contains(item))
                    HT.Add(item, null);
                else
                    return item;
            }
            return null;
        }
    }
}
