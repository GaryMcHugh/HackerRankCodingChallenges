using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace diagonalDiff
{
    class Program
    {
        static int diagonalDifference(int[][] arr)
        {
            var row = 0;
            var total = 0;
            while (row < arr.Length)
            {
                total += arr[row][row];
                row++;
            }

            var total2 = 0;
            var col = 0;
            row--;

            while (row > -1)
            {
                total2 += arr[col][row];
                row--;
                col++;
            }

            return Math.Abs(total - total2);
        }
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for (var i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            var result = diagonalDifference(arr);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
