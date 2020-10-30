
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Trie
{
  public class SearchDict_charArray {
      
    // Alphabet size
    public const int SIZE = 26;
      
    // trie Node
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
      
    // If not present, inserts key into trie
    // If the key is prefix of trie node, just
    // marks leaf node
   public static void insert(TrieNode root, String Key)
    {
        int n = Key.Length;
        TrieNode pChild = root;
      
        for (int i=0; i<n; i++)
        {
            int index = Key[i] - 'a';
      
            if (pChild.Child[index] == null)
                pChild.Child[index] = new TrieNode();
      
            pChild = pChild.Child[index];
        }
      
        // make last node as leaf node
        pChild.leaf = true;
    }
      
  //  // A recursive function to print all possible valid
  //  // words present in array
  // public static void searchWord(TrieNode root, bool[] Hash,
  //                                          String str)
  //  {
  //      // if we found word in trie / dictionary
  //      if (root.leaf == true)
  //          System.Console.WriteLine(str);
      
  //      // traverse all child's of current root
  //      for (int K =0; K < SIZE; K++)
  //      {
  //          if (Hash[K] == true && root.Child[K] != null )
  //          {
  //              // add current character
  //              char c = (char) (K + 'a');
      
  //              // Recursively search reaming character 
  //              // of word in trie
  //              searchWord(root.Child[K], Hash, str + c);
  //          }
  //      }
  //  }
      
  //  // Prints all words present in dictionary.
  //public  static void PrintAllWords(char[] Arr, TrieNode root, 
  //                                            int n)
  //  {
  //      // create a 'has' array that will store all 
  //      // present character in Arr[]
  //      bool[] Hash = new bool[SIZE];
      
  //      for (int i = 0 ; i < n; i++)
  //          Hash[Arr[i] - 'a'] = true;
      
  //      // tempary node
  //      TrieNode pChild = root ;
      
  //      // string to hold output words
  //      String str = "";
      
  //      // Traverse all matrix elements. There are only 
  //      // 26 character possible in char array
  //      for (int i = 0 ; i < SIZE ; i++)
  //      {
  //          // we start searching for word in dictionary
  //          // if we found a character which is child
  //          // of Trie root
  //          if (Hash[i] == true && pChild.Child[i] != null )
  //          {
  //              str = str+(char)(i + 'a');
  //              searchWord(pChild.Child[i], Hash, str);
  //              str = "";
  //          }
  //      }
  //  }

        public static bool FindWord(TrieNode root, string str)
        {
            int n = str.Length;
            TrieNode current = root;
            for (int i = 0; i < n; i++)
            {
                int index = str[i] - 'a';
                if (current.Child[index] != null)
                {
                    current = current.Child[index];
                    if (current.leaf == true && n-1==i)
                        return true;
                }
                else
                    return false;
            }
            return false;
        }

       public static string addBinary(string a,
                           string b)
        {

            // Initialize result 
            string result = "";

            // Initialize digit sum 
            int s = 0;

            // Traverse both strings starting  
            // from last characters 
            int i = a.Length - 1, j = b.Length - 1;
            while (i >= 0 || j >= 0 || s == 1)
            {

                // Comput sum of last  
                // digits and carry 
                s += ((i >= 0) ? a[i] - '0' : 0);
                s += ((j >= 0) ? b[j] - '0' : 0);

                // If current digit sum is  
                // 1 or 3, add 1 to result 
                result = (char)(s % 2 + '0') + result;

                // Compute carry 
                s /= 2;

                // Move to next digits 
                i--; j--;
            }
            return result;
        }

        public static void Main_1(String[] args)
        {
            
            addBinary("1101", "100");
            string test = "abcdef";
            TrieNode root = new TrieNode();
            //String[] Dict = { "go", "bat", "me", "eat", "goal", "boy", "run" };
            String[] Dict = { "apple", "applet", "car", "card" };
            int n = Dict.Length;
            for (int i = 0; i < n; i++)
                insert(root, Dict[i]);
            FindWord(root, "gosal");

        }
    ////Driver program to test above function
    //public static void main(String args[])
    //{
    //    // Let the given dictionary be following
    //    String[] Dict = {"go", "bat", "me", "eat",
    //                       "goal", "boy", "run"} ;

        //    // Root Node of Trie
        //    TrieNode root = new TrieNode();

        //    // insert all words of dictionary into trie
        //    int n = Dict.Length;
        //    for (int i=0; i<n; i++)
        //        insert(root, Dict[i]);

        //    char[] arr = {'e', 'o', 'b', 'a', 'm', 'g', 'l'} ;
        //    int N = arr.Length;

        //    PrintAllWords(arr, root, N);
        //}
    }
}

