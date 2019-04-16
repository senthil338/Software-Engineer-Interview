using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.DataStructure
{
    public class dfs
    {
        public class Vertex
        {
            public string Letter;
            public bool Visited;
            public List<Vertex> adj;
            public Vertex(string Letter)
            {
                this.Letter = Letter;
                this.adj = new List<Vertex>();
                this.Visited = false;
            }

            public override string ToString()
            {
                return this.letter;
            }

            public void addNeighbour(Vertex vertex)
            {
                adj.Add(vertex);
            }

            public string letter { get { return this.Letter; } set { this.letter = value; } }
        }

        public static List<Vertex> Add()
        {
            Vertex A = new Vertex("A");
            Vertex B = new Vertex("B");
            Vertex C = new Vertex("C");
            Vertex D = new Vertex("D");
            Vertex E = new Vertex("E");
            Vertex F = new Vertex("F");
            Vertex G = new Vertex("G");
            Vertex H = new Vertex("H");

            A.addNeighbour(B);
            A.addNeighbour(D);
            A.addNeighbour(G);

            B.addNeighbour(A);
            B.addNeighbour(F);
            B.addNeighbour(E);

            C.addNeighbour(F);
            C.addNeighbour(H);

            D.addNeighbour(A);
            D.addNeighbour(F);

            E.addNeighbour(G);
            E.addNeighbour(B);

            F.addNeighbour(B);
            F.addNeighbour(C);
            G.addNeighbour(E);
            G.addNeighbour(A);
            List<Vertex> verList = new List<Vertex>();
            verList.Add(A);
            verList.Add(B);
            verList.Add(C);
            verList.Add(D);
            verList.Add(E);
            verList.Add(F);
            verList.Add(G);
            verList.Add(H);

            return verList;
        }

        public static void DFSWithStack()
        {
            Vertex A = new Vertex("A");
            Vertex B = new Vertex("B");
            Vertex C = new Vertex("C");
            Vertex D = new Vertex("D");
            Vertex E = new Vertex("E");
            Vertex F = new Vertex("F");
            Vertex G = new Vertex("G");
            Vertex H = new Vertex("H");

           
            A.addNeighbour(D);
            A.addNeighbour(B);
            A.addNeighbour(G);

            B.addNeighbour(A);
            B.addNeighbour(E);
            B.addNeighbour(F);
           

            C.addNeighbour(F);
            C.addNeighbour(H);

            D.addNeighbour(A);
            D.addNeighbour(F);

            E.addNeighbour(G);
            E.addNeighbour(B);

            F.addNeighbour(B);
            F.addNeighbour(C);
            G.addNeighbour(E);
            G.addNeighbour(A);

            H.addNeighbour(C);

            bfsUsingQueue(A);
            //dfsUsingStack(A);
         
        }
        //public static void dfs_recursive(Vertex node)
        //{
        //    Console.WriteLine(node.ToString());
        //    var neighbours = node.adj;
        //    node.Visited = true;
        //    for (int i = 0; i < neighbours.Count; i++)
        //    {
        //        Vertex n = neighbours[i];
        //        if (n != null && !n.Visited)
        //        {
        //            dfs_recursive(n);
        //        }
        //    }
        //}

        /// <summary>
        /// Time Complexity: O(V+E) where V is number of vertices in the graph and E is number of edges in the graph.
        /// </summary>
        /// <param name="node"></param>
        public static void dfsUsingStack(Vertex node)
        {
            Stack<Vertex> stack = new Stack<Vertex>();
            stack.Push(node);
           
            node.Visited = true;
            while (stack.Count!=0)
            {
                Vertex element = stack.Pop();

                Console.WriteLine(element.ToString() + " ");
                List<Vertex> neighbours = element.adj;
                for (int i = 0; i < neighbours.Count; i++)
                {
                    Vertex n = neighbours[i];
                    if (n != null && !n.Visited)
                    {
                       
                        stack.Push(n);
                        n.Visited = true;

                    }
                }
            }
        }


        public static void bfsUsingQueue(Vertex node)
        {
            Queue<Vertex> queue = new Queue<Vertex>();
            queue.Enqueue(node);

            node.Visited = true;
            while (queue.Count != 0)
            {
                Vertex element = queue.Dequeue();

                Console.WriteLine(element.ToString() + " ");
                List<Vertex> neighbours = element.adj;
                for (int i = 0; i < neighbours.Count; i++)
                {
                    Vertex n = neighbours[i];
                    if (n != null && !n.Visited)
                    {

                        queue.Enqueue(n);
                        n.Visited = true;

                    }
                }
            }
        }
    }
}
