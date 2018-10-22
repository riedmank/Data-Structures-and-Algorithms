using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;

namespace QueuesWithStacks.Classes
{
    public class QWS
    {
        Stack Stack1 = new Stack(null);
        Stack Stack2 = new Stack(null);

        /// <summary>
        /// Queues with Stacks constructor
        /// </summary>
        /// <param name="StackA">Takes in a Stack</param>
        /// <param name="StackB">Takes in a Stack</param>
        public QWS(Stack StackA, Stack StackB)
        {
            Stack1 = StackA;
            Stack2 = StackB;
        }

        /// <summary>
        /// Adds a Node to the Queue
        /// </summary>
        /// <param name="value">Takes in a Node</param>
        public void Enqueue(Node value)
        {
            Stack1.Push(value);
        }

        /// <summary>
        /// Removes a Node from the Queue
        /// </summary>
        /// <returns>Returns the Front Node from the Queue</returns>
        public Node Dequeue()
        {
            Node temp = null;
            try
            {
                while (Stack1.Top.Next != null)
                {
                    Stack2.Push(Stack1.Pop());
                }
                temp = Stack1.Pop();
                while (Stack2.Top != null)
                {
                    Stack1.Push(Stack2.Pop());
                }
                return temp;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return temp;
        }
    }
}
