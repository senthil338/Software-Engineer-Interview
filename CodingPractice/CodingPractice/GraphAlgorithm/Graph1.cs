using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GraphAlgorithm
{
    class Graph1
    {
        int V;
        LinkedList<string>[] adjListArray;

        public Graph1(int V)
        {
            adjListArray = new LinkedList<string>[V];
            for (int i = 0; i < V; i++)
            {
                adjListArray[i] = new LinkedList<string>();
            }
        }

       
    }
}
