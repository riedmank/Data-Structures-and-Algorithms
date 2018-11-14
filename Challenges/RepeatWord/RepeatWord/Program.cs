using System;
using HashTables.Classes;

namespace RepeatWord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string test = "The cheese was only better than the wine.";
            Console.WriteLine(RepeatWordMethod(test));
        }

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
