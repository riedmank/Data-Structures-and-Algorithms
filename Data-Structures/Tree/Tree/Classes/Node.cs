using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class Node
    {
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public int Value { get; set; }

        public Node(Node left, Node right, int value)
        {
            LeftChild = left;
            RightChild = right;
            Value = value;
        }
    }
}
