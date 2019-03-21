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
    }
}
