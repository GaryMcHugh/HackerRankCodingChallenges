//link to problem:
//https://www.hackerrank.com/challenges/reduced-string/problem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reducedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = super_reduced_string(s);
            //Console.WriteLine(result);
        }

        static string super_reduced_string(string s)
        {
            var chars = s.ToCharArray();
            var count = 0;
            for (var i = 0; i < chars.Length; i++)
            {
                if (i != chars.Length - 1)
                {
                    if (chars[i] == chars[i + 1])
                    {
                        chars = chars.Where((source, index) => index != i).ToArray();
                        chars = chars.Where((source, index) => index != i).ToArray();
                        i = -1;
                    }
                }
            }
            if (chars.Length == 0)
                Console.WriteLine("Empty String");
            else
            {
                for (var i = 0; i < chars.Length; i++)
                    Console.Write(chars[i]);
            }
            return "";
        }
    }
}
