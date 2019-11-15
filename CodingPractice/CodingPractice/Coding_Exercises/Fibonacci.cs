using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Coding_Exercises
{
    class Fibonacci
    {
        /* simple recursive program for Fibonacci numbers */
        int fib(int n)
        {
            if (n <= 1)
                return n;
            return fib(n - 1) + fib(n - 2);
        }

        #region Memorization (Top down)
        static int MAX = 100;
        static int NIL = -1;
        static int[] lookup = new int[MAX];

        /* Function to initialize NIL  
        values in lookup table */
        static void initialize()
        {
            for (int i = 0; i < MAX; i++)
                lookup[i] = NIL;
        }
        /* function for nth Fibonacci number */
        /// <summary>
        /// Memoization (Top Down): The memoized program for a problem is similar to the recursive version with a small
        /// modification that it looks into a lookup table before computing solutions. We initialize a 
        /// lookup array with all initial values as NIL. Whenever we need the solution to a subproblem, 
        /// we first look into the lookup table. If the precomputed value is there then we return that value, 
        /// otherwise, we calculate the value and put the result in the lookup table so that it can be reused later
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int fib_mem(int n)
        {
            if (lookup[n] == NIL)
            {
                if (n <= 1)
                    lookup[n] = n;
                else
                    lookup[n] = fib_mem(n - 1) + fib_mem(n - 2);
            }
            return lookup[n];
        }

        #endregion

        #region Tabulation (Bottom Up):
        /// <summary>
        /// The tabulated program for a given problem builds a table in bottom up fashion and returns the
        /// last entry from table. For example, for the same Fibonacci number, we first calculate fib(0) 
        /// then fib(1) then fib(2) then fib(3) and so on. So literally, we are building 
        /// the solutions of subproblems bottom-up.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int fib_tab(int n)
        {
            int[] f = new int[n + 1];
            f[0] = 0;
            f[1] = 1;
            for (int i = 2; i <= n; i++)
                f[i] = f[i - 1] + f[i - 2];
            return f[n];
        }
        #endregion
    }
}
