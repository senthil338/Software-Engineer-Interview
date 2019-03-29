using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Amazon
{
  public  class LexicographicallySorting
    {
        #region Amzon 
        /*
         <p>You have been given a task of reordering some data from a log file. Every line in the log file is a space delimited list of 
         * strings and all lines begin with an identifier that is alphanumeric. After the identifier, a line will consist of either a
         * list of words using only English letters or only a list of integers. There will be no lines that consist of only an identifier. 

            Your task is to reorder the data from the log file such that all the lines with words are at the top in the log file.
         * in lexicographical order. Words are ordered lexicographically ignoring the identifier except in the case of ties.
         * In the case of ties (if there are two lines that are identical except for the identifier), 
         * the identifier is used to order lexicographically. 
         * Alphanumerics should be sorted in ASCII order (numbers come before letters).
         * The identifiers must still be part of the lines in the output Strings. 
         * Lines with integers do not need to be sorted relative to other lines with integers.

            Write an algorithm to reorder the data in the log file. 

            The input to the function/method consists of two arguments - 

            logFileSize: an integer representing the number of lines in the log file,
            logLines: a list of strings representing the log file. 

            Output:
            Return a list of strings representing the reordered log file data. 

            Note:
            Identifier consists of only English letters and numbers. The lines with words are not required to match case and the sort needs to be case insensitive. 

            Example:
            Input: 
            logFileSize = 5 
            logLines = 
            [al 9 2 3 1] 
            [g1 Act car] 
            [zo4 4 7] 
            [abl off KEY dog] 
            [a8 act zoo]

            Output: 
            [gl Act car] 
            [a8 act zoo] 
            [ab1 off KEY dog] 
            [al 9 2 3 1] 
            [zo4 4 7]

        Explanation: 
           Second, fourth. and fifth lines are the lines with words. According to the lexicographical order, 
         * the second line will be reordered first in the log file, then fifth, and the fourth comes in the log file. 
         * Next, the lines with numbers come in the order in which these lines were in the input.</p>
         */
        /// <summary>
        /// Amazon working code, log file Lexicographically Sorting
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static string[] Sort(string[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    string left = inputArray[j - 1].Substring(inputArray[j - 1].IndexOf(' ') + 1);
                    string right = inputArray[j].Substring(inputArray[j].IndexOf(' ') + 1);
                    //string left = inputArray[j - 1];
                    //string right = inputArray[j];
                    if (string.Compare(left, right) > 0 && !right.Any(Char.IsDigit))
                    {
                        string temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                    if (right.Any(Char.IsDigit) && left.Any(Char.IsDigit) && string.Compare(left.Replace(" ", ""), right.Replace(" ", "")) < 0)
                    {
                        string temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                    if ((right.Any(Char.IsDigit) || left.Any(Char.IsDigit)) && string.Compare(left.Replace(" ", ""), right.Replace(" ", "")) < 0)
                    {
                        string temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }
#endregion
    
    }
    /// <summary>
    /// https://stackoverflow.com/questions/27169234/how-to-sort-alphanumeric-string
    /// https://www.codeproject.com/Questions/827027/How-to-do-Alphanumeric-Sorting-in-list
    /// https://coderanch.com/t/328108/java/Ordering-AlphaNumeric-ascending-Order
    /// https://blog.codinghorror.com/sorting-for-humans-natural-sort-order/
    /// </summary>
    public class AlphanumComparatorFast : System.Collections.IComparer
    {
        public int Compare(object x, object y)
        {
            string s1 = x as string;
            if (s1 == null)
            {
                return 0;
            }
            string s2 = y as string;
            if (s2 == null)
            {
                return 0;
            }

            int len1 = s1.Length;
            int len2 = s2.Length;
            int marker1 = 0;
            int marker2 = 0;

            while (marker1 < len1 && marker2 < len2)
            {
                char ch1 = s1[marker1];
                char ch2 = s2[marker2];

                char[] space1 = new char[len1];
                int loc1 = 0;
                char[] space2 = new char[len2];
                int loc2 = 0;

                do
                {
                    space1[loc1++] = ch1;
                    marker1++;

                    if (marker1 < len1)
                    {
                        ch1 = s1[marker1];
                    }
                    else
                    {
                        break;
                    }
                } while (char.IsDigit(ch1) == char.IsDigit(space1[0]));

                do
                {
                    space2[loc2++] = ch2;
                    marker2++;

                    if (marker2 < len2)
                    {
                        ch2 = s2[marker2];
                    }
                    else
                    {
                        break;
                    }
                } while (char.IsDigit(ch2) == char.IsDigit(space2[0]));

                string str1 = new string(space1);
                string str2 = new string(space2);

                int result;

                if (char.IsDigit(space1[0]) && char.IsDigit(space2[0]))
                {
                    int thisNumericChunk = int.Parse(str1);
                    int thatNumericChunk = int.Parse(str2);
                    result = thisNumericChunk.CompareTo(thatNumericChunk);
                }
                else
                {
                    result = str1.CompareTo(str2);
                }

                if (result != 0)
                {
                    return result;
                }
            }
            return len1 - len2;
        }
    }
}
