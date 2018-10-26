using System;
using Xunit;
using StacksAndQueues.Classes;
using static EenieMeenieMeineMoe.Program;

namespace EenieMeenieMeineMoeTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests if the game can be played with a number smaller than the Queue
        /// </summary>
        [Fact]
        public void CanPlayWithNumberSmallerThanQueue()
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");
            Node node5 = new Node("node5");
            Node node6 = new Node("node6");
            Node node7 = new Node("node7");

            Queue Queue = new Queue(node1);

            Queue.Enqueue(node2);
            Queue.Enqueue(node3);
            Queue.Enqueue(node4);
            Queue.Enqueue(node5);
            Queue.Enqueue(node6);
            Queue.Enqueue(node7);

            int num = 3;

            Assert.Equal(node2.Value, EMMM(num, Queue).Value);
        }

        /// <summary>
        /// Tests if the game can be played with a number larger than the Queue
        /// </summary>
        [Fact]
        public void CanPlayWithNumberLargerThanQueue()
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");
            Node node5 = new Node("node5");
            Node node6 = new Node("node6");
            Node node7 = new Node("node7");

            Queue Queue = new Queue(node1);

            Queue.Enqueue(node2);
            Queue.Enqueue(node3);
            Queue.Enqueue(node4);
            Queue.Enqueue(node5);
            Queue.Enqueue(node6);
            Queue.Enqueue(node7);

            int num = 10;

            Assert.Equal(node2.Value, EMMM(num, Queue).Value);
        }

        /// <summary>
        /// Tests that null is returned if the number is less than one is passed in
        /// </summary>
        [Fact]
        public void CanReturnNullWithNegativeNumber()
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");
            Node node5 = new Node("node5");
            Node node6 = new Node("node6");
            Node node7 = new Node("node7");

            Queue Queue = new Queue(node1);

            Queue.Enqueue(node2);
            Queue.Enqueue(node3);
            Queue.Enqueue(node4);
            Queue.Enqueue(node5);
            Queue.Enqueue(node6);
            Queue.Enqueue(node7);

            int num = -7;

            Assert.Null(EMMM(num, Queue));
        }
    }
}
