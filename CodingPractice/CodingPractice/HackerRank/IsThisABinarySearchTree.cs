using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class IsThisABinarySearchTree
    {
        public class Node
        {
          public  int data;
          public  Node left;
          public  Node right;
        }
        /// <summary>
        /// https://www.hackerrank.com/challenges/ctci-is-binary-search-tree/problem
        /// Medium 30
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        bool checkBST(Node root)
        {
            if (root == null)
            {
                return false;
            }
            return isBST(root, int.MinValue, int.MaxValue);
        }
        bool isBST(Node node, int min, int max)
        {
            if (node == null) return true;
            return min < node.data && node.data < max &&
                isBST(node.left, min, node.data) &&
                isBST(node.right, node.data, max);
        }
    }
}
