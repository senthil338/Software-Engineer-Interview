A <b>Linked list</b> is a linear collection of data elements, whose order is not given by their physical placement in memory. Instead, each element points to the next. It is a data structure consisting of a collection of nodes which together represent a sequence. In its most basic form, each node contains: data, and a reference (in other words, a link) to the next node in the sequence. This structure allows for efficient insertion or removal of elements from any position in the sequence during iteration.
A drawback of linked lists is that <b>access time is linear</b>. Faster access, such as random access, is not feasible. Arrays have better cache locality compared to linked lists.

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
