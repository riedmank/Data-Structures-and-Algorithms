using System;
using Xunit;
using static Tree.Program;
using Tree.Classes;
using System.Collections.Generic;

namespace TreeTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests that a Node will not be added if a value exists
        /// </summary>
        [Fact]
        public void AddAnExistingValueToBinarySearchTree()
        {
            Node nodeSeven = new Node(null, null, 70);
            Node nodeSix = new Node(null, null, 50);
            Node nodeFive = new Node(null, null, 30);
            Node nodeFour = new Node(null, null, 10);
            Node nodeThree = new Node(nodeSix, nodeSeven, 60);
            Node nodeTwo = new Node(nodeFour, nodeFive, 20);
            Node nodeOne = new Node(nodeTwo, nodeThree, 40);

            Node nodeEight = new Node(null, null, 40);

            BinarySearchTree BTS = new BinarySearchTree(nodeOne);
            BinaryTree BT = new BinaryTree(nodeOne);
            BTS.Add(nodeOne, nodeEight);
            BT.nodes = new List<Node>();
            BT.nodes = BT.InOrder(nodeOne);

            Assert.Equal(nodeEight.Value, nodeOne.Value);
        }

        /// <summary>
        /// Tests that a smaller value Node can be added
        /// </summary>
        [Fact]
        public void AddLesserValueToBinarySearchTree()
        {
            Node nodeSeven = new Node(null, null, 70);
            Node nodeSix = new Node(null, null, 50);
            Node nodeFive = new Node(null, null, 30);
            Node nodeFour = new Node(null, null, 10);
            Node nodeThree = new Node(nodeSix, nodeSeven, 60);
            Node nodeTwo = new Node(nodeFour, nodeFive, 20);
            Node nodeOne = new Node(nodeTwo, nodeThree, 40);

            Node nodeEight = new Node(null, null, 5);

            BinarySearchTree BTS = new BinarySearchTree(nodeOne);
            BinaryTree BT = new BinaryTree(nodeOne);
            BTS.Add(nodeOne, nodeEight);
            BT.nodes = new List<Node>();

            BT.nodes = BT.InOrder(nodeOne);

            Assert.Contains(nodeEight, BT.nodes);
        }

        /// <summary>
        /// Tests that a greater value Node can be added
        /// </summary>
        [Fact]
        public void AddGreaterValueToBinarySearchTree()
        {
            Node nodeSeven = new Node(null, null, 70);
            Node nodeSix = new Node(null, null, 50);
            Node nodeFive = new Node(null, null, 30);
            Node nodeFour = new Node(null, null, 10);
            Node nodeThree = new Node(nodeSix, nodeSeven, 60);
            Node nodeTwo = new Node(nodeFour, nodeFive, 20);
            Node nodeOne = new Node(nodeTwo, nodeThree, 40);

            Node nodeEight = new Node(null, null, 80);

            BinarySearchTree BTS = new BinarySearchTree(nodeOne);
            BinaryTree BT = new BinaryTree(nodeOne);
            BTS.Add(nodeOne, nodeEight);
            BT.nodes = new List<Node>();
            BT.nodes = BT.InOrder(nodeOne);

            Assert.Contains(nodeEight, BT.nodes);
        }

        /// <summary>
        /// Tests that a larger value can be found in the Tree
        /// </summary>
        [Fact]
        public void CanSearchForLargeNodeInBinarySearchTree()
        {
            Node nodeSeven = new Node(null, null, 70);
            Node nodeSix = new Node(null, null, 50);
            Node nodeFive = new Node(null, null, 30);
            Node nodeFour = new Node(null, null, 10);
            Node nodeThree = new Node(nodeSix, nodeSeven, 60);
            Node nodeTwo = new Node(nodeFour, nodeFive, 20);
            Node nodeOne = new Node(nodeTwo, nodeThree, 40);

            BinarySearchTree BTS = new BinarySearchTree(nodeOne);

            Assert.Equal("70", BTS.Search(70, nodeOne).Value.ToString());
        }

        /// <summary>
        /// Tests that a value not in the Tree returns null
        /// </summary>
        [Fact]
        public void CanNotFindNodeInBinarySearchTree()
        {
            Node nodeSeven = new Node(null, null, 70);
            Node nodeSix = new Node(null, null, 50);
            Node nodeFive = new Node(null, null, 30);
            Node nodeFour = new Node(null, null, 10);
            Node nodeThree = new Node(nodeSix, nodeSeven, 60);
            Node nodeTwo = new Node(nodeFour, nodeFive, 20);
            Node nodeOne = new Node(nodeTwo, nodeThree, 40);

            BinarySearchTree BTS = new BinarySearchTree(nodeOne);

            Assert.Null(BTS.Search(65, nodeOne));
        }

        /// <summary>
        /// Tests if a smaller value can be found in the Tree
        /// </summary>
        [Fact]
        public void CanSearchForSmallerNodeInBinarySearchTree()
        {
            Node nodeSeven = new Node(null, null, 70);
            Node nodeSix = new Node(null, null, 50);
            Node nodeFive = new Node(null, null, 30);
            Node nodeFour = new Node(null, null, 10);
            Node nodeThree = new Node(nodeSix, nodeSeven, 60);
            Node nodeTwo = new Node(nodeFour, nodeFive, 20);
            Node nodeOne = new Node(nodeTwo, nodeThree, 40);

            BinarySearchTree BTS = new BinarySearchTree(nodeOne);

            Assert.Equal("10", BTS.Search(10, nodeOne).Value.ToString());
        }

        /// <summary>
        /// Tests that a list is returned from PreOrder method
        /// </summary>
        [Fact]
        public void CanReturnListPreOrder()
        {
            Node nodeSeven = new Node(null, null, 70);
            Node nodeSix = new Node(null, null, 50);
            Node nodeFive = new Node(null, null, 30);
            Node nodeFour = new Node(null, null, 10);
            Node nodeThree = new Node(nodeSix, nodeSeven, 60);
            Node nodeTwo = new Node(nodeFour, nodeFive, 20);
            Node nodeOne = new Node(nodeTwo, nodeThree, 40);

            BinaryTree BT = new BinaryTree(nodeOne);

            BT.nodes = new List<Node>();

            Assert.NotNull(BT.PreOrder(nodeOne));
        }

        /// <summary>
        /// Tests that Root is first in the List for PreOrder method
        /// </summary>
        [Fact]
        public void RootIsFirst()
        {
            Node nodeSeven = new Node(null, null, 70);
            Node nodeSix = new Node(null, null, 50);
            Node nodeFive = new Node(null, null, 30);
            Node nodeFour = new Node(null, null, 10);
            Node nodeThree = new Node(nodeSix, nodeSeven, 60);
            Node nodeTwo = new Node(nodeFour, nodeFive, 20);
            Node nodeOne = new Node(nodeTwo, nodeThree, 40);

            BinaryTree BT = new BinaryTree(nodeOne);

            BT.nodes = new List<Node>();

            BT.nodes = BT.PreOrder(nodeOne);

            Assert.Equal(0, BT.nodes.IndexOf(nodeOne));
        }

        /// <summary>
        /// Tests that List returned has values
        /// </summary>
        [Fact]
        public void ListContainsValuesFromPreOrder()
        {
            Node nodeSeven = new Node(null, null, 70);
            Node nodeSix = new Node(null, null, 50);
            Node nodeFive = new Node(null, null, 30);
            Node nodeFour = new Node(null, null, 10);
            Node nodeThree = new Node(nodeSix, nodeSeven, 60);
            Node nodeTwo = new Node(nodeFour, nodeFive, 20);
            Node nodeOne = new Node(nodeTwo, nodeThree, 40);

            BinaryTree BT = new BinaryTree(nodeOne);

            BT.nodes = new List<Node>();

            BT.nodes = BT.PreOrder(nodeOne);

            Assert.NotEmpty(BT.nodes);
        }

        /// <summary>
        /// Tests that a List is returned for InOrder method
        /// </summary>
        [Fact]
        public void CanReturnListInOrder()
        {
            Node nodeSeven = new Node(null, null, 70);
            Node nodeSix = new Node(null, null, 50);
            Node nodeFive = new Node(null, null, 30);
            Node nodeFour = new Node(null, null, 10);
            Node nodeThree = new Node(nodeSix, nodeSeven, 60);
            Node nodeTwo = new Node(nodeFour, nodeFive, 20);
            Node nodeOne = new Node(nodeTwo, nodeThree, 40);

            BinaryTree BT = new BinaryTree(nodeOne);

            BT.nodes = new List<Node>();

            Assert.NotNull(BT.InOrder(nodeOne));
        }

        /// <summary>
        /// Tests that root is at index 3 of List for InOrder method
        /// </summary>
        [Fact]
        public void RootIsSecond()
        {
            Node nodeSeven = new Node(null, null, 70);
            Node nodeSix = new Node(null, null, 50);
            Node nodeFive = new Node(null, null, 30);
            Node nodeFour = new Node(null, null, 10);
            Node nodeThree = new Node(nodeSix, nodeSeven, 60);
            Node nodeTwo = new Node(nodeFour, nodeFive, 20);
            Node nodeOne = new Node(nodeTwo, nodeThree, 40);

            BinaryTree BT = new BinaryTree(nodeOne);

            BT.nodes = new List<Node>();

            BT.nodes = BT.InOrder(nodeOne);

            Assert.Equal(3, BT.nodes.IndexOf(nodeOne));
        }

        /// <summary>
        /// Tests that List returned has values
        /// </summary>
        [Fact]
        public void ListContainsValuesFromInOrder()
        {
            Node nodeSeven = new Node(null, null, 70);
            Node nodeSix = new Node(null, null, 50);
            Node nodeFive = new Node(null, null, 30);
            Node nodeFour = new Node(null, null, 10);
            Node nodeThree = new Node(nodeSix, nodeSeven, 60);
            Node nodeTwo = new Node(nodeFour, nodeFive, 20);
            Node nodeOne = new Node(nodeTwo, nodeThree, 40);

            BinaryTree BT = new BinaryTree(nodeOne);

            BT.nodes = new List<Node>();

            BT.nodes = BT.InOrder(nodeOne);

            Assert.NotEmpty(BT.nodes);
        }
        
        /// <summary>
        /// Tests that a List is returned for PostOrder method
        /// </summary>
        [Fact]
        public void CanReturnListPostOrder()
        {
            Node nodeSeven = new Node(null, null, 70);
            Node nodeSix = new Node(null, null, 50);
            Node nodeFive = new Node(null, null, 30);
            Node nodeFour = new Node(null, null, 10);
            Node nodeThree = new Node(nodeSix, nodeSeven, 60);
            Node nodeTwo = new Node(nodeFour, nodeFive, 20);
            Node nodeOne = new Node(nodeTwo, nodeThree, 40);

            BinaryTree BT = new BinaryTree(nodeOne);

            BT.nodes = new List<Node>();

            Assert.NotNull(BT.PostOrder(nodeOne));
        }

        /// <summary>
        /// Tests that Root is at index 6 of List
        /// </summary>
        [Fact]
        public void RootIsThird()
        {
            Node nodeSeven = new Node(null, null, 70);
            Node nodeSix = new Node(null, null, 50);
            Node nodeFive = new Node(null, null, 30);
            Node nodeFour = new Node(null, null, 10);
            Node nodeThree = new Node(nodeSix, nodeSeven, 60);
            Node nodeTwo = new Node(nodeFour, nodeFive, 20);
            Node nodeOne = new Node(nodeTwo, nodeThree, 40);

            BinaryTree BT = new BinaryTree(nodeOne);

            BT.nodes = new List<Node>();

            BT.nodes = BT.PostOrder(nodeOne);

            Assert.Equal(6, BT.nodes.IndexOf(nodeOne));
        }

        /// <summary>
        /// Tests that List returned has values
        /// </summary>
        [Fact]
        public void ListContainsValuesFromPostOrder()
        {
            Node nodeSeven = new Node(null, null, 70);
            Node nodeSix = new Node(null, null, 50);
            Node nodeFive = new Node(null, null, 30);
            Node nodeFour = new Node(null, null, 10);
            Node nodeThree = new Node(nodeSix, nodeSeven, 60);
            Node nodeTwo = new Node(nodeFour, nodeFive, 20);
            Node nodeOne = new Node(nodeTwo, nodeThree, 40);

            BinaryTree BT = new BinaryTree(nodeOne);

            BT.nodes = new List<Node>();

            BT.nodes = BT.PostOrder(nodeOne);

            Assert.NotEmpty(BT.nodes);
        }
    }
}
