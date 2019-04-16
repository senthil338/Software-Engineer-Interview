using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class CommonChild
    {
        /// <summary>
        /// s1=HARRY, s2=SALLY :o/p = 2
        /// s1 = AA, s2 BB :o/p = 0
        /// s1 = SHINCHAN, s2 = NOHARAAA : o/p=3
        /// s1 = ABCDEF, s2 = FBDAMN
        /// https://www.hackerrank.com/challenges/common-child/problem
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        static int commonChild(string s1, string s2)
        {

            int m = s1.Length;
            int n = s2.Length;
            int[,] L = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;
                    else if (s1[i - 1] == s2[j - 1])
                        L[i, j] = L[i - 1, j - 1] + 1;
                    else
                        L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                }
            }
            return L[m, n];
        }
    }
}
