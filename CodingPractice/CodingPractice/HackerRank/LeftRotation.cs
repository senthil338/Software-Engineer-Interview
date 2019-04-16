using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class LeftRotation
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem
        /// Easy 20
        /// </summary>
        /// <param name="args"></param>
        static void Main_1(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            /*   for (int j = 0; j < k; j++)
                    {
                        temp = a[0];
                        for (int i = 1; i < a.Length ; i++)
                        {
                           a[i-1] = a[i];
                        }
                        a[a.Length-1] = temp;
                    }*/
            int[] b = new int[a.Length];

            for (int i = 0; i < k; i++)
            {
                b[i] = a[(i + k) % n];
            }

            for (int j = k; j < a.Length; j++)
            {
                b[j] = a[(j + k) % n];
            }

            string value = string.Join(" ", b);
            Console.WriteLine(value);


        }
    }
}
