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
            combine(str,new System.Text.StringBuilder(), 0);
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

        #region Palindtome
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
    }
}
