using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._14Polymorphism.RuntimePoly
{
    internal class MethodOverridingChild : MethodOverridingPar
    {
        public override void Meth()
        {
            Console.WriteLine("Child Method");
        }

        public static void Main()
        {
            MethodOverridingPar p = new MethodOverridingChild();
            p.Meth();
        }

    }
}
