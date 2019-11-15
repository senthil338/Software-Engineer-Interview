using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Coding_Exercises
{
    /*
     *  arr[] = {1, 5, 11, 5}
        Output: true 
        The array can be partitioned as {1, 5, 5} and {11}

        arr[] = {1, 5, 3}
        Output: false 
        The array cannot be partitioned into equal sum sets.
     */
    /// <summary>
    /// https://www.geeksforgeeks.org/partition-problem-dp-18/
    /// </summary>
    class Partition_problem_Sub_Set
    {
        // A utility function that returns true if there is a 
        // subset of arr[] with sun equal to given sum 
        static bool isSubsetSum(int[] arr, int n, int sum)
        {
            // Base Cases 
            if (sum == 0)
                return true;
            if (n == 0 && sum != 0)
                return false;

            // If last element is greater than sum, then ignore it 
            if (arr[n - 1] > sum)
                return isSubsetSum(arr, n - 1, sum);

            /* else, check if sum can be obtained by any of 
            the following 
            (a) including the last element 
            (b) excluding the last element 
            */
            return isSubsetSum(arr, n - 1, sum) ||
                   isSubsetSum(arr, n - 1, sum - arr[n - 1]);
        }

        // Returns true if arr[] can be partitioned in two 
        // subsets of equal sum, otherwise false 
        static bool findPartition(int[] arr, int n)
        {
            // Calculate sum of the elements in array 
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += arr[i];

            // If sum is odd, there cannot be two subsets 
            // with equal sum 
            if (sum % 2 != 0)
                return false;

            // Find if there is subset with sum equal to half 
            // of total sum 
            return isSubsetSum(arr, n, sum / 2);
        }

    }
}
