using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.DataStructure.Stack
{

    /// <summary>
    /// Stack implementaion using Array 
    /// LIFO (last in, first out)
    /// Avg, Worst -> Search Time : - O(n), Insert :- O(1), Delete :- O(1)
    /// Space : O(n)
    /// </summary>
    public class StackImp
    {
        //Array to store values
        // Push -> to insert value
        //Pop -> to delete value
        //count to maintain Stack level (insert -> increase , Delete -> decrease

        public const int _arraySize = 10;
        private int _size = 0;
        private int _top;
        int[] store = new int[_arraySize];

        public void Push(int data)
        {
            if (_top < _arraySize)
            {
                store[_top] = data;
                _top++;
            }
            else
            {
                return;
            }
        }

        public int Pop()
        {
            int value = 0;
            if (_top > 0)
            {
                value = store[_top];
                _top--;
            }
            return value;
        }


    }
}
