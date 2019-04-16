using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class Mini_Max_Sum
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/mini-max-sum/problem
        /// Easy 10
        /// </summary>
        /// <param name="args"></param>
        static void Main_2(String[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            //long[] number = new long[5];
            long sum = 0, min = arr[0], max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                else if (arr[i] < min)
                    min = arr[i];
                sum += arr[i];
            }

            Console.WriteLine((sum - max) + " " + (sum - min));
        }

    }
}
