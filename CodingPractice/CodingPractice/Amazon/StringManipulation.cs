using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.StringProblem
{
    public class StringManipulation
    {
        public int stringAnagram(string a,string b)
        {
            int[] countA = new int[26];
            int[] countB = new int[26];

            for (int i = 0; i < a.Length; i++)
            {
                countA[a[i] - 'a']++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                countB[b[i] - 'a']++;
            }

            int result = 0;
            for (int i = 0; i < 26; i++)
                result += Math.Abs(countA[i] -
                                   countB[i]);
            return result;
        }

        public static int IntPermutaion(int n, int[] arr)
        {
            // arr. 
            
            Array.Sort(arr);
            Array.Reverse(arr);
            int min = Math.Abs(arr[0] - arr[1]);
            for (int i = 0; i < n -1 ; i++)
            {
                if (min > Math.Abs(arr[i] - arr[i + 1]))
                {
                    min = Math.Abs(arr[i] - arr[i + 1]);
                }
            }
            return min;
        }

        public static long cubCake(int[] arr)
        {
            // arr. 

            Array.Sort(arr);
            Array.Reverse(arr);
            long sum = 0;
            for (int i = 0; i < arr.Length ; i++)
            {
                //if (i == 0) {
                //    sum = arr[i];
                //}
                //else
                sum = sum + (arr[i] * (long)Math.Pow(2, i));
            }
            return sum;
        }

        public static string gridChallenge()
        {
            PairSum();
            string[] grid = { "nyx", "ynx", "xyt" };
            int[] count = new int[grid.Length];
            for (int i = 0; i < grid.Length; i++)
            {
              string test =  sortedString(grid[i].ToArray());
              grid[i] = test;
            }
        //check column sortered or not
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    count[i] = count[i] + (int)grid[i][j];
                 
                }
                if (i > 0 && count[i - 1] > count[i])
                {
                    return "NO";
                }
                else if(i>0)
                {
                    for (int k = 0; k < grid[i].Length; k++) {
                       if(string.Compare(grid[i-1][k].ToString(),grid[i][k].ToString())>0){
                          // return "NO";
                           string test = "";
                       }
                    }
                    
                }
                
            }
            return "YES";
        }

        private static string sortedString(char[] str)
        {
            Array.Sort(str);
            return string.Join("", str);

        }

        public  static int luckBalance()
        {
            //int n = 6;
            //int k = 3;
            //int[][] contests = new int[6][];
            //for (int i = 0; i < contests.Length; i++)
            //{
            //    contests[i] = new int[2];
            //}
            //contests[0] = new int[] { 5, 1 };
            //contests[1] = new int[] { 2, 1 };
            //contests[2] = new int[] { 1, 1 };
            //contests[3] = new int[] { 8, 1 };
            //contests[4] = new int[] { 10,0 };
            //contests[5] = new int[] { 5, 0 };
            int n = 3;
            int k = 1;
            int[][] contests = new int[3][];
            for (int i = 0; i < contests.Length; i++)
            {
                contests[i] = new int[2];
            }
            contests[0] = new int[] { 5, 1 };
            contests[1] = new int[] { 1, 1 };
            contests[2] = new int[] { 4, 0 };
      
            contests = contests.OrderByDescending(inner => inner[1]).ThenByDescending(inner=>inner[0]).ToArray();
            int luckofSum = 0;

            //lose k no of contest
            for (int i = 0; i < n; i++)
            {
                if (contests[i][1] == 1 && k > i)
                {
                    luckofSum = luckofSum + contests[i][0];
                }
                else if (contests[i][1] == 0) {
                    luckofSum = luckofSum + contests[i][0];
                }
                else if (contests[i][1] == 1 && k <= i)
                {
                    luckofSum = luckofSum - contests[i][0];
                }
            }



            return luckofSum;
        }

         public static int[] maximumPerimeterTriangle()
        {
            int[] sticks = {1, 1, 1,2,3,5};
            Array.Sort(sticks);
             int i = sticks.Length - 3;
             while(i>=0 && (sticks[i] + sticks[i+1] <= sticks[i+2]))
             {
                 i -= 1;
             }

             if (i >= 0)
                 return new int[] { sticks[i], sticks[i + 1], sticks[i + 2] };
             else
                 return new int[] {-1};

        }

         static void largestValue()
         {

             List<int> pair = new List<int>();
             int[] A = { 5, 7, -5, 6, 3, 9, -8, 2, -1, 10};

             int[] result = new int[2];
             int size = A.Length;
             int min = int.MinValue;
             int max_so_far = int.MinValue,
                 max_ending_here = 0;

             for (int i = 0; i < size; i++)
             {
                 max_ending_here = max_ending_here + A[i];

                 if (max_so_far < max_ending_here)
                 {
                     if(A[i] > 0)
                     pair.Add(A[i]);
                     max_so_far = max_ending_here;
                 }
                 if (A[i] > min && A[i] < 0)
                 {
                    
                     min = A[i];
                 }
             }
             pair.Add(min);
                 if (max_ending_here < 0)
                     max_ending_here = 0;
             
             // Return the largest value of any of A's nonempty subarrays.

         }

         public static void PairSum()
         {
             int[] A = { 27, 349, -586, 34, 47, -124, 579, 975, -591, 194, -635, 27, -889, -474, -545, 465, 433, 913, 447, -568, -17, -251, -107, 110, 623, -853, 810, 851, -478, 639, 49, -654, 313, 722, 573, -687, 260, -715, 78, -956, 15, 259, 949, -825, 289, 544, 478, 529, -318, -807, -442, -487, -908, -397, -14, -733, -428, 876, -487, 587, 98, 116, 701, -522, 239, -331, 490, 59, -397, -552, -525, 256, 421, 773, 362, -838, 786, -759, 801, -280, -287, 48, 780, 608, 746, 877, 585, -639, 498, 564, 278, 125, 22, 29, -894, -991, 139, 144, -434, 751 };
             int n = A.Length;
             long[] db = new long[A.Length];
             db[0] = 0;
             db[1] = A[0] * A[1];

             int[] rsum = new int[A.Length];
    
             int sum = 0;
             for (int i = 0; i < n; i++)
             {
                 sum = sum + A[i];
                 rsum[i] = sum;
             }
             long dbSum = 0;
             long m = db[1];
             for (int i = 2; i < n; i++) {
                 dbSum = rsum[i - 1] * A[i];
                 dbSum = db[i - 1] + dbSum;
                 db[i] = dbSum;
                 if (dbSum > m)
                 {
                     m = dbSum;
                 }
             }
             long res = m;
             long rrsum = 0;
             long db2 = 0;
             for (int i = 0; i < n; i++) {
                 if (db[i] != m)
                     continue;
                 rrsum = rsum[i];
                 db2 = db[i];
                 for (int j = 0; j < i; j++) {
                     rrsum = rrsum - A[j];
                     db2 = db2 - A[j] * rrsum;
                     res = Math.Max(db2, res);
                 }
             }
         }

         public static int LongestCommonSubStringWithOutRepeatingChar(string s) {
             int len = s.Length;
             char[] str = s.ToCharArray();
             int start = 0;
             int max = 0;
             Dictionary<char, int> map = new Dictionary<char, int>();
             for (int i = 0; i < len; i++) {
                 if (map.ContainsKey(str[i]) == true && map[str[i]] >= start)
                 {
                     start = map[str[i]] + 1;
                 }
                 map[str[i]] = i;
                 max = Math.Max(max, i - start + 1);
             }
             return max;
         }

         public static string UniqueIdGeneration(List<string> str,Dictionary<string,string> dict)
         {
            // string[] str = { "1", "2", "3", "4", "5" };
             StringBuilder builder = new StringBuilder();
         //no  str.AsQuer
           // str.Select(s=>s.range
            

             str.Concat(str)
                // .Concat(str)
                 .OrderBy(e => Guid.NewGuid())
                  .Take(3)
                  .Where(w => !dict.ContainsKey(w))
                  .ToList().ForEach(e => builder.Append(e));
            
             string id1 = builder.ToString();
             dict.Add(id1, id1);
             //Enumerable
             //    .Range(65, 26)
             //    .Select(e => ((char)e).ToString())
             //    .Concat(Enumerable.Range(97, 26).Select(e => ((char)e).ToString()))
             //    .Concat(Enumerable.Range(0, 10).Select(e => e.ToString()))
             //    .OrderBy(e => Guid.NewGuid())
             //    .Take(11)
             //    .ToList().ForEach(e => builder.Append(e));
             //string id = builder.ToString();
             return id1;
         }

         public static void SequenceOfWord(string str = "aabcaabc")
         {
            //  int jjjj = 2 * 3 - 4 * 5;
            // string str1 = "aabcaabcaabcaabcxy";
            string str1 = "abba";
            //take first char i.e a
            //compare with next char . i.e a
            //if match add seq + 1
            //else leave the seq
            // add the next char into previous char
            // compare added char with next char
            // do the same steps until length become equal
            // 
            string concat = "";
             string compare = "";
             Dictionary<string,int> dic = new Dictionary<string,int>();
             for (int i = 1; i < str1.Length; i++)
             {
                 if (concat == "")
                 {
                     if (str1[i - 1] == str1[i])
                     {
                         dic.Add(str1[i - 1].ToString(), 2);
                     }
                     concat = concat + str1[i - 1].ToString() + str1[i];
                 }
                 else
                 {
                     concat = concat + str1[i];
                 }

                 compare = compareStr(str1, concat.Length,concat.Length);
                 //for (int j = 0; j < concat.Length; j++)
                 //{
                 //    compare = compare + str1[concat.Length + j];
                 //}
                 if (concat == compare)
                 {
                     if (dic.ContainsKey(concat))
                     {
                         dic[concat]++;
                     }
                     else
                     {
                         dic.Add(concat, 2);
                     }
                     for (int k = 2; k < str1.Length / concat.Length; k++)
                     {
                         compare = compareStr(str1, concat.Length * k, concat.Length);
                         if (concat == compare)
                         {
                             if (dic.ContainsKey(concat))
                             {
                                 dic[concat]++;
                             }
                             else
                             {
                                 dic.Add(concat, 2);
                             }
                             if (concat.Length * k + compare.Length == str1.Length)
                             {
                                 return;
                             }
                         }
                     }

                 }

             }
         }


         private static string compareStr(string str1,int len, int startIndex)
         {
             string compare = "";
             for (int j = 0; j < startIndex; j++)
             {
                if(str1.Length >= len + j)
                 compare = compare + str1[len + j-1];
             }
             return compare;
         }

        public static void stringPermutation(string str)
        {
            str = "ABC";
                       
            permutation(str,"");
        }

        private static void permutation(string str, string pre)
        {
            if(str.Length == 0)
            {
                Console.WriteLine(pre);
            }
            else
            {
                for(int i = 0; i < str.Length; i++)
                {
                    string rem = str.Substring(0, i) + str.Substring(i + 1);
                    permutation(rem, pre + str[i]);
                }
            }
        }

    }
}

