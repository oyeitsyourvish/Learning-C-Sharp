using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ShivaGautamCsharpCourseNotes._19Collection.Arraylist
{
    internal class ArrayListX
    {
        internal void ArraylistEx()
        {
            // this is the example of non-generic collection ArrayList we can store different data types in ArrayList
            // manage index for data representation. we dont need to define size at the time of declaration.
            System.Collections.ArrayList al = new System.Collections.ArrayList(); // creating object of ArrayList class
            al.Add(10);  // adding different data types in ArrayList
            al.Add(5);
            al.Add("Shiva");
            al.Add(15.5);

            // There are three ways to iterate ArrayList
            // 1. for loop
            Console.WriteLine("Using For Loop");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            // 2. Foreach using var keyword
            Console.WriteLine("Using Foreach Var keyword");
            foreach (var data in al)
            {
                Console.WriteLine(data);
            }

            // 3. Foreach using object keyword
            Console.WriteLine("Using Foreach Object keyword");
            foreach (object data in al)
            {
                Console.WriteLine(data);
            }

            // Remove method
            Console.WriteLine("After Remove Method");
            al.Remove(5); // removing data using Remove method
            foreach (object data in al)
            {
                Console.WriteLine(data);
            }
        }
    }
}
