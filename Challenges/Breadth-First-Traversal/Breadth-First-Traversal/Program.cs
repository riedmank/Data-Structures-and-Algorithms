using Tree.Classes;
using System;
using System.Collections.Generic;

namespace Breadth_First_Traversal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node nodeSeven = new Node(null, null, 22);
            Node nodeSix = new Node(null, null, 2);
            Node nodeFive = new Node(null, null, 45);
            Node nodeFour = new Node(null, null, 87);
            Node nodeThree = new Node(nodeSix, nodeSeven, 10);
            Node nodeTwo = new Node(nodeFour, nodeFive, 4);
            Node nodeOne = new Node(nodeTwo, nodeThree, 67);

            BinaryTree BT = new BinaryTree(nodeOne);

            BreadthFirst(BT.Root);
        }

        /// <summary>
        /// Performs a Breadth First Traversal of a Binary Tree
        /// </summary>
        /// <param name="root">Takes in the Root Node of a Binary Tree</param>
        public static List<Node> BreadthFirst(Node root)
        {
            if (root == null)
                return null;
            Queue<Node> q = new Queue<Node>();
            List<Node> l = new List<Node>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                Node Front = q.Dequeue();
                l.Add(Front);
                Console.WriteLine(Front.Value);
                if (Front.LeftChild != null)
                    q.Enqueue(Front.LeftChild);
                if (Front.RightChild != null)
                    q.Enqueue(Front.RightChild);
            }
            return l;
        }
    }
}
