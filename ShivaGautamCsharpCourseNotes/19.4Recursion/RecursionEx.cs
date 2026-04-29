using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19._4Recursion
{
    internal class RecursionEx
    {
        public int FactorialRecursion(int n)
        {
            try
            {
                if (n == 0)
                {
                    Console.WriteLine("Factorial of 0 is 1");
                    return 1;
                }
                else
                {
                    return n * FactorialRecursion(n - 1); ;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return -1; // Return -1 to indicate an error
            }
        }
    }
}
