using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class Apple_and_Orange
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/apple-and-orange/problem
        /// Easy 10
        /// </summary>
        /// <param name="args"></param>
        static void Main_3(String[] args)
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int t = Convert.ToInt32(tokens_s[1]);
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] apple_temp = Console.ReadLine().Split(' ');
            int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
            string[] orange_temp = Console.ReadLine().Split(' ');
            int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);
            int apple_count = 0;
            int orange_count = 0;
            for (int i_app = 0; i_app < m; i_app++)
            {
                if (a + apple[i_app] >= s && a + apple[i_app] <= t)
                {
                    apple_count++;
                }
            }
            Console.WriteLine(apple_count);
            for (int i_ora = 0; i_ora < n; i_ora++)
            {
                if (b + orange[i_ora] >= s && b + orange[i_ora] <= t)
                {
                    orange_count++;
                }
            }
            Console.WriteLine(orange_count);

        }
    }
}
