using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.DataStructure
{

    public class DFS_1
    {
        public class Vertex
        {
            public string Letter;
            public bool Visited;
            public Vertex(string Letter)
            {
                this.Letter = Letter;
                this.Visited = false;
            }
        }
        public class Graph
        {
            private static int Max_Vertex = 20;
            private static Vertex[] Vertex_List;
            private static int[][] adjMat;
            private static int nVerts;
            private static Stack<int> s;

            public Graph()
            {
                Vertex_List = new Vertex[Max_Vertex];
                adjMat = new int[Max_Vertex][];
                nVerts = 0;
                s = new Stack<int>();
                for(int i =0;i< Max_Vertex;i++)
                {
                    adjMat[i] = new int[Max_Vertex];
                }
            }

            public void AddVertex(string letter)
            {
                Vertex_List[nVerts++] = new Vertex(letter);
            }

            public void AddEdge(int start,int end)
            {
                adjMat[start][end] = 1;
                adjMat[end][start] = 1;

            }

            public static void dfs()
            {
                Add();
                Vertex_List[0].Visited = true;
                printVertex(0);
                s.Push(0);
                while (s.Count != 0)
                {

                    int v = GetAdjUnvisitedVetex(s.Peek());
                    if (v == -1)
                    {
                        s.Pop();
                    }
                    else
                    {
                        Vertex_List[v].Visited = true;
                        printVertex(v);
                        s.Push(v);
                    }
                }
            }
            public static int GetAdjUnvisitedVetex(int v)
            {
                for(int j = 0; j < nVerts; j++)
                {
                    if(adjMat[v][j] == 1 && Vertex_List[j].Visited == false)
                    {
                        return j;
                    }
                }
                return -1;
            }
            public static void Add()
            {
                Graph graph = new Graph();
                graph.AddVertex("A");
                graph.AddVertex("B");
                graph.AddVertex("C");
                graph.AddVertex("D");
                graph.AddVertex("E");
                graph.AddVertex("F");
                graph.AddVertex("G");
                graph.AddVertex("H");

                graph.AddEdge(0, 1);
                graph.AddEdge(0, 3);
                graph.AddEdge(0, 6);
                graph.AddEdge(1, 4);
                graph.AddEdge(1, 5);
                graph.AddEdge(2, 5);
                graph.AddEdge(2, 7);
                graph.AddEdge(3, 5);
                graph.AddEdge(4, 6);
            }

            public static void printVertex(int v)
            {
                Console.WriteLine(Vertex_List[v].Letter + " ");
            }
        }
    }
}
