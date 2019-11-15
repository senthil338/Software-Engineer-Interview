using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Coding_Exercises
{
   public class Stair_Case
    {
        public static void Steps()
        {
            int[] X = { 1, 2, 3 };
            int result = Steps(4, X);
            int result1 = Steps_Mem(4, X);
        }
        #region Stair Case problem , very slow
        /// <summary>
        /// https://dailycodingproblem.com/blog/staircase-problem/
        /// https://www.techiedelight.com/find-total-ways-reach-nth-stair-with-atmost-m-steps/
        ///  very slow (O(|X|^N)) since we are repeating computations again. 
        ///  We can use dynamic programming to speed it up.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="X"></param>
        /// <returns></returns>
        private static int Steps(int n, int[] X)
        {
            if (n < 0)
            {
                return 0;
            }
            else if (n == 0) return 1;
            else
            {
                int count = 0;
                for(int i = 0; i < X.Length; i++)
                {
                    count += Steps(n - X[i], X);
                }
                return count;
            }
        }
        #endregion

        #region Memerozation 
        static int[] mem = new int[100];
        private static int Steps_Mem(int n,int[] X)
        {
            int[] arr = new int[n + 1];
            arr[0] = 1;
            arr[1] = 1;
            arr[2] = 2;

            for (int i = 3; i < n + 1; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
            }
            return arr[n];
        }
        #endregion
    }
}
