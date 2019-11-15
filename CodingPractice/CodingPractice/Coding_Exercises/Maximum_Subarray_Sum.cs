using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Coding_Exercises
{
    class Maximum_Subarray_Sum
    {
        /*The Kadane’s Algorithm for this problem takes O(n) time
         https://www.geeksforgeeks.org/largest-sum-contiguous-subarray/
         Simple idea of the Kadane’s algorithm is to look for all positive contiguous segments of the array 
         (max_ending_here is used for this). And keep track of maximum sum contiguous segment among all
         positive segments (max_so_far is used for this). Each time we get a positive sum compare it with 
         max_so_far and update max_so_far if it is greater than max_so_far
         */
        static int maxSubArraySum(int[] a,
                         int size)
        {
            int max_so_far = 0,
                max_ending_here = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + a[i];
                if (max_ending_here < 0)
                    max_ending_here = 0;

                /* Do not compare for all 
                elements. Compare only  
                when max_ending_here > 0 */
                else if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;
            }
            return max_so_far;
        }

        #region to handle Negative number

        static int maxSubArraySum_Negative(int[] a, int size)
        {
            int max_so_far = a[0];
            int curr_max = a[0];

            for (int i = 1; i < size; i++)
            {
                curr_max = Math.Max(a[i], curr_max + a[i]);
                max_so_far = Math.Max(max_so_far, curr_max);
            }

            return max_so_far;
        }

        // Drive code  
        public static void Main_2()
        {
            int[] a = { -2, -3, 4, -1, -2, 1, 5, -3 };
            int n = a.Length;
            Console.Write("Maximum contiguous sum is "
                               + maxSubArraySum(a, n));
        }
        #endregion

        #region Largest sum contiguous increasing subarray
        /// <summary>
        /// https://www.geeksforgeeks.org/largest-sum-contiguous-increasing-subarray/
        /// Time Complexity : O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static int largestSum(int[] arr,
                         int n)
        {

            // Initialize result 
            int result = -9999999;

            // Note that i is incremented by  
            // inner loop also, so overall  
            // time complexity is O(n) 
            for (int i = 0; i < n; i++)
            {

                // Find sum of longest increasing  
                // subarray starting from arr[i] 
                int curr_sum = arr[i];
                while (i + 1 < n &&
                       arr[i + 1] > arr[i])
                {
                    curr_sum += arr[i + 1];
                    i++;
                }

                // Update result if required 
                if (curr_sum > result)
                    result = curr_sum;
            }

            // required largest sum 
            return result;
        }
        #endregion
    }
}
