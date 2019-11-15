using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class OneEditDistance
    {
        static void Main_1()
        {
            string s = "ab", t = "acb";
            var result = isOneEditDistance(s, t);
        }

        /*
         There are 3 possiblities to satisify one edit distance apart:
            Insert a character into s to get t
            Delete a character from s to get t
            Replace a character of s to get t 
            Input: s = "ab", t = "acb"
            Output: true
            Explanation: We can insert 'c' into s to get t.

            Input: s = "cab", t = "ad"
            Output: false
            Explanation: We cannot get t from s by only one step.

            Input: s = "1203", t = "1213"
            Output: true
            Explanation: We can replace '0' with '1' to get t.
         */
        public static bool isOneEditDistance(String s, String t)
        {
            
            int ns = s.Length;
            int nt = t.Length;

            // Ensure that s is shorter than t.
            if (ns > nt)
                return isOneEditDistance(t, s);

            // The strings are NOT one edit away distance  
            // if the length diff is more than 1.
            if (nt - ns > 1)
                return false;

            for (int i = 0; i < ns; i++)
                if (s[i] != t[i])
                    // if strings have the same length
                    if (ns == nt)
                        return s.Substring(i + 1).Equals(t.Substring(i + 1));
                    // if strings have different lengths
                    else
                        return s.Substring(i).Equals(t.Substring(i + 1));

            // If there is no diffs on ns distance
            // the strings are one edit away only if
            // t has one more character. 
            return (ns + 1 == nt);
        }
    }
}
