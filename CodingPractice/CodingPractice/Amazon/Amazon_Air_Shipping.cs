using System;
using System.Collections.Generic;
using System.Text;
namespace CodingPractice.Amazon
{
    public class Amazon_Air_Shipping
    {

        public class Node
        {
            public int x;
            public int y;
            public int sum;
            public Node(int x, int y,int sum)
            {
                this.x = x;
                this.y = y;
                this.sum = sum;
            }
        }

        public static void AirShipping()
        {
            int[][] forwardRouteList = { new int[] { 1, 2000 }, new int[] { 2, 4000 }, new int[] { 3, 6000 } };
            int[][] returnRouteList = { new int[] { 1, 2000 } }; // 6000
            int dist = 7000;
            //int[][] forwardRouteList = { new int[] { 1, 3000 }, new int[] { 2, 5000 }, new int[] { 3, 7000 }, new int[] { 4, 10000 } };
            //int[][] returnRouteList = { new int[] { 1, 2000 }, new int[] { 2, 3000 }, new int[] { 3, 4000 }, new int[] { 4, 5000 } };
            //int dist = 10000;
            Dictionary<int, Node> result = AirShipping(dist, forwardRouteList, returnRouteList);
            int temp = 0;
            int mapkey = 0;
            foreach(KeyValuePair<int,Node> key in result)
            {
                if(key.Value.sum <= dist)
                {
                    if (key.Value.sum >= temp)
                    {
                        temp = key.Value.sum;
                        mapkey = key.Key;
                        if (temp == dist)
                        {
                            Console.WriteLine("X : " + key.Value.x + " Y: " + key.Value.y);
                        }
                    }
                }
            }
            if(temp < dist)
            {
                Console.WriteLine("X : " + result[mapkey].x + " Y: " + result[mapkey].y);
            }
        }

        public List<int> test()
        {
            return new List<int>();
        }

        
    
        public static Dictionary<int, Node> AirShipping(int dist, int[][] forwardRouteList, int[][] returnRouteList)
        {
            int[] result = new int[returnRouteList.Length];
            Dictionary<int, Node> dictionary = new Dictionary<int, Node>();
            List<Node> l = new List<Node>();
           // new List<Node>
           
            int colDivided = returnRouteList.Length%2 == 0? returnRouteList.Length / 2: (returnRouteList.Length +1)/2;
            for (int row = 0; row < forwardRouteList.Length; row++)
            {
                for (int col = 0; col < colDivided; col++)
                {
                    int sum = forwardRouteList[row][1] + returnRouteList[col][1];
                    if ((sum <= dist && row == 0) || dictionary[col].sum <= dist && sum <= dist && sum >= dictionary[col].sum)
                    {
                        //if (row == 0 || dictionary[col].sum <= dist && sum <= dist && sum >= dictionary[col].sum)
                        //{
                            if (dictionary.ContainsKey(col) && dictionary[col].sum <= sum)
                            {
                              
                                dictionary[col] = new Node(row + 1, col + 1, sum);
                            }
                            else if(!dictionary.ContainsKey(col))
                            {
                                dictionary.Add(col, new Node(row + 1, col + 1, sum));
                            }
                      }
                    //to reduce the time complexity by half
                    int colright = returnRouteList.Length - 1 - col;
                    sum = forwardRouteList[row][1] + returnRouteList[colright][1];
                    if ((sum <= dist && row == 0) || dictionary[colright].sum <= dist && sum <= dist && sum >= dictionary[colright].sum)
                    {
                        //if (row == 0 || dictionary[col].sum <= dist && sum <= dist && sum >= dictionary[col].sum)
                        //{
                        if (dictionary.ContainsKey(colright) && dictionary[colright].sum <= sum)
                        {

                            dictionary[colright] = new Node(row + 1, colright + 1, sum);
                        }
                        else if (!dictionary.ContainsKey(colright))
                        {
                            dictionary.Add(colright, new Node(row + 1, colright + 1, sum));
                        }
                    }
                }
            }
            return dictionary;
        }
    }
}
           
        

    

