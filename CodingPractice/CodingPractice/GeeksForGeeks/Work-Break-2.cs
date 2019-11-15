using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class Work_Break_2
    {
        /*
         Time complexity : O(n^3). Two loops are required to fill dp array and one loop for appending a list .

        Space complexity : O(n^3) Length of dp array is nn and each value of \text{dp}dp array contains a list of string i.e. n^2  space.
             */
        public List<String> wordBreak(String s, HashSet<String> wordDict)
        {
            List<String>[] dp = new List<String>[s.Length + 1];
            List<String> initial = new List<String>();
            initial.Add("");
            dp[0] = initial;
            for (int i = 1; i <= s.Length; i++)
            {
                List<String> list = new List<String>();
                for (int j = 0; j < i; j++)
                {
                    if (dp[j].Count > 0 && wordDict.Contains(s.Substring(j, i)))
                    {
                        foreach (String l in dp[j])
                        {
                            list.Add(l + (l.Equals("") ? "" : " ") + s.Substring(j, i));
                        }
                    }
                }
                dp[i] = list;
            }
            return dp[s.Length];
        }
    }
}
