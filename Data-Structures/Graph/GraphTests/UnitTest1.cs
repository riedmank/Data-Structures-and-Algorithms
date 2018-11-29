using Graph.Classes;
using System;
using Xunit;

namespace GraphTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Determines whether this instance [can add edge].
        /// </summary>
        [Fact]
        public void CanAddEdge()
        {
            Node nodeOne = new Node("nodeOne");
            Node nodeTwo = new Node("nodeTwo");
            Node nodeThree = new Node("nodeThree");
            Node nodeFour = new Node("nodeFour");
            Node nodeFive = new Node("nodeFive");
            Graphs myGraph = new Graphs(nodeOne);

            myGraph.AddEdge(nodeOne, new Tuple<Node, int>(nodeTwo, 5));
            myGraph.AddEdge(nodeTwo, new Tuple<Node, int>(nodeThree, 10));
            myGraph.AddEdge(nodeThree, new Tuple<Node, int>(nodeFour, 15));
            myGraph.AddEdge(nodeFour, new Tuple<Node, int>(nodeFive, 20));
            myGraph.AddEdge(nodeFive, new Tuple<Node, int>(nodeOne, 25));

            Assert.NotEmpty(myGraph.GetNodes());
        }

        /// <summary>
        /// Nodeses the can have multiple edges.
        /// </summary>
        [Fact]
        public void NodesCanHaveMultipleEdges()
        {
            Node nodeOne = new Node("nodeOne");
            Node nodeTwo = new Node("nodeTwo");
            Node nodeThree = new Node("nodeThree");
            Node nodeFour = new Node("nodeFour");
            Node nodeFive = new Node("nodeFive");
            Graphs myGraph = new Graphs(nodeOne);

            myGraph.AddEdge(nodeOne, new Tuple<Node, int>(nodeTwo, 5));
            myGraph.AddEdge(nodeTwo, new Tuple<Node, int>(nodeThree, 10));
            myGraph.AddEdge(nodeThree, new Tuple<Node, int>(nodeFour, 15));
            myGraph.AddEdge(nodeFour, new Tuple<Node, int>(nodeFive, 20));
            myGraph.AddEdge(nodeFive, new Tuple<Node, int>(nodeOne, 25));
            myGraph.AddEdge(nodeOne, new Tuple<Node, int>(nodeThree, 742));

            Assert.NotEmpty(myGraph.GetNodes());
        }

        /// <summary>
        /// Determines whether this instance [can add edge with zero weight].
        /// </summary>
        [Fact]
        public void CanAddEdgeWithZeroWeight()
        {
            Node nodeOne = new Node("nodeOne");
            Node nodeTwo = new Node("nodeTwo");
            Node nodeThree = new Node("nodeThree");
            Node nodeFour = new Node("nodeFour");
            Node nodeFive = new Node("nodeFive");
            Graphs myGraph = new Graphs(nodeOne);

            myGraph.AddEdge(nodeOne, new Tuple<Node, int>(nodeTwo, 0));
            myGraph.AddEdge(nodeTwo, new Tuple<Node, int>(nodeThree, 0));
            myGraph.AddEdge(nodeThree, new Tuple<Node, int>(nodeFour, 0));
            myGraph.AddEdge(nodeFour, new Tuple<Node, int>(nodeFive, 0));
            myGraph.AddEdge(nodeFive, new Tuple<Node, int>(nodeOne, 0));

            Assert.NotEmpty(myGraph.GetNodes());
        }

        /// <summary>
        /// Determines whether this instance [can get multiple neighbors from graph].
        /// </summary>
        [Fact]
        public void CanGetMultipleNeighborsFromGraph()
        {
            Node nodeOne = new Node("nodeOne");
            Node nodeTwo = new Node("nodeTwo");
            Node nodeThree = new Node("nodeThree");
            Node nodeFour = new Node("nodeFour");
            Node nodeFive = new Node("nodeFive");
            Graphs myGraph = new Graphs(nodeOne);

            myGraph.AddEdge(nodeOne, new Tuple<Node, int>(nodeTwo, 5));
            myGraph.AddEdge(nodeTwo, new Tuple<Node, int>(nodeThree, 10));
            myGraph.AddEdge(nodeThree, new Tuple<Node, int>(nodeFour, 15));
            myGraph.AddEdge(nodeFour, new Tuple<Node, int>(nodeFive, 20));
            myGraph.AddEdge(nodeFive, new Tuple<Node, int>(nodeOne, 25));
            myGraph.AddEdge(nodeOne, new Tuple<Node, int>(nodeThree, 742));

            Assert.Equal(3, myGraph.GetNeighbors(nodeOne).Count);
        }

        /// <summary>
        /// Determines whether this instance [can return list of nodes].
        /// </summary>
        [Fact]
        public void CanReturnListOfNodes()
        {
            Node nodeOne = new Node("nodeOne");
            Node nodeTwo = new Node("nodeTwo");
            Node nodeThree = new Node("nodeThree");
            Node nodeFour = new Node("nodeFour");
            Node nodeFive = new Node("nodeFive");
            Graphs myGraph = new Graphs(nodeOne);

            myGraph.AddEdge(nodeOne, new Tuple<Node, int>(nodeTwo, 5));
            myGraph.AddEdge(nodeTwo, new Tuple<Node, int>(nodeThree, 10));
            myGraph.AddEdge(nodeThree, new Tuple<Node, int>(nodeFour, 15));
            myGraph.AddEdge(nodeFour, new Tuple<Node, int>(nodeFive, 20));
            myGraph.AddEdge(nodeFive, new Tuple<Node, int>(nodeOne, 25));

            Assert.NotEmpty(myGraph.GetNodes());
        }

        /// <summary>
        /// Determines whether this instance [can return list of nodes with zero weight].
        /// </summary>
        [Fact]
        public void CanReturnListOfNodesWithZeroWeight()
        {
            Node nodeOne = new Node("nodeOne");
            Node nodeTwo = new Node("nodeTwo");
            Node nodeThree = new Node("nodeThree");
            Node nodeFour = new Node("nodeFour");
            Node nodeFive = new Node("nodeFive");
            Graphs myGraph = new Graphs(nodeOne);

            myGraph.AddEdge(nodeOne, new Tuple<Node, int>(nodeTwo, 0));
            myGraph.AddEdge(nodeTwo, new Tuple<Node, int>(nodeThree, 0));
            myGraph.AddEdge(nodeThree, new Tuple<Node, int>(nodeFour, 0));
            myGraph.AddEdge(nodeFour, new Tuple<Node, int>(nodeFive, 0));
            myGraph.AddEdge(nodeFive, new Tuple<Node, int>(nodeOne, 0));

            Assert.NotEmpty(myGraph.GetNodes());
        }

        /// <summary>
        /// Determines whether this instance [can return list of neighbor nodes].
        /// </summary>
        [Fact]
        public void CanReturnListOfNeighborNodes()
        {
            Node nodeOne = new Node("nodeOne");
            Node nodeTwo = new Node("nodeTwo");
            Node nodeThree = new Node("nodeThree");
            Node nodeFour = new Node("nodeFour");
            Node nodeFive = new Node("nodeFive");
            Graphs myGraph = new Graphs(nodeOne);

            myGraph.AddEdge(nodeOne, new Tuple<Node, int>(nodeTwo, 5));
            myGraph.AddEdge(nodeTwo, new Tuple<Node, int>(nodeThree, 10));
            myGraph.AddEdge(nodeThree, new Tuple<Node, int>(nodeFour, 15));
            myGraph.AddEdge(nodeFour, new Tuple<Node, int>(nodeFive, 20));
            myGraph.AddEdge(nodeFive, new Tuple<Node, int>(nodeOne, 25));

            Assert.NotEmpty(myGraph.GetNeighbors(nodeOne));
        }

        /// <summary>
        /// Determines whether this instance [can return null list with no neighbor nodes].
        /// </summary>
        [Fact]
        public void CanReturnNullListWithNoNeighborNodes()
        {
            Node nodeOne = new Node("nodeOne");
            Graphs myGraph = new Graphs(nodeOne);            

            Assert.Empty(myGraph.GetNeighbors(nodeOne));
        }

        /// <summary>
        /// Determines whether this instance [can return list of neighbor nodes with zero weight].
        /// </summary>
        [Fact]
        public void CanReturnListOfNeighborNodesWithZeroWeight()
        {
            Node nodeOne = new Node("nodeOne");
            Node nodeTwo = new Node("nodeTwo");
            Node nodeThree = new Node("nodeThree");
            Node nodeFour = new Node("nodeFour");
            Node nodeFive = new Node("nodeFive");
            Graphs myGraph = new Graphs(nodeOne);

            myGraph.AddEdge(nodeOne, new Tuple<Node, int>(nodeTwo, 0));
            myGraph.AddEdge(nodeTwo, new Tuple<Node, int>(nodeThree, 0));
            myGraph.AddEdge(nodeThree, new Tuple<Node, int>(nodeFour, 0));
            myGraph.AddEdge(nodeFour, new Tuple<Node, int>(nodeFive, 0));
            myGraph.AddEdge(nodeFive, new Tuple<Node, int>(nodeOne, 0));

            Assert.NotEmpty(myGraph.GetNeighbors(nodeOne));
        }

        /// <summary>
        /// Determines whether this instance [can return size of graph].
        /// </summary>
        [Fact]
        public void CanReturnSizeOfGraph()
        {
            Node nodeOne = new Node("nodeOne");
            Node nodeTwo = new Node("nodeTwo");
            Node nodeThree = new Node("nodeThree");
            Node nodeFour = new Node("nodeFour");
            Node nodeFive = new Node("nodeFive");
            Graphs myGraph = new Graphs(nodeOne);

            myGraph.AddEdge(nodeOne, new Tuple<Node, int>(nodeTwo, 5));
            myGraph.AddEdge(nodeTwo, new Tuple<Node, int>(nodeThree, 10));
            myGraph.AddEdge(nodeThree, new Tuple<Node, int>(nodeFour, 15));
            myGraph.AddEdge(nodeFour, new Tuple<Node, int>(nodeFive, 20));
            myGraph.AddEdge(nodeFive, new Tuple<Node, int>(nodeOne, 25));

            Assert.Equal(5, myGraph.Size());
        }

        /// <summary>
        /// Determines whether this instance [can return one with empty graph].
        /// </summary>
        [Fact]
        public void CanReturnOneWithEmptyGraph()
        {
            Node nodeOne = new Node("nodeOne");
            Graphs myGraph = new Graphs(nodeOne);

            Assert.Equal(1, myGraph.Size());
        }

        /// <summary>
        /// Determines whether this instance [can return size of graph with zero weight].
        /// </summary>
        [Fact]
        public void CanReturnSizeOfGraphWithZeroWeight()
        {
            Node nodeOne = new Node("nodeOne");
            Node nodeTwo = new Node("nodeTwo");
            Node nodeThree = new Node("nodeThree");
            Node nodeFour = new Node("nodeFour");
            Node nodeFive = new Node("nodeFive");
            Graphs myGraph = new Graphs(nodeOne);

            myGraph.AddEdge(nodeOne, new Tuple<Node, int>(nodeTwo, 0));
            myGraph.AddEdge(nodeTwo, new Tuple<Node, int>(nodeThree, 0));
            myGraph.AddEdge(nodeThree, new Tuple<Node, int>(nodeFour, 0));
            myGraph.AddEdge(nodeFour, new Tuple<Node, int>(nodeFive, 0));
            myGraph.AddEdge(nodeFive, new Tuple<Node, int>(nodeOne, 0));

            Assert.Equal(5, myGraph.Size());
        }
    }
}
