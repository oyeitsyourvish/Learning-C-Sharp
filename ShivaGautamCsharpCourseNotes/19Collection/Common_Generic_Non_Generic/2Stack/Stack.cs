using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19Collection.Common_Generic_Non_Generic.Stack
{
    internal class Stack
    {
        /*
         Stack in C# :- it store elements in LIFO (Last In First Out) order.
        - it provide generic as well as non-generic features.
        - it has a push method to add elements and pop method to remove elements from the stack and
        peek method to view the top element without removing it.
         */
        public static void Main(string[] args)
        {
            StackEx ex = new StackEx(); // creating object of StackEx class
            ex.StackExample_Non_Generic(); // calling non-generic stack example method
            ex.StackExample_Generic(); // calling generic stack example method
        }
    }
}
