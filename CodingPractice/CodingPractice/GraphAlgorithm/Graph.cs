using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GraphAlgorithm
{
    public class Graph
    {
        Dictionary<int, Node> nodeLookup = new Dictionary<int, Node>();
        public class Node
        {
            private int id;
            LinkedList<Node> adjacent = new LinkedList<Node>();
            Graph graph = new Graph();
            public Node(int id)
            {
                this.id = id;
               
            }

            private Node getNode(int id)
            {
              
                if (!graph.nodeLookup.ContainsKey(id))
                {
                    Node node = new Node(id);
                    graph.nodeLookup.Add(id, node);
                }
               return graph.nodeLookup.GetValueOrDefault(id);
              
            }

            public void AddEdge(int source,int destination)
            {
                Node s = getNode(source);
                Node d = getNode(destination);
                s.adjacent.AddLast(d);
            }
            
            public bool HasPathDFS(int source,int destination)
            {
                Node s = getNode(source);
                Node d = getNode(destination);
                HashSet<int> visited = new HashSet<int>();
                return hasPathDFS(s,d,visited);
            }
            #region Depth first search
            private bool hasPathDFS(Node source,Node destination, HashSet<int> visited)
            {
                if (visited.Contains(source.id))
                {
                    return true;
                }
                visited.Add(source.id);
                if(source == destination)
                {
                    return true;
                }
                foreach(Node child in source.adjacent)
                {
                    if (hasPathDFS(child, destination, visited))
                    {
                        return true;
                    }
                }
                return false;
            }
            #endregion
            #region Breadh first search
            private bool hasPathBFS(Node source,Node destination)
            {
                LinkedList<Node> nextToVisit = new LinkedList<Node>();
                HashSet<int> visited = new HashSet<int>();
                nextToVisit.AddLast(source);
                while(nextToVisit.Count > 0)
                {
                    Node node = nextToVisit.First.Value;
                    nextToVisit.RemoveFirst();
                    if (node == destination)
                    {
                        return true;
                    }
                    if (visited.Contains(node.id))
                    {
                        continue;
                    }
                    visited.Add(node.id);
                    foreach(Node child in node.adjacent)
                    {
                        nextToVisit.AddLast(child);
                    }
                }
                return false;
            }
            #endregion
        }
    }
}
