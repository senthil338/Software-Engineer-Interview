using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank
{
    class Grading_Students
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/grading/problem
        /// Easy 10
        /// </summary>
        /// <param name="G"></param>
        /// <returns></returns>
        public static int multipleOf5(int G)
        {
            int aux = 0;
            if (G % 5 == 0)
            {
                return G;
            }
            else
            {
                while (G % 5 != 0)
                {
                    G++;
                    if (G % 5 == 0)
                    {
                        aux = G;
                    }
                }
            }
            return aux;
        }

        static void Main_4(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            for (int a0 = 0; a0 < n; a0++)
            {
                int grade = Convert.ToInt32(Console.ReadLine());
                if (grade <= 37)
                {
                    result = grade;
                }
                else if (grade >= 38)
                {
                    //double d = double.Parse(grade.ToString());
                    result = multipleOf5(grade);
                    if (result - grade >= 3)
                    {
                        result = grade;
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
