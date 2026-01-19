using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._17ExceptionHandling
{
    internal class ExampleOfException
    {
        internal void Exception()
        {
            int a = 10, b = 0;

            // here we got this exception: System.DivideByZeroException
            int c = a / b;  // it goes to infinite loop so we need to handle exception.
            Console.WriteLine(c);

        }
    }
}
