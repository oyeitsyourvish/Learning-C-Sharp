using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._14Polymorphism
{
    internal class Overriding
    {
        /* Here Overriding works.
            but in Overriding We need to parent method as Virtual access modifier and in child when we Override it the we use
            Override keyword as access modifier */
        virtual internal  double  Func(int a)
        {
            Console.WriteLine("Parent Class Override Method");
            return a * a;
        }
    }
}
