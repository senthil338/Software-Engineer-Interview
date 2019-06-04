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


#### Tree Traversals

1. Pre-order traversal
      - Process data of root node
      - First, traverse left subtree completely
      - Then, traverse right subtree
2. Post-order traversal
      - Process data of left subtree
      - First, traverse right subtree
      - Then, traverse root node
3. In-order traversal
      - First process left subtree (before processing root node)
      - Then, process current root node
      - Process right subtree

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

#### Types of Binary Tree
1. Complete binary tree
    - A complete binary tree is a binary tree in which every level, except possibly the last, is completely filled, and all nodes are as far left as possible. 
2. Full binary tree
    - A full Binary Tree A Binary Tree is full if every node has 0 or 2 children
3. Perfect binary tree
    -  A Binary tree is Perfect Binary Tree in which all internal nodes have two children and all leaves are at the same level.


