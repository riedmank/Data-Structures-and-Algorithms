using Tree.Classes;
using System;
using System.Collections.Generic;

namespace Breadth_First_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Node nodeSeven = new Node(null, null, 22);
            Node nodeSix = new Node(null, null, 2);
            Node nodeFive = new Node(null, null, 45);
            Node nodeFour = new Node(null, null, 87);
            Node nodeThree = new Node(nodeSix, nodeSeven, 10);
            Node nodeTwo = new Node(nodeFour, nodeFive, 4);
            Node nodeOne = new Node(nodeTwo, nodeThree, 67);

            BreadthFirst(nodeOne);
        }

        public static void BreadthFirst(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            try
            {
                while (q.Peek() != null)
                {
                    Node Front = q.Dequeue();
                    Console.WriteLine(Front.Value);
                    if (Front.LeftChild != null)
                        q.Enqueue(Front.LeftChild);
                    if (Front.RightChild != null)
                        q.Enqueue(Front.RightChild);
                }
            }
            catch
            {
                return;
            }
        }
    }
}
