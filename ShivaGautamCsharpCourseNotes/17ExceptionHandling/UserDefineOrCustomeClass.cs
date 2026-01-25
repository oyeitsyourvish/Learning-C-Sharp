using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._17ExceptionHandling
{
    internal class UserDefineOrCustomeClass
    {
        /* Custome Or User Define Exception :- this type of exception is created by developer itself. 
          - Custom Exception is always called by using 'throw' keyword.
          
         */
        internal void Run()
        {
            try
            {
                Console.WriteLine("Enter the first number:");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a < 0)
                {
                    throw new VishalCustomeException(); // manually call exception.
                }
                Console.WriteLine("This is the user entered value : " + a);
            }
            catch (VishalCustomeException ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }
        }
    }
}
