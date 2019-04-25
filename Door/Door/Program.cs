//this one is not a hackerrank problem
//it is the monty hall problem or 'door problem'
//here is a link decsriobing the puzzle: https://www.montyhallproblem.com/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Door
{
    class Program
    {
        static void Main(string[] args)
        {
            //RobsWay();
            //return;
            var count = 0;
            for (int i = 0; i < 1000000; i++)
            {
                var door = new int[] {1, 2, 3};

                var random = new Random();

                var n = random.Next(0, 3);
                var prize = door[n];

                var choice = random.Next(1, 4);
                var open = random.Next(1, 4);

                while (open == prize || open == choice)
                    open = random.Next(1, 4);

                List<int> list = door.ToList();
                list.RemoveAt(open - 1);
                int[] doors = list.ToArray();

                var change = random.Next(0, 2);
                
                if (choice == doors[change] && change == 0)
                    change++;
                else if (choice == doors[change] && change == 1)
                    change--;
                
                if (doors[change] == prize)
                    count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }

        private static void RobsWay()
        {
            var count = 0;
            for (var index = 0; index < 1000000; index++)
            {
                var doors = new[] {false, false, false};
                doors[GetRandomDoor()] = true;

                var choice = GetRandomDoor();

                //if (doors[choice])
                //    count++;
                var shownDoor = GetRandomDoor();
                for (var i = 0; i < 3; i++)
                {
                    if (i == choice || doors[i]) continue;
                    shownDoor = i;
                    break;
                }

                var changeMind = 0;
                for (var i = 0; i < 3; i++)
                {
                    if (i == choice || i == shownDoor) continue;
                    changeMind = i;
                    break;
                }

                if (doors[changeMind])
                    count++;

            }
            Console.WriteLine(count);
            Console.ReadLine();
        }

        private static int GetRandomDoor()
        {
            var rnd = new Random();

            return rnd.Next(0, 3);
        }
    }
}
