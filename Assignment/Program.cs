
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

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Reverse<int>(queue);

            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

            //for (int i = 0; i < queue.Count; i++)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            #endregion



        }
    }
}
