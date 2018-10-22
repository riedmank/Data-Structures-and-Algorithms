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

        public QWS(Stack StackA, Stack StackB)
        {
            Stack1 = StackA;
            Stack2 = StackB;
        }

        public void Enqueue(Node value)
        {
            Stack1.Push(value);
        }

        public Node Dequeue()
        {
            while (Stack1.Top.Next != null)
            {
                Stack2.Push(Stack1.Pop());
            }
            Node temp = Stack1.Pop();
            while (Stack2.Top != null)
            {
                Stack1.Push(Stack2.Pop());
            }
            return temp;
        }
    }
}
