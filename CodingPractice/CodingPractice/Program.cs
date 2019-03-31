using System;
using CodingPractice.DataStructure.BinarySearchTree;
using CodingPractice.StringManipulation;
using CodingPractice.DesignPattern;
using CodingPractice.HackerRank;
using CodingPractice.SortingAlgorithm;
using CodingPractice.Amazon;
namespace CodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            TruckSpace.Truck();
            Amazon_Air_Shipping.AirShipping();
            Console.ReadLine();
            int[][] arr = new int[3][];
            arr[0] = new int[3] { 1,2,100};
            arr[1] = new int[3] { 2, 5, 100 };
            arr[2] = new int[3] { 3, 4, 100 };

            ArrayManipulation.arrayManipulation(5,arr);
            Count_Triplets.countTriplets();
            AmazonDemo.generalizedGSD();
            GraphAlgorithm.Graph.Node graph = new GraphAlgorithm.Graph.Node(1);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(2, 3);

            WordExclude.retrieveWords();
            // StringManipulations.combine("abc",new System.Text.StringBuilder(),0);
            AbstractFactory.main();


            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
