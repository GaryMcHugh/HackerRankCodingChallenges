//link to problem:
//https://www.hackerrank.com/challenges/migratory-birds/problem

using System;
using System.Collections.Generic;
using System.Linq;

namespace MigratingBirds
{
    class Program
    {
        static void Main(string[] args)
        {

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            Console.WriteLine(result);
        }

        static int migratoryBirds(List<int> arr)
        {
            var most = arr.GroupBy(i => i).OrderByDescending(grp => grp.Count())
                .Select(grp => grp.Key).First();

            return most;
        }
    }
}
