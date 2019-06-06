[Source Code](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DataStructure/HashTable/HashTableImp.cs)

#### Important Topic

1. Given an unsorted arrays, find all pairs whose sum is x
2. key-value database (DynamoDB)
3. Bloom Filter

# HashTable

A hash table is a data structure that is used to store keys/value pairs. Hashing is a technique that is used to uniquely identify a specific object from a group of similar objects
which maps keys to values. Any non-null object can be used as a key or as a value.

### Basic Opearation 

| Operation | Average | Worst |
| --- | --- | --- |
| Space | O(n) | O(n) |
| Search | O(1) | O(n) |
| Insert | O(1) | O(n) |
| Delete | O(1) | O(n) |

Hash key collision :- A collision will occur when two different keys have the same hashCode.

#### Disadvantage
The look up is not always O(1) in Worst case its O(n) when key collision occures

[Wiki](https://en.wikipedia.org/wiki/Hash_table)
