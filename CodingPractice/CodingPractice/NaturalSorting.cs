using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Sorting
{
    public class NaturalSorting
    {

        /// <summary>
        /// http://www.interact-sw.co.uk/iangblog/2007/12/13/natural-sorting
        /// Compares two sequences.
        /// </summary>
        /// <typeparam name="T">Type of item in the sequences.</typeparam>
        /// <remarks>
        /// Compares elements from the two input sequences in turn. If we
        /// run out of list before finding unequal elements, then the shorter
        /// list is deemed to be the lesser list.
        /// 
        /// </remarks>
        /*
         string[] testItems = { "z24", "z2", "z15", "z1",
                               "z3", "z20", "z5", "z11",
                               "z 21", "z22" };

        Func<string, object> convert = str =>
        {   try { return int.Parse(str); }
            catch { return str; } };
        var sorted = testItems.OrderBy(
            str => Regex.Split(str.Replace(" ", ""), "([0-9]+)").Select(convert),
            new EnumerableComparer<object>());
            */
        public class EnumerableComparer<T> : IComparer<IEnumerable<T>>
        {
            /// <summary>
            /// Create a sequence comparer using the default comparer for T.
            /// </summary>
            public EnumerableComparer()
            {
                comp = Comparer<T>.Default;
            }

            /// <summary>
            /// Create a sequence comparer, using the specified item comparer
            /// for T.
            /// </summary>
            /// <param name="comparer">Comparer for comparing each pair of
            /// items from the sequences.</param>
            public EnumerableComparer(IComparer<T> comparer)
            {
                comp = comparer;
            }

            /// <summary>
            /// Object used for comparing each element.
            /// </summary>
            private IComparer<T> comp;


            /// <summary>
            /// Compare two sequences of T.
            /// </summary>
            /// <param name="x">First sequence.</param>
            /// <param name="y">Second sequence.</param>
            public int Compare(IEnumerable<T> x, IEnumerable<T> y)
            {
                using (IEnumerator<T> leftIt = x.GetEnumerator())
                using (IEnumerator<T> rightIt = y.GetEnumerator())
                {
                    while (true)
                    {
                        bool left = leftIt.MoveNext();
                        bool right = rightIt.MoveNext();

                        if (!(left || right)) return 0;

                        if (!left) return -1;
                        if (!right) return 1;

                        int itemResult = comp.Compare(leftIt.Current, rightIt.Current);
                        if (itemResult != 0) return itemResult;
                    }
                }
            }
        }

        ///// <summary>
        ///// normal sorting
        ///// </summary>
        ///// <param name="inputArray"></param>
        ///// <returns></returns>
        //public static string[] Sorting(string[] inputArray)
        //{
        //    for (int i = 0; i < inputArray.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j > 0; j--)
        //        {
        //            string left = inputArray[j - 1].Substring(inputArray[j - 1].IndexOf(' ') + 1);
        //            string right = inputArray[j].Substring(inputArray[j].IndexOf(' ') + 1);
        //            if (string.Compare(left, right) > 0 && !right.Any(Char.IsDigit))
        //            {
        //                string temp = inputArray[j - 1];
        //                inputArray[j - 1] = inputArray[j];
        //                inputArray[j] = temp;
        //            }
        //            if (right.Any(Char.IsDigit) && left.Any(Char.IsDigit) && string.Compare(left, right) > 0)
        //            {
        //                string temp = inputArray[j - 1];
        //                inputArray[j - 1] = inputArray[j];
        //                inputArray[j] = temp;
        //            }
        //        }
        //    }
        //    return inputArray;
        //}


    }

   
}
