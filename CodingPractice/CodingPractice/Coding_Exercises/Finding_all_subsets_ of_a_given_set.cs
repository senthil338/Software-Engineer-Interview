using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Coding_Exercises
{
    /// <summary>
    /// https://www.geeksforgeeks.org/finding-all-subsets-of-a-given-set-in-java/
    /// S = {a, b, c, d} 
    /// {}, {a} , {b}, {c}, {d}, {a,b}, {a,c},
    ///{a,d}, {b,c}, {b,d}, {c,d}, {a,b,c}, 
    ///{a,b,d}, {a,c,d}, {b,c,d}, {a,b,c,d}
    ///The total number of subsets of any given set is equal to 2^ (no. of elements in the set). 
    ///If we carefully notice it is nothing but binary numbers from 0 to 15 which can be shown as below:
    /// </summary>
    class Finding_all_subsets__of_a_given_set
    {
        static void printSubsets(char[] set)
        {
            int n = set.Length;

            // Run a loop for printing all 2^n 
            // subsets one by obe 
            for (int i = 0; i < (1 << n); i++)
            {
                //System.out.print("{ ");

                // Print current subset 
                for (int j = 0; j < n; j++)

                    // (1<<j) is a number with jth bit 1 
                    // so when we 'and' them with the 
                    // subset number we get which numbers 
                    // are present in the subset and which 
                    // are not 
                    if ((i & (1 << j)) > 0) {
                       // System.out.print(set[j] + " ");
                    }

               // System.out.println("}");
            }
        }
    }
}
