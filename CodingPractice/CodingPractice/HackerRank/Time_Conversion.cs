using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class Time_Conversion
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/time-conversion/problem
        /// Easy 15
        /// </summary>
        /// <param name="args"></param>
        static void Main_6(String[] args)
        {
            string time = Console.ReadLine();

            DateTime dt;
            bool res = DateTime.TryParse(time, out dt);
            time = dt.ToString("HH:mm:ss");
            Console.WriteLine(time);
        }
    }
}
