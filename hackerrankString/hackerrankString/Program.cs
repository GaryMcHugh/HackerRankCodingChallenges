//link to problem:
//https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankString
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                string result = hackerrankInString(s);
                Debug.WriteLine(result);
            }
        }

        static string hackerrankInString(string s)
        {
            var chars = s.ToCharArray();

            if (chars.Contains('h') && chars.Contains('a') && chars.Contains('c') && chars.Contains('k') &&
                chars.Contains('e') && chars.Contains('r') && chars.Contains('n'))
                return "YES";
            else
                return "NO";
        }
    }
}
