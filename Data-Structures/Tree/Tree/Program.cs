using System;
using System.Collections.Generic;
using Tree.Classes;

namespace Tree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TreeExample();
        }

        public static void TreeExample()
        {
            Node node7 = new Node(null, null, 70);
            Node node6 = new Node(null, null, 60);
            Node node5 = new Node(null, null, 50);
            Node node4 = new Node(null, null, 40);
            Node node3 = new Node(node6, node7, 30);
            Node node2 = new Node(node4, node5, 20);
            Node node1 = new Node(node2, node3, 10);

            BinaryTree BT1 = new BinaryTree(node1);
            BT1.nodes = new List<Node>();
            BinaryTree BT2 = new BinaryTree(node1);
            BT2.nodes = new List<Node>();
            BinaryTree BT3 = new BinaryTree(node1);
            BT3.nodes = new List<Node>();

            List<Node> preOrder = BT1.PreOrder(node1);
            List<Node> inOrder = BT2.InOrder(node1);
            List<Node> postOrder = BT3.PostOrder(node1);

            Console.WriteLine("PreOrder search results");

            foreach (Node item in preOrder)
            {
                Console.WriteLine($"{item.Value}");
            }

            BT1.nodes.Clear();

            Console.WriteLine("===========================");

            Console.WriteLine("InOrder search results");

            foreach (Node item in inOrder)
            {
                Console.WriteLine($"{item.Value}");
            }

            BT2.nodes.Clear();

            Console.WriteLine("===========================");

            Console.WriteLine("PostOrder search results");

            foreach (Node item in postOrder)
            {
                Console.WriteLine($"{item.Value}");
            }

            BT3.nodes.Clear();

            Console.WriteLine("===========================");

            Node nodeSeven = new Node(null, null, 70);
            Node nodeSix = new Node(null, null, 50);
            Node nodeFive = new Node(null, null, 30);
            Node nodeFour = new Node(null, null, 10);
            Node nodeThree = new Node(nodeSix, nodeSeven, 60);
            Node nodeTwo = new Node(nodeFour, nodeFive, 20);
            Node nodeOne = new Node(nodeTwo, nodeThree, 40);

            BinarySearchTree BTS = new BinarySearchTree(nodeOne);
            BinaryTree BT = new BinaryTree(nodeOne);
            BT.nodes = new List<Node>();

            List<Node> search = BT.InOrder(nodeOne);

            Console.WriteLine("BinarySearchTree results");

            foreach (Node item in search)
            {
                Console.WriteLine($"{item.Value}");
            }

            BT.nodes.Clear();

            Console.WriteLine("===========================");

            Console.WriteLine("Binary Search: searching for 50");

            Console.WriteLine($"Search result: {BTS.Search(50, nodeOne).Value}");

            Console.WriteLine("===========================");

            Console.WriteLine("Adding to Binary Search Tree");

            Node nodeEight = new Node(null, null, 25);

            Console.WriteLine($"Node to add: {nodeEight.Value}");

            BTS.Add(nodeOne, nodeEight);

            List<Node> add = BT.InOrder(nodeOne);

            foreach (Node item in add)
            {
                Console.WriteLine($"{item.Value}");
            }
        }
    }
}
