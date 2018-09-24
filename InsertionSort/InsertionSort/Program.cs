using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            insertionSort1(n, arr);
        }

        static void insertionSort1(int n, int[] arr)
        {
            var temp = arr[arr.Length - 1];
            for (var i = arr.Length - 1; i >= 0; i--)
            {
                if (i > 0)
                {
                    arr[i] = arr[i - 1];
                    if((temp <= arr[i]))
                        printArray(arr);
                }
                if (temp >= arr[i])
                {
                    arr[i] = temp;
                    printArray(arr);
                    break;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        private static void printArray(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
