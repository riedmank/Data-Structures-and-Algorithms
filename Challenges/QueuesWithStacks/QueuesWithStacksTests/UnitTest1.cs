using System;
using Xunit;
using StacksAndQueues.Classes;
using static QueuesWithStacks.Program;
using QueuesWithStacks.Classes;

namespace QueuesWithStacksTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests FIFO concept with new Queue Class and Dequeue method
        /// </summary>
        [Fact]
        public void CanRemoveFirstNodeAddedToQueue()
        {
            Stack Stack1 = new Stack(null);
            Stack Stack2 = new Stack(null);

            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");
            Node node5 = new Node("node5");

            QWS Queue = new QWS(Stack1, Stack2);

            Queue.Enqueue(node1);
            Queue.Enqueue(node2);
            Queue.Enqueue(node3);
            Queue.Enqueue(node4);
            Queue.Enqueue(node5);

            Assert.Equal(node1.Value, Queue.Dequeue().Value);
        }

        /// <summary>
        /// Tests to ensure last Node added is not first Node out
        /// </summary>
        [Fact]
        public void NodeAddedIsNotFirstOut()
        {
            Stack Stack1 = new Stack(null);
            Stack Stack2 = new Stack(null);

            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");
            Node node5 = new Node("node5");

            QWS Queue = new QWS(Stack1, Stack2);

            Queue.Enqueue(node1);
            Queue.Enqueue(node2);
            Queue.Enqueue(node3);
            Queue.Enqueue(node4);
            Queue.Enqueue(node5);

            Assert.NotEqual(node5.Value, Queue.Dequeue().Value);
        }

        /// <summary>
        /// Tests to ensure that order of Nodes of after Enqueue, Dequeue, and Enqueue is retained
        /// </summary>
        [Fact]
        public void CanEnqueueDequeueAndEnqueue()
        {
            Stack Stack1 = new Stack(null);
            Stack Stack2 = new Stack(null);

            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");
            Node node5 = new Node("node5");
            Node node6 = new Node("node6");
            Node node7 = new Node("node7");

            QWS Queue = new QWS(Stack1, Stack2);

            Queue.Enqueue(node1);
            Queue.Enqueue(node2);
            Queue.Enqueue(node3);
            Queue.Enqueue(node4);
            Queue.Enqueue(node5);

            Queue.Dequeue();

            Queue.Enqueue(node6);
            Queue.Enqueue(node7);
            
            Assert.Equal("node2", Queue.Dequeue().Value);
        }
        
        /// <summary>
        /// Tests to ensure one Node can be Enqueued and Dequeued
        /// </summary>
        [Fact]
        public void CanEnqueueAndDequeueOneNode()
        {
            Stack Stack1 = new Stack(null);
            Stack Stack2 = new Stack(null);

            Node node1 = new Node("node1");

            QWS Queue = new QWS(Stack1, Stack2);

            Queue.Enqueue(node1);

            Assert.Equal(node1.Value, Queue.Dequeue().Value);
        }

        /// <summary>
        /// Tests that two Nodes in a row can be Dequeued
        /// </summary>
        [Fact]
        public void CanDequeueTwoNodesInARow()
        {
            Stack Stack1 = new Stack(null);
            Stack Stack2 = new Stack(null);

            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");
            Node node5 = new Node("node5");

            QWS Queue = new QWS(Stack1, Stack2);

            Queue.Enqueue(node1);
            Queue.Enqueue(node2);
            Queue.Enqueue(node3);
            Queue.Enqueue(node4);
            Queue.Enqueue(node5);

            Queue.Dequeue();

            Assert.Equal(node2.Value, Queue.Dequeue().Value);
        }

        /// <summary>
        /// Tests that program doesn't break if calling Dequeue on an empty Queue
        /// </summary>
        [Fact]
        public void CanDequeueFromEmptyQueue()
        {
            Stack Stack1 = new Stack(null);
            Stack Stack2 = new Stack(null);

            QWS Queue = new QWS(Stack1, Stack2);

            Assert.Null(Queue.Dequeue());
        }
    }
}
