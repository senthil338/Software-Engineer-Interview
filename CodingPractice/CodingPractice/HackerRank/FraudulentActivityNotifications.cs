using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class FraudulentActivityNotifications
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/fraudulent-activity-notifications/problem
        /// 9 5 and 2 3 4 2 3 6 8 4 5 o/p = 5
        /// 5 4 and 1 2 3 4 4 o/p = 0
        /// Medium 40
        /// </summary>
        /// <param name="expenditure"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        static int activityNotifications(int[] expenditure, int d)
        {
            int[] freq = new int[201];
            int pop_element = 0;
            int notification = 0;
            int nextDaySpent = 0;
            for (int i = 0; i < d; i++)
            {
                freq[expenditure[i]]++;
            }
            for (int j = d; j < expenditure.Length; j++)
            {
                int median = getMedian(freq, d);
                pop_element = expenditure[j - d];
                freq[pop_element]--;
                freq[expenditure[j]]++;
                nextDaySpent = expenditure[j];
                if (d % 2 == 0)
                {
                    if (expenditure[j] >= median)
                        notification++;
                }
                else
                {
                    if (expenditure[j] >= 2 * median)
                        notification++;
                }
            }
            return notification;
        }
        public static int getMedian(int[] freq, int d)
        {
            int[] prefix_sum = new int[201];
            prefix_sum[0] = freq[0];
            for (int i = 1; i < 201; i++)
            {
                prefix_sum[i] = prefix_sum[i - 1] + freq[i];
            }
            int median;
            int a = 0;
            int b = 0;
            if (d % 2 == 0)
            {
                int first = d / 2;
                int second = first + 1;
                int i = 0;
                for (; i < 201; i++)
                {
                    if (first <= prefix_sum[i])
                    {
                        a = i;
                        break;
                    }
                }
                for (; i < 201; i++)
                {
                    if (second <= prefix_sum[i])
                    {
                        b = i;
                        break;
                    }
                }

            }
            else
            {
                int first = d / 2 + 1;
                for (int i = 0; i < 201; i++)
                {
                    if (first <= prefix_sum[i])
                    {
                        a = i;
                        break;
                    }
                }
            }
            median = a + b;
            return median;
        }
    }
}
