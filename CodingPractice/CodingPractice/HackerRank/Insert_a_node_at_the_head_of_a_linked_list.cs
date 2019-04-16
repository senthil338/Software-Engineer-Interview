using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class Insert_a_node_at_the_head_of_a_linked_list
    {
         public class Node
        {
          public  int Data;
           public Node Next;
        }
        /// <summary>
        /// https://www.hackerrank.com/challenges/insert-a-node-at-the-head-of-a-linked-list/problem
        /// Easy 5
        /// </summary>
        /// <param name="head"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static Node Insert(Node head, int x)
        {
            Node newNode = new Node();
            newNode.Data = x;
            newNode.Next = head;
            return newNode;
        }
    }
}
