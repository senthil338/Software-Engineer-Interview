using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Problems
{
    public class ArrayRotation
    {
        public static void RotateArray()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int k = 4;
            int n = a.Length;
            StringBuilder output = new StringBuilder();
            //for (int i = 0; i < n; i++)
            //{

            //    b[i] = a[(i + k) % n];
            //    output = output.append(b[i]).append(" ");

            //}

          //  for (int j = 0; j < n; j++)
            {
                int[] b = new int[a.Length];
                int temp = a[0];
                for (int i = 0; i < k; i++)
                {
                    b[i] = a[(i + k) % n];
                }

                for (int j = k; j < a.Length; j++)
                {
                    b[j] = a[(j + k) % n];
                }

                string value = string.Join(" ", b);
                Console.WriteLine(value);

               // output.Append(temp).Append(" ");
            }
           
           
        }
    }
}
