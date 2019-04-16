using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    public class Count_Triplets
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/the-love-letter-mystery/problem
        /// </summary>
        public static void theLoveLetterMystery()
        {
            theLoveLetterMystery("adslkfjas");
        }
        public static void countTriplets()
        {
            List<long> arr = new List<long>();
            //arr.Add(1);
            //arr.Add(2);
            //arr.Add(2);
            //arr.Add(4);
            arr.Add(1);
            arr.Add(3);
            arr.Add(9);
            arr.Add(9);
            arr.Add(27);
            arr.Add(81);



            countTriplets(arr, 2);
        }

        static long countTriplets(List<long> arr, long r)
        {
            long count = arr.Count - 1;
            long pairSet = count * 3;
            if (pairSet % 2 != 0)
            {
              
                pairSet = pairSet / 2;
               // pairSet = pairSet + 1;
            }
            else
            {
                pairSet = pairSet / 2;
            }
            Dictionary<long, long> val = new Dictionary<long, long>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (!val.ContainsKey(arr[i])){
                    val.Add(arr[i], 1);
                }
                else
                {
                    val[arr[i]] = val[arr[i]] + 1;
                }
            }
            long result = 0;
            
            foreach (KeyValuePair<long, long> ky in val)
            {
                if (ky.Value > 1)
                {
                    result += ky.Value;
                }
            }
            return pairSet - result;
        }

        static int theLoveLetterMystery(string s)
        {
          
            bool isPalindorm = isPalindrome(s);
            int result = 0;
            if (isPalindorm == false)
            {
                int halfLen = s.Length/2;
                int totalLength = s.Length % 2 == 0 ? halfLen + halfLen - 1 : halfLen + halfLen;
                //divide string into two half

                result = countSwap(s, halfLen, totalLength);
            }
            return result;
        }
        private static int countSwap(string s, int left, int right)
        {
            int count = 0;

            for (int i = 0; i < left; i++)
            {

                //if(s1[i] != s1[right])
                {
                    count += Math.Abs(s[right] - s[i]); ;
                }
                right--;
            }

            return count;
        }

        //private static int countSwap(string s1,int left,int right)
        //{
        //    int count = 0;
           
        //    for (int i = 0; i < left; i++)
        //    {
               
        //        //if(s1[i] != s1[right])
        //        {
        //            count += right - i;
        //        }
        //        right--;
        //    }

        //    return count;
        //}

        private static bool isPalindrome(string s)
        {
            for(int i = 0;i< s.Length/2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
