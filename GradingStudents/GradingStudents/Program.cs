using System;
using System.IO;

namespace GradingStudents
{
    class Program
    {
        static int[] gradingStudents(int[] grades)
        {
            for (var i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= 38)
                {
                    if (grades[i] % 5 >= 3)
                    {
                        if (grades[i] % 5 == 4)
                        {
                            grades[i] += 1;
                        }

                        if (grades[i] % 5 == 3)
                        {
                            grades[i] += 2;
                        }
                    }
                }
            }
            return grades;

        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] grades = new int[n];

            for (int gradesItr = 0; gradesItr < n; gradesItr++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine());
                grades[gradesItr] = gradesItem;
            }


            Console.WriteLine("----");
            int[] result = gradingStudents(grades);

            Console.WriteLine(string.Join("\n", result));
            Console.ReadLine();
        }
    }
}
