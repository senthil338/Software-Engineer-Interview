using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Books
{
    public static class StringManipulations
    {
        public static void StringPermutation(string str)
        {
            permutation(str, "");

        }

        private static void permutation(string str,string pre)
        {

            if(str.Length == 0)
            {
                Console.WriteLine(pre);
            }
            else
            {
                for(int i = 0; i < str.Length; i++)
                {
                    /*--------------------------------------------------------------
                     |  i       |   str    |  rem  | Sub(0, i) | Sub(i + 1)| pre+str[i]
                     |------    |-------------------------------------------------------
                     |  0       |  ABC     |   BC  |    ""     |   BC      |   A    
                     |  0       |   BC     |    C  |    ""     |    C      |   B
                     |  0       |    C     |    "" |    ""     |   ""      |   C
                     |          |          |       |           |           |
                     |  1-BC    |    BC    |    B  |     B     |    ""     |    A + C
                     |  0       |          |    "" |     ""    |    ""     |    A + C + B
                     | 1-ABC    |    ABC   |  AC   |     A     |    C      |    B  
                     |  0       |          |   C   |     ""    |    C      |    B + A
                     |  0       |     C    |    "" |    ""     |     ""    |    B + A + C
                     | 1-AC     |     AC   |    A  |     A     |    ""     |    B + C
                     | 0-A      |     A    |    "" |    ""     |     ""    |    B + C + A
                     | 2-ABC    |          |    AB |    OO     |     OO    |
                     | 2-      |          |    OO |    OO     |     OO    |    OO
                     | 000      |          |    OO |    OO     |     OO    |    OO
                     | 000      |          |    OO |    OO     |     OO    |    OO
                     | 00000    |          |    OO |    OO     |     OO    |    OO
                     | 00000    |          |    OO |    OO     |     OO    |    OO
                     | 00000    |          |    OO |    OO     |     OO    |    OO
                  */
                    string rem = str.Substring(0, i) + str.Substring(i + 1);
                    permutation(rem, pre + str[i]);
                }
            }
        }

        public static void permute(string str, int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }

        private static string swap(string a,int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
