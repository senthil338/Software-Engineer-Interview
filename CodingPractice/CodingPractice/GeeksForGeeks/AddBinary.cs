using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class AddBinary
    {
        #region without Add

        static void Main_1()
        {
           var result = addBinarywithoutAdd("15", "32");
        }

        private static string GetNumberFormBinary(String a, String b)
        {
           
            int _base = 2;
            int x = Convert.ToInt32(a, _base);
            int y = Convert.ToInt32(b, _base);
            int intValue = x + y;
            return Convert.ToString(intValue, 2);
        }

        int add(int a, int b)
        {
            while (b != 0)
            {
                int c = a & b;  // Find the carry bits
                a = a ^ b;  // Add the bits without considering the carry
                b = c << 1;  // Propagate the carry
            }
            return a;
        }
        int subtract(int x, int y)
        {
            // Iterate till there 
            // is no carry 
            while (y != 0)
            {
                // borrow contains common  
                // set bits of y and unset 
                // bits of x 
                int borrow = (~x) & y;

                // Subtraction of bits of x  
                // and y where at least one 
                // of the bits is not set 
                x = x ^ y;

                // Borrow is shifted by one  
                // so that subtracting it from 
                // x gives the required sum 
                y = borrow << 1;
            }
            return x;
        }
        public static String addBinarywithoutAdd(String a, String b)
        {
            int i = a.Length - 1, j = b.Length - 1;
            int answer = 0;
            int carry = 0;
            int x = int.Parse(a);
            int y = int.Parse(b);
            while (y!=0)
            {
               
                answer = x ^ y;
                carry = (x & y) << 1;
                x = answer;
                y = carry;
             
            }

            return x.ToString("2");
        }

        #endregion
        #region with Add
        /// <summary>
        /// https://www.geeksforgeeks.org/program-to-add-two-binary-strings/
        ///  Time complexity: O(max(N,M)), where NN and MM are lengths of the input strings a and b.
        ///  Space complexity: O(max(N,M)) to keep the answer.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string AddTwoBinary(string a,string b)
        {
            // Initialize result 
            string result = "";

            // Initialize digit sum 
            int s = 0;

            // Traverse both strings starting  
            // from last characters 
            int i = a.Length - 1, j = b.Length - 1;
            while (i >= 0 || j >= 0 || s == 1)
            {

                // Comput sum of last  
                // digits and carry 
                s += ((i >= 0) ? a[i] - '0' : 0);
                s += ((j >= 0) ? b[j] - '0' : 0);

                // If current digit sum is  
                // 1 or 3, add 1 to result 
                result = (char)(s % 2 + '0') + result;

                // Compute carry 
                s /= 2;

                // Move to next digits 
                i--; j--;
            }
            return result;
        }
        #endregion
    }
}
