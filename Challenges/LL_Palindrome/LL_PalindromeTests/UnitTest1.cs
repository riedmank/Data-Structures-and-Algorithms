using System;
using Xunit;
using static LL_Palindrome.Program;
using LinkedList.Classes;

namespace LL_PalindromeTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests to see if an even numbered Linked List is a palindrome
        /// </summary>
        [Fact]
        public void EvenLetterPalindromeTest()
        {
            Node node1 = new Node("H");
            Node node2 = new Node("A");
            Node node3 = new Node("N");
            Node node4 = new Node("N");
            Node node5 = new Node("A");
            Node node6 = new Node("H");

            LL LL1 = new LL(node1);

            LL1.Append(node2);
            LL1.Append(node3);
            LL1.Append(node4);
            LL1.Append(node5);
            LL1.Append(node6);

            Assert.True(PalindromeChecker(LL1));
        }

        /// <summary>
        /// Test to see if an odd numbered Linked List is a palindrome
        /// </summary>
        [Fact]
        public void OddLetterPalindromeTest()
        {
            Node node1 = new Node("R");
            Node node2 = new Node("A");
            Node node3 = new Node("C");
            Node node4 = new Node("E");
            Node node5 = new Node("C");
            Node node6 = new Node("A");
            Node node7 = new Node("R");

            LL LL1 = new LL(node1);

            LL1.Append(node2);
            LL1.Append(node3);
            LL1.Append(node4);
            LL1.Append(node5);
            LL1.Append(node6);
            LL1.Append(node7);

            Assert.True(PalindromeChecker(LL1));
        }

        /// <summary>
        /// Checks to make sure that a linked list is not a palindrome
        /// </summary>
        [Fact]
        public void NotAPalindromeTest()
        {
            Node node1 = new Node("S");
            Node node2 = new Node("H");
            Node node3 = new Node("A");
            Node node4 = new Node("I");
            Node node5 = new Node("H");
            Node node6 = new Node("U");
            Node node7 = new Node("L");
            Node node8 = new Node("U");
            Node node9 = new Node("D");

            LL LL1 = new LL(node1);

            LL1.Append(node2);
            LL1.Append(node3);
            LL1.Append(node4);
            LL1.Append(node5);
            LL1.Append(node6);
            LL1.Append(node7);
            LL1.Append(node8);
            LL1.Append(node9);

            Assert.False(PalindromeChecker(LL1));
        }
    }
}
