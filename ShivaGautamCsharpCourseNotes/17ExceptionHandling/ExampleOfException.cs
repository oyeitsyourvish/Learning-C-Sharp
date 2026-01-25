using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._17ExceptionHandling
{
    internal class ExampleOfException
    {
        internal void Exception()
        {
            string s = " ";
            try
            {
                Console.WriteLine("Enter the First Number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the First Number");
                int b = Convert.ToInt32(Console.ReadLine()); 
                // here we got this exception: System.DivideByZeroException
                int c = a / b;  // it goes to infinite loop so we need to handle exception. // we handled it in Catch Block.
                Console.WriteLine(c);
                s ="Successfully Done"; // if no exception occur then only it will print this line.
            }
            catch (Exception e) //it by default identify which excpetion is there if we use Exception e
            {
                Console.WriteLine(e.Message.ToString()); //it give why we get the exception there.
                s = "Not Successful"; // if exception occur then it will print this line.
            }


            /* Finally Keyword Use :- it is used to execute the code after try and catch block.
             and it always execute no matter exception occur or not. */
            finally
            {
                Console.WriteLine(s); // it always execute no matter exception occur or not.
            }

        }
    }
}
