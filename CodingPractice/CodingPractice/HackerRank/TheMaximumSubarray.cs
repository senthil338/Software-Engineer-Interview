using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class TheMaximumSubarray
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/maxsubarray/problem
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        static int[] maxSubarray(int[] A)
        {

            int[] result = new int[2];
            int size = A.Length;
            int max_so_far = int.MinValue,
                max_ending_here = 0;
            int totalsum = 0;
            bool isPositive = false;
            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + A[i];

                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                }
                if (A[i] > 0)
                {
                    totalsum += A[i];
                    isPositive = true;
                }

                if (max_ending_here < 0)
                    max_ending_here = 0;
            }
            if (isPositive == false)
            {
                Array.Sort(A);
                Array.Reverse(A);
                result[0] = A[0];
                result[1] = A[0];
            }
            else
            {
                result[0] = max_so_far;
                result[1] = totalsum;
            }
            return result;
        }
    }
}
