using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable All

namespace CSharpIntro
{
    public class ExampleClass
    {
        #region Getter and Setter Methods

        private string _firstName;

        public string GetFirstName()
        {
            return _firstName;
        }

        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }

        #endregion

        #region Properties!

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        #endregion

        #region Automatic Properties! (C# 3.0; Visual Studio 2008)

        public double Gpa { get; set; }

        #endregion

    }
}
