using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class WordBreak
    {
        public static void Main_1(string[] args)
        {
            HashSet<string> hash = new HashSet<string>();
            hash.Add("leet");
            hash.Add("code");
            WordBreak_1("leetcode", hash);
        }

        //public static bool wordBreak(String s, HashSet<String> wordDict)
        //{
        //    int[] pos = new int[s.Length + 1];

        //    Array.Fill(pos, -1);

        //    pos[0] = 0;

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (pos[i] != -1)
        //        {
        //            for (int j = i + 1; j <= s.Length; j++)
        //            {
        //                String sub = "";
        //                if (i + j < s.Length)
        //                {
        //                    sub = s.Substring(i, j);
        //                }
        //                else
        //                {
        //                    sub = s.Substring(i, s.Length - j);
        //                }
        //                if (wordDict.Contains(sub))
        //                {
        //                    pos[j] = i;
        //                }
        //            }
        //        }
        //    }

        //    return pos[s.Length] != -1;
        //}
        /// <summary>
        /// https://www.programcreek.com/2012/12/leetcode-solution-word-break/
        /// </summary>
        /// <param name="str"></param>
        /// <param name="dict"></param>
        /// <returns></returns>
        public static bool WordBreak_1(String str, HashSet<string> dict)
        {
            //StringBuilder sb = new StringBuilder(str);
            int start = 0, end = str.Length, counter = 2;

            for (; counter <= end; counter++)
            {
                if (dict.Contains(str.ToString().Substring(start, counter)))
                {

                    str = str.Remove(start, counter);
                    counter = 1;
                    end = str.Length;
                }
            }
            return (str.Length == 0) ? true : false;
        }
        public bool wordBreak(String s, IList<String> wordDict)
        {
            // HashSet<String> wordDictSet = new HashSet<string>()(wordDict);

            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;
            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (dp[j] && wordDict.Contains(s.Substring(j, i)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }
            return dp[s.Length];
        }

        public static bool WordBreak_1(String str, IList<string> dict)
        {
            //StringBuilder sb = new StringBuilder(str);
            int start = 0, end = str.Length, counter = 2;

            for (; counter <= end; counter++)
            {
                if (dict.Contains(str.ToString().Substring(start, counter)))
                {

                    str = str.Remove(start, counter);
                    counter = 1;
                    end = str.Length;
                }
            }
            return (str.Length == 0) ? true : false;
        }
        /// <summary>
        /// Time: O(string length * dict size).
        /// https://www.programcreek.com/2012/12/leetcode-solution-word-break/
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dict"></param>
        /// <returns></returns>
        public static bool wordBreak(String s, HashSet<String> dict)
        {
            bool[] t = new bool[s.Length + 1];
            t[0] = true; //set first to be true, why?
                         //Because we need initial state

            for (int i = 0; i < s.Length; i++)
            {
                //should continue from match position
                if (!t[i])
                    continue;

                foreach (String a in dict)
                {
                    int len = a.Length;
                    int end = i + len;
                    if (end > s.Length)
                        continue;

                    if (t[end]) continue;

                    if (i + end <= len && s.Substring(i, end).Equals(a))
                    {
                        t[end] = true;
                    }
                    else if (s.Substring(i, end - len).Equals(a))
                    {
                        t[end] = true;
                    }
                }
            }

            return t[s.Length];
        }
    }
}
