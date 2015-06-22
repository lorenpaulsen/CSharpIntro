using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable All

namespace CSharpIntro
{
    /// <summary>
    /// Initialization syntax introduced in C# 3.0
    /// </summary>
    public class Initialization
    {
        public static IEnumerable<Student> Run()
        {
            // classic initialization
            Student student1 = new Student();
            student1.FirstName = "Beth";
            student1.LastName = "Tipton";
            student1.Gpa = 3.0m;

            // implicitly typed object with object initializer
            var student2 = new Student
            {
                FirstName = "Kelly",
                LastName = "Morales",
                Gpa = 3.5m
            };

            // adding to a collection
            var list = new List<Student>();
            list.Add(student1);
            list.Add(student2);

            // using a collection initializer 
            return new List<Student>
            {
                new Student {FirstName = "Lisa", LastName = "Wright", Gpa = 2.9m},
                new Student {FirstName = "Patricia", LastName = "Brown", Gpa = 3.1m},
                new Student {FirstName = "Alfredo", LastName = "Myers", Gpa = 3.7m}
            };
        }
    }
}
