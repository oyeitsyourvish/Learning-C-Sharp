using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._14Polymorphism
{
    internal class OverhidingChild
    {
        internal double Func(int a)
        {
            Console.WriteLine("Parent Class Override Method");
            return a * a;
        }
    }
}
