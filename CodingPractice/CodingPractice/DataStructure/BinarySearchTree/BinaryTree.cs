using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.DataStructure.BinarySearchTree
{
    public class BinaryTree
    {
        private class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node(int data)
            {
                this.Data = data;
                Left = Right = null;

            }
        }

        Node root;

        #region Add BST
        /// <summary>
        /// Add data in the binary search tree non recurive
        /// </summary>
        /// <param name="data">param</param>
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                bool isAdded = false;
                do
                {
                    if (data < current.Data)
                    {
                        if (current.Left == null)
                        {
                            current.Left = newNode;
                            isAdded = true;
                        }
                        else
                        {
                            current = current.Left;
                        }
                    }
                    else
                    {
                        if (current.Right == null)
                        {
                            current.Right = newNode;
                            isAdded = true;
                        }
                        else
                        {
                            current = current.Right;
                        }
                    }
                } while (!isAdded);
            }
        }
        #endregion

        #region Add BST Recursive
        /// <summary>
        /// Add data in the bst recursively
        /// </summary>
        /// <param name="data"></param>
        public void AddRec(int data)
        {
           root = InsertData(root, data);
        }

        private Node InsertData(Node node,int data)
        {
            if (node == null)
            {
                node = new Node(data);
                return node;

            }
            else if (node.Data < data)
            {
             node.Right =  InsertData(node.Right, data);
            }

            else if (node.Data > data)
            {
              node.Left = InsertData(node.Left, data);
            }
            return node;
        }
        #endregion

        #region find LCA
        public int FindLCA(int n1,int n2)
        {
            root = FindLCA(root,n1, n2);
            return root.Data;
        }

        private Node FindLCA(Node root,int n1,int n2)
        {
            if (root == null)
            {
                return null;
            }
            // If either n1 or n2 matches with root's key, report the presence
            // by setting v1 or v2 as true and return root (Note that if a key
            // is ancestor of other, then the ancestor key becomes LCA)
            if (root.Data > n1 && root.Data > n2)
            {
                return FindLCA(root.Left, n1, n2);
            }
            else if (root.Data < n1 && root.Data < n2)
            {
                return FindLCA(root.Right, n1, n2);
            }
            else
            {
                return root;
            }
        }
        #endregion

        #region print leaf node
        public void PrintLeafNode()
        {
            printLeafNode(root);
        }
        private void printLeafNode(Node root)
        {
            if (root == null)
            {
                return;
            }
            if (root.Left == null && root.Right == null)
            {
                Console.WriteLine(root.Data);
                return;
            }
            if (root.Left != null)
            {
                printLeafNode(root.Left);
            }
            if (root.Right != null)
            {
                printLeafNode(root.Right);
            }

        }
        #endregion

        #region print root node 
        public void PrintRootNode()
        {
            printRootNode(root);
        }

        
        // Traverses given tree in Inorder fashion and
        // prints all nodes that have both children as
        // non-empty.
        private void printRootNode(Node root)
        {
            if (root != null)
            {
                printRootNode(root.Left);
                if(root.Left!=null && root.Right != null)
                {
                    Console.WriteLine(root.Data);
                }
                printRootNode(root.Right);
            }
        }
        #endregion

        #region Tree Travesal
        public void PreOrder()
        {
            preOrder(root);
        }
        public void InOrder()
        {
            preOrder(root);
        }
        public void PostOrder()
        {
            postOrder(root);
        }

        private void preOrder(Node root)
        {
            if (root != null)
            {


                Console.WriteLine(root.Data); 
                preOrder(root.Left);  
                preOrder(root.Right); 
            }
        }
        private void inOrder(Node root)
        {
            if (root != null)
            {
                inOrder(root.Left);
                Console.WriteLine(root.Data);
                inOrder(root.Right);
            }
            
        }

        private void postOrder(Node root)
        {
            if (root != null)
            {
                postOrder(root.Left);
                postOrder(root.Right);
                Console.WriteLine(root.Data);
            }
        }
        #endregion

        #region Search
        public bool Search(int n)
        {
            return search(root, n);
        }
        private bool search(Node root,int n)
        {
            if(root == null)
            {
                return false;
            }
            if(root.Data == n)
            {
                return true;
            }
            else if(root.Data > n)
            {
                search(root.Left, n);
            }
            else if(root.Data < n)
            {
                search(root.Right, n);
            }
            return false;
        }
        #endregion

        /// <summary>
        /// A simpler solution would be to do an inorder traversal and keep track of the element 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public int KthSmallest(int position)
        {
            return kthSmallest(root, position);
        }
        private int kthSmallest(Node root,int position)
        {
            if(root == null)
            {
                return position;
            }
            position = kthSmallest(root.Left,position);
            position--;

            if (position == 0)
            {
                Console.WriteLine(root.Data);
                
            }
            position = kthSmallest(root.Right, position);
            return position;
        }
    }
}
