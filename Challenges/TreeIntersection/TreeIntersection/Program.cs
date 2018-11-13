using System;
using System.Collections.Generic;
using Tree.Classes;
using HashTables.Classes;

namespace TreeIntersection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node nodeFourteen = new Node(null, null, 9);
            Node nodeThirteen = new Node(null, null, 4);
            Node nodeTwelve = new Node(null, null, 24);
            Node nodeEleven = new Node(null, null, 78);
            Node nodeTen = new Node(nodeThirteen, nodeFourteen, 12);
            Node nodeNine = new Node(nodeEleven, nodeTwelve, 45);
            Node nodeEight = new Node(nodeNine, nodeTen, 6);

            Node nodeSeven = new Node(null, null, 9);
            Node nodeSix = new Node(null, null, 55);
            Node nodeFive = new Node(null, null, 74);
            Node nodeFour = new Node(null, null, 30);
            Node nodeThree = new Node(nodeSix, nodeSeven, 12);
            Node nodeTwo = new Node(nodeFour, nodeFive, 17);
            Node nodeOne = new Node(nodeTwo, nodeThree, 6);

            BinaryTree BT1 = new BinaryTree(nodeOne);
            BinaryTree BT2 = new BinaryTree(nodeEight);

            Console.WriteLine("Values that are the same in both tree: 6, 9, 12.");

            List<string> matches = TreeIntersection(BT1, BT2);

            Console.WriteLine("Tree Intersect method results:");

            foreach (string item in matches)
            {
                Console.WriteLine(item);
            }
        }

        public static List<string> TreeIntersection(BinaryTree BT1, BinaryTree BT2)
        {
            BT1.nodes = new List<Node>();
            BT2.nodes = new List<Node>();
            BT1.nodes = BT1.InOrder(BT1.Root);
            BT2.nodes = BT2.InOrder(BT2.Root);
            HashTable HT = new HashTable();
            foreach (Node node in BT1.nodes)
            {
                HT.Add(node.Value.ToString(), null);
            }
            List<string> matches = new List<string>();
            foreach (Node node in BT2.nodes)
            {
                if (HT.Contains(node.Value.ToString()))
                    matches.Add(node.Value.ToString());
            }
            return matches;
        }
    }
}
