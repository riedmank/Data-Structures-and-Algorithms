using System;
using StacksAndQueues.Classes;
using QueuesWithStacks.Classes;

namespace QueuesWithStacks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack Stack1 = new Stack(null);
            Stack Stack2 = new Stack(null);

            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");
            Node node5 = new Node("node5");
            Node node6 = new Node("node6");
            Node node7 = new Node("node7");

            QWS Queue = new QWS(Stack1, Stack2);

            Queue.Enqueue(node1);
            Queue.Enqueue(node2);
            Queue.Enqueue(node3);
            Queue.Enqueue(node4);
            Queue.Enqueue(node5);

            Console.WriteLine("Dequeue Top Node");

            Console.WriteLine(Queue.Dequeue().Value);

            Console.WriteLine("=========================");

            Queue.Enqueue(node6);
            Queue.Enqueue(node7);

            Console.WriteLine("Dequeue Top Node after adding nodes");

            Console.WriteLine(Queue.Dequeue().Value);
        }
    }
}
