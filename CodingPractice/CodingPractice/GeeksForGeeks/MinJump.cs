using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class MinJump
    {
        /// <summary>
        /// https://github.com/mission-peace/interview/blob/master/src/com/interview/dynamic/MinJumpToReachEnd.java
        /// https://www.youtube.com/watch?v=cETfFsSTGJI
        /// * Space complexity O(n) to maintain result and min jumps
        ///* Time complexity O(n^2)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public int minJump(int[] arr, int[] result)
        {
            int[] jump = new int[arr.Length];
            jump[0] = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                jump[i] = int.MaxValue - 1;
            }

            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] + j >= i)
                    {
                        if (jump[i] > jump[j] + 1)
                        {
                            result[i] = j;
                            jump[i] = jump[j] + 1;
                        }
                    }
                }
            }

            return jump[jump.Length - 1];
        }
    }
}
