//link to problem:
//https://www.hackerrank.com/challenges/counting-valleys/problem

using System;
using System.IO;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLength = Convert.ToInt32(Console.ReadLine());

            var inputString = Console.ReadLine();

            var result = CountingValleys(inputLength, inputString);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int CountingValleys(int inputLength, string inputString)
        {
            var charArr = inputString.ToCharArray();
            var seaLevel = 0;
            var noOfValleys = 0;

            foreach (var letter in charArr)
            {
                if (letter == 'U')
                    seaLevel++;

                if (letter == 'D')
                    seaLevel--;

                if (seaLevel == 0 && letter != 'D')
                    noOfValleys++;
            }

            return noOfValleys;
        }
    }
}
