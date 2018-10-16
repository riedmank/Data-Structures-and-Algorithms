using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classess
{
    public class Node
    {
        public object Value { get; set; }
        public Node Next { get; set; }

        public Node(object value)
        {
            Value = value;
        }
    }
}
