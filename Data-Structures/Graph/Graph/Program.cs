using Graph.Classes;
using System;

namespace Graph
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GraphBuilder();
        }

        public static void GraphBuilder()
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
            myGraph.AddEdge(nodeTwo, new Tuple<Node, int>(nodeFour, 17));

            Console.WriteLine($"Graph size: {myGraph.Size()}");
            Console.WriteLine("Graph nodes:");
            foreach (var item in myGraph.GetNodes())
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine("Graph neighbors for nodeOne:");
            foreach (var item in myGraph.GetNeighbors(nodeOne))
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine("Graph neighbors for nodeTwo:");
            foreach (var item in myGraph.GetNeighbors(nodeTwo))
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine("Graph neighbors for nodeThree:");
            foreach (var item in myGraph.GetNeighbors(nodeThree))
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine("Graph neighbors for nodeFour:");
            foreach (var item in myGraph.GetNeighbors(nodeFour))
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine("Graph neighbors for nodeFive:");
            foreach (var item in myGraph.GetNeighbors(nodeFive))
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
