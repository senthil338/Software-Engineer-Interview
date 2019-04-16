using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class Compare_the_Triplets
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/compare-the-triplets/problem
        /// Easy 10
        /// </summary>
        /// <param name="args"></param>
        static void Main_10(String[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            int scoreA = 0;
            int scoreB = 0;
            if (a0 > b0)
            {
                scoreA = 1;
            }

            else if (a0 < b0)
            {
                scoreB = 1;
            }


            if (a1 > b1)
            {
                scoreA = scoreA + 1;
            }

            else if (a1 < b1)
            {
                scoreB = scoreB + 1;
            }


            if (a2 > b2)
            {
                scoreA = scoreA + 1;
            }

            else if (a2 < b2)
            {
                scoreB = scoreB + 1;
            }
            Console.WriteLine(scoreA + " " + scoreB);
        }
    }
}
