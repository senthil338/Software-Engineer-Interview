using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class Circular_Array_Rotation_and_GCD_HCM
    {

        /// <summary>
        /// https://www.hackerrank.com/challenges/circular-array-rotation/problem
        /// Java code
        /// Easy 20
        /// </summary>
        /// <param name="args"></param>
        public static void main_5(String[] args)
        {
            //Scanner in = new Scanner(System.in);
            //int n = in.nextInt();
            //int k = in.nextInt();
            //int q = in.nextInt();
            //int[] a = new int[n];
            //int[] b = new int[n]; //rotated array
            //for (int a_i = 0; a_i < n; a_i++)
            //{
            //    a[a_i] = in.nextInt();
            //}

            //int alt = k % n;
            //System.arraycopy(a, 0, b, alt, n - alt);
            //System.arraycopy(a, n - alt, b, 0, alt);

            //for (int a0 = 0; a0 < q; a0++)
            //{
            //    int m = in.nextInt();
            //    System.out.println(b[m]);
            //}

        }
        #region left roated
        public static void Main_11()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            leftRotate(arr, 2, 7);
            printArray(arr, 7);
        }

        /// <summary>
        /// to roated use the Juggling Algorithm
        /// Time complexity : O(n)
        /// Auxiliary Space : O(1)
        /// https://www.geeksforgeeks.org/array-rotation/
        /// </summary>
        /// <param name="a"></param>
        /// <param name="k"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        static void leftRotate(int[] arr, int d,
                            int n)
        {
            int i, j, k, temp;
            for (i = 0; i < gcd(d, n); i++)
            {
                /* move i-th values of blocks */
                temp = arr[i];
                j = i;
                while (true)
                {
                    k = j + d;
                    if (k >= n)
                        k = k - n;
                    if (k == i)
                        break;
                    arr[j] = arr[k];
                    j = k;
                }
                arr[j] = temp;
            }
        }
        static void printArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
        }

        /* Fuction to get gcd of a and b*/
        /// <summary>
        /// https://en.wikipedia.org/wiki/Euclidean_algorithm
        /// Euclidean_algorithm HCM or GCD
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return gcd(b, a % b);
        }
        #endregion
        /// <summary>
        /// https://www.geeksforgeeks.org/reversal-algorithm-right-rotation-array/
        /// Time Complexity : O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        #region right roated
        static void reverseArray(int[] arr, int start,
                                        int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        // Function to right rotate  
        // arr[] of size n by d  
        static void rightRotate(int[] arr, int d, int n)
        {
            reverseArray(arr, 0, n - 1);
            reverseArray(arr, 0, d - 1);
            reverseArray(arr, d, n - 1);
        }

     
        // Driver code 
        public static void Main_2()
        {
            int[] arr = {1, 2, 3, 4, 5,
                    6, 7, 8, 9, 10};

            int n = arr.Length;
            int k = 3;

            rightRotate(arr, k, n);
            printArray(arr, n);

        }
        #endregion
    }
}
