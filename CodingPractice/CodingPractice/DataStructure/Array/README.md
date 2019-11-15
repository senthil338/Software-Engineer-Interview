#### Some important topic to be considered
1. Write a program to find duplicate elements in an array
2. Write a program to find continuous sub array whose sum is equal to a given number
3. Write a program to find a missing number in an integer array
4. Write a program to count occurrences of each element in an array
5. Write a program to reverse an array without using an additional array

### Array
<p name="array"></p>
An array, is a data structure consisting of a collection of elements (values or variables), each identified by at least one array index.
<br/>
 
    
1. An array stores a fixed-size sequential collection of elements of the same type. 
	 - (i.e) char array only accept the char likewise integer only accept int value
2. Array is a reference type, so you need to use the new keyword to create an instance of the array. For example,
	- int[] balance = new int[10];
3. You can assign values to the array at the time of declaration, as shown,
	- char[] arr1 = {'g', 'e', 'e', 'k', 's'};
	- You can also create and initialize an array, as shown
	- int [] marks = new int[5]  { 99,  98, 92, 97, 95};




#### Types of Array
- **One dimensional arrays**
	char[] arr1 = {'g', 'e', 'e', 'k', 's'};
- **Two dimensional**
    int[,] array = new int[4, 2];
- **Multi dimensional arrays**
	int[, ,] array1 = new int[4, 2, 3];
- **Jagged arrays** - A jagged array is an array whose elements are arrays. The elements of a jagged array can be of different dimensions and sizes. A jagged array is sometimes called an "array of arrays." 

	int[][] jaggedArray = new int[3][]; <br>
	jaggedArray[0] = new int[5]; <br>
	jaggedArray[1] = new int[4]; <br>
	jaggedArray[2] = new int[2]; <br>

Reference : [Multidimensional-arrays](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays)
<br>Reference : [Jagged-arrays](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/jagged-arrays)
<br/>

##### Basic Operations on Arrays and Complexity
- Insert - O(n), Get - O(1), Delete - O(n) , Size
<br/>
