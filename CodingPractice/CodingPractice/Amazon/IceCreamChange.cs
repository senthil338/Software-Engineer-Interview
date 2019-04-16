using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Amazon
{
   public class IceCreamChange
    {
        /*
          For example 
            5, 5, 5, 10, 20 -> true, 
            5, 5, 10 -> true, 
            10, 10 -> false
             5, 20 -> false
            10, 20 -> false
            10 , 5 -> false
        
         * * <p>Amazon phone interview
            <br>A queue of people are waiting to buy ice cream from you. 
            <br>Each person buys one ice cream, which sells for $5. 
            <br>Each customer is holding a bill of $5, $10 or $20. 
            <br>Your initial balance is 0. 
            <br>Find whether you will be able to make change for every customer in the queue. You must serve customers in the order they come in.
            <br>
            <br>For example 
            <br>5, 5, 5, 10, 20 ->; true, 
            <br>5, 5, 10 ->; true, 
            <br>10, 10 ->; false</p>
         */

        public static bool Change(int[] bills)
        {
            int[] coin = new int[2];//store 5 and 10
            for (int i = 0; i < bills.Length; i++)
            {
                int m = bills[i];
                if (m == 5)
                {
                    coin[0]++;
                    continue;
                }
               
                if (m == 10)
                {
                    if (coin[0] <= 0)
                    {
                        return false;
                    }

                    coin[0]--;
                    coin[1]++;
                }
                if (m == 20)
                {
                    if (coin[1] <= 0 || coin[0] <= 1)
                    {
                        return false;
                    }
                    if(coin[1]>=1 && coin[0] >=1)
                    {
                        coin[1]--;
                        coin[0]--;
                    }
                }
                
            }
            return true;
        }
    }
}
