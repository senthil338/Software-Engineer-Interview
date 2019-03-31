using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
     public class WordExclude
    {
        public static void retrieveWords()
        {

        }

        public static List<string> retrieveWords(string literalWords,List<string> execludeWords)
        {
            //Replace 
            List<string> commonWordsToExeclude = new List<string>();
          
            string noSpecialChar = System.Text.RegularExpressions.Regex.Replace(literalWords, @"[^0-9a-zA-Z]+", " ");
           
            string modifiedWords = "";
            foreach (string word in execludeWords)
            {
                modifiedWords = noSpecialChar.Replace(word, "");

            }
            string[] list_Words = modifiedWords.Split(' ');

            //words counts
            // list_Words.
            return null;
        }
    }
}
