using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class FindPeekElement
    {
        /// <summary>
        /// https://leetcode.com/explore/interview/card/facebook/54/sorting-and-searching-3/3032/
        /// run n(logn)
        /// space 1
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int findPeakElement(int[] nums)
        {
            int l = 0, r = nums.Length - 1;
            while (l < r)
            {
                int mid = (l + r) / 2;
                if (nums[mid] > nums[mid + 1])
                    r = mid;
                else
                    l = mid + 1;
            }
            return l;
        }
    }
}
