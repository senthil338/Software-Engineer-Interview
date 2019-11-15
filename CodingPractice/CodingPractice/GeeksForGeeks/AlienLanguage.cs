using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class AlienLanguage
    {
        public bool isAlienSorted(String[] words, String order)
        {
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (!isAlienSorted(words[i], words[i + 1], order))
                {
                    return false;
                }
            }
            return true;

        }

        private bool isAlienSorted(String word1, String word2, String order)
        {
            for (int i = 0, j = 0; i < word1.Length && j < word2.Length; i++, j++)
            {
                if (order.IndexOf(word1[i]) < order.IndexOf(word2[j]))
                {
                    return true;
                }
                else if (order.IndexOf(word1[i]) > order.IndexOf(word2[j]))
                {
                    return false;
                }
            }

            if (word1.Length > word2.Length)
            {
                return false;
            }

            return true;
        }
    }
}
