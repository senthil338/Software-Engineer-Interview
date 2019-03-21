using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.DataStructure.Queue
{
    /// <summary>
    /// First-In-First-Out:
    /// Queue Implementation using Linked List
    /// Enqueue :- Adds an object to the end of the Queue. Add after 4
    /// Dequeue :- Removes and returns the object at the beginning of the Queue. Remove 1
    /// Peek    :- Returns the object at the beginning of the Queue without removing it. return 1 
    /// Avg, Worst -> Search Time : - O(n), Insert :- O(1), Delete :- O(1)
    /// Space : O(n)
    /// </summary>
    public class QueueImp
    {
        public class Node
        {
            public Node Next;
            public object Key;
            public Node(object key)
            {
                this.Next = null;
                this.Key = key;
            }
        }

        public Node rear { get; set; } //private
        public Node front { get; set; } //private

        public int Count { get; set; }
        public void Enqueue(object key)
        {
            Node node = new Node(key);
            if (rear == null)
            {
                front = rear = node;

            }
            else
            {
                rear.Next = node;
                rear = node;
            }
            Count++;
        }

        public object Dequeue()
        {
            if (front == null)
            {
                throw new Exception("Queue is Empty");
            }
            object data = front.Key;
            front = front.Next;
            // If front becomes NULL, then change rear also as NULL
            if (this.front == null)
                this.rear = null;

            return data;
        }
    }
}
