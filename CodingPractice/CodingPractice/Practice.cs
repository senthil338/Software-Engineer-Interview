using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Books
{
    public class Practice_code
    {
        #region find K nearest points


        #endregion
        #region Amazon
        public static void GCD()
        {
            int[] arr = { 16, 20,24,28,30,32 };
            int result = GCD(arr);
        }
        public static int GCD(int[] test)

        {

            var temp = new Dictionary<int, int>();

            var final = new Dictionary<int, int>();

            bool tempvalueset = false;

            for (int i = 0; i < test.Length; i++)

            {

                for (int j = 1; j <= test[i]; j++)

                {

                    if ((test[i] % j) == 0)

                    {

                        if (tempvalueset == false)

                        {

                            temp.Add(j, 1);

                        }

                        else

                        {

                            if (temp.ContainsKey(j))

                            {

                                temp[j] = (temp[j] + 1);

                            }

                        }

                    }

                }

                if (temp.Count > 0 && tempvalueset == false)

                {

                    tempvalueset = true;

                }

            }

            int max = 0;

            foreach (KeyValuePair<int, int> pair in temp)

            {

                if (pair.Value == test.Length)

                {

                    if (max < pair.Value)

                    {

                        max = pair.Key;

                    }

                }



            }



            return max;

        }


        public static void EightHouseCount()
        {
            int[] arr = { 1, 1, 1, 0, 1, 1, 1, 1 };
            EightHouseCount(2, arr);
        }
        public static int[] EightHouseCount(int days,int[] arr)
        {
            for(int day = 0; day < days; day++)
            {
                int prev = 0; // edges are inactive
                for(int house = 0; house < 8-1; house++)
                {
                    int next = arr[house + 1];
                    int result = prev + next;
                    prev = arr[house];
                    arr[house] = result > 1 ? 0 : result;
                }
                arr[7] = prev - 0; // edges are inactive
            }
            return arr;
        }
        private static int checkDivisible(int a,int b)
        {
            if (a == 0)
            {
                return b;
            }
            return checkDivisible(b % a, a);
        }
        public static int checkDivisible()
        {
            int[] arr = { 4, 24, 30 };
            int div = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                div = checkDivisible(arr[i], div);
            }
            return div;
        }
        #endregion
        public class Points
        {
           public  int x;
           public int y;
            public Points(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }


    

        class Compare : IComparable<Points>
        {
            int x;
            int y;
            public int CompareTo(Points other)
            {
                return other.y - this.y;
            }

          
        }
                #region coin change
                public static int count()
        {
            int[] arr = { 1, 2, 3 };
            int m = arr.Length;
            int res = count(arr, m, 4 ,""); 
            return res;
        }
        static int count(int[] S, int m, int n,string test)
        {
            // If n is 0 then there is 1 solution  
            // (do not include any coin) 
                if (n == 0)
                return 1;

            // If n is less than 0 then no  
            // solution exists 
            if (n < 0)
                return 0;

            // If there are no coins and n  
            // is greater than 0, then no 
            // solution exist 
            if (m <= 0 && n >= 1)
                return 0;

            // count is sum of solutions (i)  
            // including S[m-1] (ii) excluding S[m-1] 
            return count(S, m - 1, n , "left") +
                   count(S, m, n - S[m - 1] ,"right");
        }
        public static int makeChange()
        {
            int[] arr = { 1, 3, 5 };
            int m = arr.Length;
            Dictionary<string, int> map = new Dictionary<string, int>();
            int res = makeChange(arr, 5, 0, map);
            return res;
        }

        private static int makeChange(int[] coins, int money, int index, Dictionary<string, int> map)
        {
            if(money == 0)
            {
                return 1;
            }
            if(index >= coins.Length)
            {
                return 0;
            }
            string keys = money + "-" + index;
            int addAmountWithCoin = 0;
            int ways = 0;
            while(addAmountWithCoin <= money)
            {
                int remaining = money - addAmountWithCoin;
                ways += makeChange(coins, remaining, index + 1, map);
                addAmountWithCoin += coins[index];
            }
            return ways;
        }
        #endregion

        static int birthdayCakeCandles(int[] ar)
        {

            return 0;

        }
        #region Merge Sort
        public static long MergeSort()
        {
            long count = 0;
            int[] array = { 7, 5, 3, 1 };
            int[] temp = new int[array.Length];
            long result = sort(array,temp, 0, array.Length - 1,ref count);
            return result;
        }
        private static long sort(int[] array,int[] temp,int low, int high,ref long count)
        {
            long totalCount = 0;
            if (low < high)
            {
                int mid = (low + high) / 2;
                long lowerCount = sort(array, temp, low, mid, ref count);
                long higherCount = sort(array, temp, mid + 1, high,ref count);
                totalCount += lowerCount + higherCount + merge(array, temp, low, mid, high,ref count);
            }
            return totalCount;
        }
            private static long merge(int[] array, int[] temp, int low, int mid ,int high,ref long count)
            {
               // int[] temp = new int[high - low + 1];
                int i = low;
                int j = mid + 1;
                int k = 0;
            long countInversions = 0;
            while (i <= mid && j <= high)
                {
                    if (array[i] <= array[j])
                    {
                        temp[k] = array[i];
                        i++;
                    }
                    else
                    {
                        temp[k] = array[j];
                    int res = Math.Abs(i - j);
                    j++;
                    countInversions += (mid - low + 1 - i);
                    count = res + count;
                    }
                    k++;
                }
                while (i <= mid)
                {
                    temp[k] = array[i];
                    k += 1; i += 1;
                }

                while (j <= high)
                {
                    temp[k] = array[j];
                    k += 1; j += 1;
                }
                for (i = low; i <= high; i += 1)
                {
                    array[i] = temp[i - low];

                }
            return countInversions;
            }
#endregion
        #region longest common subsequence


        public static int longestCommonSubsequence()
        {
           string s1 = "bd";
           string s2 = "abcd";
           int[,] array = new int[s1.Length,s2.Length];
           for(int i = 0; i < s1.Length; i++)
            {
                for(int j = 0; j< s2.Length; j++)
                {
                    array[i, j] = -1;
                }
               
            }
           int result = lcs(s1, s2, s1.Length, s2.Length, array);
           return result;
        }

        public static int lcsMemorization()
        {
            string str1 = "HARRY";
            string str2 = "SALLY";
            int m = str1.Length;
            int n = str2.Length;
            int[,] L = new int[m + 1, n + 1];

            /* Following steps build L[m+1][n+1]  
            in bottom up fashion. Note 
            that L[i][j] contains length of  
            LCS of X[0..i-1] and Y[0..j-1] */
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;
                    else if (str1[i - 1] == str2[j - 1])
                        L[i, j] = L[i - 1, j - 1] + 1;
                    else
                        L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                }
            }
            return L[m, n];
           
        }

        private static int lcs(string s1,string s2,int i,int j, int[,] array)
        {
            if (i == 0 || j == 0)
            {
                return 0;
            }
            if (s1[i - 1] == s2[j - 1])
            {
                array[i - 1, j - 1] = lcs(s1, s2, i - 1, j - 1, array) + 1;
                return array[i - 1, j - 1];
            }
            else
            {
                array[i - 1, j - 1] = Math.Max(lcs(s1, s2, i, j - 1, array), lcs(s1, s2, i - 1, j, array));
                return array[i - 1, j - 1];
            }
        }
