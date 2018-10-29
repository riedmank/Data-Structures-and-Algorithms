using System;
using Xunit;
using Tree.Classes;
using static FizzBuzzTree.Program;
using System.Collections.Generic;

namespace FizzBuzzTreeTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests that Fizz can be returned
        /// </summary>
        [Fact]
        public void CanReturnFizz()
        {
            Node nodeSeven = new Node(null, null, 3);
            Node nodeSix = new Node(null, null, 5);
            Node nodeFive = new Node(null, null, 15);
            Node nodeFour = new Node(null, null, 3);
            Node nodeThree = new Node(nodeSix, nodeSeven, 7);
            Node nodeTwo = new Node(nodeFour, nodeFive, 30);
            Node nodeOne = new Node(nodeTwo, nodeThree, 50);

            List<string> test = FizzBuzzTreeMethod(nodeOne);

            Assert.Contains("Fizz", test);
        }

        /// <summary>
        /// Tests that Buzz can be returned
        /// </summary>
        [Fact]
        public void CanReturnBuzz()
        {
            Node nodeSeven = new Node(null, null, 3);
            Node nodeSix = new Node(null, null, 5);
            Node nodeFive = new Node(null, null, 15);
            Node nodeFour = new Node(null, null, 3);
            Node nodeThree = new Node(nodeSix, nodeSeven, 7);
            Node nodeTwo = new Node(nodeFour, nodeFive, 30);
            Node nodeOne = new Node(nodeTwo, nodeThree, 50);

            List<string> test = FizzBuzzTreeMethod(nodeOne);

            Assert.Contains("Buzz", test);
        }

        /// <summary>
        /// Tests that FizzBuzz can be returned
        /// </summary>
        [Fact]
        public void CanReturnFizzBuzz()
        {
            Node nodeSeven = new Node(null, null, 3);
            Node nodeSix = new Node(null, null, 5);
            Node nodeFive = new Node(null, null, 15);
            Node nodeFour = new Node(null, null, 3);
            Node nodeThree = new Node(nodeSix, nodeSeven, 7);
            Node nodeTwo = new Node(nodeFour, nodeFive, 30);
            Node nodeOne = new Node(nodeTwo, nodeThree, 50);

            List<string> test = FizzBuzzTreeMethod(nodeOne);

            Assert.Contains("FizzBuzz", test);
        }
    }
}
