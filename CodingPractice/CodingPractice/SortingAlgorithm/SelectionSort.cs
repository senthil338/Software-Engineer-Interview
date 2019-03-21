using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.SortingAlgorithm
{
    /// <summary>
    /// Worst-case performance	О(n2)
    /// Best-case performance	О(n2)
    /// Average performance	О(n2)
    /// Worst-case space complexity	О(n) total, O(1) auxiliary
    /// The selection sort algorithm sorts an array by repeatedly finding the minimum element
    /// (considering ascending order) from unsorted part and putting it at the beginning. 
    /// The algorithm maintains two subarrays in a given array.
    /// 1) The subarray which is already sorted.
    /// 2) Remaining subarray which is unsorted.
    /// https://en.wikipedia.org/wiki/Selection_sort
    /// </summary>
    public class SelectionSort
    {
        public static void selectionSort()
        {
            int[] array = { 2, 1, 4, 6, 2, 56, 9, 3 };
            int n = array.Length;
            int c = 0, position = 0, d = 0, swap = 0;
            for (c = 0; c < (n - 1); c++)
            {
                position = c;

                for (d = c + 1; d < n; d++)
                {
                    if (array[position] > array[d])
                        position = d;
                }
                if (position != c)
                {
                    swap = array[c];
                    array[c] = array[position];
                    array[position] = swap;
                }
            }
        }
    }
}
