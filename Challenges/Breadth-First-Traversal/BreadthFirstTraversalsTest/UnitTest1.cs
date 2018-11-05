using System;
using Xunit;
using Tree.Classes;
using static Breadth_First_Traversal.Program;
using System.Collections.Generic;

namespace BreadthFirstTraversalsTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests that all Nodes are iterated over
        /// </summary>
        [Fact]
        public void CanAddAllNodesToList()
        {
            Node nodeSeven = new Node(null, null, 22);
            Node nodeSix = new Node(null, null, 2);
            Node nodeFive = new Node(null, null, 45);
            Node nodeFour = new Node(null, null, 87);
            Node nodeThree = new Node(nodeSix, nodeSeven, 10);
            Node nodeTwo = new Node(nodeFour, nodeFive, 4);
            Node nodeOne = new Node(nodeTwo, nodeThree, 67);

            BinaryTree BT = new BinaryTree(nodeOne);

            List<Node> l =BreadthFirst(BT.Root);

            Assert.Equal(7, l.Count);
        }

        /// <summary>
        /// Tests that NodeOne is in the correct location
        /// </summary>
        [Fact]
        public void NodesInCorrectOrder()
        {
            Node nodeSeven = new Node(null, null, 22);
            Node nodeSix = new Node(null, null, 2);
            Node nodeFive = new Node(null, null, 45);
            Node nodeFour = new Node(null, null, 87);
            Node nodeThree = new Node(nodeSix, nodeSeven, 10);
            Node nodeTwo = new Node(nodeFour, nodeFive, 4);
            Node nodeOne = new Node(nodeTwo, nodeThree, 67);

            BinaryTree BT = new BinaryTree(nodeOne);

            List<Node> l = BreadthFirst(BT.Root);

            Assert.Equal(0, l.IndexOf(nodeOne));
        }

        /// <summary>
        /// Tests that null is returned if a null Root is passed in
        /// </summary>
        [Fact]
        public void CanReturnNull()
        {
            BinaryTree BT = new BinaryTree(null);

            Assert.Null(BreadthFirst(BT.Root));
        }
    }
}
