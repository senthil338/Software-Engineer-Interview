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
[Source Code](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DataStructure/Trie/TrieNode.cs)
##### References:
1. [wiki](https://en.wikipedia.org/wiki/Trie)
2. [medium](https://medium.com/basecs/trying-to-understand-tries-3ec6bede0014)
3. [geeksforgeeks](https://www.geeksforgeeks.org/trie-insert-and-search/)
