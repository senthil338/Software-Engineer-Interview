using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Coding_Exercises
{
    class KNearestPoint
    {
        private double compute_euclidean_distance(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
        
        public void nearest_neighbor(double[,] points,double[,] goal,int k)
        {
            double[,] distances = new double[points.Length, points.Length];

            for(int i = 0; i < points.Length; i++)
            {
                double distance = compute_euclidean_distance(points[i,0], points[i,1], goal[i,0], goal[i,1]);
                distances[i, 0] = distance;


            }
        }
//        #region Solution 1
				
//public class Program
//    {
//        public class Point : IComparable<Point>
//        {
//            public int x { get; set; }
//            public int y { get; set; }

//            public int CompareTo(Point point)
//            {
//                var pointComparer = new PointComparer();
//                return pointComparer.Compare(this, point);
//            }
//            public override string ToString()
//            {
//                return "[" + this.x + "," + this.y + "]";
//            }
//        }
//        public static double Epsilon = 0.0001;
//        public static Point P { get; set; }
//        public static double GetDistanceBetweenTwoPoints(Point point1, Point point2)
//        {
//            var delta1 = point1.x - point2.x;
//            var delta2 = point1.y - point2.y;
//            return Math.Sqrt(Math.Pow(delta1, 2) + Math.Pow(delta2, 2));
//        }
//        public class PointComparer : IComparer<Point>
//        {
//            public int Compare(Point point1, Point point2)
//            {
//                var d1 = GetDistanceBetweenTwoPoints(P, point1);
//                var d2 = GetDistanceBetweenTwoPoints(P, point2);
//                var res = 0;
//                if (Math.Abs(d1 - d2) < Epsilon) res = 0;
//                else if (d1 > d2) res = 1;
//                else res = -1;
//                return res;
//            }
//        }
//        public static Point[] FindKNearestPoints(Point[] points, int k)
//        {
//            if (points.Length <= k)
//            {
//                return null;
//            }
//            var pointComparer = new PointComparer();
//            var pq = new IntervalHeap<Point>(pointComparer);
//            /*for (var i=0; i<k; i++){
//                pq.Add(points[i]);
//            }
//            for (var i=k; i<points.Length; i++){
//                if (points[i].CompareTo(pq.FindMax()) >= 0) continue;
//                pq.DeleteMax();
//                pq.Add(points[i]);
//            }*/
//            for (var i = 0; i < k; i++)
//            {
//                pq.Add(points[i]);
//            }
//            for (var i = k; i < points.Length; i++)
//            {
//                pq.Add(points[i]);
//                if (pq.Count > k)
//                {
//                    pq.DeleteMax();
//                }

//            }
//            var kNearest = new Point[k];
//            var j = 0;
//            foreach (var point in pq)
//            {
//                kNearest[j] = point;
//                j++;
//            }
//            return kNearest;
//        }
//        public static void Main()
//        {
//            var point1 = new Point { x = 8, y = 5 }; //d=6
//            var point2 = new Point { x = 2, y = 3 }; //d=2
//            var point3 = new Point { x = -3, y = 5 }; //d=5
//            var point4 = new Point { x = 4, y = 7 }; //d=2.82
//            var point5 = new Point { x = 2, y = -2 }; //d=7
//            P = new Point { x = 2, y = 5 };
//            var points = new Point[5] { point1, point2, point3, point4, point5 };
//            var kNearest = FindKNearestPoints(points, 3);
//            foreach (var point in kNearest)
//            {
//                Console.Write(point + " ");
//            }
//        }
//    }
//    #endregion

}
}
