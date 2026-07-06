using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19Collection.PracticeGeneric_NonGenericExample.Non_Generic._1_ArrayList
{
    internal class ArrayList_Non_Generic
    {
        public static void Main(string[] args)
        {
            // ArrayList :- it store any type of data. and all methods are same.
            ArrayList al = new ArrayList();

            // Adding data
            al.Add(1);
            al.Add("Vish");
            al.Add(2.5);
            al.Add(true);
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // using AddRange() method to add multiple elements at once
            al.AddRange(new object[] { 3, "Sanj", 4.5, false });

            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Inserting an element at a specific index using Insert() method
            al.Insert(2, "Inserted Element");

            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Inserting multiple elements at a specific index using InsertRange() method
            al.InsertRange(4, new object[] { "Inserted Element 1", "Inserted Element 2" });
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Removing an element by value using Remove() method
            al.Remove("Inserted Element 1");
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Removing an element by index using RemoveAt() method
            al.RemoveAt(3);
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Removing a range of elements using RemoveRange() method
            al.RemoveRange(0, 2);
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Contains :
            Console.WriteLine(al.Contains("Sanj"));
            Console.WriteLine();

            // IndexOf
            Console.WriteLine(al.IndexOf("Sanj"));
            Console.WriteLine();

            //Last Index of use when we want same data but last in row.
            Console.WriteLine(al.LastIndexOf(3));
            Console.WriteLine();

            ArrayList all = new ArrayList { 30, 50, 20 };

            //Sort Arraylist using Sort() method.
            all.Sort();
            foreach (var i in all)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Reverse Arraylist Using Reverse() method
            all.Reverse();
            foreach (var i in all)
            {
                Console.WriteLine(i);
            }
        }
    }
}
