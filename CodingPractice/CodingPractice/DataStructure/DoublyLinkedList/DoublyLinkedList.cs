using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.DataStructure.DoublyLinkedList
{
    public class DoublyLinkedList
    {
        public class Node
        {
            int Data;
            public Node Prev;
            public Node Next;
            public Node(int data)
            {
                this.Data = data;
                Prev = Next = null;
            }
        }

        Node head;
        public void Insert(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;  
            }
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
            newNode.Prev = current;
        }

        public void InsertAtFront(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head.Prev = newNode;
           
        }

    }
}
