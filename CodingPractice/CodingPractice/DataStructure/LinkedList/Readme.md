[Source Code](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DataStructure/LinkedList/LinkedList.cs)

#### Important Topic

1. Add a two linked list and return a new list with digits. 
2. Insert a value  at Kth position in a linked list
3. Reverse a linked list
4. Detect loop in a linked list
5. LRU (Least Recently Used) cache

### Linked List 
A linked list consists of nodes where each node contains a data field and a reference(link) to the next node in the list. This structure allows for efficient insertion or removal of elements from any position in the sequence during iteration.
A drawback of linked lists is that <b>access time is linear</b>. Faster access, such as random access, is not feasible. Arrays have better cache locality compared to linked lists.
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


#### Advantages
1. A linked list can be viewed as a group of items, each of which points to the item in its neighbourhood
2. A linked lists is dynamic data structure(no need to define initial size in). Therefore,the primary advantages of linked lists over arrays is that linked lists can grow or shrink in size during the execution of a programme.
3. Linear data structures such as stacks and queues can be implemented using a linked list.


#### Disadvantages
1. They use more memory than arrays because of the storage used by their pointers.
2. Nodes in a linked list must be read in order from the beginning as linked lists are inherently sequential access.
3. Nodes are stored incontiguously, greatly increasing the time periods required to access individual elements within the list, especially with a CPU cache.
4. Difficulties arise in linked lists when it comes to reverse traversing. For instance, singly linked lists are cumbersome to navigate backwards[1] and while doubly linked lists are somewhat easier to read, memory is consumed in allocating space for a back-pointer.

Reference : [wiki](https://en.wikipedia.org/wiki/Linked_list)
