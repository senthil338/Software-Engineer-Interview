using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Books
{
    /// <summary>
    /// https://www.techiedelight.com/lee-algorithm-shortest-path-in-a-maze/
    /// Time complexity is O(MN) 
    ///  Space complexity = O(m*n)
    ///  You can optimize the space complexity to O(1) if you change the values of the matrix
    ///  current solution uses BFS
    ///  efficient solution is Dijkstra's Algorithm
    ///  
    /// </summary>
    public class ShortestPath_Binary_Maze
    {
        public class Value
        {
            public int x;
            public int y;
            public Value(int x, int y)
            {
                this.x = x;
                this.y = y;
               
            }
        }
      public  class Node
        {
            public int x;
            public int y;
            public int dist;
           
            public Node(int x, int y, int dist)
            {
                this.x = x;
                this.y = y;
                this.dist = dist;
               // this.path = path;
            }

          

        }
        // M x N matrix
       // private static int M = 10;
        //private static int N = 10;

        // Below arrays details all 4 possible movements from a cell
        private static int[] row = { -1, 0, 0, 1 };
        private static int[] col = { 0, -1, 1, 0 };

       // Function to check if it is possible to go to position(row, col)
    // from current position. The function returns false if (row, col)
    // is not a valid position or has value 0 or it is already visited
        private static bool isValid(int[][] mat, bool[][] visited, int row, int col,int N,int M)
        {
            return (row >= 0) && (row < M) && (col >= 0) && (col < N)
                            && mat[row][col] == 1 && !visited[row][col];
        }

        public static void BFS()
        {
            int[][] mat =
           {
            new int[]{ 1, 1, 1, 1, 1, 1 },
            new int[] { 1, 1, 0, 1, 0, 1 },
            new int[] { 1, 0, 0, 0, 1, 1 },
            new int[] { 1, 1, 1, 0, 1, 1 },
            new int[] {0, 0, 0, 0, 0, 0}

            };
            //int[][] mat =
            //{
            //new int[]{ 1, 0, 1, 1, 1, 1, 0, 1, 1, 1 },
            //new int[] { 1, 0, 1, 0, 1, 1, 1, 0, 1, 1 },
            //new int[] { 1, 1, 1, 0, 1, 1, 0, 1, 0, 1 },
            //new int[] { 1, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
            //new int[] {1, 1, 1, 0, 1, 1, 1, 1, 1, 0 },
            //new int[] { 1, 0, 1, 1, 1, 1, 0, 1, 0, 0 },
            //new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
            //new int[] {1, 0, 1, 1, 1, 1, 0, 1, 1, 1 },
            //new int[]  {1, 1, 0, 0, 0, 0, 1, 0, 0, 1 }

            //};
            //int[][] mat =
            //{
            ////new int[]{ 1, 1, 1, 1, 1, 0, 0, 1, 1, 1 },
            ////new int[] { 0, 1, 1, 1, 1, 1, 0, 1, 0, 1 },
            ////new int[] { 0, 0, 1, 0, 1, 1, 1, 0, 0, 1 },
            ////new int[] { 1, 0, 1, 1, 1, 0, 1, 1, 0, 1 },
            ////new int[] { 0, 0, 0, 1, 0, 0, 0, 1, 0, 1 },
            ////new int[] { 1, 0, 1, 1, 1, 0, 0, 1, 1, 0 },
            ////new int[] { 0, 0, 0, 0, 1, 0, 0, 1, 0, 1 },
            ////new int[] { 0, 1, 1, 1, 1, 1, 1, 1, 0, 0 },
            ////new int[]  { 1, 1, 1, 1, 1, 0, 0, 1, 1, 1 },
            ////new int[]  { 0, 0, 1, 0, 0, 1, 1, 0, 0, 1 },
            //};

            // Find shortest path from source (0, 0) to
            // destination (7, 5)
            BFS(mat, 0, 0, 3, 2);
        }
        private static void printPath(List<Value> path)
        {
            foreach(Value val in path)
            {
                Console.WriteLine("( " + val.x + " " + val.y + " )");
            }
        }
        //Find Shortest Possible Route in a matrix mat from source
        // cell (i, j) to destination cell (x, y)
        private static void BFS(int[][] mat, int i, int j, int x, int y)
        {
            // construct a matrix to keep track of visited cells
            // bool[][] visited = new bool[M][N];
           
            
            bool[][] visited = new bool[mat.Length][];
            for(int arr = 0; arr < mat.Length; arr++)
            {
                visited[arr] = new bool[mat[arr].Length];
            }
           
           
            // create an empty queue
            Queue<Node> q = new Queue<Node>();

          
            // mark source cell as visited and enqueue the source node
            visited[i][j] = true;
            q.Enqueue(new Node(i, j, 0));
           

            // stores length of longest path from source to destination
            int min_dist = int.MaxValue;
           
            // run till queue is not empty
            while (q.Count != 0)
            {
                // pop front node from queue and process it
                Node node = q.Dequeue();
               // output.Add(node);
                 // (i, j) represents current cell and dist stores its
                 // minimum distance from the source
                 i = node.x;
                j = node.y;
               // path = node.path;
                int dist = node.dist;

                // if destination is found, update min_dist and stop
                if (i == x && j == y)
                {
                   // printPath(path);
                    min_dist = dist;
                    break;
                }

                // check for all 4 possible movements from current cell
                // and enqueue each valid movement
              
                for (int k = 0; k < 4; k++)
                {
                    // check if it is possible to go to position
                    // (i + row[k], j + col[k]) from current position
                   
                    if (isValid(mat, visited, i + row[k], j + col[k], mat[0].Length, mat.Length))
                    {
                        // mark next cell as visited and enqueue it
                        //path.Add(new Value(i + row[k], j + col[k]));
                        Node enNode = new Node(i + row[k], j + col[k], dist + 1);
                       
                         visited[i + row[k]][j + col[k]] = true;
                       
                        q.Enqueue(enNode);
                      
                        // output.Add(enNode);
                        //if(k==3)

                    }
                    //flag = true;
                    
                }
             

            }

            if (min_dist != int.MaxValue)
            {
               Console.WriteLine("The shortest path from source to destination " +
                                         "has length " + min_dist);
            }
            else
            {
                Console.WriteLine("Destination can't be reached from given source");
            }
        }
    }
}
