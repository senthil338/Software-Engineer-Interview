using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.StringManipulation
{
    public class StringManipulations
    {
        #region "Compination of all string"
        /// <summary>
        /// abc -> a,ab,abc,ac,b,bc,c
        /// </summary>
        public static void CombinationOfString(string str)
        {
            combine(str, new System.Text.StringBuilder(), 0);
        }

        /// <summary>
        /// abc -> a,ab,abc,ac,b,bc,c
        /// </summary>
        /// <param name="instr"></param>
        /// <param name="outstr"></param>
        /// <param name="index"></param>
        private static void combine(String instr, StringBuilder outstr, int index)
        {

            for (int i = index; i < instr.Length; i++)
            {
                outstr.Append(instr[i]);
                System.Console.WriteLine(outstr);
                combine(instr, outstr, i + 1);
                outstr.Length = outstr.Length - 1;

            }
        }



        #endregion

        #region "Anagram"
        /// <summary>
        /// Check whether two Strings are Anagrams
        /// For example, “abcd” and “dabc” are anagram of each other.
        /// Only the order of characters can be different
        /// </summary>
        public static bool Anagram()
        {
            string str1 = "TOMMARVOLORIDDLE".ToLower();
            string str2 = "IAMLORDVOLDEMORT".ToLower();
            int[] num1 = new int[26];
            int[] num2 = new int[26];
            for (int i = 0; i < str1.Length; i++)
            {
                num1[str1[i] - 'a']++;
            }

            for (int j = 0; j < str1.Length; j++)
            {
                num1[str2[j] - 'a']++;
            }

            for (int i = 0; i < 26; i++)
            {
                if (num1[i] != num2[i])
                    return false;
            }
            return true;

        }
        #endregion

        #region string permutation
        /// <summary>
        /// stting permutation:- ABC to ABC ACB BAC BCA CBA CAB
        /// Backtracking
        /// Time Complexity: O(n*n!) Note that there are n! 
        /// permutations and it requires O(n) time to print a a permutation.
        /// Auxiliary Space: O(0) if we dont consider stack space
        /// </summary>
        /// <param name="str"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        public void permutation(string str, int l, int r)
        {
            if (l == r)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = Swap(str, l, i);
                    permutation(str, l + 1, r);
                    str = Swap(str, l, i);
                }
            }

        }

        private string Swap(string str, int l, int r)
        {
            char temp;
            temp = str[l];
            char[] charArray = str.ToCharArray();
            charArray[l] = str[r];
            charArray[r] = temp;
            return charArray.ToString();
            // str[l] = str[r];

        }
        #endregion

        #region Is Palindrome
        /// <summary>
        /// Palindrome 
        /// Given a string, we need to check whether it is possible to make this string a 
        /// palindrome. 
        /// </summary>
        /// <returns></returns>
        public static bool PalindromeFinder()
        {
            string str = "abcba";
            int low = 0;
            int high = str.Length - 1;
            while (low < high)
            {
                if (str[low] == str[high])
                {
                    low++;
                    high--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region int permutaion
        public static int IntPermutaion(int n, int[] arr)
        {
            // arr. 

            Array.Sort(arr);
            Array.Reverse(arr);
            int min = Math.Abs(arr[0] - arr[1]);
            for (int i = 0; i < n - 1; i++)
            {
                if (min > Math.Abs(arr[i] - arr[i + 1]))
                {
                    min = Math.Abs(arr[i] - arr[i + 1]);
                }
            }
            return min;
        }
        #endregion

        #region Longest Common Substring without repeating Char
        public static int LongestCommonSubStringWithOutRepeatingChar(string s)
        {
            int len = s.Length;
            char[] str = s.ToCharArray();
            int start = 0;
            int max = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < len; i++)
            {
                if (map.ContainsKey(str[i]) == true && map[str[i]] >= start)
                {
                    start = map[str[i]] + 1;
                }
                map[str[i]] = i;
                max = Math.Max(max, i - start + 1);
            }
            return max;
        }
        #endregion

        #region String permutaion
        public static void stringPermutation(string str)
        {
            str = "ABC";

            permutation(str, "");
        }

        private static void permutation(string str, string pre)
        {
            if (str.Length == 0)
            {
                Console.WriteLine(pre);
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    string rem = str.Substring(0, i) + str.Substring(i + 1);
                    permutation(rem, pre + str[i]);
                }
            }
        }

        #endregion

        #region RemoveDuplicateChars
        static string RemoveDuplicateChars(string key)
        {
            // --- Removes duplicate chars using string concats. ---
            // Store encountered letters in this string.
            string table = "";

            // Store the result in this string.
            string result = "";

            // Loop over each character.
            foreach (char value in key)
            {
                // See if character is in the table.
                if (table.IndexOf(value) == -1)
                {
                    // Append to the table and the result.
                    table += value;
                    result += value;
                }
            }
            return result;
        }
        #endregion

        #region reverse a string
        public static string Reverse(string x)
            {
                string result = "";
                for (int i = x.Length - 1; i >= 0; i--)
                    result += x[i];
                return result;

              
            }
        #endregion
        #region number of words in a string
        public static int Count(string x)
        {
            int result = 0;

            //Trim whitespace from beginning and end of string
            x = x.Trim();

            //Necessary because foreach will execute once with empty string returning 1
            if (x == "")
                return 0;

            //Ensure there is only one space between each word in the passed string
            while (x.Contains("  "))
                x = x.Replace("  ", " ");

            //Count the words
            foreach (string y in x.Split(' '))
                result++;

            return result;
        }
        #endregion

        #region all possible substrings from a string
        /// <summary>
        /// https://www.geeksforgeeks.org/program-print-substrings-given-string/
        /// abc -> a,b,c,ab,bc,                           abc 
        /// </summary>
        static void possibleSubstring()
        {
            string value = "rstuvwxyz";
            // Avoid full length.
            for (int length = 1; length < value.Length; length++)
            {
                // End index is tricky.
                for (int start = 0; start <= value.Length - length; start++)
                {
                    string substring = value.Substring(start, length);
                    Console.WriteLine(substring);
                }
            }
        }
        #endregion

        #region Number of substrings of a string
        /// <summary>
        /// abc-> a,b,c,ab,bc,abc -> 6
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static int countNonEmptySubstr(string str)
        {
            int n = str.Length;
            return n * (n + 1) / 2;
        }
        #endregion

    }
}
