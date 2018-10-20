using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        public Stack (Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Looks at the Top node in the stack
        /// </summary>
        /// <returns>Returns a node</returns>
        public Node Peek()
        {
            return Top;
        }

        /// <summary>
        /// Removes the top node from the stack
        /// </summary>
        /// <returns>Returns a node</returns>
        public Node Pop()
        {
            Node temp = Peek();
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Adds a node to the top of the stack
        /// </summary>
        /// <param name="node">Takes in a node to add to the stack</param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }
    }
}
