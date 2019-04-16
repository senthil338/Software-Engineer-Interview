using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class Staircase
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/staircase/problem
        /// Easy 10
        /// </summary>
        /// <param name="args"></param>
        static void Main_7(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string pad = "#";
            string padResult = "";
            for (int i = 1; i <= n; i++)
            {
                padResult = pad.PadLeft(i, '#');
                padResult = padResult.PadLeft(n);
                Console.WriteLine(padResult);
            }
        }
    }
}
