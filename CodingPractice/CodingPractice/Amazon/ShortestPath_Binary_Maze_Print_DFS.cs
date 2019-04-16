using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Books
{
    class ShortestPath_Binary_Maze_Print_DFS
    {
        
        //DFS, Time O(n^2), Space O(n^2)
        static int shortestPath(int[][] matrix, int[] start, int[] end)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            bool[][] visited = new bool[m][];
            for(int j = 0; j < n; j++)
            {
                visited[j] = new bool[n];
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                        visited[i][j] = true;
                    else
                        visited[i][j] = false;
                }
            }
            int count = visitUtil(matrix, start, end, visited, int.MaxValue, 0);
            return count;
        }
        //recursion function
        static int visitUtil(int[][] matrix, int[] start, int[] end, bool[][] visited, int shortest, int dist)
        {
            int sx = start[0], sy = start[1];
            int dx = end[0], dy = end[1];

            //if start or end is 0, or (x, y) pair is invalid, return
            if (matrix[sx][sy] == 0 || matrix[dx][dy] == 0 || !isValid(matrix, sx, sy, visited))
                return int.MaxValue;

            //find destination
            if (sx == dx && sy == dy)
            {
                return Math.Min(dist, shortest);
            }

            visited[sx][sy] = true;
            // moving up
            if (isValid(matrix, sx - 1, sy, visited))
                shortest = visitUtil(matrix, new int[] { sx - 1, sy }, end, visited, shortest, dist + 1);

            // moving down
            if (isValid(matrix, sx + 1, sy, visited))
                shortest = visitUtil(matrix, new int[] { sx + 1, sy }, end, visited, shortest, dist + 1);

            // moving left
            if (isValid(matrix, sx, sy - 1, visited))
                shortest = visitUtil(matrix, new int[] { sx, sy - 1 }, end, visited, shortest, dist + 1);

            // moving right
            if (isValid(matrix, sx, sy + 1, visited))
                shortest = visitUtil(matrix, new int[] { sx, sy + 1 }, end, visited, shortest, dist + 1);

            //backtracking 
            visited[sx][sy] = false;
            return shortest;
        }
        //utility function to check the (x,y) pair is valid
        static bool isValid(int[][] matrix, int x, int y, bool[][] visited)
        {
            if (x >= 0 && x < matrix.Length && y >= 0 && y < matrix[0].Length && matrix[x][y] == 1 && !visited[x][y])
                return true;
            return false;
        }

    }
}
