using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class Plus_Minus
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/plus-minus/problem
        /// Easy 10
        /// </summary>
        /// <param name="args"></param>
        static void Main_8(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            double zero = 0;
            double pos = 0;
            double neg = 0;
            double zeroSum = 0;
            double posSum = 0;
            double negSum = 0;
            int totalLen = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    zero = zero + 1;
                }
                else if (arr[i] < 0)
                {
                    neg = neg + 1;
                }
                else if (arr[i] > 0)
                {
                    pos = pos + 1;
                }

            }
            zeroSum = zero / totalLen;
            posSum = pos / totalLen;
            negSum = neg / totalLen;

            Console.WriteLine(Math.Round(posSum, 6));
            Console.WriteLine(Math.Round(negSum, 6));
            Console.WriteLine(Math.Round(zeroSum, 6));
        }
    }
}
