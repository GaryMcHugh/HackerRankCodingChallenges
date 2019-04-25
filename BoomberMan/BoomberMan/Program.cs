//link to problem(InComplete):
//https://www.hackerrank.com/challenges/bomber-man/problem

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomberMan
{
    class Program
    {
        private static int NoOfSeconds;
        private static int count;
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            var gridLength = Int32.Parse(numbers[0]);
            var gridWidth = Int32.Parse(numbers[1]);
            NoOfSeconds = Int32.Parse(numbers[2]);

            char[,] grid = new char[gridLength, gridWidth];

            ReadInGrid(gridLength, gridWidth, grid);

            if (NoOfSeconds == 0 || NoOfSeconds == 1)
            {
                PrintGrid(grid);
                return;
            }
            count++;
            plantBombs(grid, gridLength, gridWidth);
        }

        private static void plantBombs(char[,] grid, int length, int width)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (grid[i, j] == '.')
                        grid[i, j] = '0';
                }
            }
            count++;
            if (NoOfSeconds % 2 == 0)
            {
                PrintGrid(grid);
                return;
            }
            blowUp(grid, length, width);
        }

        private static void blowUp(char[,] grid, int length, int width)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (grid[i, j] == 'O')
                    {
                        //check boundaries
                        if (i - 1 >= 0 && grid[i - 1, j] != 'O')
                        {
                            //up
                            grid[i - 1, j] = '-';
                        }
                        if (i + 1 < length && grid[i + 1, j] != 'O')
                        {
                            //down
                            grid[i + 1, j] = '-';
                        }

                        if (j - 1 >= 0 && grid[i, j - 1] != 'O')
                        {
                            //left
                            grid[i, j - 1] = '-';
                        }
                        if (j + 1 < width && grid[i, j + 1] != 'O')
                        {
                            //right
                            grid[i, j + 1] = '-';
                        }
                        grid[i, j] = '-';
                    }
                }
            }
            count++;

            if (count == 3 && NoOfSeconds % 3 == 0)
            {
                PrintGrid(grid);
                return;
            }
            if (count == 5)
            {
                PrintGrid(grid);
                return;
            }
            plantBombs(grid, length, width);
        }

        private static void ReadInGrid(int length, int width, char[,] data)
        {
            for (int j = 0; j < length;)
            {
                string read;
                read = Console.ReadLine();

                for (int i = 0; i < width; i++)
                    data[j, i] = read[i];
                j++;
            }
        }
        private static void PrintGrid(char[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == '-')
                        grid[i, j] = '.';
                    else if (grid[i, j] == '0')
                        grid[i, j] = 'O';
                    Console.Write(grid[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}