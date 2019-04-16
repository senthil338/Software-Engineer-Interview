using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class Print_the_Elements_of_a_Linked_List
    {
        public class Node
        {
           public int Data;
          public  Node Next;
        }
        /// <summary>
        /// https://www.hackerrank.com/challenges/print-the-elements-of-a-linked-list/problem
        /// Easy 5
        /// </summary>
        /// <param name="head"></param>
        public static void Print(Node head)
        {
            while (head != null)
            {
                Console.WriteLine(head.Data);
                head = head.Next;
            }
        }
    }
}
