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
- [Tries](#tries) -> Trie is an efficient information retrieval data structure.
- [Graph](#graph) -> A graph is a data structure where a node can have zero or more adjacent elements.
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



<p name="trees"></p>



<p name="tries"></p>








<p name="graph"></p>



