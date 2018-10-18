using LinkedList.Classes;
using System;

namespace LL_merge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node LL1Node1 = new Node("LL1Node1");
            Node LL1Node2 = new Node("LL1Node2");
            Node LL1Node3 = new Node("LL1Node3");
            Node LL1Node4 = new Node("LL1Node4");
            Node LL1Node5 = new Node("LL1Node5");
            Node LL1Node6 = new Node("LL1Node6");

            LL LL1 = new LL(LL1Node1);
            
            LL1.Append(LL1Node2);
            LL1.Append(LL1Node3);
            LL1.Append(LL1Node4);
            LL1.Append(LL1Node5);
            LL1.Append(LL1Node6);

            Node LL2Node1 = new Node("LL2Node1");
            Node LL2Node2 = new Node("LL2Node2");
            Node LL2Node3 = new Node("LL2Node3");
            Node LL2Node4 = new Node("LL2Node4");
            Node LL2Node5 = new Node("LL2Node5");

            LL LL2 = new LL(LL2Node1);
            
            LL2.Append(LL2Node2);
            LL2.Append(LL2Node3);
            LL2.Append(LL2Node4);
            LL2.Append(LL2Node5);

            LL1.Print();

            Console.WriteLine("");

            LL2.Print();

            LL LLNew = LLMerge(LL1, LL2);

            Console.WriteLine("");

            LLNew.Print();
        }

        /// <summary>
        /// Merges two linked lists
        /// </summary>
        /// <param name="LL1">A linked list</param>
        /// <param name="LL2">A linked list</param>
        /// <returns>Returns a merged linked list</returns>
        public static LL LLMerge(LL LL1, LL LL2)
        {
            LL1.Current = LL1.Head;
            LL2.Current = LL2.Head;
            Node temp = LL2.Current.Next;
            
            while (LL1.Current.Next.Next != null)
            {
                LL1.AddAfter(LL2.Head, LL1.Current);
                LL2.Head = temp;
                LL2.Current = LL2.Head;
                temp = LL2.Current.Next;
                LL1.Current = LL1.Current.Next.Next;
            }
            LL1.AddAfter(LL2.Head, LL1.Current);
            LL2.Head = temp;
            LL1.Append(LL2.Head);
            LL2.Head = null;
            return LL1;
        }
    }
}
