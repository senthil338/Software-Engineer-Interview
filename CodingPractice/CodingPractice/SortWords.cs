using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1.Problems
{
    public class SortWords
    {
        private static List<string> splitNumbersAndChar(string originalString)
        {
            string letters = string.Empty;
            string numbers = string.Empty;
            List<string> list = new List<string>();
            foreach (char c in originalString)
            {
                if (Char.IsLetter(c))
                {
                    letters += c;
                }
                if (Char.IsNumber(c))
                {
                    numbers += c;
                }
            }
            list.Add(letters);
            list.Add(numbers);
            return list;
        }
        //private static int partition(string[] array, int left, int right, int pivot)
        //{
        //    while (left < right)
        //    {
        //        while (array[left].CompareTo(array[pivot]) < 0)
        //        {
        //            left++;
        //        }
        //        while (array[right].CompareTo(array[pivot]) > 0)
        //        {
        //            right--;
        //        }
        //        if (left <= right)
        //        {
        //            string temp = array[left];
        //            array[left] = array[right];
        //            array[right] = temp;
        //            left++;
        //            right--;

        //        }
        //    }

        //    return left;
        //}
        
        public static int partitionWithNumber(String[] stringArray, int idx1, int idx2)
        {
            String pivotValue = stringArray[idx1];
            while (idx1 < idx2)
            {
              
                while ((stringArray[idx1].Split( )[1]).CompareTo(pivotValue.Split( )[1]) <= 0 && Convert.ToInt32(stringArray[idx1].Split()[0]) < Convert.ToInt32(pivotValue.Split()[0]))
                {
                    idx1 = idx1 + 1;
                }
                while ((stringArray[idx2].Split( )[1]).CompareTo(pivotValue.Split( )[1]) >= 0 && Convert.ToInt32(stringArray[idx2].Split()[0]) > Convert.ToInt32(pivotValue.Split()[0]))
                {
                    idx2 = idx2 - 1;
                }
                string temp = stringArray[idx1];
                stringArray[idx1] = stringArray[idx2];
                stringArray[idx2] = temp;
                idx1++;
                idx2--;

            }
            return idx1;
        }
        public static void QuicksortWords(string[] arr, int start, int end)
        {
            if (start < end)
            {
               
                int pivot = (start + end) / 2;
                int pivotIndex = partitionWithNumber(arr, start, end);

                QuicksortWords(arr, start, pivotIndex);
                QuicksortWords(arr, pivotIndex + 1, end);
            }
        }

    }
}
