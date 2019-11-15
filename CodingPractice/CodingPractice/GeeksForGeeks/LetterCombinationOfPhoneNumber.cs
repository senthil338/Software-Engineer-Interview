using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.GeeksForGeeks
{
    class LetterCombinationOfPhoneNumber
    {
        Dictionary<String, String> phone = new Dictionary<String, String>();
        List<String> output = new List<String>();
        public LetterCombinationOfPhoneNumber()
        {
            phone.Add("2", "abc");
            phone.Add("3", "def");
            phone.Add("4", "ghi");
            phone.Add("5", "jkl");
            phone.Add("6", "mno");
            phone.Add("7", "pqrs");
            phone.Add("8", "tuv");
            phone.Add("9", "wxyz");
        }

        /*
        Time complexity : O(3^N * 4^M) where N is the number of digits in the input that maps to 3 letters (e.g. 2, 3, 4, 5, 6, 8) 
        and M is the number of digits in the input that maps to 4 letters (e.g. 7, 9), and N+M is the total number digits in the input.

        Space complexity : \{O}(3^N * 4^M) 
        since one has to keep 3^N * 4^M
           https://leetcode.com/explore/interview/card/facebook/53/recursion-3/267/
        */
        public void backtrack(String combination, String next_digits)
        {
            // if there is no more digits to check
            if (next_digits.Length == 0)
            {
                // the combination is done
                output.Add(combination);
            }
            // if there are still digits to check
            else
            {
                // iterate over all letters which map 
                // the next available digit
                String digit = next_digits.Substring(0, 1);
                String letters = phone[digit];
                for (int i = 0; i < letters.Length; i++)
                {
                    String letter = phone[digit].Substring(i, i + 1);
                    // append the current letter to the combination
                    // and proceed to the next digits
                    backtrack(combination + letter, next_digits.Substring(1));
                }
            }
        }

        public List<String> letterCombinations(String digits)
        {
            if (digits.Length != 0)
                backtrack("", digits);
            return output;
        }
    }
}
