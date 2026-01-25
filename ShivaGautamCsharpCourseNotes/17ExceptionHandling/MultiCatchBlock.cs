using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace CSharpBasicToAdvanced._17ExceptionHandling
{
    internal class MultiCatchBlock
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Enter the first number:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                int b = Convert.ToInt32(Console.ReadLine());

                int c = a / b;
                Console.WriteLine("Result: " + c);
            }
            catch (FormatException) // specific exception for invalid format
            {
                Console.WriteLine("Input was not a valid integer.");
            }
            catch (DivideByZeroException) // specific exception for division by zero
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (OverflowException) // only for int32
            {
                Console.WriteLine("The number entered is too large or too small.");
            }
            catch (Exception ex)  // overall exception handler
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
        }
    }
}
