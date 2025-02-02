
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {

        #region Q1
        public static int[]? BiggerNumbers(int[]? arr, int[]? q)
        {

            if (arr is not null && q is not null)
            {
                Array.Sort(arr);

                int[] result = new int[q.Length];

                int count = 0;
                for (int i = 0; i < q.Length; i++)
                {

                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[j] > q[i])
                            count++;
                    }

                    result[i] = count;
                    count = 0;
                }
                return result;
            }
            return [-1];
        }
        #endregion

        #region Q2

        public static bool CheckPalindrome(int[]? arr , int N)
        {

            if ( arr is null || N != arr.Length)
                return false;

            int left = 0;
            int right = N - 1;

            while (left < right)
            {
                if (arr[left] != arr[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }

        #endregion

        #region Q3

        public static Queue<T> Reverse<T>(Queue<T>? q)
        {

            
            if (q is not null || q?.Count > 1)
            {

                bool QueueFlag = true;

                bool StackFlag = true;

                T? QueueOutput;

                T? StackOutput;


                Stack<T> stack = new Stack<T>();

                while ( QueueFlag )
                {

                    QueueFlag = q.TryDequeue(out QueueOutput);

                    if (QueueFlag && QueueOutput is not null)
                        stack.Push(QueueOutput);

                }

                while ( StackFlag )
                { 
                
                    StackFlag = stack.TryPop( out StackOutput);
                      
                    if (StackFlag && StackOutput is not null)
                        q.Enqueue(StackOutput);

                }

                return q;


            }

            return q;

        }

        #endregion

        #region Q4

        static public bool IsBalanced( string? str)
        {

            if (str == null) return false;

            
            
            Stack<char> chars = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == '(' || str[i] == '[' || str[i] == '{')
                {
                    chars.Push(str[i]);
                }
                else if (str[i] == ')' || str[i] == ']' || str[i] == '}')
                {
                    if (chars.Count == 0)
                        return false;
                    

                    char top = chars.Pop();

                    if (str[i] == ')' && top != '(' ||
                        str[i] == ']' && top != '[' ||
                        str[i] == '}' && top != '{'
                        ) 
                        return false;

                    
                }
            }

            return chars.Count == 0;

        }

        #endregion

        #region Q5

        public static T[]? RemoveDublicated<T>(T[]? arr)
        {

            if (arr is null || arr?.Length == 0)
                return Array.Empty<T>();

            List<T> list = new List<T>();  

            for (int i = 0; i < arr?.Length; i++)
            {

                bool dublicated = false;

                for (int j = 0; j < i; j++ )
                {

                    if (arr[i]?.Equals(arr[j]) ?? false)
                    {
                        
                        dublicated = true;
                        break;
                    }
                }

                if (!dublicated)
                {
                    list.Add(arr[i]);
                }

            }

            return list?.ToArray();

        }

        #endregion

        #region Q6

        public static List<int> RemoveOddNumbers(List<int> list)
        {
            if ( list is null || list.Count == 0)
                return new List<int>(0);

            for (int i = 0; i < list?.Count; i++)
            {
                if (list[i] % 2 != 0 )
                    list.RemoveAt(i);
            }

            return list ?? new List<int>(0);
        }
        #endregion

        #region Q8

        public static void Target(Stack<int> stack , int target)
        {
           
            

            bool found = false;

            int count = 0;

            while (stack?.Count > 0)
            {
                int top = stack.Pop();

                if ( top == target)
                {
                    found = true;
                    count++;
                    break;
                }

                count++;

            }

            if (found)
                Console.WriteLine($"Target was found successfully and the count = {count}");
            else
                Console.WriteLine("Target was not found");

        }

        #endregion

        #region Q9

        public static int[] Intersection( int[] array01, int[] array02 )
        {
            Array.Sort(array01);
            Array.Sort(array02);

            List<int> list = new List<int>();

            int i = 0;
            int j = 0;

            while (i < array01.Length && j < array02.Length)
            {

                if (array01[i] == array02[j])
                {
                    list.Add(array01[i]);
                    j++;
                    i++;
                }
                else if (array01[i] < array02[j] )
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return list.ToArray();
        }

        #endregion

        #region Q10

        public static ArrayList FindContiguousSublist(ArrayList nums, int target)
        {

            if ( nums is null ||  nums.Count == 0 )
                return new ArrayList();

            for (int i = 0; i < nums.Count; i++)
            {

                int current = 0;

                for (int j = i; j < nums.Count; j++)
                {

                    current += (int?)nums[j] ?? 0;

                    if (current == target)
                    {

                        ArrayList list = new ArrayList();
                        
                        for (int k = i; k <= j ; k++)
                            list.Add(nums[k]);

                        return list;
                    }
                }
            }

            return new ArrayList();
        }

        #endregion
        static void Main(string[] args)
        {

            #region Q1 - Given an array consists of numbers with size N and number of queries, in each query you will be given an integer X, and you shouldprint how many numbers in array that is greater than X.

            //int[] numbers = { 11, 5, 3 };
            //int[] queries = { 1, 5, 13 };

            //int[]? result = BiggerNumbers(numbers, queries);

            //foreach (int i in result ?? [-1])
            //    Console.WriteLine(i);

            #endregion

            #region Q2 - Given a number N and an array of N numbers. Determine if it's palindrome or not.

            //int N = 5;
            //int[] array = { 1, 2, 3, 2, 1 };

            //bool flag = CheckPalindrome (array, N);

            //Console.WriteLine (flag);

            #endregion

            #region Q3 - Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //Reverse<int>(queue);

            //foreach (int item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q4 - Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            //Console.WriteLine(IsBalanced("[()]"));
            //Console.WriteLine(IsBalanced("[()}"));

            #endregion

            #region Q5 - Given an array, implement a function to remove duplicate elements from an array.

            //int[] array = { 1, 2, 2, 3, 4, 4, 5 };

            //int[] newArray = RemoveDublicated<int>(array);

            //for (int i = 0; i < newArray?.Length; i++)
            //{
            //    Console.Write($"{newArray[i]} ");
            //}

            #endregion

            #region Q6 - Given an array list , implement a function to remove all odd numbers from it.

            //List<int> list = [ 1 , 2 , 3 , 4 , 5 , 6];

            //List<int> evenList = RemoveOddNumbers(list);

            //foreach (int i in evenList)
            //    Console.WriteLine(i);

            #endregion

            #region Q7 - Implement a queue that can hold different data types.

            //AnyDataTypeQueue queue = new AnyDataTypeQueue();

            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.25);

            //Console.WriteLine(queue.Dequeue());

            //Console.WriteLine(queue.Peek());

            //Console.WriteLine(queue.Count());

            //Console.WriteLine("============================");

            //queue.Print();


            #endregion

            #region Q8

            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //int target;

            //bool flag = false;

            //do
            //{

            //    Console.Write("Enter your target : ");

            //    flag = int.TryParse(Console.ReadLine(), out target );

            //}while(!flag);


            //Target(stack, target);

            #endregion

            #region Q9 - Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.

            //int[] arr01 = { 1, 2, 4, 4, 5 };
            //int[] arr02 = { 0, 4, 4 };

            //int[] result = Intersection(arr01, arr02);

            //foreach( int i in result ) 
            //    Console.WriteLine(i);

            #endregion

            #region Q10 - Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.

            ArrayList list = [1, 2, 3, 7, 5];

            ArrayList result = FindContiguousSublist(list, 12);

            foreach (int item in result)
                Console.Write($"{item} ");

            #endregion
        }
    }
}
