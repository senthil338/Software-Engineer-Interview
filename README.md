# coding_interview

This project contains most of the interview preparation question , answer and the reference for the questions <b>
(leetcode, geeksforgeeks, youtupe etc).</b> I started preparing Data Structure and Alogirthm and solving the problem using C#. I don't
find enough solution using C# as a language, So I started documeting that and mostly used online site like <b>leetcode, hackerrank,
hackerearth , youtupe </b> as my learning source and I wanted to combine all together and provide the single source for interview 
preparation. This will not cover 100% problem but this will help us to know from where to start and provide good understanting of 
interview praparation, In online most of the problem solved by using Python and Java, So I learned Python myself and as a C# developer
picking a Java its not much difficult task.This project provide overview of Design pattern, OOPS, Object Oriented design 
for realtime problem, problem solving and System Design. I will keep update this repostory as I learn. 
Basic understading of programming language is require to understand the code.
Suggestions and comments are welcome. 

* [Technical Interview Questions](#tech)
   * [Data Structures and Algorithms](#dsalg)
   * [DBMS](#dbms)
   * [Operating System](#os)
   * [System Design](#design)
   * [Miscellaneous](#misc)
* [References](#ref)
<br/>
<h1> <b name="tech">Technical Interview Questions</b> </h1>
 <br/>
 <b name="dsalg">Data Structures and Algorithms</b>
 <p> 
  <h5>Why do we need data structures? </h5>
Data structure is a particular way of storing and organizing information in a computer so that it can be retrieved and used most productively.

Data structures are important for the following reasons:

1. Data structures are used in almost every program or software system.
2. Each Data Structure allows data to be stored in specific manner.
3. Data Structure allows efficient data search and retrieval.
4. Specific Data structures are decided to work for specific problems.
 </p>
 
  <br/><br/>
<b> Data structure:</b> Method to store information
</br> <b>Algorithm: </b> Method for solving a problem.
<br/>
<b>Note:- </b>
<b>Time complexity</b> of an algorithm quantifies the amount of time taken by an algorithm to run as a function of the length of the input.
</br>
<br>
<b>Space complexity</b> of an algorithm quantifies the amount of space or memory taken by an algorithm to run as a function of the length of the input.<br/><br>
Algorithm complexity is commonly represented with the O(n) notation, also known as asymptotic notation or <b> “Big O notation”</b>, where n is the function of the size of the input data. <br>
We need to know how well our algorithm perform in <b> Best Case, Average Case and Worst Case </b>
<br/>
###### Refer:- http://bigocheatsheet.com/
<br/>
<br/>
Most interviewers won't ask about specific algorithms for binary tree balancing or other complex algorithms and 
 You're usually only expected to know the basics</font>
 
## Data Structure
- [Array](#array) -> An array, is a data structure consisting of a collection of elements (values or variables), each identified by at least one array index.
- [Linked Lists](#linkedlist) -> A linked list is a linear data structure where each element is a separate object. Linked list elements are not stored at contiguous location; the elements are linked using pointers.
- ArrayList -> It is similar to an array, except that it grows automatically as you add items in it. Unlike an array, you don't need to specify the size of ArrayList.
- [Trees](#trees) -> Tree, [Binary Search Tree](#bst), [Binary Tree](#bt). A tree is a collection of nodes connected by directed (or undirected) edges.
- Tires
- Graph
- Stack
- Queue
- Heap
- HashTable or Dictinoary

## Algorithm
- Breadth-First Search
- Depth-First Search
- Tree Traversal
- Merge Sort
- QuickSort
- Insertion sort, Selection sort, Bubble sort. (just to let you know)
- Binary Search
- Dijkstra

 
Most of the time we hear the term called Greed and Naive/Brute-force  Algorithm
I don't want to explain more depth but it's very useful to know the term as we go indepth we hear this work more offten </br></br>
<b>Greed algorithm :</b> Greedy algorithm is one which finds the feasible solution at every stage with the hope of finding global optimum solution.
</br><b>Brute-force Algorithms :</b> Solves a problem in the most simple, direct, or obvious way.
</br></br> <h3> Programming Concept </h3>
<table>
<tr><th>Programming Concepts</th></tr>
<tr><td>Dynamic Programming</td></tr>
<tr><td>Backtracking</td></tr>
<tr><td>Big O Time and Space complexcity</td></tr>
<tr><td>Memory </td></tr>
<tr><td>Recursion</td></tr>

</table>

<br/>

 #### Array
<p name="array"></p>
An array, is a data structure consisting of a collection of elements (values or variables), each identified by at least one array index.
<br/>
 


    
1. An array stores a fixed-size sequential collection of elements of the same type. 
	 - (i.e) char array only accept the char likewise integer only accept int value
2. Array is a reference type, so you need to use the new keyword to create an instance of the array. For example,
	- int[] balance = new int[10];
3. You can assign values to the array at the time of declaration, as shown,
	- char[] arr1 = {'g', 'e', 'e', 'k', 's'};
	- You can also create and initialize an array, as shown
	- int [] marks = new int[5]  { 99,  98, 92, 97, 95};




### Types of Array
- **One dimensional arrays**
	char[] arr1 = {'g', 'e', 'e', 'k', 's'};
- **Two dimensional**
    int[,] array = new int[4, 2];
- **Multi dimensional arrays**
	int[, ,] array1 = new int[4, 2, 3];
- **Jagged arrays** - A jagged array is an array whose elements are arrays. The elements of a jagged array can be of different dimensions and sizes. A jagged array is sometimes called an "array of arrays." 

	int[][] jaggedArray = new int[3][]; <br>
	jaggedArray[0] = new int[5]; <br>
	jaggedArray[1] = new int[4]; <br>
	jaggedArray[2] = new int[2]; <br>

Reference : [Multidimensional-arrays](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays)
<br>Reference : [Jagged-arrays](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/jagged-arrays)
<br/>

##### Basic Operations on Arrays and Complexity
- Insert - O(n), Get - O(1), Delete - O(n) , Size
<br/>
<p name="linkedlist"></p>

#### Linked List 
A linked list consists of nodes where each node contains a data field and a reference(link) to the next node in the list.
<br>
<img src="https://github.com/senthil338/coding_interview/blob/master/Images/linkedlist.JPG" 
 width="300" height="120" border="4" alt="Linked List Representation" />
<br>
Reference :- https://en.wikipedia.org/wiki/Linked_list <br>

##### Basic Operations on Linked List and Complexity
- Insert - O(1), Get - O(n), Delete - O(1)
<br>
Linked list require head node , reference pointer for next node , and data to store

```cs
class Node {
	Node next;
	int val;
	Node(int val) {
	        this.val = val;
		next = null;
	}
}
```
### Types of Linked List 
Source code and more details can be found by clicking below link
1. [Singly Linked List](https://github.com/senthil338/coding_interview/tree/master/CodingPractice/CodingPractice/DataStructure/LinkedList)
<br/><img src="https://github.com/senthil338/coding_interview/blob/master/Images/Singly-linked-list.png" 
 width="220" height="22" border="4" alt="Linked List" /><br>
2. [Doubly Linked List](https://github.com/senthil338/coding_interview/tree/master/CodingPractice/CodingPractice/DataStructure/DoublyLinkedList)<br>
<img src="https://github.com/senthil338/coding_interview/blob/master/Images/Doubly-linked-list.png" 
 width="220" height="22" border="4" alt="Doubly Linked List" /> <br>
3. Circular Linked List <br>
<img src="https://github.com/senthil338/coding_interview/blob/master/Images/Circularly-linked-list.png" 
 width="220" height="22" border="4" alt="Circular Linked List" />
 -  A circularly linked list, all nodes are linked in a continuous circle, without using null. Circularly linked lists can be either singly or doubly linked.


<p name="trees"></p>

#### Trees

In this section we are going to cover Tree, Binary Search Tree and Binary Tree, B+ tree will be covered later as part of DBMS 


A tree is a collection of nodes connected by directed (or undirected) edges. A tree is a nonlinear data structure, compared to arrays, linked lists, stacks and queues which are linear data structures. A tree can be empty with no nodes or a tree is a structure consisting of one node called the root and zero or one or more subtrees. A tree has following general properties:
<br><br>
One node is distinguished as a root; <br>
Every node (exclude a root) is connected by a directed edge from exactly one other node; A direction is: parent -> children <br>

![alt text][trees]

[trees]: https://github.com/senthil338/coding_interview/blob/master/Images/trees.jpg "Trees"

 <br>
 
- A is a parent of B, C, D, <br>
- B is called a child of A. <br>
- On the other hand, B is a parent of E, F, K <br>
- Nodes with no children are called leaves.  In the above picture, C, E, F, L, G are leaves. <br>
- Nodes with the same parent are called siblings. In the picture, B, C, D are called siblings <br>
- The depth of a node is the number of edges from the root to the node.  The depth of K is 2. <br>
- The height of a node is the number of edges from the node to the deepest leaf. The height of B is 2. <br>


##### Implementing a simple tree data structure
```cs
 public class TreeNode
        {
            public string Value { get; set; }
            public List<TreeNode> Neighbors { get; set; }

            public TreeNode(string s)
            {
                Value = s;
                Neighbors = new List<TreeNode>();
            }
        }
```
	
	
We can create a tree with 3 descendents as follows:	


```cs
TreeNode abe = new TreeNode("Abe");
TreeNode homer = new TreeNode("Homer");
TreeNode bart = new TreeNode("Bart");
TreeNode lisa = new TreeNode("Lisa");
TreeNode maggie = new TreeNode("Maggie");

abe.Neighbors.Add(homer);
homer.Neighbors.Add(bart);
homer.Neighbors.Add(lisa);
homer.Neighbors.Add(maggie);
```
[Source code and more details](https://github.com/senthil338/coding_interview/tree/master/CodingPractice/CodingPractice/DataStructure/Trees)


##### Tree represent shown as below.


![alt text][imp_tree]

[imp_tree]: https://github.com/senthil338/coding_interview/blob/master/Images/imp-tree.jpg "Trees"



#### Binary Tree

Trees nodes can have zero or more children. However, when a tree has at the most two children, then it’s called binary tree.


#### Binary Search Tree

For a binary tree to be a binary search tree, the data of all the nodes in the left sub-tree of the root node should be  the data of the root. The data of all the nodes in the right subtree of the root node should be  the data of the root.




