using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.SortingAlgorithm
{
    /// <summary>
    /// Worst-case performance	O(n^{2})
    /// Best-case performance	O(n)
    /// Average performance O(n^{2})
    /// Worst-case space complexity	O(1) auxiliary
    /// https://en.wikipedia.org/wiki/Bubble_sort
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// compares each pair of adjacent items and swaps them if they are in the wrong order. 
        /// The pass through the list is repeated until no swaps are needed, 
        /// which indicates that the list is sorted
        /// </summary>
        public void bubbleSort(int[] number)
        {
            // int[] number = { 89, 76, 45, 92, 67, 12, 99 };
            bool flag = true;
            int temp;
            int numLength = number.Length;
            //sorting an array
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (number[j + 1] < number[j])
                    {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;
                    }
                }
            }
        }
    }
}
