using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class Palindrom2
    {
        class Solution
        {
            // time O(S.length+T.length) ,space O(T.Length)
            public String customSortString(String S, String T)
            {
                StringBuilder sb = new StringBuilder();
                int[] frequency = new int[26];
                foreach(char token in T.ToCharArray())
                {
                    frequency[token - 'a']++;
                }

                foreach (char token in S.ToCharArray())
                {
                    while (frequency[token - 'a'] != 0)
                    {
                        sb.Append(token);
                        frequency[token - 'a']--;
                    }
                }

                for (int i = 0; i < 26; i++)
                {
                    while (frequency[i] > 0)
                    {
                        sb.Append((char)(i + 'a'));
                        frequency[i]--;
                    }
                }
                return sb.ToString();
            }
        }
    }
}
