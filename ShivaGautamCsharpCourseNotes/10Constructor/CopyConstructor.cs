using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._10Constructor
{
    internal class CopyConstructor
    {
        int a, b;
        public CopyConstructor()
        {
            a = 20;
            b = 10;
            Console.WriteLine("Non-Static Non-Parameterized Constructor : "+(a+b));
        }

        // we are passing above constructor as paramater.
        public CopyConstructor(CopyConstructor c)
        {
            this .a = c.a;
            this .b = c.b;
            Console.WriteLine("Copy-Constructor : "+ (a-b));
        }

    }
}
