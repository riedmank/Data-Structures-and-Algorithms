using System;
using LinkedList.Classes;

namespace FindKthElement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");
            Node node5 = new Node("node5");

            LL ll = new LL(node1);

            NodeFinderAtK(1, ll);
        }

        /// <summary>
        /// Finds the Kth node from end of a Linked List
        /// </summary>
        /// <param name="k">The target value</param>
        /// <param name="ll">A Linked List</param>
        /// <returns>Returns the value at the searched for node</returns>
        public static object NodeFinderAtK(int k, LL ll)
        {
            int counter = 0;
            ll.Current = ll.Head;
            while (ll.Current != null)
            {
                counter++;
                ll.Current = ll.Current.Next;
            }
            ll.Current = ll.Head;
            try
            {
                if (k > counter)
                {
                    throw new Exception("Value is outside Linked List");
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            
            for (int i = 0; i < counter - k; i++)
            {
                ll.Current = ll.Current.Next;
            }
            return ll.Current.Value;
        }
    }
}
