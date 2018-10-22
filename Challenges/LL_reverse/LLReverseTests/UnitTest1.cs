using System;
using Xunit;
using LinkedList.Classes;
using static LL_reverse.Program;

namespace LLReverseTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReverseEvenLinkedList()
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");

            LL LL1 = new LL(node1);

            LL1.Append(node2);
            LL1.Append(node3);
            LL1.Append(node4);

            LL LL2 = ReverseLL(LL1);

            Assert.Equal(LL1.Head.Value, LL2.Head.Value);
        }

        [Fact]
        public void CanReverseOddLinkedList()
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");
            Node node4 = new Node("node4");
            Node node5 = new Node("node5");

            LL LL1 = new LL(node1);

            LL1.Append(node2);
            LL1.Append(node3);
            LL1.Append(node4);
            LL1.Append(node5);

            LL LL2 = ReverseLL(LL1);

            Assert.Equal(LL1.Head.Value, LL2.Head.Value);
        }

        [Fact]
        public void NullLinkedList()
        {
            LL LL1 = new LL(null);

            Assert.Null(ReverseLL(LL1));
        }
    }
}
