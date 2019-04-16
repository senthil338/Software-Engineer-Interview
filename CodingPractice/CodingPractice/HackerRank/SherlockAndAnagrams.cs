using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingPractice.HackerRank
{
    class SherlockAndAnagrams
    {
        /// <summary>
        /// abba o/p = 4
        /// abcd o/p = 0
        /// ifailuhkqq o/p = 3
        /// kkkk o/p = 10
        /// cdcd o/p = 5
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static int sherlockAndAnagrams(string s)
        {
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {

                for (int j = 1; j < s.Length - i; j++)
                {
                    string str = s.Substring(i, j);

                    byte[] bytes = Encoding.ASCII.GetBytes(str);
                    int sum = bytes.Sum(d => d);
                    //char[] strArr = str.ToCharArray();
                    // Array.Sort(strArr);
                    compare(str, s, ref count, sum, i + 1);
                }

            }
            return count;

        }
        private static void compare(string str, string compare, ref int count, int sum, int len)
        {
            string original = "";
            string compareStr = "";
            int n = str.Length;
            for (int j = len; j < compare.Length; j = j + 1)
            {
                if (j + n <= compare.Length && j > 0)
                {
                    string sub = compare.Substring(j, n);
                    // char[] strCompareArr = sub.ToCharArray();
                    // Array.Sort(strCompareArr);
                    //original = string.Join("", strArr); 
                    //compareStr = string.Join("", strCompareArr);
                    byte[] bytescompare = Encoding.ASCII.GetBytes(sub);
                    int sumCompare = bytescompare.Sum(d => d);
                    if (sum == sumCompare)
                    {
                        if (sub == str)
                        {
                            count++;
                        }
                        else if (areMetaStrings(sub, str))
                        {
                            count++;
                        }
                    }
                }


            }

        }
        static bool areMetaStrings(String str1,
                               String str2)
        {
            int[] arrA = new int[26];
            int[] arrB = new int[26];
            for (int i = 0; i < str1.Length; i++)
            {
                arrA[str1[i] - 'a']++;
            }
            for (int i = 0; i < str2.Length; i++)
            {
                arrB[str2[i] - 'a']++;
            }
            for (int i = 0; i < 26; i++)
            {
                if (arrA[i] != arrB[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
