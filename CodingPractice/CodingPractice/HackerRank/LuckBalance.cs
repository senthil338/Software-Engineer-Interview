using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingPractice.HackerRank
{
    class LuckBalance
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/luck-balance/problem
        /// Easy 20
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <param name="contests"></param>
        /// <returns></returns>
        static int luckBalance(int n, int k, int[][] contests)
        {
            contests = contests.OrderByDescending(inner => inner[1]).ThenByDescending(inner => inner[0]).ToArray();
            int luckofSum = 0;

            //lose k no of contest
            for (int i = 0; i < n; i++)
            {
                if (contests[i][1] == 1 && k > i)
                {
                    luckofSum = luckofSum + contests[i][0];
                }
                else if (contests[i][1] == 0)
                {
                    luckofSum = luckofSum + contests[i][0];
                }
                else if (contests[i][1] == 1 && k <= i)
                {
                    luckofSum = luckofSum - contests[i][0];
                }
            }
            return luckofSum;
        }

    }
}
