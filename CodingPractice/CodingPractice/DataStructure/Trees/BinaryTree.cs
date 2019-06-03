using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.BinarySearch
{
    public class BinaryTree
    {
        public class Node
        {
           public int data;
            public Node left;
            public Node right;
            public Node()
            {
                //this.data = data;
                left = right = null;
            }
            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        }
       static Node tree;
        public static void Insert()
        {
            //recursive Insert
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Insert(tree, 0, arr.Length, arr);

            //using Queue
            for (int i = 0; i < arr.Length; i++)
                Insert(tree, arr[i]);
        }
       
        private static Node Insert(Node tree,int index,int size,int[] arr)
        {
           
            if(index < size)
            {
                tree.data = arr[index];
                Insert(tree.left = new Node(),2 * index + 1,size,arr);
                Insert(tree.right= new Node(), 2 * index + 2,size,arr);
            }
            return tree;

        }

        private static void Insert(Node node,int key)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(node);
            while (q != null)
            {
                Node nd = q.Peek();
                q.Dequeue();

                if(nd.left == null)
                {
                    nd.left = new Node(key);
                    break;
                }
                else
                {
                    q.Enqueue(nd.left);
                }
                if(nd.right == null)
                {
                    nd.right = new Node(key);
                    break;
                }
                else
                {
                    q.Enqueue(nd.right);
                }
            }
        }
    }
}
