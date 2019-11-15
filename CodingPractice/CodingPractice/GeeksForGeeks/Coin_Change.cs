using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class Coin_Change
    {
        /// <summary>
        /// https://www.geeksforgeeks.org/understanding-the-coin-change-problem-with-dynamic-programming/
        /// </summary>
        /// <param name="N"></param>
        /// <param name="Coins"></param>
        /// <returns></returns>
        static long getNumberOfWays(long N, long[] Coins)
        {
            // Create the ways array to 1 plus the amount  
            // to stop overflow  
            long[] ways = new long[(int)N + 1];

            // Set the first way to 1 because its 0 and  
            // there is 1 way to make 0 with 0 coins  
            ways[0] = 1;

            // Go through all of the coins  
            for (int i = 0; i < Coins.Length; i++)
            {

                // Make a comparison to each index value  
                // of ways with the coin value.  
                for (int j = 0; j < ways.Length; j++)
                {
                    if (Coins[i] <= j)
                    {

                        // Update the ways array  
                        ways[j] += ways[(int)(j - Coins[i])];
                    }
                }
            }

            // return the value at the Nth position  
            // of the ways array.  
            return ways[(int)N];
        }

        //https://www.csharpstar.com/csharp-coin-change-problem-greedy-algorithm/

        //static void MakeChange(double origAmount, double
        //                   remainAmount, int[] coins)
        //{
        //    if ((origAmount % 0.25) < origAmount)
        //    {
        //        coins[3] = (int)(origAmount / 0.25);
        //        remainAmount = origAmount % 0.25;
        //        origAmount = remainAmount;
        //    }
        //    if ((origAmount % 0.1) < origAmount)
        //    {
        //        coins[2] = (int)(origAmount / 0.1);
        //        remainAmount = origAmount % 0.1;
        //        origAmount = remainAmount;
        //    }
        //    if ((origAmount % 0.05) < origAmount)
        //    {
        //        coins[1] = (int)(origAmount / 0.05);
        //        remainAmount = origAmount % 0.05;
        //        origAmount = remainAmount;
        //    }
        //    if ((origAmount % 0.01) < origAmount)
        //    {
        //        coins[0] = (int)(origAmount / 0.01);
        //        remainAmount = origAmount % 0.01;
        //    }
        //}
        //static void ShowChange(int[] arr)
        //{
        //    if (arr[3] > 0)
        //        Console.WriteLine("Number of quarters: " +
        //        arr[3]);
        //    if (arr[2] > 0)
        //        Console.WriteLine("Number of dimes: " + arr[2]);
        //    if (arr[1] > 0)
        //        Console.WriteLine("Number of nickels: " + arr[1]);
        //    if (arr[0] > 0)
        //        Console.WriteLine("Number of pennies: " + arr[0]);
        //}
        //static void Main()
        //{
        //    Console.WriteLine("Enter the amount you want to change:");
        //    double origAmount = Convert.ToDouble(Console.ReadLine());
        //    double toChange = origAmount;
        //    double remainAmount = 0.0;
        //    int[] coins = new int[4];
        //    MakeChange(origAmount, remainAmount, coins);

        //    Console.WriteLine("The best way to change " +
        //    toChange + " cents is: ");
        //    ShowChange(coins);
        //}
    }
}
