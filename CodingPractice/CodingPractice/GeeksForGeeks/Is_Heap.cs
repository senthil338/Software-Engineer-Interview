using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    /// <summary>
    ///Arr[(i -1) / 2] returns its parent node.
    ///Arr[(2 * i) + 1] returns its left child node.
    ///Arr[(2 * i) + 2] returns its right child node.
    ///https://www.geeksforgeeks.org/how-to-check-if-a-given-array-represents-a-binary-heap/
    /// </summary>
    class Is_Heap
    {
        public static void isHeap()
        {
            int[] arr = { 90, 15, 10, 7, 12, 2, 7, 3 };
            isHeap(arr, 0, arr.Length-1);
        }
        #region recursive solution
        /// <summary>
        /// recursive
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="i"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static bool isHeap(int[] arr, int i, int n)
        {
            // If a leaf node  
            if (i > (n - 2) / 2)
            {
                return true;
            }

            // If an internal node and is greater  
            // than its children, and same is  
            // recursively true for the children  
            if (arr[i] >= arr[2 * i + 1] && arr[i] >= arr[2 * i + 2] &&
                isHeap(arr, 2 * i + 1, n) && isHeap(arr, 2 * i + 2, n))
            {
                return true;
            }

            return false;
        }
        #endregion
        #region iterative
        // Returns true if arr[i..n-1]  
        // represents a max-heap  
        static bool isHeap(int[] arr, int n)
        {
            // Start from root and go till  
            // the last internal node  
            for (int i = 0; i <= (n - 2) / 2; i++)
            {
                // If left child is greater,  
                // return false  
                if (arr[2 * i + 1] > arr[i])
                {
                    return false;
                }

                // If right child is greater,  
                // return false  
                if (2 * i + 2 < n && arr[2 * i + 2] > arr[i])
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
