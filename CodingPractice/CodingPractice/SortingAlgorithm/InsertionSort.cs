using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.SortingAlgorithm
{
    /// <summary>
    /// Worst-case performance	О(n2) comparisons, swaps
    /// Best-case performance	O(n) comparisons, O(1) swaps
    /// Average performance	О(n2) comparisons, swaps
    /// Worst-case space complexity	О(n) total, O(1) auxiliary
    /// https://en.wikipedia.org/wiki/Insertion_sort
    /// Each iteration, insertion sort removes one element from the input data, 
    /// finds the location it belongs within the sorted list, and inserts it there. 
    /// It repeats until no input elements remain.
    /// </summary>
    public class InsertionSort
    {
        /* Function to sort an array using insertion sort*/
        public void insertionSort(int[] arr, int n)
        {
            int i, key, j;
            for (i = 1; i < n; i++)
            {
                key = arr[i];
                j = i - 1;

                /* Move elements of arr[0..i-1], that are
                   greater than key, to one position ahead
                   of their current position */
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
    }
}
