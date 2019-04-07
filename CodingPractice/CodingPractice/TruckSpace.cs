using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Amazon
{
    public class TruckSpace
    {
        /// <summary>
        /// Amazon sort center, a computer system decides what packages are to be loaded on what trucks.
        /// All room and spaces are abstraced into space units which is represented as an integer.
        /// For each type of truck, they have different type of space units. For each packages they will be 
        /// occupying different space units.
        /// 
        /// As a software development engineer in sort center, you will need to write a method. 
        /// Given truck space units and a list of product space units find out exactly TWO products that fit
        /// into the truck. You will also implement an internal rule that the truck has to reserve exactly 
        /// 30 space units for safty purpose. Each package is assigned a Unique ID, numbered from 0 to N-1
        /// 
        /// Assumptions:
        /// 1. You will pick exactly 2 packages
        /// 2. You cannot pick up one packages twice
        /// 3. If you have multiple pairs, Select the pair with the Largest packages
        /// 
        /// input:
        /// The input to the function/method consists of two arguments
        /// truckSpace, an integer representing the truck space
        /// packagSpace, a list of integer representing the sapce unit occupying packages.
        ///
        /// </summary>
        public static void IDsOfPackages()
        {
            List<int> input = new List<int>() { 20, 70,90,30,60,110 };
            var res = IDsOfPackages(110, input); //0 and 4
            //List<int> input = new List<int>() { 100, 180, 40, 120, 10 };
            //var res = IDsOfPackages(250, input); //1 and 2

        }

        /// <summary>
        /// Runtime O(n*n) = n square 
        /// Space 3 constact variable for checking condition, and one list contains top 2 Package Ids
        /// so total O(5)
        /// </summary>
        /// <param name="truckSpace"></param>
        /// <param name="PackagesSpace"></param>
        /// <returns></returns>
        public static List<int> IDsOfPackages(int truckSpace, List<int> PackagesSpace)
        {
            int requireSpace = truckSpace - 30;
            int previousSpace = int.MinValue;
            int previousPackageId = int.MinValue;
            List<int> result = new List<int>();
            int topCounts = 2;
            if (requireSpace <= 30)
            {
                return new List<int>();
            }
            for(int row = 0; row < PackagesSpace.Count; row++)
            {
                for(int col=0;col < PackagesSpace.Count; col++)
                {
                    if (col != row && PackagesSpace[row] != PackagesSpace[col])
                    {
                        int sum = PackagesSpace[row] + PackagesSpace[col];
                        if(sum <= requireSpace && previousSpace < sum && PackagesSpace[row] > previousPackageId)
                        {
                            if (result.Count ==0 )
                            {
                                result.Add(row > col ? col : row);
                                result.Add(col < row ? row : col);
                            }
                            else
                            {
                                result[0] = row > col ? col : row;
                                result[1] = col < row ? row : col;
                            }
                            previousPackageId = PackagesSpace[row];
                            previousSpace = sum;
                        }
                    }
                }
            }
            return result;
        }

        public class Ids
        {
            internal int row;
            internal int value;
            public Ids(int row, int value)
            {
                this.row = row;
                this.value = value;
            }

        }
        public static void printpairs()
        {
            List<int> res = new List<int>() { 20, 70, 90, 30, 60, 110, 70, 10 };
            var test = IDsOfPackages_Time_N(res, 110);
        }

        /// <summary>
        /// time com = O(n)
        /// Space 0(n) 
        /// This can be achived with lesser number of space but 
        /// run time will be increased to O(N*N) even though inner loop run N/2 ,
        /// the total work is (N*N)/2 which is O(N*N);
        /// N = Number of element in an array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="truckSpace"></param>
        /// <returns></returns>
       public static List<int> IDsOfPackages_Time_N(List<int> PackagesSpace,
                       int truckSpace)
        {
            int previousValue = int.MinValue;

            int requiredSpace = truckSpace - 30;
            
            Dictionary<int, int> map = new Dictionary<int, int>();
            List<int> result = new List<int>();

            for (int i = 0; i < PackagesSpace.Count; ++i)
            {
                int temp = requiredSpace - PackagesSpace[i];
                // checking for condition , if we find Match values then insert values into output list
                if (temp >= 0 && map.ContainsKey(temp) && previousValue < temp)
                {

                    //Console.Write("Pair with given sum " +
                    //              sum + " is (" + arr[i] +
                    //                   ", " + temp + ")");
                    int row = i > map[temp] ? map[temp] : i;
                    int col = i < map[temp] ? map[temp] : i;
                    if (result.Count == 0)
                    {
                        result.Add(row);
                        result.Add(col);
                    }
                    else // if we find the higher ranking id than previous then replace the old one
                    {
                        result[0] = row;
                        result[1] = col;
                    }
                    previousValue = temp;
                }
              
                if (!map.ContainsKey(PackagesSpace[i]))
                {
                    map.Add(PackagesSpace[i],i);
                }
            }
            return result;
        }
     


        //public static List<int> IDsOfPackages(int truckSpace, List<int> PackagesSpace)
        //{
        //    int requireSpace = truckSpace - 30;
        //    int previousSpace = int.MinValue;
        //    int previousPackageId = int.MinValue;
        //    List<int> result = new List<int>();
        //    int topCounts = 2;
        //    if (requireSpace <= 30)
        //    {
        //        return new List<int>();
        //    }
        //    for (int row = 0; row < PackagesSpace.Count; row++)
        //    {
        //        for (int col = row; col < PackagesSpace.Count; col++)
        //        {
        //            if (col != row && PackagesSpace[row] != PackagesSpace[col])
        //            {
        //                int sum = PackagesSpace[row] + PackagesSpace[col];
        //                if (sum <= requireSpace && previousSpace <= sum && (PackagesSpace[row] > previousPackageId || PackagesSpace[col] > previousPackageId))
        //                {
        //                    if (result.Count == topCounts)
        //                    {
        //                        result[0] = row > col ? col : row;
        //                        result[1] = col < row ? row : col;
        //                        continue;
        //                    }
        //                    else
        //                    {
        //                        result.Add(row > col ? col : row);
        //                        result.Add(col < row ? row : col);
        //                    }
        //                    previousPackageId = PackagesSpace[row];
        //                    previousSpace = sum;
        //                }
        //            }
        //        }
        //    }
        //    return result;
        //}
    }
}
