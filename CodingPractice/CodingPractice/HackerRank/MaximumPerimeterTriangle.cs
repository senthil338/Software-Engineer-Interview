using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class MaximumPerimeterTriangle
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/maximum-perimeter-triangle/problem
        /// </summary>
        /// <param name="sticks"></param>
        /// <returns></returns>
        static int[] maximumPerimeterTriangle(int[] sticks)
        {
            Array.Sort(sticks);
            int i = sticks.Length - 3;
            while (i >= 0 && (sticks[i] + sticks[i + 1] <= sticks[i + 2]))
            {
                i -= 1;
            }


            if (i >= 0)
                return new int[] { sticks[i], sticks[i + 1], sticks[i + 2] };
            else
                return new int[] { -1 };


        }

    }
}
