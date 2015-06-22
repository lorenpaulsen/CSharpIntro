using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable All

namespace CSharpIntro
{
    public class Collections
    {
        public static void Run(IEnumerable<Student> students)
        {
            // yes, I would usually use "var"
            IEnumerable<Student> iEnumerable = students;

            // IEnumerable only contains "GetEnumerator"
            // returning an enumerator with a "Current" property
            // and a "MoveNext" method

            // the foreach loop uses the enumerator
            foreach (var student in iEnumerable)
            {
                Console.WriteLine("{0} {1} ({2})", student.FirstName, student.LastName, student.Gpa);

                // or override ToString()
                Console.WriteLine(student);
            }
            Console.WriteLine();

            // ICollections are "bags", with Add/Remove/Count
            ICollection<Student> iCollection = (ICollection<Student>) students;
            iCollection.Add(new Student { FirstName = "Jean", LastName = "Cooper", Gpa = 4.0m});

            // ILists add an indexer
            IList<Student> iList = (IList<Student>) students;
            var firstStudent = iList[0];

            Console.WriteLine(firstStudent);

            // be as generic as possible, use IEnumerable wherever possible
            Console.WriteLine();
        }
    }
}
