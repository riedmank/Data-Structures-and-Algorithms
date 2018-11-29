using System;
using Xunit;
using Graph.Classes;
using static DirectFlight.Program;

namespace DirectFlightsTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Determines whether this instance [can find direct flight no layover].
        /// </summary>
        [Fact]
        public void CanFindDirectFlightNoLayover()
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

            Assert.Equal("True $99", GetEdges(trip1, flights));
        }

        /// <summary>
        /// Determines whether this instance [can find direct flight multiple layovers].
        /// </summary>
        [Fact]
        public void CanFindDirectFlightMultipleLayovers()
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

            Node[] trip2 = new Node[] { Narnia, Metroville, Arendelle };

            Assert.Equal("True $136", GetEdges(trip2, flights));
        }

        /// <summary>
        /// Determines whether this instance [can find no direct flight].
        /// </summary>
        [Fact]
        public void CanFindNoDirectFlight()
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

            Node[] trip3 = new Node[] { Naboo, Pandora };

            Assert.Equal("False $0", GetEdges(trip3, flights));
        }
    }
}
