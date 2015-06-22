using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable All

namespace CSharpIntro
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Gpa { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}: {2}", LastName, FirstName, Gpa);
        }
    }
}
