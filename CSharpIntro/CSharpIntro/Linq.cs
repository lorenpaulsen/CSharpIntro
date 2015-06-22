using System;
using System.Collections.Generic;
using System.Linq;
// ReSharper disable All

namespace CSharpIntro
{
    public class Linq
    {
        public static void Run(IEnumerable<Student> students)
        {
            // how many students have a 3.5 or higher?
            var total = students.Count();
            var honorRollCount = 0;
            foreach (var student in students)
            {
                if (student.Gpa >= 3.5m)
                {
                    honorRollCount++;
                }
            }

            Console.WriteLine("{0} of {1} students\n", honorRollCount, total);

            #region using LINQ

            honorRollCount = students.Where(x => x.Gpa >= 3.5m).Count();

            #endregion

            honorRollCount = students.Count(x => x.Gpa >= 3.5m);

            Console.WriteLine("{0} of {1} students\n", honorRollCount, total);
        }
    }
}