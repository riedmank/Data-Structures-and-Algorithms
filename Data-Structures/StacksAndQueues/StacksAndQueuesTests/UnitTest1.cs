using System;
using Xunit;
using StacksAndQueues.Classes;

namespace StacksAndQueuesTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanPushToStack()
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");

            Stack Stack = new Stack(null);

            Stack.Push(node4);
            Stack.Push(node3);
            Stack.Push(node2);
            Stack.Push(node1);

            Assert.Equal(node1, Stack.Peek());
        }

        [Fact]
        public void CanPopFromStack()
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");

            Stack Stack = new Stack(null);

            Stack.Push(node4);
            Stack.Push(node3);
            Stack.Push(node2);
            Stack.Push(node1);

            Stack.Pop();

            Assert.Equal(node2, Stack.Peek());
        }

        [Fact]
        public void CanPeekAtTopOfStack()
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");

            Stack Stack = new Stack(null);

            Stack.Push(node4);
            Stack.Push(node3);
            Stack.Push(node2);
            Stack.Push(node1);

            Assert.Equal(node1, Stack.Peek());
        }

        [Fact]
        public void CanEnqueueToQueue()
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");

            Queue Queue = new Queue(node1);

            Queue.Enqueue(node2);
            Queue.Enqueue(node3);
            Queue.Enqueue(node4);

            Assert.Equal(node4, Queue.Rear);
        }

        [Fact]
        public void CanDequeueFromQueue()
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");

            Queue Queue = new Queue(node1);

            Queue.Enqueue(node2);
            Queue.Enqueue(node3);
            Queue.Enqueue(node4);

            Queue.Dequeue();

            Assert.Equal(node2, Queue.Front);
        }

        [Fact]
        public void CanPeekAtFrontOfQueue()
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");

            Queue Queue = new Queue(node1);

            Queue.Enqueue(node2);
            Queue.Enqueue(node3);
            Queue.Enqueue(node4);

            Assert.Equal(node1, Queue.Peek());
        }
    }
}
