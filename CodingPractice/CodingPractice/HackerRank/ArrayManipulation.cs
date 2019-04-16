using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class ArrayManipulation
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/crush/problem
        /// 1 2 100
        ///2 5 100
        ///3 4 100
        ///o/p = 200;
        ///Hard 60
        /// </summary>
        /// <param name="n"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
       public static long arrayManipulation(int n, int[][] queries)
        {
            int m = queries.Length;
            long[] numList = new long[n + 1];
            for (int i = 0; i < m; i++)
            {
                //string[] opString = Console.ReadLine().Split(' ');
                int a = queries[i][0];
                int b = queries[i][1];
                long k = queries[i][2];
                numList[a] += k;
                if (b + 1 <= n) numList[b + 1] -= k;
            }
            long tempMax = 0;
            long max = 0;
            for (int i = 1; i <= n; i++)
            {
                tempMax += numList[i];
                if (tempMax > max) max = tempMax;
            }
            return max;
        }
    }
}
