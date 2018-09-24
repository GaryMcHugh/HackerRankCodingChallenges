using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace SumsAndIndexs
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 12;
            int[] numbers = new int[9] { 1, 8, 7, 3, 5, 4, 6, 6, 5 };
            var total = 0;
            var dic = new Dictionary<int,List<int>>();
            for (var index = 0; index < numbers.Length; index++)
            {
                if (!dic.ContainsKey(numbers[index]))
                {
                    dic.Add(numbers[index], new List<int>());
                }

                dic[numbers[index]].Add(index);
            }
            for (var index = 0; index < numbers.Length; index++)
            {
                var find = 12 - numbers[index];
                if (!dic.ContainsKey(find))
                    continue;
                foreach (var item in dic[find])
                {
                    if (item <= index)
                        continue;
                    Console.WriteLine(index + "," + item);
                }
            }
                /*
                var numWithIndexes = numbers.Select((value, index) => new { value, index });

                var pairs = from num1 in numWithIndexes
                    from num2 in numWithIndexes
                    select new[]
                    {
                        num1.value, // first number in the pair
                        num2.value, // second number in the pair
                        num1.index, // index of the first number in the pair
                        num2.index  // index of the second member in the pair
                    };

                foreach (var pair in pairs)
                {
                    total = pair[0] + pair[1];

                    if (total == sum && pair[2] != pair[3])  
                        Console.WriteLine(pair[2] + ", " + pair[3]);
                }*/
                Console.ReadLine();
        }
    }
}