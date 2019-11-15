using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class ValidPalindrome
    {
        class Solution
        {
            /// <summary>
            /// https://leetcode.com/explore/interview/card/facebook/5/array-and-strings/289/
            /// </summary>
            /// <param name="s"></param>
            /// <param name="i"></param>
            /// <param name="j"></param>
            /// <returns></returns>
            public bool isPalindromeRange(String s, int i, int j)
            {
                for (int k = i; k <= i + (j - i) / 2; k++)
                {
                    if (s[k] != s[j - k + i]) return false;
                }
                return true;
            }
            public bool validPalindrome(String s)
            {
                for (int i = 0; i < s.Length / 2; i++)
                {
                    if (s[i] != s[s.Length - 1 - i])
                    {
                        int j = s.Length - 1 - i;
                        return (isPalindromeRange(s, i + 1, j) ||
                                isPalindromeRange(s, i, j - 1));
                    }
                }
                return true;
            }
        }
    }
}
