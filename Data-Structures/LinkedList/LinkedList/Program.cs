using System;
using LinkedList.Classess;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node(10);
            Node node4 = new Node("node4");
            Node node5 = new Node("node5");
            LinkedListClass LL = new LinkedListClass(node1);
            LL.Add(node2);
            LL.Add(node3);
            LL.Add(node4);
            LL.Add(node5);

            Console.WriteLine("BaseLine");
            LL.Print();
            Console.WriteLine("");
            Console.WriteLine("Append to the end");
            Node node6 = new Node("node6");
            LL.Append(node6);
            LL.Print();
            Console.WriteLine("");
            Console.WriteLine("Add before node3");
            Node node7 = new Node("node7");
            LL.AddBefore(node7, node3);
            LL.Print();
            Console.WriteLine("");
            Console.WriteLine("Add after node4");
            Node node8 = new Node("node8");
            LL.AddAfter(node8, node4);
            LL.Print();
            
            Console.WriteLine(LL.Find(10));
        }
    }
}
