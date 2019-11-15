using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class MoveZero
    {
        /// <summary>
        /// https://leetcode.com/explore/interview/card/facebook/5/array-and-strings/262/
        /// </summary>
        /// <param name="nums"></param>
        void moveZeroes(int[] nums)
        {
            for (int lastNonZeroFoundAt = 0, cur = 0; cur < nums.Length; cur++)
            {
                if (nums[cur] != 0)
                {
                    //swap(nums[lastNonZeroFoundAt++], nums[cur]);
                }
            }
        }

        void moveZeroes_1(int[] nums)
        {
            int lastNonZeroFoundAt = 0;
            // If the current element is not 0, then we need to
            // append it just in front of last non 0 element we found. 
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[lastNonZeroFoundAt++] = nums[i];
                }
            }
            // After we have finished processing new elements,
            // all the non-zero elements are already at beginning of array.
            // We just need to fill remaining array with 0's.
            for (int i = lastNonZeroFoundAt; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
