using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class NewYearChaos
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/new-year-chaos/problem
        /// Medium 40
        /// </summary>
        /// <param name="q"></param>
        // Complete the minimumBribes function below.
        static void minimumBribes(int[] q)
        {
            int n = q.Length;
            int i, j, temp;
            bool swapped;
            Dictionary<int, int> res = new Dictionary<int, int>();
            int total = 0;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (q[j] > q[j + 1])
                    {

                        total++;
                        if (!res.ContainsKey(q[j]))
                        {
                            res.Add(q[j], 1);
                        }
                        else
                        {
                            res[q[j]]++;

                            if (res[q[j]] >= 3)
                            {
                                Console.WriteLine("Too chaotic");
                                return;
                            }
                        }

                        temp = q[j];
                        q[j] = q[j + 1];
                        q[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
            Console.WriteLine(total);

        }

    }
}
