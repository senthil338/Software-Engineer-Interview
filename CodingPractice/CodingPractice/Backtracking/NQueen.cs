using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.GeeksForGeeks
{
   public class NQueen
    {
       static int N = 4;

        public static bool solveNQ()
        {
            int[][] board = {new int[] {0, 0, 0, 0},
            new int[] {0, 0, 0, 0},
            new int[] {0, 0, 0, 0},
            new int[] {0, 0, 0, 0}
        };


            return NQueenUtil(board, 0);
      }
        private static bool isSafe(int[][] board, int row, int col)
        {
            int i, j;

            /* Check this row on left side */
            for (i = 0; i < col; i++)
                if (board[row][i] == 1)
                    return false;

            /* Check upper diagonal on left side */
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
                if (board[i][j] == 1)
                    return false;

            /* Check lower diagonal on left side */
            for (i = row, j = col; j >= 0 && i < N; i++, j--)
                if (board[i][j] == 1)
                    return false;

            return true;
        }

        private static bool NQueenUtil(int[][] board, int col)
        {
            if (col >= N)
                return true;

            /* Consider this column and try placing 
               this queen in all rows one by one */
            for (int i = 0; i < N; i++)
            {
                /* Check if the queen can be placed on 
                   board[i][col] */
                if (isSafe(board, i, col))
                {
                    /* Place this queen in board[i][col] */
                    board[i][col] = 1;

                    /* recur to place rest of the queens */
                    if (NQueenUtil(board, col + 1) == true)
                        return true;

                    
                    board[i][col] = 0; // BACKTRACK 
                }
            }

            /* If the queen can not be placed in any row in 
               this colum col, then return false */
            return false;
        }
    }
}
