using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.SortingAlgorithm
{
    public class MergeTwoArray
    {
        //public static int[] merge(int[] a, int[] b)
        public static int[] merge()
        {
            int[] a = { 2, 4, 5, 7 };
            int[] b = { 3, 6, 8, 9, 10 };
            int[] answer = new int[a.Length + b.Length];
            int i = a.Length - 1, j = b.Length - 1, k = answer.Length;

            while (k > 0)
                answer[--k] =
                    (j < 0 || (i >= 0 && a[i] >= b[j])) ? a[i--] : b[j--];
            return answer;
        }

        //public static int[] mergeArray(int[] a, int[] b)
        public static int[] mergeArray()
        {
            int[] a = { 2, 4, 5, 7 };
            int[] b = { 3, 6, 8, 9, 10 };

            int[] answer = new int[a.Length + b.Length];
            int i = 0, j = 0, k = 0;

            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                    answer[k++] = a[i++];

                else
                    answer[k++] = b[j++];
            }

            while (i < a.Length)
                answer[k++] = a[i++];


            while (j < b.Length)
                answer[k++] = b[j++];

            return answer;
        }
    }
}
