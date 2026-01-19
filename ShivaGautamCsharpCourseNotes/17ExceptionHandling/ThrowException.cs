using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._17ExceptionHandling
{
    internal class ThrowException
    {
        // Throw :-  It is used to call exception manually(if there have no exception but we provide manually).


        // wap user enter the negative value then it will throw exception or call exception.
        internal void Run()
        {
            try
            {
                Console.WriteLine("Enter the first number:");
                int a = Convert.ToInt32(Console.ReadLine());
                if(a < 0)
                {
                    throw new Exception("Negetive value not allowed"); // manually call exception.
                }
                Console.WriteLine("This is the user entered value : "+a);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: "+ex);
            }
        }
    }
}
