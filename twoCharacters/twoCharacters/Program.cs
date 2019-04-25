//link to problem:
//https://www.hackerrank.com/challenges/two-characters/problem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            if (s.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }
            int result = twoCharaters(s);
            
            Console.WriteLine(result);
        }

        static int twoCharaters(string s)
        {
            IDictionary<char, int> charDict = new Dictionary<char, int>();
            var _outInt = 0;
            var chars = s.ToCharArray();
            var removeChar = "";
            char[] chr = { };
            var result = RemoveConsecutiveLetters(chars);
            //result contains string char[] with no consecutive letters

            charDict = populateDictionary(result);

            for (int i = 0; i < 10000; i++)
            {
                if (charDict.Values.Count > 2)
                {
                    result = removeLowestFrequency(charDict, result);
                    charDict = populateDictionary(result);
                    if (charDict.Values.Count == 2)
                    {
                        break;
                    }
                    result = RemoveConsecutiveLetters(result);
                    //pass result to dictionary
                    
                }
            }


            if (result.Length == 0)
                return 0;

            return result.Length;
        }

        private static Dictionary<char, int> populateDictionary(char[] result)
        {
            IDictionary<char, int> charDict = new Dictionary<char, int>();
            int _outInt;
            foreach (var ch in result)
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
            return (Dictionary<char, int>) charDict;
        }

        private static char[] RemoveConsecutiveLetters(char[] chars)
        {
            var removeChar = "";
            char[] chr = { };
            for (var i = 0; i < chars.Length; i++)
            {
                if (i != chars.Length - 1)
                {
                    if (chars[i] == chars[i + 1])
                    {
                        removeChar = chars[i].ToString();
                        string noConsecutive = new string(chars);
                        var result = noConsecutive.Replace(removeChar, "");
                        chr = result.ToCharArray();
                        chars = chr;
                        i = -1;
                    }
                }
            }
            //chars = chr;
            return chars;
        }

        private static char[] removeLowestFrequency(IDictionary<char, int> charDict, char[] result)
        {
            char[] chr;


            for (var i = 0; i < result.Length; i++)
            {
                if (i != result.Length - 1)
                {
                    var min = charDict.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;
                    String cString = min.ToString();
                    string noConsecutive = new string(result);
                    var resultss = noConsecutive.Replace(cString, "");
                    chr = resultss.ToCharArray();
                    result = chr;
                }
            }
            return result;
        }
    }
}
