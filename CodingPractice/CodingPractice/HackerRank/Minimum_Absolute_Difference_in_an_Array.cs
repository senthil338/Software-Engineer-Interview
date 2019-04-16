using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class Minimum_Absolute_Difference_in_an_Array
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem
        /// Easy 15
        /// </summary>
        /// <param name="n"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int minimumAbsoluteDifference(int n, int[] arr)
        {
            Array.Sort(arr);
            int min = Math.Abs(arr[0] - arr[1]);
            for (int i = 0; i < n - 1; i++)
            {
                if (min > Math.Abs(arr[i] - arr[i + 1]))
                {
                    min = Math.Abs(arr[i] - arr[i + 1]);
                }
            }
            return min;

        }
    }
}
