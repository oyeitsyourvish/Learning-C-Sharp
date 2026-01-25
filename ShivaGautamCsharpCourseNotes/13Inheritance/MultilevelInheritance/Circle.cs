using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._13Inheritance
{
    internal class Circle
    {
        internal int param1;
        internal float area;

        internal void Accept(int param1)
        {
            this.param1 = param1;
        }

        internal void CircleArea()
        {
            area = 3.14F * param1 * param1;
        }

        internal void Display()
        {
            Console.WriteLine("Area is {0}", area);
        }
    }
}
