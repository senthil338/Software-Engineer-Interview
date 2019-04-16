using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingPractice.HackerRank
{
    class GridChallenge
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/grid-challenge/problem
        /// Easy 20
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        static string gridChallenge(string[] grid)
        {
            int[] count = new int[grid.Length];
            for (int i = 0; i < grid.Length; i++)
            {
                string test = sortedString(grid[i].ToArray());
                grid[i] = test;
            }
            //check column sortered or not
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    count[i] = count[i] + (int)grid[i][j];

                }
                if (i > 0 && count[i - 1] > count[i])
                {
                    return "NO";
                }
                else if (i > 0)
                {
                    for (int k = 0; k < grid[i].Length; k++)
                    {
                        if (string.Compare(grid[i - 1][k].ToString(), grid[i][k].ToString()) > 0)
                        {
                            return "NO";
                        }
                    }

                }

            }
            return "YES";

        }

        private static string sortedString(char[] str)
        {
            Array.Sort(str);
            return string.Join("", str);

        }

    }
}
