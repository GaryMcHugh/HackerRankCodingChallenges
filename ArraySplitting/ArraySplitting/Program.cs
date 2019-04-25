//this one is not from hackerrank but I thought it was cool

// we take an array and determine if there is anyway to split that array and sum it in a way that two parts will equal
// i.e. { 3, 1, 1, 1 } if we split this array after the 3 then and sum each side.. they will be equal.

using System;

namespace ArraySplitting
{
    class Program
    {
        static void Main(string[] args)
        {

            int b=0;
            var s = int.TryParse("23423", out b);



            TestFunc(x =>
            {
                return x * 5;
            });
            var totalFirstPart = 0;

            var split = new [] { 3, 1, 1, 1 };

            for (var i = 0; i <= split.Length-1; i++)
            {
                totalFirstPart += split[i];
            
                var totalSecondPart = 0;
                for (var j = split.Length - 1; j > i; j--)
                {
                    if (j > i)
                        totalSecondPart += split[j];

                    if (totalFirstPart == totalSecondPart)
                    {
                        Console.WriteLine("they are equal, can split: " + totalFirstPart + " = " + totalSecondPart);
                        Console.ReadLine();
                    }
                }
            }

        }

        private static void TestFunc(Func<int, int> func)
        {
            var test = func.Invoke(10);
            Console.WriteLine(test);
        }

        private static bool Test(int bing)
        {
            bing = 5;
            return true;
        }
    }
    
}
