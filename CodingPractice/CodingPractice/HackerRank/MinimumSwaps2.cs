using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class MinimumSwaps2
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/minimum-swaps-2/problem
        /// Medidum 
        /// 40
        /// 4 3 1 2 o/p = 3
        /// 2 3 4 1 5 o/p = 3
        /// 1 3 5 2 4 6 7 0/p= 3
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int minimumSwaps(int[] arr)
        {
            int i = 0;
            int swapCount = 0;
            while (i < arr.Length - 1)
            {
                while (arr[i] != i + 1)
                {
                    int swapKey = arr[i] - 1;
                    int temp = arr[i];
                    arr[i] = arr[swapKey];
                    arr[swapKey] = temp;
                    swapCount++;
                }
                i++;


            }
            return swapCount;
        }
    }
}
