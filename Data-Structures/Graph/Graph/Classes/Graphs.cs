using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Graphs
    {
        public LinkedList<LinkedList<Tuple<Node, int>>> AdjacencyList { get; set; }
        
        public Graphs(Node edge)
        {
            AdjacencyList = new LinkedList<LinkedList<Tuple<Node, int>>>();
            LinkedList<Tuple<Node, int>> vertex = new LinkedList<Tuple<Node, int>>();
            vertex.AddFirst(new Tuple<Node, int>(edge, 0));
            AdjacencyList.AddLast(vertex);
        }

        /// <summary>
        /// Adds the edge.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="child">The child.</param>
        public void AddEdge(Node parent, Tuple<Node, int> child)
        {
            bool vertexExists = false;

            foreach (var item in AdjacencyList)
            {
                if (item.First.Value.Item1 == parent)
                {
                    item.AddLast(child);
                }
                else if (item.First.Value.Item1 == child.Item1)
                {
                    //item.AddLast(new Tuple<Node, int>(parent, child.Item2));
                    vertexExists = true;
                }
            }        
            
            if (!vertexExists)
            {
                LinkedList<Tuple<Node, int>> newEdge = new LinkedList<Tuple<Node, int>>();
                newEdge.AddFirst(new Tuple<Node, int>(child.Item1, 0));
                AdjacencyList.AddLast(newEdge);
            }
        }

        /// <summary>
        /// Gets the nodes.
        /// </summary>
        /// <returns>Returns a List of Nodes</returns>
        public List<Node> GetNodes()
        {
            List<Node> nodeList = new List<Node>();
            foreach (var item in AdjacencyList)
            {
                nodeList.Add(item.First.Value.Item1);
            }
            return nodeList;
        }

        /// <summary>
        /// Gets the neighbors.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>Returns a List of Neighbor nodes</returns>
        public List<Node> GetNeighbors(Node parent)
        {
            List<Node> nodeList = new List<Node>();
            foreach (var item in AdjacencyList)
            {
                if (item.First.Value.Item1 == parent)
                {
                    foreach (var val in item)
                    {
                        nodeList.Add(val.Item1);
                    }
                }
            }
            return nodeList;
        }

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns>Returns the size of the Adjacency list</returns>
        public int Size()
        {
            return AdjacencyList.Count;
        }
    }
}
