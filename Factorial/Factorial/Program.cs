//link to problem:
//https://www.hackerrank.com/challenges/extra-long-factorials/problem

using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Convert.ToInt64(Console.ReadLine());

            Console.Write(extraLongFactorials(number));
        }

        public static BigInteger extraLongFactorials(BigInteger number)
        {
            BigInteger total = 1;
            while (number != 1)
            {
                total = total * number;
                number = number - 1;
            }
            return total;
        }
    }
}
