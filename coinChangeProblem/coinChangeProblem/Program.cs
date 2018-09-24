using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

class Solution
{
     public static int NoOfSolutions = 0;
     public static List<long> myList = new List<long> { 0 };
    static void GetWays(long total, long[] c)
    {
        foreach (var items in c)
        {
            total -= c[items-1];
            myList.Add(c[items-1]);

            if (total == 0)
            {
                NoOfSolutions++;
                Console.WriteLine("numbers used to make zero");
                myList.ForEach(Console.WriteLine);
                myList.Clear();
                return;
            }
            if (total < 0)
            {
                myList.Clear();
                return;
            }

            //foreach (var item in c)
            //{
            //}

            GetWays(total, c);
        }
    }

    static void Main(String[] args)
    {
        //string[] tokens_n = Console.ReadLine().Split(' ');
        //int n = Convert.ToInt32(tokens_n[0]);
        //int m = Convert.ToInt32(tokens_n[1a]);
        //string[] c_temp = Console.ReadLine().Split(' ');
        //long[] c = Array.ConvertAll(c_temp, Int64.Parse);
        int n = 4;
        long[] c = {1, 2 ,3};

        GetWays(n, c);

        Console.WriteLine("no of solutions is: " + NoOfSolutions);
        Console.ReadLine();

        //// Print the number of ways of making change for 'n' units using coins having the values given by 'c'
        ////long ways = getWays(n, c);
        //List<long> lst = c.OfType<long>().ToList(); // this isn't going to be fast.
        //GetCombination(lst);
    }

    //static void GetCombination(List<long> list)
    //{
    //    int n = 4;
    //    List<long> myList = new List<long> { 0 };
    //    double count = Math.Pow(2, list.Count);
    //    for (int i = 1; i <= count - 1; i++)
    //    {
    //        myList.Clear();
    //        string str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
    //        for (int j = 0; j < str.Length; j++)
    //        {
    //            if (str[j] == '1')
    //            {
    //                //Console.WriteLine("Progam output" + list[j]);
    //                myList.Add(list[j]);
    //            }
    //        }
    //        long total = myList.Sum(x => Convert.ToInt32(x));
    //        //Console.WriteLine("total: " + total);

    //        if (total == n)
    //        {
    //            Console.WriteLine("list contents");
    //            myList.ForEach(Console.WriteLine);
    //        }
    //    }
    //}
}
