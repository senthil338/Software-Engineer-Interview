using System;
using CodingPractice.DataStructure.BinarySearchTree;
using CodingPractice.StringManipulation;
using CodingPractice.DesignPattern;
using CodingPractice.HackerRank;
using CodingPractice.SortingAlgorithm;
using CodingPractice.Amazon;
using ConsoleApplication1.Amazon;
using System.Linq;
using System.Collections.Generic;
using CodingPractice.Coding_Exercises;
using CodingPractice.OnlineProblem;
namespace CodingPractice
{

    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="roadsAvailable"></param>
        /// <param name="costNewRoadsConstruct"></param>
        /// <returns></returns>
        public static int solve( int[,] roadsAvailable, int[,] costNewRoadsConstruct)
        {
            int numTotalAvailableCities = 0;
            int numNewRoadsConstruct = 2;
            if (numTotalAvailableCities > 50)
            {
                return -1;
            }
            Dictionary<int, int> costMap = new Dictionary<int, int>();
            for (int i = 0; i < roadsAvailable.GetLength(0); i++)
            {
                if(!costMap.ContainsKey(roadsAvailable[i, 0]))
                costMap.Add(roadsAvailable[i, 0], 0);
                if (!costMap.ContainsKey(roadsAvailable[i, 1]))
                    costMap.Add(roadsAvailable[i, 1], 0);
              
            }

            int previousCost = 0;
            int previoussource = 0;
            for (int j =0;j< costNewRoadsConstruct.GetLength(0); j++)
            {
                int source = costNewRoadsConstruct[j,0];
                int destination = costNewRoadsConstruct[j, 1];
                int min_cost = costNewRoadsConstruct[j, 2];
                if (0 <= j && j < numNewRoadsConstruct)
                {
                   if (min_cost < 1 && min_cost > 1000)
                    {
                        continue;
                    }
                    // if (destination <= numNewRoadsConstruct)
                    {
                        if (costMap.ContainsKey(source) && costMap.ContainsKey(destination))
                        {
                            if (costMap[source] != 0 && previousCost > min_cost)
                                costMap[source] = previousCost = costMap[source] < min_cost ? costMap[source] : min_cost;
                            else if (previousCost > min_cost || previousCost == 0)
                            {
                                if (previousCost == 0)
                                {
                                    costMap[source] = min_cost;
                                    previousCost = min_cost;
                                    previoussource = source;
                                }
                                else if (previousCost > min_cost)
                                {
                                    costMap[previoussource] = min_cost;
                                    previousCost = min_cost;
                                }

                            }
                        }
                        else if (costMap.ContainsKey(source) && !costMap.ContainsKey(destination))
                        {

                            costMap.Add(destination, min_cost);
                            previousCost = min_cost;

                        }
                        else if (!costMap.ContainsKey(source))
                        {
                            costMap.Add(source, min_cost);
                        }
                    }
                }

            }

          
            int total = 0;
            foreach(KeyValuePair<int,int> key in costMap)
            {
                total += costMap[key.Key];
            }

            return total;
        }
        
      
        
         public static void getMinimumCostToConstruct_1()
        {
            //int numTotalAvailableCities = 6;
            //int numTotalAvailableRoads = 3;
            //int[,] roadsAvailable = { { 1, 4 }, { 4, 5 }, { 2, 3 } };
            //int[,] costNewRoadsToConstruct = { { 1, 2, 5 }, { 1, 3, 10 }, { 1, 6, 2 }, { 5, 6, 5 } };
            //int numNewRoadsConstruct = 4;

            //int numTotalAvailableCities = 6;
            //int numTotalAvailableRoads = 4;
            //int[,] roadsAvailable = { { 1, 2 }, { 2, 3 }, { 4, 5 }, { 3, 5 } };
            //int[,] costNewRoadsToConstruct = { { 1, 6, 410 }, { 2, 4, 800 } };
            //int numNewRoadsConstruct = 2;

            //int[,] roadsAvailable = { { 1, 4 }, { 4, 5 }, { 2, 3 } };
            //int[,] costToConstructNewRoads = { { 1, 2, 5 }, { 1, 3, 10 }, { 6, 1, 2 }, { 5, 6, 5 } };
            //int[,] roadsAvailable = { { 1, 2 }, { 2, 3 }, { 4, 5 }, { 3, 5 } };
            //int[,] costToConstructNewRoads = { { 1, 6, 410 }, { 2, 4, 800 } };

            int[,] roadsAvailable = { { 1, 2 }, { 2, 3 }, { 4, 5 }, { 5, 6 } };
            int[,] costToConstructNewRoads = { { 1, 5, 110 }, { 2, 4, 84 }, { 3, 4, 79 } };

            solve(roadsAvailable, costToConstructNewRoads);
          

        }

       
        static void Main_1(string[] args)
        {
           // CareerCup.GenerateSet();
          //  Stair_Case.Steps();
            // CodingPractice.DataStructure.DFS_1.Graph.dfs();
            AddDigit add = new AddDigit();
            add.Digit();
            CodingPractice.DataStructure.dfs.DFSWithStack();
            Console.ReadLine();
            //MergeTwoArray.mergeArrayinTheSameArray_1();
            BinaryTree tree = new BinaryTree();
            tree.findSum(51);
            getMinimumCostToConstruct_1();

           // string[] input = { "mi2 jog mid pet", "wz3 34 54 398", "a1 alps cow bar", "x4 45 21 7" };
           // string[] input = { "t2 13 121 98","r1 box ape bit","b4 xi me nu","br8 eat nim did","w1 has uni gry","f5 52 54 31" };
            string[] input = { "ykc 82 01","eo first qpx","09z cat hamster","06f 12 25 6","az0 first qpx","236 cat dog rabbit snake" };
          

            //LetterSubSequence.lengthSubSequenceShopper();
            //TruckSpace.Truck();
            //Amazon_Air_Shipping.AirShipping();
            //Console.ReadLine();
            //int[][] arr = new int[3][];
            //arr[0] = new int[3] { 1,2,100};
            //arr[1] = new int[3] { 2, 5, 100 };
            //arr[2] = new int[3] { 3, 4, 100 };

            //ArrayManipulation.arrayManipulation(5,arr);
            //Count_Triplets.countTriplets();
            //AmazonDemo.generalizedGSD();
            //GraphAlgorithm.Graph.Node graph = new GraphAlgorithm.Graph.Node(1);
            //graph.AddEdge(1, 2);
            //graph.AddEdge(1, 3);
            //graph.AddEdge(1, 4);
            //graph.AddEdge(2, 3);

            //WordExclude.retrieveWords();
            //// StringManipulations.combine("abc",new System.Text.StringBuilder(),0);
            //AbstractFactory.main();


            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
