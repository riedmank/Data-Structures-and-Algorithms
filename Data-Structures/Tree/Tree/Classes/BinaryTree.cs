using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public List<Node> nodes { get; set; }

        public BinaryTree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// Performs a Depth-First traversal using PreOrder method
        /// </summary>
        /// <param name="root">Root Node of the Binary Tree</param>
        /// <returns>Returns a List of all Nodes in the Binary Tree</returns>
        public List<Node> PreOrder(Node root)
        {
            nodes.Add(root);
            if (root.LeftChild != null)
                PreOrder(root.LeftChild);
            if (root.RightChild != null)
                PreOrder(root.RightChild);
            return nodes;
        }

        /// <summary>
        /// Performs a Depth-First traversal using InOrder method
        /// </summary>
        /// <param name="root">Root Node of the Binary Tree</param>
        /// <returns>Returns a List of all Nodes in the Binary Tree</returns>
        public List<Node> InOrder(Node root)
        {
            if (root.LeftChild != null)
                InOrder(root.LeftChild);
            nodes.Add(root);
            if (root.RightChild != null)
                InOrder(root.RightChild);
            return nodes;
        }

        /// <summary>
        /// Performs a Depth-First traversal using PostOrder method
        /// </summary>
        /// <param name="root">Root Node of the Binary Tree</param>
        /// <returns>Returns a List of all Nodes in the Binary Tree</returns>
        public List<Node> PostOrder(Node root)
        {
            if (root.LeftChild != null)
                PostOrder(root.LeftChild);
            if (root.RightChild != null)
                PostOrder(root.RightChild);
            nodes.Add(root);
            return nodes;
        }
    }
}
