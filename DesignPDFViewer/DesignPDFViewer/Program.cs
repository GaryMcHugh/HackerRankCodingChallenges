//link to problem:
//https://www.hackerrank.com/challenges/designer-pdf-viewer/problem

using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPDFViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));
            var word = Console.ReadLine();

            Console.WriteLine(DesignerPdfViewer(height, word));
        }

        private static int DesignerPdfViewer(int[] height, string word)
        {
            var alphabet = new Dictionary<char, int>();

            var letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (var i = 0; i < height.Length; i++)
                alphabet.Add(letters[i], height[i]);

            var charArr = word.ToCharArray();

            var tallestNum = charArr.Select(item => alphabet[item]).Concat(new[] {0}).Max();

            return word.Length * tallestNum;
        }
    }
}
