##### Source code

1. [Tree](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DataStructure/Trees/TreeNode.cs)
2. [BinaryTree](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DataStructure/Trees/BinaryTree.cs)
3. [BinarySearchTree](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DataStructure/Trees/BinaryTree.cs)



#### Trees


A tree or N-ary Tree is a collection of nodes connected by directed (or undirected) edges. A tree is a nonlinear data structure, compared to arrays, linked lists, stacks and queues which are linear data structures. A tree can be empty with no nodes or a tree is a structure consisting of one node called the root and zero or one or more subtrees. A tree has following general properties:
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



##### Tree represent shown as below.


![alt text][imp_tree]

[imp_tree]: https://github.com/senthil338/coding_interview/blob/master/Images/imp-tree.jpg "Trees"


A tree is a data structure where a node can zero or more children. Each node contains a value. Like graphs, the connection between nodes is called edges. A tree is a type of graph, but not all of them are trees.

These data structures are called “trees” because the data structure resembles a tree 🌳. It starts with a root node and branch off with its descendants, and finally, there are leaves.

There are many basic data structures that can be used to solve application problems. Array is a good static data structure that can be accessed randomly and is fairly easy to implement. Linked Lists on the other hand is dynamic and is ideal for application that requires frequent operations such as add, delete, and update. One drawback of linked list is that data access is sequential. Then there are other specialized data structures like, stacks and queues that allows us to solve complicated problems (eg: Maze traversal) using these restricted data structures. One other data structure is the hash table that allows users to program applications that require frequent search and updates. They can be done in O(1) in a hash table.

One of the disadvantages of using an array or linked list to store data is the time necessary to search for an item. Since both the arrays and Linked Lists are linear structures the time required to search a “linear” list is proportional to the size of the data set. For example, if the size of the data set is n, then the number of comparisons needed to find (or not find) an item may be as bad as some multiple of n. So imagine doing the search on a linked list (or array) with n = 106 nodes. Even on a machine that can do million comparisons per second, searching for m items will take roughly m seconds. This not acceptable in today’s world where speed at which we complete operations is extremely important. Time is money. Therefore it seems that better (more efficient) data structures are needed to store and search data.

![alt text][tree]

[tree]: https://github.com/senthil338/coding_interview/blob/master/Images/tree-parts.jpg "Tree"

#### Some properties of trees:

1. The top-most node is called root.
2. A node without children is called leaf node or terminal node.
3. Height (h) of the tree is the distance (edge count) between the farthest leaf to the root.
      - A has a height of 3
      - I has a height of 0
4. Depth or level of a node is the distance between the root and the node in question.
      - H has a depth of 2
      - B has a depth of 1



### Binary Tree

#### Binary Tree and Binary search Tree

1. Binary Tree 
      - Trees nodes can have zero or more children. However, when a tree has at the most two children, then it’s called binary tree. 
2. Binary Search Tree 
      - For a binary tree to be a binary search tree, the data of all the nodes in the left sub-tree of the root node should be  the data of the root. The data of all the nodes in the right subtree of the root node should be  the data of the root.

#### Types of Binary Tree
1. Complete binary tree
    - A complete binary tree is a binary tree in which every level, except possibly the last, is completely filled, and all nodes are as far left as possible. 
2. Full binary tree
    - A full Binary Tree A Binary Tree is full if every node has 0 or 2 children
3. Perfect binary tree
    -  A Binary tree is Perfect Binary Tree in which all internal nodes have two children and all leaves are at the same level.

![alt text][bt_types]

[bt_types]: https://github.com/senthil338/coding_interview/blob/master/Images/bt_types.JPG "Binary tree types "

#### Binary Tree Representation:

![alt text][bt_tree]

[bt_tree]: https://github.com/senthil338/coding_interview/blob/master/Images/Binary_tree.png "Binary Tree"


##### Time Complexity 
 - Search O(n)	
 - Insertion O(n)
 - Deletion O(n)

#### Binary Search Tree Representaion:

![alt text][bst_tree]

[bst_tree]: https://github.com/senthil338/coding_interview/blob/master/Images/binary_search_tree.png "Binary Search Tree"



##### Time Complexity 
 - Search O(log(n))	
 - Insertion O(log(n))
 - Deletion O(log(n))


Binary Tree can be implemented as shown.


```cs
 public class Node
 {
        public int Data;
        public Node Left;
        public Node Right;
        public Node(int data) {
            this.Data = data;
            Right = Left = null;
        }
  }
```

#### Tree Traversals

1. Pre-order traversal (root-left-right)
2. Post-order traversal - (left-right-root)
3. In-order traversal (left-root-right) - For Binary Search Tree "in order traversal" will return shorted list.

#### Tree Traversals can be implemented as shown.
1. Pre order

```cs
public void PreOrder(Node root) {
           if (root != null)  {
               Console.WriteLine(root.Data);
               PreOrder(root.Left);
               PreOrder(root.Right);
             }
 }
```
2. Post order

```cs
 public void PostOrder(Node root)
         {
             if (root != null) {
                 PostOrder(root.Left);
                 PostOrder(root.Right);
                 Console.WriteLine(root.Data);
             }
 }
 ```
 
 3. In order
 
 ```cs
 public void InOrder(Node root){
             if (root != null) {
                 InOrder(root.Left);
                 Console.WriteLine(root.Data);
                 InOrder(root.Right);
             }
           }
```






