using System;

namespace breakingRecords
{
    class Program
    {
        static int[] breakingRecords(int[] scores)
        {
            var highest = scores[0];
            var lowest = scores[0];

            var highestCount = 0;
            var lowestCount = 0;
            
            for (var i = 1; i < scores.Length; i++)
            {
                if (scores[i] > highest)
                {
                    highest = scores[i];
                    highestCount++;
                }

                if (scores[i] < lowest)
                {
                    lowest = scores[i];
                    lowestCount++;
                }
            }

            int[] countArray = {highestCount, lowestCount};

            return countArray;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            var n = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
                ;
            int[] result = breakingRecords(scores);

            Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
