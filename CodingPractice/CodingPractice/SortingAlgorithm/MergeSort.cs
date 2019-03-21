using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.SortingAlgorithm
{
    /// <summary>
    /// Worst-case performance	O(n log n)
    /// Best-case performance O(n log n) typical,
    /// Average performance	O(n log n)
    /// Worst-case space complexity	О(n) total, O(n) 
    /// https://en.wikipedia.org/wiki/Merge_sort
    /// </summary>
    public class MergeSort
    {
        // Main function that sorts arr[l..r] using
        // merge()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        public void mergeSort(int[] arr, int l, int r)
        {
            //int arr[] = {12, 11, 13, 5, 6, 7};

            if (l < r)
            {
                // Find the middle point
                int m = (l + r) / 2;

                // Sort first and second halves
                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);

                // Merge the sorted halves
                merge(arr, l, m, r);
            }
        }


        /// <summary>
        /// Merges two subarrays of arr[].
        ///  First subarray is arr[l..m]
        ///  Second subarray is arr[m+1..r]
        ///  http://quiz.geeksforgeeks.org/merge-sort/
        /// </summary>
        public void merge(int[] arr, int l, int m, int r)
        {
            // Find sizes of two subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;
            int i = 0, j = 0;
            /* Create temp arrays */
            int[] L = new int[n1];
            int[] R = new int[n2];

            /*Copy data to temp arrays*/
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];


            /* Merge the temp arrays */

            // Initial indexes of first and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged subarry array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            /* Copy remaining elements of L[] if any */
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            /* Copy remaining elements of L[] if any */
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }


    }
}
