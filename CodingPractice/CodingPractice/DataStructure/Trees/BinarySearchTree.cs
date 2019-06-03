using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.BinarySearch
{
   public class BinarySearchTree
    {
        public class BNode
        {
            public int Data;
            public BNode Left;
            public BNode Right;
            public BNode(int data)
            {
                this.Data = data;
                Right = Left = null;
            }


        }

        public BNode root;
       public void Add(int data)
       {
         root =  AddRec(root, data);
       }
        private BNode AddRec(BNode root, int data)
        {
            if (root == null)
            {
                root = new BNode(data);
            }
            else
            {
                if (data > root.Data)
                {
                    root.Right = AddRec(root.Right, data);
                }
                else if (data < root.Data)
                {
                    root.Left = AddRec(root.Left, data);
                }
            }
            return root;
        }

        public void AddNonRec(int data)
        {
            if (root == null)
            {
                root = new BNode(data);
            }
            else
            {
                BNode current = root;
                bool added = false;
                do
                {
                    if (data < current.Data)
                    {
                        if (current.Left == null)
                        {
                            current.Left = new BNode(data);
                            added = true;
                        }
                        else
                        {
                            current = current.Left;
                        }
                    }
                    else if (data > current.Data)
                    {
                        if (current.Right == null)
                        {
                            current.Right = new BNode(data);
                            added = true;
                        }
                        else
                        {
                            current = current.Right;
                        }
                    }
                }
                while (!added);
            }
        }
        #region Sum of  Tree
        public int RecSum()
        {
            Add();
            var result = RecSum(root);
            return result;
        }
        private int RecSum(BNode root)
        {
            int sum = 0;
           
            if (root != null)
            {
                sum += RecSum(root.Right) + root.Data + RecSum(root.Left);
            }
            return sum;
        }
        #endregion

        #region Sum of  Right Tree
        public int RecRightSum()
        {
            Add();
            var result = RecRightSum(root);
            return result;
        }
        private int RecRightSum(BNode root)
        {
            int sum = 0;
           
            if (root != null && root.Right!=null)
            {
               
                sum += RecRightSum(root.Right) + root.Data;
                sum += RecRightSum(root.Left) + root.Data;
            }
            return sum;
        }
        #endregion
     
        public void isBST()
        {
            Add();
            var result = isBST(root, int.MinValue, int.MaxValue);
        }
       private bool isBST(BNode root,int min,int max){
           if (root == null)
               return true;
           if (root.Data < min || root.Data > max) {
               return false;
           }
           return isBST(root.Left, min, root.Data) && isBST(root.Right, root.Data, max);
          
       }

       public void PreOrder(BNode root) {
           if (root != null)
           {
               Console.WriteLine(root.Data);
               PreOrder(root.Left);
               PreOrder(root.Right);
              
           }

       }
         public void InOrder(BNode root){
             if (root != null) {
                 InOrder(root.Left);
                 Console.WriteLine(root.Data);
                 InOrder(root.Right);
             }
           }
         public void PostOrder(BNode root)
         {
             if (root != null)
             {
                 PostOrder(root.Left);
                 PostOrder(root.Right);
                 Console.WriteLine(root.Data);
             }
         }
        public void DepthOfBT()
        {
            Add();
            var result = DepthOfBT(root);

        }
         private int DepthOfBT(BNode node)
         {
             if (node == null)
             {
                 return 0;
             }
             else
             {
                 int lCnt = DepthOfBT(node.Left);
                 int rCnt = DepthOfBT(node.Right);
                 if (lCnt > rCnt)
                 {
                     return lCnt + 1;
                 }
                 else
                     return rCnt + 1;
             }
         }

         public int DepethOfBTQueue(BNode root) {
             var queue = new Queue<BNode>();
             int depth = 0;
             if (root != null)
             {
                 queue.Enqueue(root);
             }
             return 0;
         }

        public void Add()
        {
            Add(20);
            Add(8);
            Add(22);
            Add(4);
            Add(12);
            Add(21);
            Add(28);
            Add(10);
            Add(14);
            Add(27);
            Add(30);
        }
    }
}
