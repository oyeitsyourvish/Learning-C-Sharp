using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._13Inheritance.SingleLevelInheritance
{
    internal class MainSingleLevel
    {
        public static void Main(string[] args)
        {
            A_Parent a = new A_Parent();
            Console.WriteLine(a.a);

            A_Parent aa = new B_Child(); // this is called Loose Coupling.
            Console.WriteLine(aa.a);

            B_Child b = new B_Child();
            b.fun();
            b.fun1();
            Console.WriteLine(b.a);
            Console.WriteLine(b.b);


          //B_Child bb = new P_Parent(); // this is not possible we cant store parent class obj into child class variable.
        }
    }
}
