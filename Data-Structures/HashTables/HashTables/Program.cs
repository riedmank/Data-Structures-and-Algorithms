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
            Console.WriteLine(HT.Contains("food"));

            HT.Add("rats", "cat");
            Console.WriteLine(HT.Contains("rats"));

            HT.Add("fish", "grouper");
            Console.WriteLine(HT.Contains("fish"));

            HT.Add("car", "porshe");
            Console.WriteLine(HT.Contains("car"));

            HT.Add("occupation", "dentist");
            Console.WriteLine(HT.Contains("occupation"));

            HT.Add("star", "pulsar");
            Console.WriteLine(HT.Contains("star"));
        }
    }
}
