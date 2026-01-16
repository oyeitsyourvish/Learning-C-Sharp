using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._14Polymorphism
{
    internal class OverrideChild : Overriding
    {
        override internal double Func(int a)
        {
            Console.WriteLine("Child Class Override Method");
            return a * a ;
        }
    }
}
