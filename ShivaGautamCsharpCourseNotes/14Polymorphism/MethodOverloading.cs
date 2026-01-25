using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._14Polymorphism
{
    internal class MethodOverloading
    {
        internal void MethOverloading(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        internal void MethOverloading(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        internal void MethOverloading(string a, string b)
        {
            Console.WriteLine(a + b);
        }
    }
}
