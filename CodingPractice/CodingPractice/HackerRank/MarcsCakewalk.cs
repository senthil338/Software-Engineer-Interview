using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class MarcsCakewalk
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/marcs-cakewalk/problem
        /// Easy 15
        /// </summary>
        /// <param name="calorie"></param>
        /// <returns></returns>
        static long marcsCakewalk(int[] calorie)
        {
            Array.Sort(calorie);
            Array.Reverse(calorie);
            long sum = 0;
            for (int i = 0; i < calorie.Length; i++)
            {
                sum = sum + (calorie[i] * (long)Math.Pow(2, i));
            }
            return sum;

        }
    }
}
