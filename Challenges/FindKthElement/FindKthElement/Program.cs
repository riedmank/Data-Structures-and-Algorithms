using System;
using LinkedList.Classes;

namespace FindKthElement
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            NodeFinderAtK(12);
        }

        public static object NodeFinderAtK(int k)
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");
            Node node5 = new Node("node5");

            LL ll = new LL(node1);
            
            int counter = 0;
            ll.Current = ll.Head;
            while (ll.Current != null)
            {
                counter++;
                ll.Current = ll.Current.Next;
            }
            ll.Current = ll.Head;
            for (int i = 0; i < counter - k; i++)
            {
                ll.Current = ll.Current.Next;
            }
            return ll.Current.Value;
        }
    }
}
