using System;
using StacksAndQueues.Classes;

namespace EenieMeenieMeineMoe
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
            Node node6 = new Node("node6");
            Node node7 = new Node("node7");

            Queue Queue = new Queue(node1);

            Queue.Enqueue(node2);
            Queue.Enqueue(node3);
            Queue.Enqueue(node4);
            Queue.Enqueue(node5);
            Queue.Enqueue(node6);
            Queue.Enqueue(node7);

            int num = 10;

            Console.WriteLine($"The winner is: {EMMM(num, Queue).Value}");
        }

        /// <summary>
        /// This method takes in a Queue and plays Eenie Meenie Meine Moe.  Every nth node is out. The last node in the Queue is the winner
        /// </summary>
        /// <param name="n">An integer</param>
        /// <param name="q">A queue</param>
        /// <returns>Returns a node</returns>
        public static Node EMMM(int n, Queue q)
        {
            if (n < 1)
                return null;
            while (n - 1 > 0)
            {
                q.Enqueue(q.Dequeue());
                n--;
            }
            Console.WriteLine($"{q.Dequeue().Value} is out!");
            if (q.Front.Next != null)
                return EMMM(n, q);            
            return q.Dequeue();
        }
    }
}
