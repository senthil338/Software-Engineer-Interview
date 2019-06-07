# Sorting 

A sorting algorithm is an algorithm that puts elements of a list in a certain order. The most frequently used orders are numerical order and lexicographical order. 


#### Time Complexity

| Sorting Algorithm | Best | Average | Worst |
| --- | --- | --- | --- |
| Quicksort	Array	| O(n log(n)) |	O(n log(n)) |	O(n<sup>2</sup>) |
| Mergesort	Array |	O(n log(n)) |	O(n log(n)) |	O(n log(n)) |
| Heapsort Array | O(n log(n)) | O(n log(n)) | O(n log(n)) |
| Bubble Sort |	O(n) | O(n<sup>2</sup>) |	O(n<sup>2</sup>) |
| Insertion Sort | O(n) |	O(n<sup>2</sup>) | O(n<sup>2</sup>) |
| Select Sort |	O(n<sup>2</sup>) | O(n<sup>2</sup>) | O(n<sup>2</sup>) |

#### Why is sorting so important
  - The first step in organizing data is sorting. Lots of tasks become easier once a data set of items is sorted
  - Some algorithms like binary search are built around a sorted data structure.

#### Considerations:
  - How to sort: descending order or ascending order?
  - Sorting based on what? An object name (alphabetically), by some number defined by its fields/instance variables. Or maybe compare dates, birthdays, etc.
  - What happens with equals keys, for example various people with the same name: John, then sort them by Last Name.
  - Does your sorting algorithm sorts in place or needs extra memory to hold another copy of the array to be sorted. This is even more important in embedded systems.

#### SELECTION SORT

It is called selection sort because it repeatedly selects the smallest remaining item:
1. Find the smallest element. Swap it with the first element.
2. Find the second smallest element. Swap it with the second element
3. Find the third smallest element. Swap it with the third element
4. Repeat finding the smallest element and swapping in the correct position until the list is sorted

#### MERGESORT

Mergesort is also called divide and conquer algorithm, because it divides the original data into smaller pieces of data to solve the problem. Merge sort works in the following way:

1. Divide into 2 collections. Mergesort will take the middle index in the collection and split it into the left and right parts based on this middle index.
2. Resulting collections are again recursively splited and sorted
3. Once the sorting of the two collections is finished, the results are merged
4. Now Mergesort it picks the item which is smaller and inserts this item into the new collection.
5. Then selects the next elements and sorts the smaller element from both collections

#### QUICKSORT

Quick sort is better than merge sort from a memory usage comparison. Because quick sort doesn’t require additional storage to work. It only uses a small auxiliary stack.

Merge sort is a sorting technique based on divide and conquer technique. 
With worst-case time <br> complexity being Ο(n log(n)). It divides input array in two halves, calls itself for 
the two halves and then merges the two sorted halves.

1. If the array contains only 1 element or 0 elements then the array is sorted.
2. If the array contains more than 1 element:
3. Select randomly an element from the array. This is the "pivot element".
4. Split into 2 arrays based on pivot element: smaller elements than pivot go to the first array, the ones above the pivot go into the second array
5. Sort both arrays by recursively applying the Quicksort algorithm.
6. Merge the arrays




