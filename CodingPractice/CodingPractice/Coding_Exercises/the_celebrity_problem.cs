using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Coding_Exercises
{
    class the_celebrity_problem
    {
        #region using stack
        // Person with 2 is celebrity 
        static int[][] MATRIX = {new int[] { 0, 0, 1, 0 },
                            new int[]{ 0, 0, 1, 0 },
                           new int[] { 0, 0, 0, 0 },
                           new int[] { 0, 0, 1, 0 } };

        // Returns true if a knows  
        // b, false otherwise 
        static bool knows(int a, int b)
        {
            bool res = (MATRIX[a][b] == 1) ?
                                         true :
                                         false;
            return res;
        }

        // Returns -1 if celebrity  
        // is not present. If present, 
        // returns id (value from 0 to n-1). 
        static int findCelebrity(int n)
        {
            Stack<int> st = new Stack<int>();
            int c;

            // Step 1 :Push everybody 
            // onto stack 
            for (int i = 0; i < n; i++)
            {
                st.Push(i);
            }

            while (st.Count > 1)
            {
                // Step 2 :Pop off top 
                // two persons from the  
                // stack, discard one  
                // person based on return 
                // status of knows(A, B). 
                int a = st.Pop();
                int b = st.Pop();

                // Step 3 : Push the  
                // remained person onto stack. 
                if (knows(a, b))
                {
                    st.Push(b);
                }

                else
                    st.Push(a);
            }

            c = st.Pop();

            // Step 5 : Check if the last  
            // person is celebrity or not 
            for (int i = 0; i < n; i++)
            {
                // If any person doesn't 
                //  know 'c' or 'a' doesn't  
                // know any person, return -1 
                if (i != c && (knows(c, i) ||
                              !knows(i, c)))
                    return -1;
            }
            return c;
        }

        // Driver Code 
        public static void main_2(String[] args)
        {
            int n = 4;
            int result = findCelebrity(n);
            if (result == -1)
            {
                //System.out.println("No Celebrity");
            }
            else
            {

                // System.out.println("Celebrity ID " + result);
            }
        }
        #endregion

        #region using 2 pointer
        // Returns -1 if celebrity  
        // is not present. If present,  
        // returns id (value from 0 to n-1). 
        static int findCelebrity_2_pointer(int n)
        {
            // Initialize two pointers  
            // as two corners 
            int a = 0;
            int b = n - 1;

            // Keep moving while  
            // the two pointers 
            // don't become same. 
            while (a < b)
            {
                if (knows(a, b))
                    a++;
                else
                    b--;
            }

            // Check if a is actually  
            // a celebrity or not 
            for (int i = 0; i < n; i++)
            {
                // If any person doesn't  
                // know 'a' or 'a' doesn't 
                // know any person, return -1 
                if (i != a && (knows(a, i) ||
                              !knows(i, a)))
                    return -1;
            }
            return a;
        }
        #endregion
    }
}
