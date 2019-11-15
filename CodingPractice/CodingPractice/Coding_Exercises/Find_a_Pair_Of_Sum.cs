using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Coding_Exercises
{
    class Find_a_Pair_Of_Sum
    {
        #region Method one time O(nLogn)
        /*
         Time Complexity: Depends on what sorting algorithm we use. If we use Merge Sort or 
         Heap Sort then (-)(nlogn) in worst case. If we use Quick Sort then O(n^2) in worst case.
        Auxiliary Space : Again, depends on sorting algorithm. For example auxiliary space is O(n)
        for merge sort and O(1) for Heap Sort.
         */
        static bool hasArrayTwoCandidates(int[] A,
                            int sum)
        {
            int l, r;

            /* Sort the elements */
            Array.Sort(A);

            /* Now look for the two candidates  
            in the sorted array*/
            l = 0;
            r = A.Length - 1;
            while (l < r)
            {
                if (A[l] + A[r] == sum)
                    return true;
                else if (A[l] + A[r] < sum)
                    l++;
                else // A[i] + A[j] > sum 
                    r--;
            }
            return false;
        }
        #endregion

        #region Method 2 O(n) using hash
        /// <summary>
        /// Time Complexity: O(n)
        ///Auxiliary Space: O(n) where n is size of array.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sum"></param>
        static void printpairs(int[] arr,
                       int sum)
        {
           
            HashSet<int> s = new HashSet<int>();
            for (int i = 0; i < arr.Length; ++i)
            {
                int temp = sum - arr[i];

                // checking for condition 
                if (temp >= 0 && s.Contains(temp))
                {
                    Console.Write("Pair with given sum " +
                                  sum + " is (" + arr[i] +
                                       ", " + temp + ")");
                }
                s.Add(arr[i]);
            }
        }
        #endregion
    }
}
