using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.OnlineProblem
{
   public class CareerCup
    {
        public static Dictionary<int, int> GenerateSet()
        {
            // https://www.careercup.com/question?id=5095657344860160
            //int[,] set = { { 1, 2 }, { 1, 3 }, { 2, 4 } }; // 1,3 & 2, 4
           // int[,] set = { { 1, 2 }, { 1, 3 }, { 1, 1 }, { 2, 4 },{ 1, 5 },{ 5, 1 },{ 5, 4 } };
            //1,5 & 2,4 & 5,4
            int[,] set = { { 1, 2 }, { 1, 3 }, { 1, 1 }, { 2, 4 },{ 1, 5 },{ 4, 9 },{ 5, 4 },{ 2, 8 } };
            //1,5 & 2,8 & 5,4 & 4,9
            Dictionary<int, int> map = new Dictionary<int, int>();

            for(int i = 0; i < set.GetLength(0); i++)
            {
                if (!map.ContainsKey(set[i, 0]) && !map.ContainsKey(set[i, 1]) && set[i, 0] != set[i, 1])
                {
                    map.Add(set[i, 0], set[i, 1]);
                    map.Add(set[i, 1], set[i, 0]);
                }
                else if (map.ContainsKey(set[i, 0]) && map[set[i, 0]] < set[i, 1])
                {
                    map[set[i, 0]] = set[i, 1];
                }
                if (!map.ContainsKey(set[i, 0]))
                {
                    map.Add(set[i, 0], set[i, 1]);
                }
                if (!map.ContainsKey(set[i, 1]))
                {
                    map.Add(set[i, 1], 0);
                }
                
            }
            Dictionary<int, int> result = new Dictionary<int, int>();
            foreach (KeyValuePair<int, int> key in map)
            {
                if (key.Value != 0)
                {
                    result.Add(key.Key, key.Value);
                }
            }
            return result;
        }

        public static List<int> getIntersection(int[] arr1, int[] arr2)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        list.Add(arr1[i]);
                    }
                }
            }
            return list;
        }
    }
}
