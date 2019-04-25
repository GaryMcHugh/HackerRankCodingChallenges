//link to problem:
//https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockValidString
{
    class Program
    {
        static void Main(String[] args)
        {
            IDictionary<char, int> charDict = new Dictionary<char, int>();
            List<int> counts = new List<int>();
            int _outInt = 0;
            int countMin = 0;
            int countMax = 0;

            string s = "abcccc";

            foreach (var ch in s)
            {
                //if the value is not in the dictionary
                if (!charDict.TryGetValue(ch, out _outInt))
                {
                    //add it
                    charDict.Add(new KeyValuePair<char, int>(ch, 1));
                }
                else
                {
                    //if it is then increment its count
                    charDict[ch]++;
                }
            }

            foreach (var kvp in charDict)
            {
                //Console.WriteLine("Char: "+kvp.Key+" Count: "+kvp.Value);
                counts.Add(kvp.Value);
            }


            //counts.ForEach(Console.WriteLine);

            int lowest_val = counts.Min();
            int max_val = counts.Max();

            int[] array = counts.ToArray();
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == lowest_val)
                    countMin++;

                if (array[i] == max_val)
                    countMax++;
            }

            //if the diff between max and min is 1 and the min occurs only once in the list.

            int diff = max_val - lowest_val;

            List<int> unique = counts.Distinct().ToList();
            //check if all values in the list are equal
            if (counts.Distinct().Count() == 1 || (countMin == 1 || countMax == 1) && unique.Distinct().Count() == 2 && (diff == 1 || unique.Contains(1) && !unique.Contains(4)))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
}
