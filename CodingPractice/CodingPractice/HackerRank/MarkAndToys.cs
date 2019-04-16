using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class MarkAndToys
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/mark-and-toys/problem
        /// 7 50 and 1 12 5 111 200 1000 10 o/p = 4
        /// </summary>
        /// <param name="prices"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        static int maximumToys(int[] prices, int k)
        {

            quickSort(prices, 0, prices.Length - 1);
            int sum = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (sum > k)
                {
                    return i - 1;
                }
                sum = sum + prices[i];
            }
            return prices.Length - 1;
        }

        static void quickSort(int[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            int pivot = arr[(left + right) / 2];
            int index = partition(arr, left, right, pivot);
            quickSort(arr, left, index - 1);
            quickSort(arr, index, right);
        }
        static int partition(int[] arr, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }
            return left;
        }
    }
}
