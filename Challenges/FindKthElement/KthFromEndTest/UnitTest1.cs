using System;
using Xunit;
using static FindKthElement.Program;
using LinkedList.Classes;

namespace KthFromEndTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindKthFromEnd()
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");
            Node node5 = new Node("node5");

            LL ll = new LL(node1);

            ll.Append(node2);
            ll.Append(node3);
            ll.Append(node4);
            ll.Append(node5);

            Assert.Equal("node3", NodeFinderAtK(3, ll));
        }
        
        [Fact]
        public void CanThrowException()
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");
            Node node5 = new Node("node5");

            LL ll = new LL(node1);

            ll.Append(node2);
            ll.Append(node3);
            ll.Append(node4);
            ll.Append(node5);

            Assert.Equal("Value is outside Linked List", NodeFinderAtK(10, ll));
        }

        [Fact]
        public void CanFindValueAtHead()
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");
            Node node5 = new Node("node5");

            LL ll = new LL(node1);

            ll.Append(node2);
            ll.Append(node3);
            ll.Append(node4);
            ll.Append(node5);

            Assert.Equal("node1", NodeFinderAtK(5, ll));
        }
    }
}
