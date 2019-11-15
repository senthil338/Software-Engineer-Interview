using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class UnionIntersection
    {
        #region unsorted array Union
        static void printUnion(int[] arr1, int[] arr2)
        {
            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < arr1.Length; i++)
                hs.Add(arr1[i]);
            for (int i = 0; i < arr2.Length; i++)
                hs.Add(arr2[i]);

            Console.WriteLine(string.Join(", ", hs));
        }
        #endregion

        #region unsorted array Intersection
        // Prints intersection of arr1[0..m-1] and arr2[0..n-1] 
        static void printIntersection(int[] arr1, int[] arr2)
        {
            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < arr1.Length; i++)
                hs.Add(arr1[i]);

            for (int i = 0; i < arr2.Length; i++)
                if (hs.Contains(arr2[i]))
                    Console.Write(arr2[i] + " ");
        }
        #endregion

        #region Union for Sorted Array
        static int printUnion(int[] arr1,
                  int[] arr2, int m, int n)
        {
            int i = 0, j = 0;

            while (i < m && j < n)
            {
                if (arr1[i] < arr2[j])
                    Console.Write(arr1[i++] + " ");
                else if (arr2[j] < arr1[i])
                    Console.Write(arr2[j++] + " ");
                else
                {
                    Console.Write(arr2[j++] + " ");
                    i++;
                }
            }

            /* Print remaining elements of  
                the larger array */
            while (i < m)
                Console.Write(arr1[i++] + " ");
            while (j < n)
                Console.Write(arr2[j++] + " ");

            return 0;
        }
        #endregion

        #region Intersction for Sorted Array
        static void printIntersection(int[] arr1,
                     int[] arr2, int m, int n)
        {
            int i = 0, j = 0;

            while (i < m && j < n)
            {
                if (arr1[i] < arr2[j])
                    i++;
                else if (arr2[j] < arr1[i])
                    j++;
                else
                {
                    Console.Write(arr2[j++] + " ");
                    i++;
                }
            }
        }
        #endregion
        // Driver Code 
        static void Main_1()
        {
            int[] arr1 = { 7, 1, 5, 2, 3, 6,8,20 };
            int[] arr2 = { 3, 8, 6, 20, 7 };

            Console.WriteLine("Union of two arrays is : ");
            printUnion(arr1, arr2);

            Console.WriteLine("\nIntersection of two arrays is : ");
            printIntersection(arr1, arr2);
        }
    }
}

