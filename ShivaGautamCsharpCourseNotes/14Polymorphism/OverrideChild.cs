using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._14Polymorphism
{
    internal class OverrideChild : Overriding
    {
        override internal double Func(int a)
        {
            Console.WriteLine("Child Class Overhiding Method");
            return a * a ;
        }
    }
}
