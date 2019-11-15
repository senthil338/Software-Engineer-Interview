using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.OnlineProblem
{
    public class Glassdoor
    {

        public static void MergeSort()
        {
            int[] arr = { 4, 6, 7, 2, 4, 10, 56 };

        }

        public static void MergeSort(int[] arr, int leftStart,int rightEnd,int[] temp)
        {
            if(leftStart >= rightEnd)
            {
                return;
            }
            int Middle =  (leftStart + rightEnd) / 2;
            MergeSort(arr, leftStart, Middle, temp);
            MergeSort(arr, Middle + 1, rightEnd, temp);

        }

        public static void Merge(int[] arr, int leftStart, int rightEnd, int[] temp)
        {
            int leftEnd = (leftStart + rightEnd) / 2;
            int rightStart = leftEnd + 1;
            int left = leftStart;
            int right = rightStart;
            int index = leftStart;
            while(left <= leftEnd && right <= rightEnd)
            {
                if(arr[left] <= arr[right])
                {
                    temp[index] = arr[left];
                    left++;
                }
                else{
                    temp[index] = arr[right];
                    right++;
                }
                index++;
            }
            while(left <= leftEnd)
            {
                temp[index] = arr[left];
                left++;
            }

            while (right <= rightEnd)
            {
                temp[index] = arr[right];
                left++;
            }
            
        }
        /// <summary>
        /// Asked in FB, Microsofts
        /// ou are given a list containing k sorted lists of integers , each list is of varying size, 
        /// max of which is n. Implement an iterator in java that with each call to its next() 
        /// function retrieves the next integer in the overall order of all the integers in all the 
        /// lists combined. Answer should be efficient depending on the number of calls to next(). 
        /// Example: lists = [[1,2,3],[1,4],[2,5,7,8]] n = 4 k = 3 
        /// iterator should return (if called 9 times): 1,1,2,2,3,4,5,7,8
        /// https://careercup.com/question?id=5647438614888448
        /// https://www.glassdoor.com/Interview/You-are-given-a-list-containing-k-sorted-lists-of-integers-each-list-is-of-varying-size-max-of-which-is-n-Implement-an-QTN_913587.htm
        /// </summary>
        public static void SortKSortedList()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 2, 4 };
            int[] result1 = mergeArray(a, b);
            int[] c = { 2, 5, 7, 8 };
            int[] result2 = mergeArray(result1, c);
            
        }

        public static int[] mergeArray(int[] a, int[] b)
        {
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
