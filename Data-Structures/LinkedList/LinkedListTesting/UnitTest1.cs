using System;
using Xunit;
using LinkedList;
using LinkedList.Classes;

namespace LinkedListTesting
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("potato")]
        [InlineData(22)]
        [InlineData(false)]
        public void LLCanAdd(object value)
        {
            Node node1 = new Node(10);
            Node node2 = new Node(null);
            Node node3 = new Node("Dune");
            Node node4 = new Node(value);
            LL LL = new LL(node1);

            LL.Add(node2);
            LL.Add(node3);
            LL.Add(node4);

            Assert.Equal(value, LL.Head.Value);
        }

        [Theory]
        [InlineData("potato")]
        [InlineData(22)]
        [InlineData(false)]
        public void LLCanAppend(object value)
        {
            Node node1 = new Node(10);
            Node node2 = new Node(null);
            Node node3 = new Node("Dune");
            Node node4 = new Node(value);
            LL LL = new LL(node1);

            LL.Append(node2);
            LL.Append(node3);
            LL.Append(node4);

            Assert.Null(node4.Next);
        }

        [Theory]
        [InlineData("potato")]
        [InlineData(22)]
        [InlineData(false)]
        public void LLCanFind(object value)
        {
            Node node1 = new Node(10);
            Node node2 = new Node(null);
            Node node3 = new Node("Dune");
            Node node4 = new Node(value);
            LL LL = new LL(node1);

            LL.Append(node2);
            LL.Append(node3);
            LL.Append(node4);

            Assert.Equal(value, LL.Find(value).Value);
        }

        [Theory]
        [InlineData("potato")]
        [InlineData(22)]
        [InlineData(false)]
        public void LLCanAddAfter(object value)
        {
            Node node1 = new Node(10);
            Node node2 = new Node(null);
            Node node3 = new Node("Dune");
            Node node4 = new Node(value);
            LL LL = new LL(node1);

            LL.Append(node2);
            LL.Append(node3);
            LL.AddAfter(node4, node2);

            Assert.Equal(node4, node2.Next);
        }

        [Theory]
        [InlineData("potato")]
        [InlineData(22)]
        [InlineData(false)]
        public void LLCanAddBefore(object value)
        {
            Node node1 = new Node(10);
            Node node2 = new Node(null);
            Node node3 = new Node("Dune");
            Node node4 = new Node(value);
            LL LL = new LL(node1);

            LL.Append(node2);
            LL.Append(node3);
            LL.AddBefore(node4, node3);

            Assert.Equal(node3, node4.Next);
        }
    }
}
