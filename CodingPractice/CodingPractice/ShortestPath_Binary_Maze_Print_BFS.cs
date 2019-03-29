using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Books
{
    public class ShortestPath_Binary_Maze_Print_BFS
    {
        //using BFS
       public class Cell 
        {
           public int x;
           public int y;
           public int dist;
           public Cell prev;
            public Cell(int x, int y, int dist, Cell prev)
            {
                this.x = x;
                this.y = y;
                this.dist = dist;
                this.prev = prev;
            }

        }
        static void visit(Cell[][] cells, LinkedList<Cell> queue, int x, int y, Cell parent)
        {
            int dist = parent.dist + 1;
            if (x < 0 || x >= cells.Length || y < 0 || y >= cells[0].Length || cells[x][y] == null)
            {
                return;
            }
            Cell curr = cells[x][y];
            if (dist < curr.dist)
            {
                curr.dist = dist;
                curr.prev = parent;
                queue.AddLast(curr);
            }
        }

        //Time O(n^2), Space O(n^2)
        public static void print(int[][] matrix, int[] start, int[] end)
        {
         
            if (matrix[start[0]][start[1]] == 0 || matrix[end[0]][end[1]] == 0)
                return;

            // Cell[][] cells = new Cell[matrix.Length][matrix[0].Length];
            Cell[][] cells = new Cell[matrix.Length][];
            for (int arr = 0; arr < matrix.Length; arr++)
            {
                cells[arr] = new Cell[matrix[arr].Length];
            }
            for (int i = 0; i < cells.Length; i++)
            {
                for (int j = 0; j < cells[0].Length; j++)
                {
                    if (matrix[i][j] != 0)
                    {
                        cells[i][j] = new Cell(i, j, int.MaxValue, null);
                    }
                }
            }

            LinkedList<Cell> queue = new LinkedList<Cell>();
            Cell src = cells[start[0]][start[1]];
            src.dist = 0;
            queue.AddFirst(src);
            Cell dest = null;
            Cell curr;
           var t = queue.First;
           
           // while ((curr = queue.poll()) != null)
          
             while (queue.First!=null && (curr = queue.First.Value) != null)
            {
                queue.RemoveFirst();
                if (curr.x == end[0] && curr.y == end[1])
                {
                    dest = curr;
                }
                visit(cells, queue, curr.x - 1, curr.y, curr);
                visit(cells, queue, curr.x + 1, curr.y, curr);
                visit(cells, queue, curr.x, curr.y - 1, curr);
                visit(cells, queue, curr.x, curr.y + 1, curr);
            }

            if (dest == null)
            {
                return;
            }
            else
            {
                LinkedList<Cell> path = new LinkedList<Cell>();
                curr = dest;
                do
                {
                    path.AddFirst(curr);
                } while ((curr = curr.prev) != null);
                Console.WriteLine(path);
            }
        }

        public static void print()
        {
            int[][] matrix = new int[][] {
            new int[] {1, 1, 1, 1, 1, 1},
            new int[] {1, 1, 0, 1, 0, 1},
            new int[] {1, 0, 0, 0, 1, 1},
            new int[] {1, 1, 1, 0, 1, 0},
            new int[] {0, 0, 0, 0, 0, 0}
       };
            int[] start = { 0, 0 };
            int[] end = { 3, 2 };
            print(matrix, start, end);
        }
    }
}
