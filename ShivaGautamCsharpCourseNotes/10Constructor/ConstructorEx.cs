using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._10Constructor
{
    internal class ConstructorEx
    {
        static int x, y;
        int a, b;

        //we dont need to create it its by default present 
        static ConstructorEx()
        {
            x = 100;
            y = 200;
            Console.WriteLine("Static Constructor "+ (x + y));
        }

        internal ConstructorEx()
        {
            a = 100;
            b = 200;
            Console.WriteLine("Non-Static Constructor Without Parametr "+ (a+b));
        }
        internal ConstructorEx(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("Parameterized Non-Static Constructor");
            Console.WriteLine("A is {0} and B is {1}", a,b);
        }
    }
}
