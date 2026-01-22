using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._19Collection.Common_Generic_Non_Generic.Stack
{
    internal class StackEx
    {
        internal void StackExample_Non_Generic()
        {
            try
            {
                Console.WriteLine("Example of Non-Generic Stack"); // we can store different data types in Stack cause it is non-generic collection.
                System.Collections.Stack stack = new System.Collections.Stack(); // creating object of Stack class
                stack.Push("Mumbai"); // adding elements using Push method
                stack.Push(25);
                stack.Push("Delhi");
                foreach (object item in stack) // displaying elements using foreach loop
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("After Pop Method:");
                stack.Peek(); // viewing top element using Peek method
                stack.Pop(); // removing top element using Pop method
                foreach (object item in stack)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something is wrong");
            }
        }

        internal void StackExample_Generic()
        {
            Console.WriteLine("Example of Generic Stack"); // we can store specific data type in Generic Stack.
            try
            {
                System.Collections.Generic.Stack<string> stack = new System.Collections.Generic.Stack<string>(); // creating object of Generic Stack class
                stack.Push("Apple"); // adding elements using Push method
                stack.Push("Banana");
                stack.Push("Cherry");
                foreach (object item in stack) // displaying elements using foreach loop
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("After Pop Method:");
                stack.Peek(); // viewing top element using Peek method
                stack.Pop(); // removing top element using Pop method
                foreach (object item in stack)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something is wrong");
            }
        }
    }
}
