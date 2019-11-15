using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.SortingAlgorithm
{
    /// <summary>
    /// Quicksort is a comparison sort
    /// Quicksort is a divide and conquer algorithm. 
    /// Quicksort first divides a large array into two smaller sub-arrays:
    /// the low elements and the high elements. Quicksort can then recursively sort the sub-arrays.
    /// 
    /// Average performance	O(n log n)
    /// Best-case performance	O(n log n) (simple partition)
    /// Worst-case performance O(n2)
    /// http://www.algolist.net/Algorithms/Sorting/Quicksort
    /// Worst-case space complexity	O(n) auxiliary (naive)
    /// </summary>
    public class QuickSort
    {
        /************
         *  Step 1 − Choose the highest index value has pivot
            Step 2 − Take two variables to point left and right of the list excluding pivot
            Step 3 − left points to the low index
            Step 4 − right points to the high
            Step 5 − while value at left is less than pivot move right
            Step 6 − while value at right is greater than pivot move left
            Step 7 − if both step 5 and step 6 does not match swap left and right
            Step 8 − if left ≥ right, the point where they met is new pivot
         */

        int partition(int[] arr, int left, int right)
        {
            int i = left, j = right;
            int tmp;
            int pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i] < pivot)
                    i++;
                while (arr[j] > pivot)
                    j--;
                if (i <= j)
                {
                    tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++;
                    j--;
                }
            };

            return i;
        }

        public void quickSort(int[] arr, int left, int right)
        {
           
            if (left < right)
            {
                int index = partition(arr, left, right);
                //if (left < index - 1)
                    quickSort(arr, left, index - 1);
                //if (index < right)
                    quickSort(arr, index+1, right);
            }
        }
    }
}
