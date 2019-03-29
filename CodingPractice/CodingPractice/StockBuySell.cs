using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Problems
{
    class Interval {
       public int buy;
       public int sell;
    }
    public class StockBuySell
    {
        /// <summary>
        /// https://www.geeksforgeeks.org/stock-buy-sell/
        /// </summary>
        /// <param name="price"></param>
        /// <param name="n"></param>
     public static void stockBuySell(int[] price, int n) 
     {
         if (n == 1) { return; }
         int count = 0;
         List<Interval> sol = new List<Interval>();
         int i = 0;
         while (i < n - 1)
         {
             // Find Local Minima. Note that the limit is (n-2) as we are
             // comparing present element to the next element. 
             while ((i < n - 1) && (price[i + 1] <= price[i]))
             {
                 i++;
             }
             // If we reached the end, break as no further solution possible
             if (i == n - 1)
                 break;
             Interval e = new Interval();
             e.buy = i++;

             // Find Local Maxima.  Note that the limit is (n-1) as we are
             // comparing to previous element
             while ((i < n) && (price[i] >= price[i - 1]))
                 i++;

             // Store the index of maxima
             e.sell = i - 1;
             sol.Add(e);

             // Increment number of buy/sell
             count++;
         }

          // print solution
        if (count == 0)
            System.Console.WriteLine("There is no day when buying the stock "
                                                  + "will make profit");
        else
            for (int j = 0; j < sol.Count; j++)
                System.Console.WriteLine("Buy on day: " + sol[j].buy
                        + "        " + "Sell on day : " + sol[j].sell);
         
        return;
     }

     public static int maxProfit(int[] price, int n, int k)
     {
         // table to store results of subproblems
         // profit[t][i] stores maximum profit using atmost
         // t transactions up to day i (including day i)
         int[,] profit = new int[k + 1, n + 1];

         // For day 0, you can't earn money
         // irrespective of how many times you trade
         for (int i = 0; i <= k; i++)
             profit[i, 0] = 0;

         // profit is 0 if we don't do any transation
         // (i.e. k =0)
         for (int j = 0; j <= n; j++)
             profit[0, j] = 0;

         // fill the table in bottom-up fashion
         for (int i = 1; i <= k; i++)
         {
             for (int j = 1; j < n; j++)
             {
                 int max_so_far = 0;

                 for (int m = 0; m < j; m++)
                     max_so_far = Math.Max(max_so_far, price[j] -
                                    price[m] + profit[i - 1, m]);

                 profit[i, j] = Math.Max(profit[i, j - 1], max_so_far);
             }
         }

         return profit[k, n - 1];
     }
    }
}
