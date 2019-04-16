using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Amazon
{
    public class LetterSubSequence
    {
        class Letter
        {
            public int start = 0;
            public int end = 0;
            public char letter = '0';
            public int total = 0;
            public Letter(int start,int end,char letter,int total)
            {
                this.start = start;
                this.end = end;
                this.letter = letter;
                this.total = total+1;
            }
        }

        public static void lengthSubSequenceShopper()
        {
            //List<char> input = new List<char>() { 'a', 'b', 'a', 'b', 'c',
            //    'b', 'a', 'c', 'a', 'd',
            //    'e', 'f','e', 'g', 'd', 'e',
            //    'h', 'i', 'j', 'h', 'k',
            //    'l', 'i', 'j' };
            //List<char> input = new List<char>() { 'a','b','c' };
            List<char> input = new List<char>() { 'a','b','c','d','a','f','g','h','i','j','e'};
            lengthSubSequenceShopper(input);
        }
        public static List<int> lengthSubSequenceShopper(List<char> input)
        {
            string finalString = string.Join("", input);
            Dictionary<char, Letter> map = new Dictionary<char, Letter>();
            int maxEnd = int.MinValue;
            char previousChar = '0';
            int previousTotal = int.MinValue;
            List<int> result = new List<int>();
            //time o(n)
            //space worst case 0(26)
            for (int i = 0; i < input.Count; i++)
            {
                int index = finalString.LastIndexOf(input[i]);
                int firstIndex = finalString.IndexOf(input[i]);
                if (!map.ContainsKey(input[i]) && maxEnd < index && maxEnd < i 
                    && maxEnd < firstIndex || previousTotal < index-i)
                {
                    if(previousTotal < index - i && previousChar!='0' && map.ContainsKey(previousChar))
                    {
                        map.Remove(previousChar);
                    }
                        map.Add(input[i], new Letter(i, index, input[i], index-i + map.Count));
                        maxEnd = index;
                        previousTotal = index - i;
                        previousChar = input[i];
                    
                }
             }

            foreach(KeyValuePair<char,Letter> key in map)
            {
                result.Add(key.Value.total);
            }



            return result;
        }
    }
}
