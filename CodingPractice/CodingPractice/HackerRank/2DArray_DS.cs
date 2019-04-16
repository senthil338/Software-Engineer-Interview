using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class _2DArray_DS
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/2d-array/problem
        /// Easy 15
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int hourglassSum(int[][] arr)
        {
            int sum = 0;
            int result = int.MinValue;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr.Length - 2; j++)
                {
                    sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if (result < sum)
                    {
                        result = sum;
                    }
                }
            }
            return result;

        }
    }
}
