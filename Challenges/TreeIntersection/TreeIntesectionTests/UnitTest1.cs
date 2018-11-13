using System;
using Xunit;
using static TreeIntersection.Program;
using Tree.Classes;
using HashTables.Classes;

namespace TreeIntesectionTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Determines whether this instance [can find matches in trees].
        /// </summary>
        [Fact]
        public void CanFindMatchesInTrees()
        {
            Node nodeFourteen = new Node(null, null, 9);
            Node nodeThirteen = new Node(null, null, 4);
            Node nodeTwelve = new Node(null, null, 24);
            Node nodeEleven = new Node(null, null, 78);
            Node nodeTen = new Node(nodeThirteen, nodeFourteen, 12);
            Node nodeNine = new Node(nodeEleven, nodeTwelve, 45);
            Node nodeEight = new Node(nodeNine, nodeTen, 6);

            Node nodeSeven = new Node(null, null, 11);
            Node nodeSix = new Node(null, null, 55);
            Node nodeFive = new Node(null, null, 74);
            Node nodeFour = new Node(null, null, 30);
            Node nodeThree = new Node(nodeSix, nodeSeven, 14);
            Node nodeTwo = new Node(nodeFour, nodeFive, 17);
            Node nodeOne = new Node(nodeTwo, nodeThree, 6);

            BinaryTree BT1 = new BinaryTree(nodeOne);
            BinaryTree BT2 = new BinaryTree(nodeEight);

            Assert.Contains("6", TreeIntersectionMethod(BT1, BT2));
        }

        /// <summary>
        /// Determines whether this instance [can find no matches in trees].
        /// </summary>
        [Fact]
        public void CanFindNoMatchesInTrees()
        {
            Node nodeFourteen = new Node(null, null, 14);
            Node nodeThirteen = new Node(null, null, 13);
            Node nodeTwelve = new Node(null, null, 12);
            Node nodeEleven = new Node(null, null, 11);
            Node nodeTen = new Node(nodeThirteen, nodeFourteen, 10);
            Node nodeNine = new Node(nodeEleven, nodeTwelve, 9);
            Node nodeEight = new Node(nodeNine, nodeTen, 8);

            Node nodeSeven = new Node(null, null, 7);
            Node nodeSix = new Node(null, null, 6);
            Node nodeFive = new Node(null, null, 5);
            Node nodeFour = new Node(null, null, 4);
            Node nodeThree = new Node(nodeSix, nodeSeven, 3);
            Node nodeTwo = new Node(nodeFour, nodeFive, 2);
            Node nodeOne = new Node(nodeTwo, nodeThree, 1);

            BinaryTree BT1 = new BinaryTree(nodeOne);
            BinaryTree BT2 = new BinaryTree(nodeEight);

            Assert.Empty(TreeIntersectionMethod(BT1, BT2));
        }

        /// <summary>
        /// Determines whether this instance [can find matches in shorter tree].
        /// </summary>
        [Fact]
        public void CanFindMatchesInShorterTree()
        {
            Node nodeThirteen = new Node(null, null, 4);
            Node nodeTwelve = new Node(null, null, 24);
            Node nodeTen = new Node(nodeThirteen, null, 12);
            Node nodeNine = new Node(null, nodeTwelve, 45);
            Node nodeEight = new Node(nodeNine, nodeTen, 6);

            Node nodeSeven = new Node(null, null, 9);
            Node nodeSix = new Node(null, null, 55);
            Node nodeFive = new Node(null, null, 74);
            Node nodeFour = new Node(null, null, 30);
            Node nodeThree = new Node(nodeSix, nodeSeven, 14);
            Node nodeTwo = new Node(nodeFour, nodeFive, 17);
            Node nodeOne = new Node(nodeTwo, nodeThree, 6);

            BinaryTree BT1 = new BinaryTree(nodeOne);
            BinaryTree BT2 = new BinaryTree(nodeEight);

            Assert.Contains("6", TreeIntersectionMethod(BT1, BT2));
        }
    }
}
