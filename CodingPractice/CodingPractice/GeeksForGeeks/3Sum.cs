using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class _3Sum
    {
        public static void Main_1(string[] args)
        {
            int[] arr = { -1, 0, 1, 2, -1, -4 };
            int n = arr.Length;
            findTriplets(arr, n);
            int[] pos = new int[3 + 1];
            Array.Fill(pos, -1);
        }

        /// <summary>
        /// https://leetcode.com/problems/3sum/
        /// https://www.geeksforgeeks.org/find-triplets-array-whose-sum-equal-zero/
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static List<int[]> findTriplets_sorted(int[] arr, int n)
        {
            bool found = false;
            List<int[]> result = new List<int[]>();
            // sort array elements 
            Array.Sort(arr);

            for (int i = 0; i < n - 1; i++)
            {
                // initialize left and right 
                int start = i + 1;
                int end = n - 1;
                int initialVal = arr[i];
                if (i == 0 || arr[i] > arr[i - 1]) // do not vist the previous elements was same value  // newly added
                {
                    while (start < end)
                    {
                        if (initialVal + arr[start] + arr[end] == 0)
                        {
                            result.Add(new int[] { initialVal, arr[start], arr[end] });
                            // print elements if it's sum is zero 
                            Console.Write(initialVal + " ");
                            Console.Write(arr[start] + " ");
                            Console.WriteLine(arr[end] + " ");

                            start++;
                            end--;
                            found = true;
                        }

                        // If sum of three elements is less 
                        // than zero then increment in left 
                        else if (initialVal + arr[start] + arr[end] < 0)
                        {
                            int currentStart = start; // // newly added
                            //do not vist the previous elements was same value  // newly added
                            while (arr[currentStart] == arr[start] && (start < end))
                                start++;
                        }

                        // if sum is greater than zero than 
                        // decrement in right side 
                        else
                        {
                            int currentEnd = end; // // newly added
                            //do not vist the previous elements was same value  // newly added
                            while (arr[currentEnd] == arr[start] && (start < end))
                                end--;
                            
                        }
                    }
                }
            }

            if (found == false)
                Console.WriteLine(" No Triplet Found");

            return result;
        }

        public static void findTriplets(int[] arr, int n)
        {
            bool found = false;

            for (int i = 0; i < n - 1; i++)
            {
                // Find all pairs with sum equals to 
                // "-arr[i]" 
                HashSet<int> s = new HashSet<int>();
                for (int j = i + 1; j < n; j++)
                {
                    int x = -(arr[i] + arr[j]);
                    if (s.Contains(x))
                    {
                        Console.Write("{0} {1} {2}\n", x, arr[i], arr[j]);
                        found = true;
                    }
                    else
                    {
                        s.Add(arr[j]);
                    }
                }
            }

            if (found == false)
            {
                Console.Write(" No Triplet Found\n");
            }
        }
    }
}
