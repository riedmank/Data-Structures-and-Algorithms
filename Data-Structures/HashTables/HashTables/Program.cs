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
            
            HT.Add("animal", "cat");
            Console.WriteLine(HT.Contains("animal"));
            
            HT.Add("fish", "grouper");
            Console.WriteLine(HT.Contains("fish"));
            
            HT.Add("car", "porshe");
            Console.WriteLine(HT.Contains("car"));
            
            HT.Add("occupation", "dentist");
            Console.WriteLine(HT.Contains("occupation"));
        }
    }
}
