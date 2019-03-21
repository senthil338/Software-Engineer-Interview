using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.DataStructure.BinarySearchTree
{
    public class BinarySearch
    {

        //public static int binarySearch(int[] array,int search)
        public static int binarySearch()
        {
            int[] array = { 1, 2, 3, 4, 5, 7, 8, 9, 11, 12, 13, 15, 25, 26, 34, 35, 45, 56, 67, 78 };
            int first, last, middle, search;
            search = 26;
            first = 0;
            last = array.Length - 1;
            middle = (first + last) / 2;

            while (first <= last)
            {
                if (array[middle] < search)
                    first = middle + 1;
                else if (array[middle] == search)
                {
                    Console.WriteLine("{0} found at location {1}.\n", search, middle + 1);
                    break;
                }
                else
                    last = middle - 1;

                middle = (first + last) / 2;
            }
            if (first > last)
                Console.WriteLine("Not found! %d is not present in the list.\n", search);

            return 0;
        }

        /// <summary>
        /// Count the number of occurrences in a sorted array
        /// Input: arr[] = {1, 1, 2, 2, 2, 2, 3,},   x = 2
        /// Output: 4 // x (or 2) occurs 4 times in arr[]
        /// </summary>
        /// <returns></returns>
        public static int binarySearchCount()
        {
            int[] array = { 1, 2, 2, 2, 3, 4, 5, 7, 8, 9, 11, 12, 13, 15, 25, 26, 34, 35, 45, 56, 67, 78 };
            int first, last, middle,     search;
            search = 2;
            first = 0;
            last = array.Length - 1;
            middle = (first + last) / 2;
            int count = 0;
            while (first <= last)
            {
                if (array[middle] < search)
                    first = middle + 1;
                else if (array[middle] == search)
                {
                    count++;
                    first = middle + 1;
                    // Console.WriteLine("{0} found at location {1}.\n", search, middle + 1);
                    //break;
                }
                else
                    last = middle - 1;

                middle = (first + last) / 2;
            }
            if (first > last)
                Console.WriteLine("Not found! %d is not present in the list.\n", search);

            return count;
        }


    }
}
