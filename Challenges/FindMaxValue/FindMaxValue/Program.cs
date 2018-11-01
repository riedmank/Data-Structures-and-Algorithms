using System;
using Tree.Classes;
using System.Collections.Generic;

namespace FindMaxValue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node nodeSeven = new Node(null, null, 55);
            Node nodeSix = new Node(null, null, 37);
            Node nodeFive = new Node(null, null, 22);
            Node nodeFour = new Node(null, null, 8);
            Node nodeThree = new Node(nodeSix, nodeSeven, 75);
            Node nodeTwo = new Node(nodeFour, nodeFive, 13);
            Node nodeOne = new Node(nodeTwo, nodeThree, 74);

            int max = FindMaxValueMethod(nodeOne);

            Console.WriteLine($"Max value in Binary Tree is {max}.");
        }

        /// <summary>
        /// Finds the Max Value in a Binary Tree
        /// </summary>
        /// <param name="root">Takes in the Root Node of a Binary Tree</param>
        /// <returns>Returns the Max Value from the Binary Tree</returns>
        public static int FindMaxValueMethod(Node root)
        {
            BinaryTree BT = new BinaryTree(root);
            BT.nodes = new List<Node>();
            int max = int.MinValue;

            if (root == null)
                return max;

            foreach (Node item in BT.InOrder(root))
            {
                max = item.Value > max ? item.Value : max;
            }

            return max;
        }
    }
}
