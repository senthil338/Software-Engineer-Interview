using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    /*
   
  Input: array of integer value

Output: print each iteration by subtracting the smallest elements till array becomes empty

For example:
For input array: 4, 3, 5, 8, 12

At each iteration, find minimum number and subtract it from element and print non zero elements
1 2 5 9    (Subtracted 3 from each elements)
1 4 8       (Subtracted 1 from each elements)
3 7          (Subtracted 1 from each elements)
4             (Subtracted 3 from each elements)

For the above problem, naive approach is to find the minimum in each iteration, subtracting it and copy it in new memory.

There are 2 place where you can improve on memory as well as the time complexity (less iteration).

1. Identify minimum value while subtracting the minimum value

2. Do not copy element to another array, just simple store the last index value and decrease it in recursive call. 
    */
    public class SliceDown
    {
        static void Main_1(string[] args)
        {
            SliceDown sliceDown = new SliceDown();
            int[] a = { 15, 12, 10, 5, 3 };
            int smallNumber = sliceDown.FindSmallest(a);
            sliceDown.sliceDown(a, a.Length, smallNumber);
            Console.ReadLine();
        }

        private void sliceDown(int[] a, int range, int smallestIndex)
        {

            int new_position = 0;
            int smallNumber = FindSmallest(a);
            int new_smallestIndex = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (smallNumber != a[i])
                {
                    a[new_position] = a[i] - smallNumber;
                    if (new_smallestIndex < 0)
                    {
                        new_smallestIndex = new_position;
                    }
                    else if (a[new_position] < a[new_smallestIndex])
                    {
                        new_smallestIndex = new_position;
                    }

                    new_position++;
                }
            }
            printArray(a, new_position);
            if (new_position > 1)
            {
                sliceDown(a, new_position, new_smallestIndex);
            }

        }
        private static void printArray(int[] a, int range)
        {
            for (int i = 0; i < range; i++)
            {
                Console.WriteLine(a[i] + " ");
            }

        }

        private int FindSmallest(int[] input)
        {
            int smallestIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[smallestIndex] > input[i])
                {
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }

    }
}
