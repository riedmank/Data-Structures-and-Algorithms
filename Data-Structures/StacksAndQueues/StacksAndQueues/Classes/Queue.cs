using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// Looks at the front of the queue
        /// </summary>
        /// <returns>Returns a node object</returns>
        public Node Peek()
        {
            return Front;
        }

        /// <summary>
        /// Adds a node to the back of the queue
        /// </summary>
        /// <param name="node">Takes in a node object to be added to the queue</param>
        public void Enqueue (Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// Removes a node from the front of the queue
        /// </summary>
        /// <returns>Returns a node object</returns>
        public Node Dequeue ()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }
    }
}
