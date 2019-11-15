[Source code](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/GraphAlgorithm/Graph.cs)
<br>

#### Important Topic 
1. [Depth First Search](#dfs) - Uses stack 
2. [Breath Fisrt Search](#dfs) - Uses Queue
3. Find a lowest cost
4. Find a shortest route

### Graph

A graph is a data structure where a node can have zero or more adjacent elements. The connection between two nodes is called edge. Nodes can also be called vertices
<br>
<img src="https://github.com/senthil338/coding_interview/blob/master/Images/graph.JPG" 
 width="300" height="150" border="4" alt="Graph" />
 <br>
In the above Graph, the set of vertices V = {0,1,2,3,4} and the set of edges E = {01, 12, 23, 34, 04, 14, 13}.
<br>


Reference: [geeksforgeeks](https://www.geeksforgeeks.org/graph-data-structure-and-algorithms/)


#### Graph can be implemented as below
```cs
 public class GraphNode
        {
            public string Value { get; set; }
            public List<GraphNode> Neighbors { get; set; }

            public GraphNode(string s)
            {
                Value = s;
                Neighbors = new List<GraphNode>();
            }
        }
```



<img src="https://github.com/senthil338/coding_interview/blob/master/Images/graph-ex1.jpeg" 
 width="500" height="350" border="4" alt="Linked List" />



A graph is a data structure for storing connected data like a network of people on a social media platform.

#### Types of Graph

![alt text][graphtypes]

[graphtypes]: https://github.com/senthil338/coding_interview/blob/master/Images/graphtypes.png "Types of graph"


 
 #### Number of way to represents graph 
 
1. Adjacency Matrix - by Array
        <br><img src="https://github.com/senthil338/coding_interview/blob/master/Images/adj.jpg" 
 width="100" height="100" border="4" alt="Undirected Graph" />

2. Adjacency List - by LinkedList
        <br><img src="https://github.com/senthil338/coding_interview/blob/master/Images/mat.jpg" 
 width="100" height="100" border="4" alt="Undirected Graph" />

<p name="dfs"></p>

### Depth and Breath First Search 

The **depth-first algorithm** sticks with one path, following that path down a graph structure until it ends. The **breadth-first search** approach, however, evaluates all the possible paths from a given node equally, checking all potential vertices from one node together, and comparing them simultaneously.

  <br><img src="https://github.com/senthil338/coding_interview/blob/master/Images/Justsearch.gif" 
 width="50%" height="50%" border="4" alt="Undirected Graph" /> <br>
 
 
Time Complexity for both : O(V+E) where V is number of vertices in the graph and E is number of edges in the graph.


##### Depth First Search
```cs
       private bool hasPathDFS(Node source, Node destination, HashSet<int> visited)
        {
            if (visited.Contains(source.id))
                return true;
            visited.Add(source.id);
            if (source == destination)
                return true;
            foreach (Node child in source.adjacent)
            {
                if (hasPathDFS(child, destination, visited))
                    return true;
            }
            return false;
        }
```

<p name="bfs"></p>


##### Breath First Search
```cs
        private bool hasPathBFS(Node source, Node destination)
        {
            Queue<Node> nextToVisit = new Queue<Node>();
            HashSet<int> visited = new HashSet<int>();
            nextToVisit.Enqueue(source);
            while (nextToVisit.Count > 0)
            {
                Node node = nextToVisit.Peek();
                nextToVisit.Dequeue();
                if (node == destination)
                    return true;
                if (visited.Contains(node.id))
                    continue;
                visited.Add(node.id);
                foreach (Node child in node.adjacent)
                    nextToVisit.Enqueue(child);

            }
            return false;
        }
 ```
##### Differences between DFS and BFS

  - If you know a solution is not far from the root of the tree, a breadth first search (BFS) might be better.
  - If the tree is very deep and solutions are rare, depth first search (DFS) might take an extremely long time, but BFS could be faster.

  - If the tree is very wide, a BFS might need too much memory, so it might be completely impractical.

  - If solutions are frequent but located deep in the tree, BFS could be impractical.

  - If the search tree is very deep you will need to restrict the search depth for depth first search (DFS), anyway (for example with iterative deepening).
