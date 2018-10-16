using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classess
{
    public class LinkedListClass
    {
        /// <summary>
        /// Always points to the first node in the LL
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// The node that is used to traverse through the LL
        /// </summary>
        public Node Current { get; set; }

        /// <summary>
        /// LL requires a node at the time of creation to be the HEAD
        /// </summary>
        /// <param name="node">Node object</param>
        public LinkedListClass(Node node)
        {
            Head = node;
            Current = Head;
        }

        /// <summary>
        /// Adding a node at the beginning of the LL: O(1)
        /// </summary>
        /// <param name="node">Head node object</param>
        public void Add(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        /// <summary>
        /// Printing the linked list
        /// </summary>
        public void Print()
        {
            Current = Head;
            while (Current.Next != null)
            {
                Console.WriteLine($"{Current.Value} -->");
                Current = Current.Next;
            }
            Console.WriteLine($"{Current.Value} --> NULL");
        }

        /// <summary>
        /// Append node to the end of the linked list
        /// </summary>
        /// <param name="node">Takes in a node object to be appended to the list</param>
        public void Append(Node newNode)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
        }

        /// <summary>
        /// Method adds a node before the target node
        /// </summary>
        /// <param name="newNode">Node to be added</param>
        /// <param name="existingNode">Target node to add new node before</param>
        public void AddBefore(Node newNode, Node existingNode)
        {
            Current = Head;
            if (Head.Value == existingNode.Value)
            {
                Add(newNode);
                return;
            }
            while (Current.Next != null)
            {
                if (Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = existingNode;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }

        /// <summary>
        /// This method finds a target value in the linked list
        /// </summary>
        /// <param name="value">Target value provided by the user</param>
        /// <returns>Returns the node where the target value was found or returns null</returns>
        public Node Find(object value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return Current;
                }
                Current = Current.Next;
            }
            return (Current.Value).ToString() == value.ToString() ? Current : null;
        }

        /// <summary>
        /// This method adds a node after the target node
        /// </summary>
        /// <param name="newNode">Node to be added</param>
        /// <param name="existingNode">Node to add new node after</param>
        public void AddAfter(Node newNode, Node existingNode)
        {
            Current = Head;
            if (existingNode.Value == Head.Value)
            {
                newNode.Next = Head.Next;
                Head.Next = newNode;
            }
            while (Current.Next != null)
            {
                if (existingNode.Value == Current.Value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
            Current.Next = newNode;
            newNode.Next = null;
        }
    }
}
