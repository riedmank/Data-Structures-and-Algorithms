using System;
using LinkedList.Classes;

namespace LL_reverse
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

            LL LL1 = new LL(node1);

            LL1.Append(node2);
            LL1.Append(node3);
            LL1.Append(node4);
            LL1.Append(node5);

            LL1.Print();

            Console.WriteLine("");

            ReverseLL(LL1);

            LL1.Print();
        }

        /// <summary>
        /// Reverses a Linked List
        /// </summary>
        /// <param name="LL">Takes in a Linked List</param>
        /// <returns>Returns a reversed Linked List</returns>
        public static LL ReverseLL(LL LL)
        {
            if (LL.Head == null)
            {
                return null;
            }
            LL.Current = LL.Head;
            Node currNode = LL.Head;
            Node nextNode = null;
            Node prevNode = null;
            while (currNode != null)
            {
                nextNode = currNode.Next;
                currNode.Next = prevNode;
                prevNode = currNode;
                currNode = nextNode;
            }
            LL.Head = prevNode;
            return LL;
        }
    }
}
