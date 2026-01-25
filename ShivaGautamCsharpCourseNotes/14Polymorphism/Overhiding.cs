using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._14Polymorphism
{
    internal class Overhiding
    {
        /* Overhidding : it is only present c#.
         * Definition : Having multiple method with same name and same parameter but different in class(par and child)
               without Virtual in parent and Override in child keyword known Overhiding.
            - which reference we create that class method will be run.
            - ex. Parent p = new Child() // it access parent ref method.
            - we cant use virtual and override keyword means it is overriding.                 
          */
        internal double Func(int a)
        {
            Console.WriteLine("Parent Class Overhiding Method");
            return a * a;
        }
    }
}
