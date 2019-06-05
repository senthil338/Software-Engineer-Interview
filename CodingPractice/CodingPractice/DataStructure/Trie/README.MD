[Source code](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DataStructure/Trie/TrieNode.cs)
#### Some important topic to be considered 

1. Design Search Autocomplete System
2. Longest word in dictionary
3. Boggle Words or Find all possible words in a board of characters



### Tries

Trie is an efficient information retrieval data structure. The term “trie” comes from the word re<b>trie</b>val, and is usually pronounced “try”, to distinguish it from other “tree” structures.

##### Basic Operations on Tries and Complexity
- Insert - O(n), Get - O(n)

Trie data strucure can be formed as shown for the given input [ peter, piper, picked, peck, pickled, peppers ].

If we type <b>pi</b>, the auto complete system will return piper, picked and pickled, if we type <b>pic</b> then it will return picked and pickled. Example Google Search and Searching contact in the mobile.

<br>
<img src="https://github.com/senthil338/coding_interview/blob/master/Images/trie.jpeg" 
 width="420" height="500" border="4" alt="Trie" />

<br>

#### Trie can be implemented as below 



```cs
  public class TrieNode
    {
      public TrieNode[] Child = new TrieNode[26];
      
        // isLeaf is true if the node represents
        // end of a word
       public bool leaf;
         
        // Constructor
        public TrieNode() {
            leaf = false;
            for (int i =0 ; i< SIZE ; i++)
                    Child[i] = null;
        }
    }
```

##### References:
1. [wiki](https://en.wikipedia.org/wiki/Trie)
2. [medium](https://medium.com/basecs/trying-to-understand-tries-3ec6bede0014)
3. [geeksforgeeks](https://www.geeksforgeeks.org/trie-insert-and-search/)
4. [YouTube](https://www.youtube.com/watch?v=zIjfhVPRZCg)
