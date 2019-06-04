[Source code](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/GraphAlgorithm/Graph.cs)
<br>



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
1. Undirected  or bidirected graph
<br>
    <img src="https://github.com/senthil338/coding_interview/blob/master/Images/undirected.jpg" 
 width="150" height="150" border="4" alt="Undirected Graph" />
2. Directed graph
<br>
        <img src="https://github.com/senthil338/coding_interview/blob/master/Images/directed.jpg" 
 width="150" height="150" border="4" alt="Directed Graph" />
3. Weighted graph
<br>
        <img src="https://github.com/senthil338/coding_interview/blob/master/Images/weighted.jpg" 
 width="150" height="150" border="4" alt="Weighted Graph" />
 
 ### Number of way to represent Graph 
 
1. Adjacency Matrix - by Array
        <br><img src="https://github.com/senthil338/coding_interview/blob/master/Images/adj.jpg" 
 width="100" height="100" border="4" alt="Undirected Graph" />

2. Adjacency List - by LinkedList
        <br><img src="https://github.com/senthil338/coding_interview/blob/master/Images/mat.jpg" 
 width="100" height="100" border="4" alt="Undirected Graph" />

#### Important Topic 
1. Depth First Search
2. Breath Fisrt Search


