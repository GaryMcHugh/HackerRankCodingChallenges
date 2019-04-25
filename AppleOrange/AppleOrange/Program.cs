//link to problem:
//https://www.hackerrank.com/challenges/apple-and-orange/problem

using System;

namespace AppleOrange
{
    class Program
    {
        static void countApplesAndOranges(int startPoint, int endPoint, int appleBaseNo, int orangeBaseNo, int[] apples, int[] oranges)
        {
            var appleCount = 0;
            var orangeCount = 0;

            foreach (var apple in apples)
            {
                var total = appleBaseNo;
                total += apple;
                if (total >= startPoint && total <= endPoint)
                    appleCount++;
            }

            foreach (var orange in oranges)
            {
                var total = orangeBaseNo;
                total += orange;
                if (total >= startPoint && total <= endPoint)
                    orangeCount++;
            }

            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string[] points = Console.ReadLine().Split(' ');
            int startPoint = Convert.ToInt32(points[0]);
            int endPoint = Convert.ToInt32(points[1]);

            string[] baseNumbers = Console.ReadLine().Split(' ');
            int appleBaseNo = Convert.ToInt32(baseNumbers[0]);
            int orangeBaseNo = Convert.ToInt32(baseNumbers[1]);

            string[] mn = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(mn[0]);
            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));

            countApplesAndOranges(startPoint, endPoint, appleBaseNo, orangeBaseNo, apples, oranges);
        }
    }
}
