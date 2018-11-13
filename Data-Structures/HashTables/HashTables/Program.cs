using HashTables.Classes;
using LinkedList.Classes;
using System;

namespace HashTables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashTable HT = new HashTable();

            HT.Add("food", "potato");
            Console.WriteLine("Add: food, potato");
            Console.WriteLine($"Found in Hash Table: {HT.Contains("food")}");

            HT.Add("rats", "cat");
            Console.WriteLine("Add: rats, cat");
            Console.WriteLine($"Found in Hash Table: {HT.Contains("rats")}");

            HT.Add("fish", "grouper");
            Console.WriteLine("Add: fish, grouper");
            Console.WriteLine($"Found in Hash Table: {HT.Contains("fish")}");

            HT.Add("car", "porshe");
            Console.WriteLine("Add: car, porshe");
            Console.WriteLine($"Found in Hash Table: {HT.Contains("car")}");

            HT.Add("occupation", "dentist");
            Console.WriteLine("Add: occupation, dentist");
            Console.WriteLine($"Found in Hash Table: {HT.Contains("occupation")}");

            HT.Add("star", "pulsar");
            Console.WriteLine("Add: star, pulsar");
            Console.WriteLine($"Found in Hash Table: {HT.Contains("star")}");
        }
    }
}
