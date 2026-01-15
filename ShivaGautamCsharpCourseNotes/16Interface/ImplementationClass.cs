using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._16Interface
{
    internal class ImplementationClass : IFirst, ISecond
    {
        public void Func()
        {
            Console.WriteLine("Function");
        }

        public void Func1()
        {
            Console.WriteLine("Func 1");
        }
        public void Func2()
        {
            Console.WriteLine("Func 2");
        }
    }
}
