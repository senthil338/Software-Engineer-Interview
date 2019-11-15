using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class ProductOfArrayExceptSelf
    {
        /// <summary>
        /// https://leetcode.com/explore/interview/card/facebook/5/array-and-strings/3016/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        #region using extra space
        public int[] productExceptSelf(int[] nums)
        {

            // The length of the input array
            int length = nums.Length;

            // The left and right arrays as described in the algorithm
            int[] Left = new int[length];
            int[] Right = new int[length];

            // Final answer array to be returned
            int[] answer = new int[length];

            // L[i] contains the product of all the elements to the left
            // Note: for the element at index '0', there are no elements to the left,
            // so L[0] would be 1
            Left[0] = 1;
            for (int i = 1; i < length; i++)
            {

                // L[i - 1] already contains the product of elements to the left of 'i - 1'
                // Simply multiplying it with nums[i - 1] would give the product of all
                // elements to the left of index 'i'
                Left[i] = nums[i - 1] * Left[i - 1];
            }

            // R[i] contains the product of all the elements to the right
            // Note: for the element at index 'length - 1', there are no elements to the right,
            // so the R[length - 1] would be 1
            Right[length - 1] = 1;
            for (int i = length - 2; i >= 0; i--)
            {

                // R[i + 1] already contains the product of elements to the right of 'i + 1'
                // Simply multiplying it with nums[i + 1] would give the product of all
                // elements to the right of index 'i'
                Right[i] = nums[i + 1] * Right[i + 1];
            }

            // Constructing the answer array
            for (int i = 0; i < length; i++)
            {
                // For the first element, R[i] would be product except self
                // For the last element of the array, product except self would be L[i]
                // Else, multiple product of all elements to the left and to the right
                answer[i] = Left[i] * Right[i];
            }

            return answer;
        }
        #endregion

        #region with out extra space
        public int[] productExceptSelf_1(int[] nums)
        {

            // The length of the input array 
            int length = nums.Length;

            // Final answer array to be returned
            int[] answer = new int[length];

            // answer[i] contains the product of all the elements to the left
            // Note: for the element at index '0', there are no elements to the left,
            // so the answer[0] would be 1
            answer[0] = 1;
            for (int i = 1; i < length; i++)
            {

                // answer[i - 1] already contains the product of elements to the left of 'i - 1'
                // Simply multiplying it with nums[i - 1] would give the product of all 
                // elements to the left of index 'i'
                answer[i] = nums[i - 1] * answer[i - 1];
            }

            // R contains the product of all the elements to the right
            // Note: for the element at index 'length - 1', there are no elements to the right,
            // so the R would be 1
            int R = 1;
            for (int i = length - 1; i >= 0; i--)
            {

                // For the index 'i', R would contain the 
                // product of all elements to the right. We update R accordingly
                answer[i] = answer[i] * R;
                R *= nums[i];
            }

            return answer;
        }
        #endregion
    }
}

