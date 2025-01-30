
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
        static void Main(string[] args)
        {

            #region 1. Given an array consists of numbers with size N and number of queries, in each query you will be given an integer X, and you shouldprint how many numbers in array that is greater than X.
            
            int[] numbers = { 11, 5, 3 };
            int[] queries = { 1, 5, 13 };

            int[]? result = BiggerNumbers(numbers, queries);

            foreach (int i in result ?? [-1])
                Console.WriteLine(i); 

            #endregion

        }
    }
}
