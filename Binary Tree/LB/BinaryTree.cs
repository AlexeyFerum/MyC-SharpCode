using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB
{
    public class BinaryTree
    {
        public class Node
        {
            public Node left, right;
            string data;
            public string Data { get { return data; } }
            public Node(string data)
            {
                this.data = data;
            }
        }

        Node root;

        public void AddElement(string element)
        {
            Add(ref root, element);
        }

        private void Add(ref Node node, string element)
        {
            if (node == null)
            {
                node = new Node(element);
                return;
            }
            if (forBinaryTree.StartCompare(node.Data, element))
                Add(ref node.right, element);
            else
                Add(ref node.left, element);
        }

        public bool Contains(string element)
        {
            return CheckNode(root, element);
        }

        private bool CheckNode(Node node, string element)
        {
            if (node == null)
                return false;
            if (node.Data.Equals(element))
                return true;
            if (forBinaryTree.StartCompare(node.Data, element))
            {
                return CheckNode(node.right, element);
            }
            else
            {
                return CheckNode(node.left, element);
            }
        }
    }
}