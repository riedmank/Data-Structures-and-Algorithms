using System;
using System.Collections.Generic;
using Tree.Classes;

namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node nodeSeven = new Node(null, null, 3);
            Node nodeSix = new Node(null, null, 5);
            Node nodeFive = new Node(null, null, 15);
            Node nodeFour = new Node(null, null, 3);
            Node nodeThree = new Node(nodeSix, nodeSeven, 7);
            Node nodeTwo = new Node(nodeFour, nodeFive, 30);
            Node nodeOne = new Node(nodeTwo, nodeThree, 50);

            FizzBuzzTree(nodeOne);
        }

        public static List<Node> FizzBuzzTree(Node root)
        {
            BinaryTree BT = new BinaryTree(root);
            BT.nodes = new List<Node>();

            BT.nodes = BT.InOrder(root);

            foreach (Node node in BT.nodes)
            {
                if (node.Value % 15 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (node.Value % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (node.Value % 5 == 0)
                    Console.WriteLine("Buzz");
                else Console.WriteLine(node.Value);
            }
            return BT.nodes; 
        }
    }
}
