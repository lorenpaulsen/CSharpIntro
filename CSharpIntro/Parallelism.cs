using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// ReSharper disable All

namespace CSharpIntro
{
    public class Parallelism
    {

        public static void Run(IEnumerable<Student> students)
        {
            Console.WriteLine();

            var stopwatch = new Stopwatch();

            stopwatch.Start();
            foreach (var student in students)
            {
                Thread.Sleep(1000);
                Console.WriteLine(student);
            }
            stopwatch.Stop();

            Console.WriteLine("{0} ms ellapsed", stopwatch.ElapsedMilliseconds);
            Console.WriteLine();

            stopwatch.Restart();

            students.AsParallel().ForAll(x =>
            {
                Thread.Sleep(1000);
                Console.WriteLine(x);
            });

            stopwatch.Stop();
            Console.WriteLine("{0} ms ellapsed", stopwatch.ElapsedMilliseconds);

        }
    }
}
