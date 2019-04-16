using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class SpecialPalindromeAgain
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/special-palindrome-again/problem
        /// str = asasd, o/p = 7
        /// str = abcbaba , o/p = 10
        /// str = aaaa , o/p = 10
        /// </summary>
        /// <param name="n"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        static long substrCount(int n, string str)
        {
            // create an empty set to store all  palindromic substrings
            ArrayList set = new ArrayList();

            for (int i = 0; i < str.Length; i++)
            {
                // find all odd length palindrome with str[i] as mid point

                expandSearch(str, i, i, set);

                // find all even length palindrome with str[i] and str[i+1]
                // as its mid points
                expandSearch(str, i, i + 1, set);
            }
            long count = set.Count + str.Length;
            return count;
        }
        private static bool allCharactersSame(string s)
        {
            int n = s.Length;
            for (int i = 1; i < n; i++)
                if (s[i] != s[0])
                    return false;

            return true;
        }
        private static void expandSearch(String str, int low, int high, ArrayList set)
        {
            string palindrome = string.Empty;
            String left = string.Empty;
            String right = string.Empty;
            while (low >= 0 && high < str.Length && str[low] == str[high])
            {

                // if(str.Substring())
                palindrome = str.Substring(low, high - low + 1);
                // if (compare.Length > 3 && compare.Length % 2 !=0) // compare between char from mid
                {
                    left = palindrome.Substring(0, palindrome.Length / 2);
                    right = palindrome.Substring(palindrome.Length - left.Length);
                }
                if (left == right && palindrome.Length > 1 && allCharactersSame(left) == true && allCharactersSame(right) == true) // uncomment to make it normal palindrome
                    set.Add(palindrome);
                low--;
                high++;

            }

        }
    }
}
