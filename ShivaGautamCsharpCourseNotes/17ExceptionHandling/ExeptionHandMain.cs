using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._17ExceptionHandling
{
    internal class ExeptionHandMain
    {
        /* Exception Handling :- it use to handle unexcpted errror
          - it use to smoothly terminate the program in case of runtime error.

        Note :- 
        - Try block is always one we can write our code thaire but catch block can be multiple.
        - It by default identify which excpetion is there if we use Exception e.
         
         */
        public static void Main(string[] args)
        {
            ExampleOfException e = new ExampleOfException();
            e.Exception();

            MultiCatchBlock m = new MultiCatchBlock();
           // m.Run();
        }

    }
}
