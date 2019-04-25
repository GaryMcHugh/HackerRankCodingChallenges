//link to problem:
//https://www.hackerrank.com/challenges/sock-merchant/problem

using System;

namespace sockPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = sockMerchant(n, ar);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        static int sockMerchant(int n, int[] ar)
        {
            Array.Sort(ar);
            var pairs = 0;

            for (var i = 0; i < ar.Length - 1; i++)
            {
                if (ar[i] == ar[i + 1])
                {
                    pairs++;
                    i += 1;
                }
            }

            return pairs;
        }
    }
}
