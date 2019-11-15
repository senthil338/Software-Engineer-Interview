using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.DataStructure.LinkedList
{
    public class LinkedList
    {
        public class Node
        {
            internal Node Next;
            internal int Data;
        }

        Node head;
        public Node Insert(int x)
        {
            Node node = new Node();
            node.Data = x;
            if (head == null)
            {

                head = node;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
            return head;

        }

        public Node InsertAtFront(int x)
        {
            Node newNode = new Node();
            newNode.Data = x;
            newNode.Next = head;
            head = newNode;
            return head;
        }

        #region insert at Kth position
        public Node InserAtKthPosition(Node head, int position, int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            if (head == null)
            {
                newNode = head;
                newNode.Data = data;
                return newNode;
            }
            if (position == 0)
            {
                newNode.Next = head;
                newNode.Data = data;
                head = newNode;
                return head;
            }
            Node current = head;
            int currentPosition = 0;


            while (currentPosition < position - 1 && current.Next != null)
            {
                current = current.Next;
                currentPosition++;
            }

            Node temp = current.Next;
            current.Next = newNode;
            newNode.Next = temp;

            return head;


        }
        #endregion
        #region "Print Middle element"
        public void PrintMiddle()
        {
            Node slow_prt = head;
            Node fast_prt = head;
            if (head != null)
            {
                while (fast_prt != null && fast_prt.Next != null)
                {
                    fast_prt = fast_prt.Next.Next;
                    slow_prt = slow_prt.Next;
                }
                Console.WriteLine(slow_prt.Data);
            }
        }
        #endregion

        #region reverse a linked list
        /// <summary>
        /// Time Complexity: O(n)
        /// Space Complexity: O(1)
        /// </summary>
        public void ReverseList()
        {
            Node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }
        /// <summary>
        /// Second Method -> reverseUtil(list.head, null);
        /// </summary>
        /// <param name="curr"></param>
        /// <param name="prev"></param>
        /// <returns></returns>
        Node reverseUtil(Node curr, Node prev)
        {

            /* If last node mark it head*/
            if (curr.Next == null)
            {
                head = curr;

                /* Update next to prev node */
                curr.Next = prev;

                return head;
            }

            /* Save curr->next node for recursive call */
            Node next1 = curr.Next;

            /* and update next ..*/
            curr.Next = prev;

            reverseUtil(next1, curr);
            return head;
        }


        #endregion

        #region Convert Binary tree to Doubly linked list
        // A simple recursive function to  
        // convert a given Binary tree to  
        // Doubly Linked List  
        //public virtual void BToDLL(Node root)
        //{
        //    // Base cases  
        //    if (root == null)
        //    {
        //        return;
        //    }

        //    // Recursively convert right subtree  
        //    BToDLL(root.right);

        //    // insert root into DLL  
        //    root.right = head;

        //    // Change left pointer of previous head  
        //    if (head != null)
        //    {
        //        (head).left = root;
        //    }

        //    // Change head of Doubly linked list  
        //    head = root;

        //    // Recursively convert left subtree  
        //    BToDLL(root.left);
        //}
        #endregion

        #region Linked list cycle
        public bool hasCycle(Node head)
        {
            Node fast = head;
            Node slow = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (slow == fast)
                    return true;
            }

            return false;
        }

        public static bool detectLoop(Node h)
        {
            HashSet<Node> s = new HashSet<Node>();
            while (h != null)
            {
                // If we have already has this node 
                // in hashmap it means their is a cycle 
                // (Because you we encountering the 
                // node second time). 
                if (s.Contains(h))
                    return true;

                // If we are seeing the node for 
                // the first time, insert it in hash 
                s.Add(h);

                h = h.Next;
            }

            return false;
        }
        #endregion

        #region Pairwise swap
        /* Function to pairwise swap  
   elements of a linked list */
        void pairWiseSwap()
        {
            Node temp = head;

            /* Traverse only till there are atleast 2 nodes left */
            while (temp != null && temp.Next != null)
            {

                /* Swap the data */
                int k = temp.Data;
                temp.Data = temp.Next.Data;
                temp.Next.Data = k;
                temp = temp.Next.Next;
            }
        }

        /* Recursive function to pairwise swap elements of a linked list */
        void pairWiseSwap(Node head)
        {
            /* There must be at-least two nodes in the list */
            if (head != null && head.Next != null)
            {
                /* Swap the node's data with data of next node */
                swap(head, head.Next);

                /* Call pairWiseSwap() for rest of the list */
                pairWiseSwap(head.Next.Next);
            }
        }
        void swap(Node a,Node b)
        {
            Node temp = a;
            a = b;
            b = temp;
        }
        #endregion
    }
}
