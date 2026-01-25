
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._13Inheritance.MultilevelInheritance
{
    internal class MainMaith
    {
        public static void Main(string[] args)
        { 
            // cause of inheritance theire is code reusability.
            Tringle t = new Tringle();
            t.Accept(3);
            t.Accept(5);
            t.triangleArea();
            t.Display();
        }
    }
}
