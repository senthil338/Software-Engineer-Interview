using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.SortingAlgorithm
{
    public class MergeTwoArray
    {
        //public static int[] merge(int[] a, int[] b)
        public static int[] merge()
        {
            int[] a = { 2, 4, 5, 7 };
            int[] b = { 3, 6, 8, 9, 10 };
            int[] answer = new int[a.Length + b.Length];
            int i = a.Length - 1, j = b.Length - 1, k = answer.Length;

            while (k > 0)
                answer[--k] =
                    (j < 0 || (i >= 0 && a[i] >= b[j])) ? a[i--] : b[j--];
            return answer;
        }

        //public static int[] mergeArray(int[] a, int[] b)
        /// <summary>
        /// Time complexity is O(m+n).
        /// </summary>
        /// <returns></returns>
        public static int[] mergeArray()
        {
            int[] a = { 2, 4, 5, 7 };
            int[] b = { 3, 6, 8, 9, 10 };

            int[] answer = new int[a.Length + b.Length];
            int i = 0, j = 0, k = 0;

            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                    answer[k++] = a[i++];

                else
                    answer[k++] = b[j++];
            }

            while (i < a.Length)
                answer[k++] = a[i++];


            while (j < b.Length)
                answer[k++] = b[j++];

            return answer;
        }
        
        #region Merge Array in same array
        public static void mergeArrayInSameArray()
        {
            int[] mPlusN = new int[] {2, 8, -1, -1, -1,
                              13, -1, 15, 20};
            int[] N = new int[] { 5, 7, 9, 25 };
            int n = N.Length;
            int m = mPlusN.Length - n;

            /*Move the m elements at the  
              end of mPlusN*/
            moveToEnd(mPlusN, m + n);

            /*Merge N[] into mPlusN[] */
            mergeArrayInSameArray(mPlusN, N, m, n);
        }

        /* Function to move m elements at  
    the end of array mPlusN[] */
        public static void moveToEnd(int[] mPlusN,
                                      int size)
        {
            int i, j = size - 1;
            for (i = size - 1; i >= 0; i--)
            {
                if (mPlusN[i] != -1)
                {
                    mPlusN[j] = mPlusN[i];
                    j--;
                }
            }
        }
        /// <summary>
        /// Let first array be mPlusN[] and other array be N[]
        ///1) Move m elements of mPlusN[] to end.
        ///2) Start from nth element of mPlusN[] and 0th
        ///  element of N[] and merge them into mPlusN[].
        ///  https://www.geeksforgeeks.org/merge-one-array-of-size-n-into-another-one-of-size-mn/
        ///  Time Complexity: O(m+n)
        /// </summary>
        /// <param name="mPlusN"></param>
        /// <param name="N"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /* Merges array N[] of size n 
           into array mPlusN[] of size m+n*/
        private static void mergeArrayInSameArray(int[] mPlusN, int[] N,
                                  int m, int n)
        {
            int i = n;

            /* Current index of i/p  
               part of mPlusN[]*/
            int j = 0;

            /* Current index of N[]*/
            int k = 0;

            /* Current index of of output mPlusN[]*/
            while (k < (m + n))
            {
                /* Take an element from mPlusN[] if  
                a) value of the picked element is smaller  
                   and we have not reached end of it  
                b) We have reached end of N[] */
                if ((i < (m + n) &&
                     mPlusN[i] <= N[j]) || (j == n))
                {
                    mPlusN[k] = mPlusN[i];
                    k++;
                    i++;
                }
                else // Otherwise take element from N[] 
                {
                    mPlusN[k] = N[j];
                    k++;
                    j++;
                }
            }
        }

        #endregion

    }
}
