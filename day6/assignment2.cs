// Declare a single-dimensional array of 5 integers.
//int[] arr = new int[5];
//arr[0] = 0;
//arr[1] = 1;

//var arr2 = (int[])arr.Clone();

//arr2[0] = 2;

//int[] arr3 = new int[5];
//arr.CopyTo(arr3, 0);

//arr3[0] = 2;
//foreach (int i in arr)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();

//foreach (int i in arr2)
//{
//    Console.Write(i + " ");

//}


//--------------------------------------------------------------------//
//Practice Arrays
//1.
//Copying an Array
//Write code to create a copy of an array. First, start by creating an initial array. (You can use 
//whatever type of data you want.) Let’s start with 10 items. Declare an array variable and 
//assign it a new array with 10 items in it.Use the things we’ve discussed to put some values in the array. 
//Now create a second array variable. Give it a new array with the same length as the first. 
//Instead of using a number for this length, use the Length
//property to get the size of the original array.
//Use a loop to read values from the original array and place them in the new array.
//Also print out the contents of both arrays, to be sure everything copied correctly.


//int[] arr = new int[10];

//for(int i = 0; i < arr.Length; i++)
//{
//    arr[i] = i;
//}

//int[] arr2 = new int[arr.Length];

//for (int i = 0; i < arr2.Length; i++)
//{
//    arr2[i] = arr[i];
//}

//for(int i = 0; i < arr.Length; i++)
//{
//    Console.Write(arr[i]);
//}
//Console.WriteLine();
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write(arr2[i]);
//}



//--------------------------------------------------------------------//
//2.
//Write a simple program that lets the user manage a list of elements.
//It can be a grocery list, "to do" list, etc. Refer to 
//Looping Based on a Logical Expression
// if necessary to see how to 
//implement an infinite loop. Each time through the loop, ask the user to perform an 
//operation, and then show the current contents of their list. The operations available should 
//be Add, Remove, and Clear. The syntax should be as follows:
//+ some item
//- some item
//--
//Your program should read in the user's input and determine if it begins with a  “+” or “-“ or 
//if it is simply  “—-“ . In the first two cases, your program should add or remove the string 
//given ("some item" in the example). If the user enters just “—“ then the program should 
//clear the current list. Your program can start each iteration through its loop with the 
//following instruction:
//Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");

//string result = "";

//while (true)
//{
//    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");

//    string s = Console.ReadLine();
//    string op = s.Substring(0, 2);
//    string item = s.Trim().Substring(2);

//    if (op.Equals("--"))
//    {
//        //clear
//        result = "";
//        Console.WriteLine("clear");
//    }else if(op[0] == '-')
//    {
//        if (result.Contains(item))
//        {
//            //remove
//            //Console.WriteLine("remove");
//            for (int i = 0; i < result.Length - item.Length + 1; i++)
//            {
//                if(result.Substring(i, item.Length).Equals(item))
//                {
//                    result = result.Substring(0,i - 2) + result.Substring(i + item.Length);
//                    break;  
//                }
//            }
//        }


//    }
//    else if(op[0] == '+')
//    {
//        //add
//        //Console.WriteLine("add");
//        result += ", " + item;

//    }
//    else
//    {
//        Console.WriteLine("Incorrect Command");
//    }

//    Console.WriteLine("current list" + result);
//}





//--------------------------------------------------------------------//

//3.
//Write a method that calculates 
//all prime numbers in given range
// and returns them as array 
//of integers

//int[] arr = FindPrimesInRange(0, 20);

//foreach(var item in arr)
//{
//   Console.WriteLine(item);
//}

//static int[] FindPrimesInRange(int startNum, int endNum) {

//    List<int> primes = new List<int>();
//    for(int i = startNum; i <= endNum; i++)
//    {
//        if(isPrime(i))
//            primes.Add(i);
//    }

//    return primes.ToArray();

//}

