using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class SherlockAndTheValidString
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem
        /// s = aabbcd, o/p = NO
        /// s = aabbccddeefghi, o/p = NO
        /// s = abcdefghhgfedecba, o/p = YES
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static string isValid(string s)
        {
            int[] chars = new int[26];
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                chars[s[i] - 'a']++;
            }
            int temp = chars[0];
            for (int i = 1; i < 25; i++)
            {
                if (temp != chars[i] && chars[i] != 0)
                {
                    if (chars[i] > temp)
                    {
                        if (chars[i] - 1 == temp || chars[i] - 1 > temp)
                        {
                            count++;
                        }
                    }
                    else
                    {
                        if (chars[i] - 1 == 0)
                        {
                            count++;
                        }
                        else if (chars[i] - 1 != temp)
                        {
                            count++;
                        }

                    }
                }
                if (count > 1)
                {
                    return "NO";
                }

            }
            return "YES";

        }
    }
}
