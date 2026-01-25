using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._13Inheritance
{
    internal class Rectangle : Circle
    {
        internal int param2;
        
        internal void Accept(int param2)
        {
            this.param2 = param2;
        }

        internal void reactArea()   
        {
            area = param1 * param2;
        }
    }
}
