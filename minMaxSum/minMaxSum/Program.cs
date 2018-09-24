using System;
using System.Linq;

namespace minMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long total = 0;

            var numbers = Console.ReadLine().Split(' ').Select(token => int.Parse(token));
            int[] arr = numbers.ToArray();

            Array.Sort(arr);

            for (long i = 0; i < arr.Length - 1; i++)
                total += arr[i];

            Console.Write(total + " ");

            total = 0;
            for (long i = arr.Length - 4; i < arr.Length; i++)
                total += arr[i];

            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
