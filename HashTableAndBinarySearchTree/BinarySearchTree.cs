using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HashTableAndBinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public class Node
        {
            public T Data;
            public Node Left;
            public Node Right;

            public Node(T data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(T data)
        {
            root = InsertNode(root, data);
        }

        private Node InsertNode(Node root, T data)
        {
            if (root == null)
            {
                root = new Node(data);
            }
            else if (data.CompareTo(root.Data) < 0)
            {
                root.Left = InsertNode(root.Left, data);
            }
            else if (data.CompareTo(root.Data) > 0)
            {
                root.Right = InsertNode(root.Right, data);
            }

            return root;
        }

        public bool Search(T data)
        {
            return SearchNode(root, data);
        }

        private bool SearchNode(Node root, T data)
        {
            if (root == null)
            {
                return false;
            }

            if (data.CompareTo(root.Data) == 0)
            {
                return true;
            }
            else if (data.CompareTo(root.Data) < 0)
            {
                return SearchNode(root.Left, data);
            }
            else
            {
                return SearchNode(root.Right, data);
            }
        }

        public void Display()
        {
            InOrderTraversal(root);
        }

        public void InOrderTraversal(Node root)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left);
                Console.Write(root.Data + " ");
                InOrderTraversal(root.Right);
            }
        }
    }


}
