using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Practice
{
    public class PowerOf
    {
        public static int PowerOf2(int n)
        {
            if(n < 1)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                int prev = PowerOf2(n / 2);
                int curr = prev * 2;
                Console.WriteLine(curr);
                return curr;
            }
        }
    }
}
