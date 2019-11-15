using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.GeeksForGeeks
{
   public class largest_sum_of_non_adjacent_numbers
    {
        /// <summary>
        /// https://www.geeksforgeeks.org/maximum-sum-such-that-no-two-elements-are-adjacent/
        /// </summary>
        public static void sum_of_adjacent()
        {
            int[] arr = { 2, 4, 6, 2, 5 }; //13
            sum_of_adjacent(arr);
        }

        private static int sum_of_adjacent(int[] arr)
        {
            int incl = arr[0];
            int excl = 0;
            int temp = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                temp = incl;
                incl = Math.Max(excl + arr[i], incl);
                excl = temp;
            }

            return Math.Max(incl, excl);
        }
    }
}
