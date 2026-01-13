using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._15Abstraction
{
    internal abstract class Abstract
    {
        internal int param1, param2;
        internal float area;
        internal void accept(int param1, int param2)
        {
            this.param1 = param1;
            this.param2 = param2;
        }

        internal abstract void tringle();
        internal abstract void rectanlge();
        internal void display()
        {
            Console.WriteLine("Area is {0}",area);
        }

    }
}
