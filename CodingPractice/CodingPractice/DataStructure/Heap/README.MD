Soure Code
  - [MinHeap](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DataStructure/Heap/MinHeap.cs)
  - [MaxHeap](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DataStructure/Heap/MaxHeap.cs)
  
  Important Topic.
  1. Return max value from an array
  2. Return min value from an array
  
  # Heap or Binary Heap
  A binary heap is a complete binary tree which satisfies the heap ordering property. The ordering can be one of two types:
   - The min-heap property: the value of each node is greater than or equal to the value of its parent, with the minimum-value element at the root.
   - The max-heap property: the value of each node is less than or equal to the value of its parent, with the maximum-value element at the root.
A heap is useful data structure when you need to remove the object with the highest (or lowest) priority. A common use of a heap is to implement a priority queue

#### Min Heap representaion

![alt text][logo]

[logo]: https://github.com/adam-p/markdown-here/raw/master/src/common/images/icon48.png "Logo Title Text 2"

For any node in position k,
its left child is located at 2*k index 
its right child is located at 2*k+1. index 
its parent is located at k/2 index

#### Inserting into a min-heap
 - Place the new element in the next available position in the array. 
 - Compare the new element with its parent. If the new element is smaller, than swap it with its parent.
 - Continue this process until either
     - the new element’s parent is smaller than or
equal to the new element, or
     - the new element reaches the root (index 0 of
the array)


#### Removing from a heap

 - Place the root element in a variable to
return later.
 - Remove the last element in the deepest
level and move it to the root.
 - While the moved element has a value
greater than at least one of its children,
swap this value with the smaller-valued
child.
- Return the original root that was saved.

  
