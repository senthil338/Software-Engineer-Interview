using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Coding_Exercises
{
    /*
    Input: n = 3, k = 2
    Output: 3
    Explanation: Let the set be {1, 2, 3}, we can partition
                 it into 2 subsets in following ways
                 {{1,2}, {3}},  {{1}, {2,3}},  {{1,3}, {2}}  

    Input: n = 3, k = 1
    Output: 1
    Explanation: There is only one way {{1, 2, 3}} 
    S(n, k) = k*S(n-1, k) + S(n-1, k-1) 
    */
    class Count_number_of_ways_to_partition_a_set
    {
        #region recursive
        // Returns count of different  
        // partitions of n elements in 
        // k subsets 
        //The time complexity of above recursive solution is exponential. 
        //The solution can be optimized as there are overlapping subproblems
        public static int countP(int n, int k)
        {

            // Base cases 
            if (n == 0 || k == 0 || k > n)
                return 0;
            if (k == 1 || k == n)
                return 1;

            // S(n+1, k) = k*S(n, k) + S(n, k-1) 
            return (k * countP(n - 1, k)
                    + countP(n - 1, k - 1));
        }
        #endregion
        #region overlapping
        // Returns count of different partitions of n  
        // elements in k subsets  
        //Time Complexity: O(n x k)
        //Auxiliary Space: O(n x k)
        static int countP_over(int n, int k)
        {
            // Table to store results of subproblems  
            int[,] dp = new int[n + 1, k + 1];

            // Base cases  
            for (int i = 0; i <= n; i++)
                dp[i, 0] = 0;
            for (int i = 0; i <= k; i++)
                dp[0, k] = 0;

            // Fill rest of the entries in dp[][] 
            // in bottom up manner  
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= k; j++)
                    if (j == 1 || i == j)
                        dp[i, j] = 1;
                    else
                        dp[i, j] = j * dp[i - 1, j] + dp[i - 1, j - 1];

            return dp[n, k];

        }
        #endregion
    }
}
