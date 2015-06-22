using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable All

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# 3.0 Language Features
            var list = Initialization.Run();

            Collections.Run(list);

            Linq.Run(list);

            Parallelism.Run(list);

            // C# 5.0 language features
            Async.Run().Wait();
        }
    }
}
