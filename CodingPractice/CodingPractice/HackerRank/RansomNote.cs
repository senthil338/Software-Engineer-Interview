using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class RansomNote
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/ctci-ransom-note/problem
        /// "give me one grand today night" note := give one grand today ,o/p YES
        /// "two times three is not four" note := two times two is four o/p = No
        /// "ive got a lovely bunch of coconuts" note:= "ive got some coconuts" o/p = No
        /// </summary>
        /// <param name="magazine"></param>
        /// <param name="note"></param>
        static void checkMagazine(string[] magazine, string[] note)
        {
            //magazine
            //note
            Dictionary<string, int> counter = new Dictionary<string, int>();
            foreach (string str in magazine)
            {
                if (!counter.ContainsKey(str))
                {
                    counter.Add(str, 1);
                }
                else
                {
                    counter[str] = counter[str] + 1;
                }

            }
            foreach (string str in note)
            {
                if (counter.ContainsKey(str))
                {
                    counter[str] = counter[str] - 1;
                    if (counter[str] < 0)
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");

        }
    }
}
