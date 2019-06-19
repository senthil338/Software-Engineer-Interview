# Software Engineering interview question and answer with example problems

Please provide your suggestion to make this document very useful.

#### I have consider the following facts while preparting this document
1. You are expecting an interview soon and you want to cover the most of the important topic as early as possible.
2. Candidate have some basic computer science fundamental knowledge.
3. Speding more than 10 mins on each topic will not be worth if you have tight deadline.
4. Need single source of document for an interview, referring multiple website require considrable amount of time and efforts. 
5. Each topic required some interview questions and answers. 

Note:- Clicking on each link will navigate us to detail page which contains source code using C# and problem you may encounter during interview


This Github repository will covers most of the software engineering interview  question and answers , also reference for the questions <b> (leetcode, geeksforgeeks,hackerrank,hackerearth, youtupe etc).</b> , any one have good understanding of object oriented programming  can able to understand the code. I started documenting all together and provide the single source for an interview preparation. This will not cover 100% interview problem but it will help us to understand all the important topics and it covers some overview of Data Structure and Algorithm, Design Pattern, OOPS, Object Oriented design for a realtime problem, DBMS (SQL and NOSQL), Network, Problem Solving and System Design. I will keep update this repostory as I learn. Basic understading of programming language is require to understand the code.

Suggestions and comments are welcome. 

