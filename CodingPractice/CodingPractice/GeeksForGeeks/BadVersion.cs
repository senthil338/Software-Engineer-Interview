using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class BadVersion
    {

        /// <summary>
        /// Time O(logN)
        /// space 1  
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int firstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (isBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }

        private bool isBadVersion(int n)
        {
            return false;
        }
    }
}
