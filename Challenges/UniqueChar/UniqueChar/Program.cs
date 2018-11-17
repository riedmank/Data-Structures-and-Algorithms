using System;
using System.Collections.Generic;
using HashTables.Classes;

namespace UniqueChar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string thing = "what does qubc";

            Console.WriteLine(UniqueCharMethod(thing));
        }


        /// <summary>
        /// Unique character method.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>Returns true if there are only unique characters; otherwise, returns false.</returns>
        public static bool UniqueCharMethod(string item)
        {
            List<char> value = new List<char>();
            foreach (char letter in item)
            {
                if (letter != ' ')
                    value.Add(letter);
            }           
            HashTable HT = new HashTable();
            foreach (char val in value)
            {
                if (HT.Contains(val.ToString()))
                    return false;
                else
                    HT.Add(val.ToString(), null);
            }
            return true;
        }
    }
}
