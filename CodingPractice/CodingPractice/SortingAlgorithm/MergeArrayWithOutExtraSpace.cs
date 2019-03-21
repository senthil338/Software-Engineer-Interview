using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.SortingAlgorithm
{
    public class MergeArrayWithOutExtraSpace
    {
        #region Merge two sorted array , array A has large enough buffer
        static void Main1(string[] args)
        {
            // MergeTwoArrayWithoutSpaceBtoA();
            //MergeTwoArrayWithoutSpace();

            int[] ar1 = { 1, 5, 9, 10, 15, 20 };
            int[] ar2 = { 2, 3, 8, 13 };
            merge(ar1, ar2, ar1.Length - 1, ar2.Length - 1);
        }
        /// <summary>
        /// You are given two sorted arrays, A and B, and A has a large enough buffer 
        /// at the end to hold B. 
        /// Write a method to merge B into A in sorted order.
        /// </summary>
        public static void MergeTwoArrayWithoutSpace()
        {
            int[] A = { 1, 3, 8, 9, 11 };
            int[] B = { 2, 4, 5, 6, 7, 0, 0, 0, 0, 0 }; // last four as place holders for the merge

            // start from the end of the larger array;
            //int idx = 8;
            int idx = B.Length - 1;
            // we also need the indices of the largest elements in both arrays
            //int idx_a = 3, idx_b = 4;
            int idx_a = A.Length - 1, idx_b = (B.Length - A.Length) - 1;

            while (idx_a >= 0)
            { // done when A has been traversed
                if (idx_b < 0 || A[idx_a] > B[idx_b])
                { // if ele


                    B[idx] = A[idx_a];
                    idx_a--;
                }
                else
                {
                    B[idx] = B[idx_b];
                    idx_b--;
                }
                idx--;
            }
        }

        public static void MergeTwoArrayWithoutSpaceBtoA()
        {
            //int[] A = { 2, 4, 5, 6, 7, 0, 0, 0, 0, 0 }; // last four as place holders for the merge
            //int[] B = { 1, 3, 8, 9, 11 };
            int[] A = { 2, 4, 7, 0, 0, 0 }; // last four as place holders for the merge
            int[] B = { 1, 3, 8 };

            // start from the end of the larger array;
            //int idx = 8;
            int idx = A.Length - 1;
            // we also need the indices of the largest elements in both arrays
            //int idx_a = 3, idx_b = 4;
            int idx_a = B.Length - 1, idx_b = (A.Length - B.Length) - 1;

            while (idx_a >= 0)
            { // done when A has been traversed
                if (idx_b < 0 || B[idx_a] > A[idx_b])
                { // if elements of b are exhausted
                    A[idx] = B[idx_a];
                    idx_a--;
                }
                else
                {
                    A[idx] = A[idx_b];
                    idx_b--;
                }
                idx--;
            }
        }
        #endregion
        #region Merge two array with O(1) extra space

        // Merge ar1[] and ar2[] with O(1) extra space
        public static void merge(int[] ar1, int[] ar2, int m, int n)
        {
            // Iterate through all elements of ar2[] starting from
            // the last element
            for (int i = n - 1; i >= 0; i--)
            {
                /* Find the smallest element greater than ar2[i]. Move all
                   elements one position ahead till the smallest greater
                   element is not found */
                int j, last = ar1[m - 1];
                for (j = m - 1; j >= 0 && ar1[j] > ar2[i]; j--)
                    ar1[j + 1] = ar1[j];

                // If there was a greater element
                if (j != m - 1)
                {
                    ar1[j + 1] = ar2[i];
                    ar2[i] = last;
                }
            }
        }
        #endregion
    }
}
