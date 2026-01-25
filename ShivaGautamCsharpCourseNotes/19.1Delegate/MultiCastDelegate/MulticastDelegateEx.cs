using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._19._1Delegate.MultiCastDelegate
{
    internal class MulticastDelegateEx
    {
        public delegate void CalculateDelegate(int a, int b); // Delegate that takes two integers and returns void

        public void Add(int a, int b)
        {
            Console.WriteLine("Addition: " + (a + b));
        }
        public void Subtract(int a, int b)
        {
            Console.WriteLine("Subtraction: " + (a - b));
        }
        public void Multiply(int a, int b)
        {
            Console.WriteLine("Multiplication: " + (a * b));
        }   
        public void Divide(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine("Division: " + (a / b));
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
        }
    }
}
