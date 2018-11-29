using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Graphs
    {
        public Dictionary<Node, List<Tuple<Node, int>>> AdjacencyList { get; set; }

        public Graphs(Node vertex)
        {
            AdjacencyList = new Dictionary<Node, List<Tuple<Node, int>>>();
            List<Tuple<Node, int>> neighbors = new List<Tuple<Node, int>>();
            AdjacencyList.Add(vertex, neighbors);
        }

        /// <summary>
        /// Adds the edge.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="child">The child.</param>
        public void AddEdge(Node parent, Tuple<Node, int> child)
        {
            if (!AdjacencyList.ContainsKey(parent))
            {
                List<Tuple<Node, int>> neighbors = new List<Tuple<Node, int>>();
                AdjacencyList.Add(parent, neighbors);
            }
            var value = AdjacencyList.GetValueOrDefault(parent);
            value.Add(child);
            if (!AdjacencyList.ContainsKey(child.Item1))
            {
                List<Tuple<Node, int>> neighbors = new List<Tuple<Node, int>>();
                AdjacencyList.Add(child.Item1, neighbors);
            }
            value = AdjacencyList.GetValueOrDefault(child.Item1);
            value.Add(new Tuple<Node, int>(parent, child.Item2));
        }

        /// <summary>
        /// Gets the nodes.
        /// </summary>
        /// <returns>Returns a list of nodes in the Graph</returns>
        public List<Node> GetNodes()
        {
            List<Node> nodeList = new List<Node>();
            foreach (var item in AdjacencyList)
            {
                if (item.Key != null)
                    nodeList.Add(item.Key);
            }
            return nodeList;
        }

        /// <summary>
        /// Gets the neighbors of the target node.
        /// </summary>
        /// <param name="vertex">The vertex.</param>
        /// <returns>Returns a List of neighbors</returns>
        public List<Node> GetNeighbors(Node vertex)
        {
            List<Node> nodeList = new List<Node>();
            var value = AdjacencyList.GetValueOrDefault(vertex);
            foreach (var item in value)
            {
                nodeList.Add(item.Item1);
            }
            return nodeList;
        }

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns>Returnst the number of Nodes in the Graph</returns>
        public int Size()
        {
            return AdjacencyList.Count;            
        }
    }
}
