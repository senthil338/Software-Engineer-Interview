using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    /// <summary>
    /// Arr[(i -1) / 2] returns its parent node.
    ///Arr[(2 * i) + 1] returns its left child node.
    ///Arr[(2 * i) + 2] returns its right child node.
    ///1. getMin(): It returns the root element of Min Heap. Time Complexity of this operation is O(1).
    ///2. extractMin() : Removes the minimum element from MinHeap.Time Complexity of this 
    ///Operation is O(Log n) as this operation needs to maintain the heap property 
    ///(by calling heapify()) after removing root.
    ///3. insert(): Inserting a new key takes O(Log n) time.We add a new key at the end of the tree.If new key is larger than its parent, then we don’t need to do anything.Otherwise,
    ///we need to traverse up to fix the violated heap property.
    /// </summary>
    class Min_Heap
    {
        public class MinHeap
        {
            private int[] Heap;
            private int size;
            private int maxsize;

            private static int FRONT = 1;

            public MinHeap(int maxsize)
            {
                this.maxsize = maxsize;
                this.size = 0;
                Heap = new int[this.maxsize + 1];
                Heap[0] = int.MinValue;
            }

            // Function to return the position of 
            // the parent for the node currently 
            // at pos 
            private int parent(int pos)
            {
                return pos / 2;
            }

            // Function to return the position of the 
            // left child for the node currently at pos 
            private int leftChild(int pos)
            {
                return (2 * pos);
            }

            // Function to return the position of 
            // the right child for the node currently 
            // at pos 
            private int rightChild(int pos)
            {
                return (2 * pos) + 1;
            }

            // Function that returns true if the passed 
            // node is a leaf node 
            private bool isLeaf(int pos)
            {
                if (pos >= (size / 2) && pos <= size)
                {
                    return true;
                }
                return false;
            }

            // Function to swap two nodes of the heap 
            private void swap(int fpos, int spos)
            {
                int tmp;
                tmp = Heap[fpos];
                Heap[fpos] = Heap[spos];
                Heap[spos] = tmp;
            }

            // Function to heapify the node at pos 
            private void minHeapify(int pos)
            {

                // If the node is a non-leaf node and greater 
                // than any of its child 
                if (!isLeaf(pos))
                {
                    if (Heap[pos] > Heap[leftChild(pos)]
                        || Heap[pos] > Heap[rightChild(pos)])
                    {

                        // Swap with the left child and heapify 
                        // the left child 
                        if (Heap[leftChild(pos)] < Heap[rightChild(pos)])
                        {
                            swap(pos, leftChild(pos));
                            minHeapify(leftChild(pos));
                        }

                        // Swap with the right child and heapify 
                        // the right child 
                        else
                        {
                            swap(pos, rightChild(pos));
                            minHeapify(rightChild(pos));
                        }
                    }
                }
            }

            // Function to insert a node into the heap 
            public void insert(int element)
            {
                if (size >= maxsize)
                {
                    return;
                }
                Heap[++size] = element;
                int current = size;

                while (Heap[current] < Heap[parent(current)])
                {
                    swap(current, parent(current));
                    current = parent(current);
                }
            }

            // Function to print the contents of the heap 
            public void print()
            {
                for (int i = 1; i <= size / 2; i++)
                {
                    Console.WriteLine(" PARENT : " + Heap[i]
                                     + " LEFT CHILD : " + Heap[2 * i]
                                     + " RIGHT CHILD :" + Heap[2 * i + 1]);

                }
            }

            // Function to build the min heap using 
            // the minHeapify 
            public void minHeap()
            {
                for (int pos = (size / 2); pos >= 1; pos--)
                {
                    minHeapify(pos);
                }
            }

            // Function to remove and return the minimum 
            // element from the heap 
            public int remove()
            {
                int popped = Heap[FRONT];
                Heap[FRONT] = Heap[size--];
                minHeapify(FRONT);
                return popped;
            }

            public static void main_2(String[] arg)
            {
              
                Console.WriteLine("The Min Heap is ");
                MinHeap minHeap = new MinHeap(15);
                minHeap.insert(5);
                minHeap.insert(3);
                minHeap.insert(17);
                minHeap.insert(10);
                minHeap.insert(84);
                minHeap.insert(19);
                minHeap.insert(6);
                minHeap.insert(22);
                minHeap.insert(9);
                minHeap.minHeap();

                minHeap.print();
                Console.WriteLine("The Min val is " + minHeap.remove());
            }
        }
    }
}
