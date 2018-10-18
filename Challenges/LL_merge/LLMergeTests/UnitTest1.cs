using System;
using Xunit;
using static LL_merge.Program;
using LinkedList.Classes;

namespace LLMergeTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests if two linked lists of the same length can be merged
        /// </summary>
        [Fact]
        public void CanMergeLinkedListSameLength()
        {
            Node LL1Node1 = new Node("LL1Node1");
            Node LL1Node2 = new Node("LL1Node2");
            Node LL1Node3 = new Node("LL1Node3");
            Node LL1Node4 = new Node("LL1Node4");
            Node LL1Node5 = new Node("LL1Node5");
            Node LL2Node1 = new Node("LL2Node1");
            Node LL2Node2 = new Node("LL2Node2");
            Node LL2Node3 = new Node("LL2Node3");
            Node LL2Node4 = new Node("LL2Node4");
            Node LL2Node5 = new Node("LL2Node5");

            LL LL1 = new LL(LL1Node1);
            LL LL2 = new LL(LL2Node1);

            LL1.Append(LL1Node2);
            LL1.Append(LL1Node3);
            LL1.Append(LL1Node4);
            LL1.Append(LL1Node5);
            LL2.Append(LL2Node2);
            LL2.Append(LL2Node3);
            LL2.Append(LL2Node4);
            LL2.Append(LL2Node5);

            LLMerge(LL1, LL2);

            Assert.NotEqual(LL1Node3, LL1Node2.Next);
        }

        /// <summary>
        /// Tests if a longer linked list can be merged with a shorter linked list
        /// </summary>
        [Fact]
        public void CanMergeLinkedListFirstListLonger()
        {
            Node LL1Node1 = new Node("LL1Node1");
            Node LL1Node2 = new Node("LL1Node2");
            Node LL1Node3 = new Node("LL1Node3");
            Node LL1Node4 = new Node("LL1Node4");
            Node LL1Node5 = new Node("LL1Node5");
            Node LL1Node6 = new Node("LL1Node6");

            Node LL2Node1 = new Node("LL2Node1");
            Node LL2Node2 = new Node("LL2Node2");
            Node LL2Node3 = new Node("LL2Node3");
            Node LL2Node4 = new Node("LL2Node4");
            Node LL2Node5 = new Node("LL2Node5");

            LL LL1 = new LL(LL1Node1);
            LL LL2 = new LL(LL2Node1);

            LL1.Append(LL1Node2);
            LL1.Append(LL1Node3);
            LL1.Append(LL1Node4);
            LL1.Append(LL1Node5);
            LL1.Append(LL1Node6);

            LL2.Append(LL2Node2);
            LL2.Append(LL2Node3);
            LL2.Append(LL2Node4);
            LL2.Append(LL2Node5);

            LLMerge(LL1, LL2);

            Assert.NotEqual(LL1Node3, LL1Node2.Next);
        }

        /// <summary>
        /// Tests if a shorter linked list can be merged with a longer linked list
        /// </summary>
        [Fact]
        public void CanMergeLinkedListSecondListLonger()
        {
            Node LL1Node1 = new Node("LL1Node1");
            Node LL1Node2 = new Node("LL1Node2");
            Node LL1Node3 = new Node("LL1Node3");
            Node LL1Node4 = new Node("LL1Node4");
            Node LL1Node5 = new Node("LL1Node5");

            Node LL2Node1 = new Node("LL2Node1");
            Node LL2Node2 = new Node("LL2Node2");
            Node LL2Node3 = new Node("LL2Node3");
            Node LL2Node4 = new Node("LL2Node4");
            Node LL2Node5 = new Node("LL2Node5");
            Node LL2Node6 = new Node("LL2Node6");

            LL LL1 = new LL(LL1Node1);
            LL LL2 = new LL(LL2Node1);

            LL1.Append(LL1Node2);
            LL1.Append(LL1Node3);
            LL1.Append(LL1Node4);
            LL1.Append(LL1Node5);

            LL2.Append(LL2Node2);
            LL2.Append(LL2Node3);
            LL2.Append(LL2Node4);
            LL2.Append(LL2Node5);
            LL2.Append(LL2Node6);

            LLMerge(LL1, LL2);

            Assert.NotEqual(LL1Node3, LL1Node2.Next);
        }
    }
}
