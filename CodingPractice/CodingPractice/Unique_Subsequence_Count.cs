using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Amazon
{
    public class Unique_Subsequence_Count
    {
        public class Letter
        {
            public int source;
            public int destination;
            public int length;
            public Letter(int source,int destination,int length)
            {
                this.destination = destination;
                this.source = source;
                this.length = length;
            }
        }

        /// <summary>
        /// You are working on developing visual recognization software for Amazon Go, Amazon's
        /// cashier-less grocery store. As input to your software, another algorithm has identified shopper
        /// (labbled with letters) that appear in a video stream in the sequence that they appear.
        /// 
        /// Write a function which will partition the given sequence of shopper into minimal
        /// subsequences, where no shopper appears in more than one subsequence. The output of your function 
        /// will be a list containing  the length of each shoppers.
        /// </summary>
        public static void SubsequenceCount()
        {
            // List<char> input = new List<char>() { 'a','b','c','a' }; // 4
            //List<char> input = new List<char>() { 'a', 'b', 'c', 'd',

            //'a','e','f','g','h','i','j','e'}; // 5, 7
            //List<char> input = new List<char>() { 'z', 'z', 'c', 'b',

            //'z','c','h','f','i','h','i'}; // 6 ,5
            //List<char> input = new List<char>() { 'a', 'b', 'a', 'b'
            //,'c','b','a','c','a','d','e','f','e','g','d','e','h','i','j','h','k','l','i','j'};//9 7 8

            //List<char> input = new List<char>() { 'x', 'z', 'y', 'n',

            //'m','n','x','c','n','p','q','s','a','n','a','j','j'}; 
            //List<char> input = new List<char>() { 'z', 'z', 'c', 'b',

            //'z','x','h','f','i','h','i'}; // 6 ,5
            List<char> input = new List<char>() { 'a', 'b', 'c', 'd',

            'a','t','t','r','r','x'}; // 6 ,5
            var result = SubsequenceCount(input);
        }
        /// <summary>
        /// Run time O(N)
        /// Space 4 Constant Space require for checking the conditon, at worst conditon to store the result in the output list we require 26 space 
        /// Worst case-> space O(30);
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<int> SubsequenceCount(List<char> input)
        {
            string str = string.Join("", input);
           
          //  Dictionary<char,Letter> map = new Dictionary<char, Letter>();
            int previous_source = 0;
            int previous_destination = 0;
            int source = str.IndexOf(input[0]);
            int destination = str.LastIndexOf(input[0]);
            List<int> result = new List<int>();
            //first time to store the previous source and destination value;
           // map.Add(input[0], new Letter(source, destination, destination +1));
            result.Add(destination + 1);
            previous_source = source;
            previous_destination = destination;

            for (int i = 1; i < input.Count; i++)
            {
                //if (map.Count == 26) // reached max Alpha char (a to z) then return result, considerting all lower case letter had been passed 
                //{
                //    return result;
                //}
                //65 to 90 Capital letter

                source = str.IndexOf(input[i]);
                destination = str.LastIndexOf(input[i]);
                // if (!map.ContainsKey(input[i]) && previous_destination <= destination && previous_source < source)
                if (previous_destination <= destination && previous_source < source)
                {
                    if (previous_destination < source)
                    {
                        result.Add(destination - previous_destination);
                        //previous_destination = destination;
                        //previous_source = source;
                    }
                    else if (previous_destination > source)
                    {
                        result[result.Count - 1] = result[result.Count - 1] + destination - previous_destination;
                        //previous_destination = destination;
                        //previous_source = source;
                    }
                  //uncomment if u need to stop if a to z values filled
                  // map.Add(input[i], new Letter(source, destination, destination - previous_destination));
                    previous_destination = destination;
                    previous_source = source;


                }
            }

          
          
            return result;
        }
    }
}