//static bool isPrime(int num)
//{
//    for(int i = 2; i <= Math.Sqrt(num); i++)
//    {
//        if (num % i == 0)
//            return false;
//    }
//    return true;
//}





//--------------------------------------------------------------------//

//4.
//Write a program to read an array of n integers
// (space separated on a single line) and an 
//integer k, rotate the array right k times
// and sum the obtained arrays after each rotation as 
//shown below.
//After r rotations the element at position I goes to position (I + r) % n.
//The sum[] array can be calculated by two nested loops:  
//for r = 1... k; for I = 0... n - 1.

//Input         Output          Comments
//3 2 4 - 1      3 2 5 6        rotated1[] = -1  3  2  4
//2                             rotated2[] = 4 - 1  3  2
//                              sum[]      = 3  2  5  6

//1 2 3 4 5     12 10 8 6 9     rotated1[] = 5  1  2  3  4
//3                             rotated2[] = 4  5  1  2  3
//                              rotated3[] = 3  4  5  1  2
//                              sum[]      = 12 10  8  6  9


//string s = Console.ReadLine();
//int k = int.Parse(Console.ReadLine());

//string[] arr = s.Split(' ');
//int[] nums = new int[arr.Length];
//int[] sum = new int[arr.Length];

//for(int i = 0; i < arr.Length; i++)
//{
//    nums[i] = int.Parse(arr[i]);
//}


//for(int i = 0; i < k; i++)
//{
//    int last = nums[nums.Length - 1];
//    //rotate once
//    for(int j = nums.Length - 1;  j > 0;  j--)
//    {
//        nums[j] = nums[j - 1];
//    }
//    nums[0] = last;


//    //add to sum
//    for(int j = 0; j < arr.Length; j++)
//    {
//        sum[j] += nums[j];
//    }

//}

//foreach(int i in sum)
//{
//    Console.WriteLine(i);
//}







//--------------------------------------------------------------------//

//5
//.
//Write a program that finds the 
//longest sequence of equal elements
// in an array of integers. 
//If several longest sequences exist, print the leftmost one.
//Input                          Output
//2 1 1 2 3 3 2 2 2 1            2 2 2
//1 1 1 2 3 1 3 3                1 1 1
//4 4 4 4                        4 4 4 4
//0 1 1 5 2 2 6 3 3              1 1

//while (true)
//{

//    string s = Console.ReadLine();
//    string[] arr = s.Trim().Split(' ');
//    int[] nums = new int[arr.Length];

//    for (int i = 0; i < arr.Length; i++)
//    {
//        nums[i] = int.Parse(arr[i]);
//    }

//    string result = "";
//    int max = 0;
//    for (int i = 0; i < nums.Length - 1;)
//    {
//        int count = 0;
//        int num = nums[i];
//        while (i < nums.Length && num - nums[i] == 0)
//        {
//            count++;
//            i++;
//        }

//        if (count > max)
//        {
//            result = "";
//            for (int j = 0; j < count; j++)
//            {
//                result += num + " ";
//            }
//            max = count;
//        }

//    }

//    Console.WriteLine("longest sequence: " + result);

//}




//--------------------------------------------------------------------//


//7.
//Write a program that finds the 
//most frequent number
// in a given sequence of numbers.
// In case of multiple numbers with the same maximal frequency, print the leftmost of them

while (true) { 
string s = Console.ReadLine();
string[] arr = s.Trim().Split(' ');
int[] nums = new int[arr.Length];

for (int i = 0; i < arr.Length; i++)
{
    nums[i] = int.Parse(arr[i]);
}


Dictionary<int, int> map = new Dictionary<int, int>();

foreach(int i in nums)
{
    if (map.ContainsKey(i)) 
    { map[i] += 1; }
    else
    {
        map.Add(i, 1);
    }
}

int mostFreq = 0;
int max = 0;
foreach (int i in map.Keys)
{
    if(map[i] > max)
    {
        max = map[i];
        mostFreq = i;
    }
}

Console.WriteLine("most frequent num: " + mostFreq);
}
