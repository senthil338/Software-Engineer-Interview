using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class Diagonal_Difference
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/diagonal-difference/problem
        /// Easy 10 
        /// </summary>
        /// <param name="args"></param>
        static void Main_9(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            int sumX = 0;
            int sumY = 0;
            int j = a.Length - 1;
            for (int i = 0; i < a.Length; i++)
            {

                sumX += a[i][i];
                sumY += a[j][i];
                j--;

            }
            int total = Math.Abs(sumX - sumY);
            Console.WriteLine(total);
        }
    }
}
