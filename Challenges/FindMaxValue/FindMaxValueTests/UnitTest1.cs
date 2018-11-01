using static FindMaxValue.Program;
using System;
using Tree.Classes;
using Xunit;

namespace FindMaxValueTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests if the Max Value can be returned from a Binary Tree
        /// </summary>
        [Fact]
        public void CanFindMaxValueInBinaryTree()
        {
            Node nodeSeven = new Node(null, null, 55);
            Node nodeSix = new Node(null, null, 37);
            Node nodeFive = new Node(null, null, 22);
            Node nodeFour = new Node(null, null, 8);
            Node nodeThree = new Node(nodeSix, nodeSeven, 75);
            Node nodeTwo = new Node(nodeFour, nodeFive, 13);
            Node nodeOne = new Node(nodeTwo, nodeThree, 74);

            Assert.Equal(75, FindMaxValueMethod(nodeOne));
        }

        /// <summary>
        /// Tests if the Max Value can be returned from a Binary Search Tree
        /// </summary>
        [Fact]
        public void CanFindMaxValueInBinarySearchTree()
        {
            Node nodeSeven = new Node(null, null, 14);
            Node nodeSix = new Node(null, null, 12);
            Node nodeFive = new Node(null, null, 10);
            Node nodeFour = new Node(null, null, 8);
            Node nodeThree = new Node(nodeSix, nodeSeven, 13);
            Node nodeTwo = new Node(nodeFour, nodeFive, 9);
            Node nodeOne = new Node(nodeTwo, nodeThree, 11);

            Assert.Equal(14, FindMaxValueMethod(nodeOne));
        }

        /// <summary>
        /// Tests if MinValue is returned if the Root is null
        /// </summary>
        [Fact]
        public void CanReturnMinValueIfRootIsNull()
        {
            BinaryTree BT = new BinaryTree(null);

            Assert.Equal(int.MinValue, FindMaxValueMethod(BT.Root));
        }
    }
}
