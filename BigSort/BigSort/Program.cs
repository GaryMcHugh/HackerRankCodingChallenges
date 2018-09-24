using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];
            for (int arr_i = 0; arr_i < n; arr_i++)
            {
                arr[arr_i] = Console.ReadLine();
            }
            bigSorting(arr);
        }

        static void bigSorting(string[] arr)
        {
            List<ulong> shortNum = new List<ulong>();
            List<string> longNum = new List<string>();

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > 19)
                    longNum.Add(arr[i]);
                else
                {
                    shortNum.Add(Convert.ToUInt64(arr[i]));
                }
            }

            shortNum.Sort();
            var result = shortNum.ConvertAll<string>(i => i.ToString());
            var sorted = longNum.OrderBy(n => n.Length).ThenBy(n => n).ToList();

            result.AddRange(sorted);
            result.ToArray();

            for (int i = 0; i < result.Count; i++)
                Console.WriteLine(result[i]);
        }
    }
}
