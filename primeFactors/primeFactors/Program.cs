using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace primeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.AreEqual(new[] { 1 }, PrimeFactors(1));
            Assert.AreEqual(new[] { 1, 2 }, PrimeFactors(2));
            Assert.AreEqual(new[] { 1, 3 }, PrimeFactors(3));
            Assert.AreEqual(new[] { 1, 2, 2 }, PrimeFactors(4));
            Assert.AreEqual(new[] { 1, 2, 3 }, PrimeFactors(6));
            Assert.AreEqual(new[] { 1, 2, 3, 5, 7, 11, 13, 17, 19 }, PrimeFactors(2 * 3 * 5 * 7 * 11 * 13 * 17 * 19));

            Console.WriteLine("All Good");
            Console.Read();
        }

        private static int[] PrimeFactors(int i)
        {
            var ret = new List<int>();
            ret.Add(1);

            var k = i;
            for (var j = 2; j <= i; j++)
            {
                while (k % j == 0)
                {
                    ret.Add(j);
                    k /= j;
                }
            }


            return ret.ToArray();
        }
    }
}
