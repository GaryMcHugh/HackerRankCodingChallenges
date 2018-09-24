using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            var count = 2;
            insertionSort2(n, arr, count);
        }
        static void insertionSort2(int n, int[] arr, int count)
        {
            int[] arr_unsorted = new int[arr.Length];
            int[] arr_sort = new int[arr.Length];
            

            for (var i = 0; i < arr.Length; i++)
            {
                if (i < count)
                    arr_sort[i] = arr[i];
                else if (i >= count)
                    arr_unsorted[i] = arr[i];
            }

            Array.Sort(arr_sort);

            List<int> list = new List<int>();
            list.AddRange(arr_sort);
            list.AddRange(arr_unsorted);

            int[] result = list.ToArray();
            result = RemoveZeros(result);

            for (var j = 0; j < arr.Length; j++)
                    Console.Write(result[j] + " ");
            Console.WriteLine();

            count++;
            if (count <= arr.Length)
            {
                insertionSort2(n, result, count);
            }
            Console.ReadLine();
        }

        public static int[] RemoveZeros(int[] source)
        {
            return source.Where(i => i != 0).ToArray();
        }
    }
}
