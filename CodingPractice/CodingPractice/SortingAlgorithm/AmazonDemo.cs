using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.SortingAlgorithm
{
    public class AmazonDemo
    {
        public static void generalizedGSD()
        {
            int[] arr = { 2, 4, 6, 8, 10 };
            generalizedGSD(arr.Length - 1, arr);

        }
        public static int generalizedGSD(int num,int[] arr)
        {
            bool isOdd = false;
            bool isEven = false;
            int initialVal = arr[0];
            
            for(int i = 1; i < num-1; i++)
            {
                if (arr[i] % 2 == 0)
                {
                   isEven = true;
                }
                else
                {
                    isOdd = true;
                }
                if(isEven && isOdd)
                {
                    return 1;
                }
                if (arr[i]% initialVal==0)
                {
                   
                }
                else
                {
                    for(int j = arr[i] - initialVal; j >=2;j = j- 2)
                    {
                        if (arr[i] % j == 0)
                        {
                            return j;
                        }
                    }
                }
            }
          
            return 0;
        }
    }
}
