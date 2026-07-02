using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19Collection.PracticeGeneric_NonGenericExample.Generic._1List
{
    internal class ListGeneric
    {
        public static void Main(string[] args)
        {
            //It is ditto same as Ilist. all methods are same.

            List<int> l = new List<int>();
            // Add elements to the collection using the Add method.
            l.Add(20);
            l.Add(30);
            l.Add(10);

            // Access elements by index using the indexer.
            Console.WriteLine($"Element at index 1: {l[1]}");

            // Get the index of an element using the IndexOf method.
            Console.WriteLine($"Index of element 30: {l.IndexOf(30)}");

            // update an element at a specific index using the indexer.
            l[1] = 50;
            Console.WriteLine($"Updated element at index 1: {l[1]}");

            // Insert an element at a specific index using the Insert method.
            l.Insert(2, 40);
            Console.WriteLine($"Element at index 2 after insertion: {l[2]}");

            // Remove element directly
            Console.WriteLine("Remove Element " + l.Remove(10)); // true

            // Remove an element at a specific index using the RemoveAt method.
            l.RemoveAt(1);

            foreach (int i in l)
            {
                Console.WriteLine(i);
            }
        }
    }
}
