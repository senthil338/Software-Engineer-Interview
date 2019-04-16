using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Amazon
{
    public class TruckSpace
    {
        public static void Truck()
        {
            //case 1
            int truckspace = 110;
            List<int> packagespace = new List<int>() { 20, 70, 90, 30, 60, 110 };
            //case 2
           // int truckspace = 250;
           // List<int> packagespace = new List<int>() { 100,180,40,120,10};


            var res = Truck(truckspace, packagespace);
        }
        public static List<int> Truck(int truckspace, List<int> packagespace)
        {
            //time O(n*2)
            //space 0(4) constant space
            int max =int.MinValue ;
            int secondMax = int.MinValue;
            int maxCell = int.MinValue;
            int secondMaxCell = int.MinValue;
           
            int requiredTruckSpace = truckspace - 30;
            for (int row = 0; row < packagespace.Count; row++)
            {
                for (int col = 0; col < packagespace.Count; col++)
                {
                    int currentSpace = packagespace[row] + packagespace[col];
                    if (row != col && currentSpace <= requiredTruckSpace)
                    {
                        if (packagespace[row] > (max > secondMax ? max : secondMax))
                        {
                            if (packagespace[row] > packagespace[col])
                            {
                                max = packagespace[row];
                                secondMax = packagespace[col];
                                maxCell = row;
                                secondMaxCell = col;
                            }
                            else
                            {
                                max = packagespace[row];
                                secondMax = packagespace[col];
                                maxCell = col;
                                secondMaxCell = row;
                            }
                        }
                        
                        //Node node = new Node(col, currentSpace);
                        //if(currentSpace > max)
                        //{
                        //    secondMax = max;
                        //    max = currentSpace;
                        //    maxCell = col;
                        //}
                        //else if(currentSpace > secondMax)
                        //{
                        //    secondMax = currentSpace;
                        //    secondMaxCell = col;
                        //}

                    }
                }
               
            }
            //if 
            if(max!=int.MinValue && secondMax != int.MinValue)
            {
                return maxCell > secondMaxCell ? new List<int>() { secondMaxCell, maxCell } : new List<int>() { maxCell, secondMaxCell };
             //   return new List<int>() { maxCell > secondMaxCell? secondMaxCell, secondMaxCell };
            }
            else if(max != int.MinValue || secondMax != int.MinValue)
            {
               return new List<int>() {  max == int.MinValue? secondMaxCell: maxCell };
            }
            else 
            {
               return new List<int>();
            }
        }
    }
}
