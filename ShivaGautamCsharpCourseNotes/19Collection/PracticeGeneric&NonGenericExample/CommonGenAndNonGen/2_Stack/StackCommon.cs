using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19Collection.PracticeGeneric_NonGenericExample.CommonGenAndNonGen._2_Stack
{
    internal class StackCommon
    {
        public static void Main(string[] args)
        {
            // Stack :- It is a collection of objects that are stored in a last-in-first-out (LIFO) manner.
            // Methods: 1-Push(), 2-Pop(), 3-Peek(), 4-Contains(), 5-Clear(), 6-Count, 7-ToArray()

            // Example of Non_Generic Stack
            Non_Generic_Stack();
            Generic_Stack();
        }

        public static void Non_Generic_Stack()
        {
            Stack s = new Stack();
            // Push() method is used to add an object to the top of the Stack.
            s.Push(30);
            s.Push(true);
            s.Push(3.5);
            s.Push("Raju");
            s.Push(20);
            //Display the elements of the Stack using foreach loop
            foreach (var i in s)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Pop() method is used to removes the top element or last element added to the Stack.
            s.Pop(); // 
            foreach (var i in s)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Peek() method is used to return the top element of the Stack without removing it.
            Console.WriteLine("Top Element using Peek : " + s.Peek());

            // Count() method is used to check the number of elements in the Stack.
            Console.WriteLine("Count: " + s.Count);

            // Contains() method is used to check whether the Stack contains a specific element or not.
            Console.WriteLine("Contains 'Raju': " + s.Contains("Raju"));

            // ToArray() method is used to copy the elements of the Stack to a new array.
            object[] array = s.ToArray();
            Console.WriteLine("Elements in array:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            // Clear() method is used to remove all the elements from the Stack.
            s.Clear();
        }

        public static void Generic_Stack()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Top Element: " + stack.Peek());

            Console.WriteLine("Removed: " + stack.Pop());

            Console.WriteLine("Count: " + stack.Count());

            Console.WriteLine("Contains 20: " + stack.Contains(20));

            Console.WriteLine("Elements:");

            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
