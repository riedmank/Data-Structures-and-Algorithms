using Graph.Classes;
using System;
using System.Collections.Generic;

namespace DirectFlight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node Pandora = new Node("Pandora");
            Node Arendelle = new Node("Arendelle");
            Node Metroville = new Node("Metroville");
            Node Monstropolis = new Node("Monstropolis");
            Node Narnia = new Node("Narnia");
            Node Naboo = new Node("Naboo");
            Graphs flights = new Graphs(Metroville);

            flights.AddEdge(Metroville, new Tuple<Node, int>(Narnia, 37));
            flights.AddEdge(Metroville, new Tuple<Node, int>(Naboo, 26));
            flights.AddEdge(Metroville, new Tuple<Node, int>(Monstropolis, 105));
            flights.AddEdge(Metroville, new Tuple<Node, int>(Arendelle, 99));
            flights.AddEdge(Metroville, new Tuple<Node, int>(Pandora, 82));
            flights.AddEdge(Pandora, new Tuple<Node, int>(Arendelle, 150));
            flights.AddEdge(Arendelle, new Tuple<Node, int>(Monstropolis, 42));
            flights.AddEdge(Monstropolis, new Tuple<Node, int>(Naboo, 73));
            flights.AddEdge(Naboo, new Tuple<Node, int>(Narnia, 250));

            Node[] trip1 = new Node[] { Metroville, Arendelle };
            Node[] trip2 = new Node[] { Narnia, Metroville, Arendelle };
            Node[] trip3 = new Node[] { Naboo, Pandora };

            Console.WriteLine(GetEdges(trip1, flights));
            Console.WriteLine(GetEdges(trip2, flights));
            Console.WriteLine(GetEdges(trip3, flights));
        }

        /// <summary>
        /// Gets the edges.
        /// </summary>
        /// <param name="trip">The trip.</param>
        /// <param name="flights">The flights.</param>
        /// <returns>Returns a string</returns>
        public static string GetEdges(Node[] trip, Graphs flights)
        {
            int cost = 0;
            bool check = false;

            for (int i = 0; i < trip.Length - 1; i++)
            {
               if (flights.GetNeighbors(trip[i]).Contains(trip[i + 1]))
               {
                    check = true;
                    var item = flights.AdjacencyList.GetValueOrDefault(trip[i]);
                    foreach (var value in item)
                    {
                        if (value.Item1 == trip[i + 1])
                            cost += value.Item2;
                    }                    
               }                
            }
            return $"{check} ${cost}";
        }
    }
}
