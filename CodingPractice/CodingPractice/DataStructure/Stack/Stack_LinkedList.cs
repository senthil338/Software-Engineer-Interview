using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.DataStructure
{
    public class Stack_LinkedList<T>
    {

        /// <summary>
        /// Linked List Node
        /// </summary>
        public class Node
        {
            public Node next;
            public T data;
            public Node(T data)
            {
                this.next = null;
                this.data = data;
            }
        }
        Node root;
        public void Push(T data)
        {
            if(root ==null)
            {
                root = new Node(data);
                return;
            }
            Node newNode = new Node(data);
            Node temp = root;
            newNode.next = temp;
        }

        public void Pop()
        {
            if(root == null)
            {
                return;
            }
            root = root.next;
        }

        public T Peek()
        {
            if (root == null)
            {
                Console.WriteLine("Stack is empty");
                return default(T);
            }
            else
            {
                return root.data;
            }

        }
    }
}
