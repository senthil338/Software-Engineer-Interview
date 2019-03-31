using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Books
{
    public class Solution
    {
#region find k nearest points
        public class Point
        {
            public int x;
            public int y;
            public Point(int[] p)
            {
                this.x = p[0];
                this.y = p[1];
            }
            public int getX()
            {
                return x;
            }
            public int getY()
            {
                return y;
            }
        }
        public  static void kClosest()
        {
            // int[][] points = new int[][] {new int[] { 3, 3 },new int[] { 5, -1 }, new int[] { -2, 4 } };
            //int[][] points = new int[][] { new int[] { 3, 3 }, new int[] { 5, -1 }, new int[] { -2, 4 } };
              int[][] points = new int[][] { new int[] { 0,1 }, new int[] { 1, 0 } };
           // int[][] points = new int[][] { new int[] { 3, 3 }, new int[] { 5, -1 },new int[]{ -2, 4 } };
            kClosest(points, 2);
        }
        /// <summary>
        /// https://www.geeksforgeeks.org/find-k-closest-points-to-the-origin/
        /// https://leetcode.com/problems/k-closest-points-to-origin/
        ///point = [[3, 3], [5, -1], [-2, 4]], K = 2
        /// o/p [[3, 3], [-2, 4]]
        /// 
        /// point = [[1, 3], [-2, 2]], K  = 1
        /// [[-2, 2]]
        /// Space O(n) , time Complexcity O(n) and soring O(n long n) = O(n log n)
        /// using selectoin sort we can improve the algorithm by Constant space and O(n) time
        /// 
        /// </summary>
        /// <param name="points"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        private static int[][] kClosest(int[][] points, int K)
        {
            double[] combinationArr = new double[points.Length];
            Dictionary<Double, int[]> pt = new Dictionary<double, int[]>();
            Dictionary<Double, List<Point>> map = new Dictionary<double, List<Point>>();
            for (int i = 0; i < points.Length; i++)
            {
                int[] input = points[i];

                for (int j = 0; j < input.Length - 1; j++)
                {
                    int x = input[j];
                    int y = input[j + 1];
                    double powerX = Math.Pow(x, 2);
                    double powerY = Math.Pow(y, 2);
                    double combination = (Double)(Math.Sqrt(powerX + powerY));
                    // if(!pt.ContainsKey(combination))
                    if (map.ContainsKey(combination))
                    {
                        map[combination].Add(new Point(points[i]));
                    }
                    else
                    {
                        List<Point> list = new List<Point>();
                        list.Add(new Point(points[i]));
                        map.Add(combination, list);
                    }
                   // pt.Add(combination, points[i]);
                    combinationArr[i] = combination;
                }
            }
            Array.Sort(combinationArr);
            int[][] kpoints = new int[K][];
            int count = 0, l = 0;
            while (count < K)
            {
                int len = map[combinationArr[l++]].Count;
                for (int j = 0; j < len; j++)
                {
                    //kpoints[n] =
                    kpoints[count++] = new int[] { map[combinationArr[l-1]][j].x, map[combinationArr[l-1]][j].y };
                }
                
            }
            return kpoints;
        }
        #endregion
        #region find k neares points 1 "using bucket sort"
        public class Coordinate
        {
           public int x;
           public int y;
            public Coordinate(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        /// <summary>
        /// https://www.cnblogs.com/EdwardLiu/p/6546969.html
        /// https://github.com/cherryljr/LeetCode/blob/master/K%20Closest%20Points%20to%20Origin.java using QuickSelection
        /// </summary>
        public static void findK()
        {
           
            Coordinate c1 = new Coordinate(1, 1);
            Coordinate c2 = new Coordinate(2, 5);
            Coordinate c3 = new Coordinate(1, 3);
            Coordinate c4 = new Coordinate(1, 2);

            List<Coordinate> list = new List<Coordinate>();
            list.Add(c1);
            list.Add(c2);
            list.Add(c3);
            list.Add(c4);
            List<Coordinate> res = findK(list, 2);
            // findK()
        }
        public static List<Coordinate> findK(List<Coordinate> input, int k)
        {
            Dictionary<Coordinate, int> map = new Dictionary<Coordinate, int>();
            int longest = 0;
            foreach (Coordinate each in input)
            {
                int distance = cal(each);
                map.Add(each, distance);
                longest = Math.Max(longest, distance);
            }

            List<Coordinate>[] arr = new List<Coordinate>[longest + 1];
            foreach (KeyValuePair<Coordinate,int> each in map)
            {
                int dis = map[each.Key];
                if (arr[dis] == null)
                {
                    arr[dis] = new List<Coordinate>();
                }
                arr[dis].Add(each.Key);
            }
            List<Coordinate> res = new List<Coordinate>();
            int j = 0;
            for (int i = 0; i < longest; i++)
            {
                if (arr[i] != null)
                {
                    if (j < k)
                    {
                        res.Add(arr[i][0]);
                        j++;
                    }
                }
            }
            return res;
          
        }

        public static int cal(Coordinate a)
        {
            //double powerX = Math.Pow(a.x, 2);
            //double powerY = Math.Pow(a.y, 2);
            //double combination = (Double)(Math.Sqrt(powerX + powerY));
            return a.x * a.x + a.y * a.y;
        }
     

        #endregion


    }
}


