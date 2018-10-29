using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// Adds a Node to the Binary Searc Tree
        /// </summary>
        /// <param name="root">The root of the existing Binary Search Tree</param>
        /// <param name="newNode">Node to be added to the tree</param>
        public void Add(Node root, Node newNode)
        {
            if (root == null)
                root = newNode;
            if (root.Value == newNode.Value)
                return;
            else if (root.Value > newNode.Value)
            {
                if (root.LeftChild == null)
                    root.LeftChild = newNode;
                else
                    Add(root.LeftChild, newNode);
            }
            else if (root.Value < newNode.Value)
            {
                if (root.RightChild == null)
                    root.RightChild = newNode;
                else
                    Add(root.RightChild, newNode);
            }
        }

        /// <summary>
        /// This methods searches for a Value in a Binary Search Tree
        /// </summary>
        /// <param name="value">The value to be found</param>
        /// <param name="root">The root Node of the Tree</param>
        /// <returns>Returns the Node of the found Value</returns>
        public Node Search(int value, Node root)
        {
            try
            {
                while (value != root.Value)
                {
                    if (value == root.Value)
                        return root;
                    if (root.Value > value)
                        root = root.LeftChild;
                    if (root.Value < value)
                        root = root.RightChild;
                }
            }
            catch
            {
                return null;
            }
            return root;
        }
    }
}
