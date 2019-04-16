using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class BubbleSort
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/ctci-bubble-sort/problem
        /// </summary>
        /// <param name="a"></param>
        static void countSwaps(int[] a)
        {
            int i, j, temp;
            bool swapped;
            int n = a.Length;
            int count = 0;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        count++;
                        // swap arr[j] and arr[j+1] 
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
            Console.WriteLine("Array is sorted in {0} swaps.", count);

            Console.WriteLine("First Element: {0}", a[0]);
            Console.WriteLine("Last Element: {0}", a[n - 1]);

        }
    }
}
