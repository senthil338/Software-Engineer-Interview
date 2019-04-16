using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class Alternating_Characters
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/alternating-characters/problem
        /// Easy 20
        /// AAAA
        /// BBBBB
        /// ABABABAB
        /// BABABA
        /// AAABBB
        /// 3
        ///4
        ///0
        ///0
        ///4
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static int alternatingCharacters(string s)
        {
            int len = s.Length - 1;
            int i = 0;
            int count = 0;
            while (len > i)
            {
                //len--;
                if (s[len] == s[len - 1])
                {

                    count++;
                }
                if (s[i] == s[i + 1] && i != len - 1 && i + 1 != len)
                {

                    count++;
                }
                i++;
                len--;

            }
            return count;

        }
    }
}
