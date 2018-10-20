using System;
using StacksAndQueues.Classes;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");
            Node node5 = new Node("node5");

            Stack Stack = new Stack(null);

            Stack.Push(node5);
            Stack.Push(node4);
            Stack.Push(node3);
            Stack.Push(node2);
            Stack.Push(node1);

            Node node6 = new Node("node6");
            Node node7 = new Node("node7");
            Node node8 = new Node("node8");
            Node node9 = new Node("node9");
            Node node10 = new Node("node10");

            Queue Queue = new Queue(node6);

            //Queue.Enqueue(node6);
            Queue.Enqueue(node7);
            Queue.Enqueue(node8);
            Queue.Enqueue(node9);
            Queue.Enqueue(node10);

            Console.WriteLine("Stack Printing");

            while (Stack.Peek() != null)
            {
                Console.WriteLine(Stack.Peek().Value);
                Stack.Pop();
            }

            Console.WriteLine("Queue Printing");

            while (Queue.Peek() != null)
            {
                Console.WriteLine(Queue.Peek().Value);
                Queue.Dequeue();
            }
        }
    }
}
