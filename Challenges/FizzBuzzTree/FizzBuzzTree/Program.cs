using System;
using System.Collections.Generic;
using Tree.Classes;

namespace FizzBuzzTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node nodeSeven = new Node(null, null, 3);
            Node nodeSix = new Node(null, null, 5);
            Node nodeFive = new Node(null, null, 15);
            Node nodeFour = new Node(null, null, 3);
            Node nodeThree = new Node(nodeSix, nodeSeven, 7);
            Node nodeTwo = new Node(nodeFour, nodeFive, 30);
            Node nodeOne = new Node(nodeTwo, nodeThree, 50);

            foreach (string item in FizzBuzzTreeMethod(nodeOne))
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Takes in a Tree and determines Fizz Buzz status
        /// </summary>
        /// <param name="root">Root of a Binary Tree</param>
        /// <returns>Returns a List of values from the Binary Tree</returns>
        public static List<string> FizzBuzzTreeMethod(Node root)
        {
            BinaryTree BT = new BinaryTree(root);
            BT.nodes = new List<Node>();
            BT.nodes = BT.InOrder(root);
            List<string> FizzBuzzList = new List<string>();

            foreach (Node node in BT.nodes)
            {
                if (node.Value % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    FizzBuzzList.Add("FizzBuzz");
                }
                else if (node.Value % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    FizzBuzzList.Add("Fizz");
                }
                else if (node.Value % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    FizzBuzzList.Add("Buzz");
                }
                else
                {
                    Console.WriteLine(node.Value);
                    FizzBuzzList.Add(node.Value.ToString());
                }
            }
            return FizzBuzzList; 
        }
    }
}