#endregion
        /// <summary>
        /// https://www.techiedelight.com/find-possible-palindromic-substrings-string/
        /// </summary>
        /// <param name="str"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <param name="set"></param>
        /// <param name="dict"></param>
        public static void expandSearch(String str, int low, int high, ArrayList set, HashSet<string> dict)
        {
            string palindrome = string.Empty;
            String left = string.Empty;
            String right = string.Empty;
            while (low >=0 && high < str.Length && str[low] == str[high])
            {
               
                // if(str.Substring())
                palindrome = str.Substring(low, high - low + 1);
               
                // if (compare.Length > 3 && compare.Length % 2 !=0) // compare between char from mid
                {
                     left = palindrome.Substring(0, palindrome.Length / 2);
                     right = palindrome.Substring(palindrome.Length- left.Length);
                }
                if (left == right && palindrome.Length > 1 && allCharactersSame(left)==true && allCharactersSame(right)) // uncomment to make it normal palindrome
                {
                   
                    set.Add(palindrome);
                    dict.Add(low + "-" + high);
                }
                low--;
                high++;
              
            }
            //// run till str[low.high] is a palindrome
            //while (low >= 0 && high < str.Length
            //        && str[low] == str[high])
            //{
            //    // push all palindromes into the set
            //    set.Add(str.Substring(low, high + 1));

            //    // expand in both directions
            //    low--;
            //    high++;
            //}
        }
        static bool allCharactersSame(string s)
        {
            int n = s.Length;
            for (int i = 1; i < n; i++)
                if (s[i] != s[0])
                    return false;

            return true;
        }
        // Function to find all unique palindromic substrings of given string
        public static void allPalindromicSubStrings(String str)
        {
            //152076 

            // create an empty set to store all  palindromic substrings
            ArrayList set = new ArrayList();
            HashSet<string> dict = new HashSet<string>();
            for (int i = 0; i < str.Length; i++)
            {
                // find all odd length palindrome with str[i] as mid point

                expandSearch(str, i, i, set, dict);

                // find all even length palindrome with str[i] and str[i+1]
                // as its mid points
                expandSearch(str, i, i + 1, set, dict);
            }
            long count = set.Count + str.Length;
            // print all unique palindromic substrings
          Console.WriteLine(set);
        }

        public static int alternatingCharacters()
        {
            string s = "AABAAB";
            int len = s.Length-1;
            int i = 0;
            int count = 0;
            while(len > i)
            {
                //len--;
                if(s[len] == s[len-1])
                {
                    
                    count++;
                }
                if(s[i] == s[i+1] && i !=len-1 && i+1!=len)
                {
                   
                    count++;
                }
                i++;
                len--;

            }
            return count;
           
            //Array.Sort(arr);

        }

        public static string isValid()
        {
             string s = "abbccc";
            //string s = "aabbc";
           // string s = "aabbc";
          //  s = "aabbcd";
            int[] chars = new int[26];
            int count = 0;
            for(int i = 0; i < s.Length; i++)
            {
                chars[s[i]-'a']++;
            }
            int temp = chars[0];
            for(int i = 1; i < 25; i++)
            {
                if(temp!= chars[i] && chars[i] != 0)
                {
                    if(chars[i] > temp)
                    {
                        if(chars[i] - 1==temp || chars[i] - 1 > temp)
                        {
                            count++;
                        }
                    }
                    else
                    {
                        if(chars[i] - 1 == 0)
                        {
                            count++;
                        }
                        else if(chars[i] - 1 != temp)
                        {
                            count++;
                        }

                    }
                }
                if(count > 1)
                {
                    return "NO";
                }
            
            }
            return "YES";
        }

    }
}
