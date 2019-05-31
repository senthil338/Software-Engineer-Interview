Doubly linked list is a complex type of linked list in which a node contains a pointer to the previous as well as the next node in the 
sequence. Therefore, in a doubly linked list, a node consists of three parts: node data, pointer to the next node in sequence (next pointer) , 
pointer to the previous node (previous pointer). A sample node in a doubly linked list is shown in the figure.

![alt text][img]

[img]: https://github.com/senthil338/coding_interview/blob/master/Images/doubly-linked-list2.png "Logo Title Text 2"

```cs
class Node   
{  
    Node prev;   
    int data;  
    Node next;   
}  
```

#### Advantages over singly linked list
1) A DLL can be traversed in both forward and backward direction.
2) The delete operation in DLL is more efficient if pointer to the node to be deleted is given.


#### Disadvantages over singly linked list

1) Every node of DLL Require extra space for an previous pointer. It is possible to implement DLL with single pointer though (See this and this).
2) All operations require an extra pointer previous to be maintained. For example, in insertion, we need to modify previous pointers together with next pointers. For example in following functions for insertions at different positions, we need 1 or 2 extra steps to set previous pointer.
