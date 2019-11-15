using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Coding_Exercises
{
    public class Factorial
    {
        /***
         * https://www.geeksforgeeks.org/factorial-large-number/
         * 
         ***/

        static int factorial(int n)
        {
            int res = 1, i;
            for (i = 2; i <= n; i++)
                res *= i;
            return res;
        }

    }
}