* [Technical Interview Questions](#tech)
   * [Data Structures and Algorithms](#dsalg)
   * [Design Pattern](#designpattern)
   * [DBMS](#dbms)
   * [Operating System](#os)(#designpattern)
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

#### Data structures are important for the following reasons:

1. Data structures are used in almost every program or software system.
2. Each Data Structure allows data to be stored in specific manner.
3. Data Structure allows efficient data search and retrieval.
4. Specific Data structures are decided to work for specific problems.
 </p>



  - <b>Time complexity</b> of an algorithm quantifies the amount of time taken by an algorithm to run as a function of the length of the input.
  - <b>Space complexity</b> of an algorithm quantifies the amount of space or memory taken by an algorithm to run as a function of the length of the input.<br/><br>
    
         Algorithm complexity is commonly represented with the O(n) notation, - also known as asymptotic 
         notation or “Big O notation”, where n is the function of the size of the input data. 
         We need to know how well our algorithm perform in  Best Case, Average Case and Worst Case 

           
###### Refer:- http://bigocheatsheet.com/

  > Most interviewers won't ask about specific algorithms for binary tree balancing or 
     other complex algorithms and You're usually only expected to know the basics.
 
### Data Structure
Method to store information

| Data Structure &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; |  | 
| --------- | -------------------------------------------- | 
| [Array](https://github.com/senthil338/coding_interview/tree/master/CodingPractice/CodingPractice/DataStructure/Array) | An array, is a data structure consisting of a collection of elements (values or variables), each identified by at least one array index. |	
| [Linked List](https://github.com/senthil338/coding_interview/tree/master/CodingPractice/CodingPractice/DataStructure/LinkedList) | A linked list is a linear data structure where each element is a separate object. Linked list elements are not stored at contiguous location; the elements are linked using pointers. |	
| ArrayList | It is similar to an array, except that it grows automatically as you add items in it. Unlike an array, you don't need to specify the size of ArrayList. |	
| [Trees](https://github.com/senthil338/coding_interview/tree/master/CodingPractice/CodingPractice/DataStructure/Trees) | [Binary Search Tree](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DataStructure/Trees/README.MD#binarytree), [Binary Tree](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DataStructure/Trees/README.MD#binarytree) A tree is a collection of nodes connected by directed (or undirected) edges |	
| [Graph](https://github.com/senthil338/coding_interview/tree/master/CodingPractice/CodingPractice/GraphAlgorithm) | A graph is a data structure where a node can have zero or more adjacent elements. |	
| [Stack](https://github.com/senthil338/coding_interview/tree/master/CodingPractice/CodingPractice/DataStructure/Stack)  | Stack is a linear data structure which represents a simple last-in-first-out (LIFO) |	
| [Queue](https://github.com/senthil338/coding_interview/tree/master/CodingPractice/CodingPractice/DataStructure/Queue) | Queue is a linear data structure which represents a simple first-in-first-out (FIFO)  |	
| [Heap](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DataStructure/Heap/README.MD)  | A Heap or Binary heap is a complete binary tree which satisfies the heap ordering property. |	
| [HashTable/Dictionary](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DataStructure/HashTable/README.MD) | A hash table is a data structure that is used to store keys/value pairs, and retrive value by passing key |	

### Algorithm
Method for solving a problem

| Algorithm &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; |   | Stable |
| --- | --- |  --- | 
| [Depth-First-Search](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/GraphAlgorithm/README.md#dfs)	| The depth-first algorithm sticks with one path, following that path down a graph structure until it ends | N/A	|
| [Breadth-First Search](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/GraphAlgorithm/README.md#dfs) |	The breadth-first search approach, however, evaluates all the possible paths from a given node equally |	N/A |
| [Tree Traversal](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DataStructure/Trees/README.MD#traversals) | A traversal is a process that visits all the nodes in the tree. Since a tree is a nonlinear data structure, there is no unique traversal (BFS, Inorder, Postorder, Preorder) | N/A |
| [Merge Sort](https://github.com/senthil338/coding_interview/tree/master/CodingPractice/CodingPractice/SortingAlgorithm)  |	Divide and Conquer algorithm  | Yes |
| [Quick Sort](https://github.com/senthil338/coding_interview/tree/master/CodingPractice/CodingPractice/SortingAlgorithm) | Divide and Conquer algorithm  |	No |
| [Insertion Sort](https://github.com/senthil338/coding_interview/tree/master/CodingPractice/CodingPractice/SortingAlgorithm) |	 |  Yes |
| [Selection Sort](https://github.com/senthil338/coding_interview/tree/master/CodingPractice/CodingPractice/SortingAlgorithm) |	 | No |
| [Bubble Sort](https://github.com/senthil338/coding_interview/tree/master/CodingPractice/CodingPractice/SortingAlgorithm) |	 | Yes |
| Binary Search |	O(n log(n)) | N/A  |
| Dijkstra |	O(n<sup>2</sup>) | N/A |

  > Most of the time we hear the term called Greed and Naive/Brute-force Algorithm     
      **Greed algorithm :** Greedy algorithm is one which finds the feasible solution at every stage with 
      the hope of finding global optimum solution.       
      **Brute-force Algorithms :** Solves a problem in the most simple, direct, or obvious way.

#### Programming Concept 
|   Programming Concepts |   | 
| --- | --- | 
|  Dynamic Programming |  Dynamic Programming is a method for solving a complex problem by breaking it down into a collection of simpler subproblems, solving each of those subproblems just once, and storing their solutions using a memory. | 
|  Recursion | When a function calls itself, its called Recursion. Recursion is useful in solving problems which can be broken down into smaller problems of the same kind.  |
|   Backtracking  |  In backtracking we can build a solution step by step using recursion; if during the process we realise that is not going to be a valid solution, then we stop computing that solution and we return back to the step before (backtrack)  | 
|  Big O Time and Space complexcity  |   Algorithm complexity is commonly represented with the O(n) notation, also known as asymptotic notation or “Big O notation”, where n is the function of the size of the input data. | 
|   Memory  | **Stack** Variables allocated on the stack are stored directly to the memory and access to this memory is very fast, and it's allocation is dealt with when the program is compiled. **Heap** Variables allocated on the heap have their memory allocated at run time and accessing this memory is a bit slower, but the heap size is only limited by the size of virtual memory.    | 

<table>
<tr><th>Programming Concepts</th></tr>
<tr><td</td></tr>
<tr><td>Backtracking</td></tr>
<tr><td>Big O Time and Space complexcity</td></tr>
<tr><td>Memory </td></tr>
<tr><td>Recursion</td></tr>

</table>


<p name="designpattern"></p>

#### Design Patterns

  - [Creational design patterns](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DesignPattern/README.md#creational) are used to design the instantiation process of objects. The creational pattern uses the inheritance to vary the object creation
  - [Structural patterns](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DesignPattern/README.md#structural) are concerned with how classes and objects are composed to form larger structures. Structural class patterns
use inheritance to compose interfaces or implementations.
  - [Behavioral patterns](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DesignPattern/README.md#behavioral)  are concerned with algorithms and the assignment of responsibilities between objects. Behavioral patterns
describe not just patterns of objects or classes but also the patterns of communication between them.

| Creational Patterns  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; | Structural Patterns  | Behavioral Patterns |
| --- | --- |  --- | 
| [Abstract Factory](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DesignPattern/README.md#abstractfactory) 	|  [Adapter](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DesignPattern/README.md#adapter) | Chain of Responsibility	|
| [Builder](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DesignPattern/README.md#builder) 	|  Bridge | Command	|
| [Factory Method](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DesignPattern/README.md#factory)	|  Composite | Interpreter	|
| Prototype	|  Decorator | Iterator	|
| Singleton	|  [Facade](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DesignPattern/README.md#facade) | Mediator	|
| 	|  Flyweight | Memento	|
| 	|  Proxy | [Observer](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DesignPattern/README.md#observer)	|
| 	|   | State	|
| 	|   | Strategy	|
| 	|   | Template Method	|
| 	|   | Visitor	|



