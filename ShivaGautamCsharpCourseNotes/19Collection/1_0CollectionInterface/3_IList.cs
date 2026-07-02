using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19Collection._1_0CollectionInterface
{
    internal class _3_IList
    {
        public static void Main(string[] args)
        {
            /* IList : it is child of ICollection. It is used when you need a collection of objects that can be accessed by index
               (like an array) and whose size can change dynamically.
               Purpose :- It allows storing objects in a dynamic collection that can be accessed, updated, inserted, or removed using an index.
               Methods :- Add, Remove, Clear, Contains, Count, IndexOf, Insert, RemoveAt 

            */

            IList<int> num = new List<int>();
            // Add elements to the collection using the Add method.
            num.Add(20);
            num.Add(30);
            num.Add(10);

            // Access elements by index using the indexer.
            Console.WriteLine($"Element at index 1: {num[1]}");

            // Get the index of an element using the IndexOf method.
            Console.WriteLine($"Index of element 30: {num.IndexOf(30)}");

            // update an element at a specific index using the indexer.
            num[1] = 50;
            Console.WriteLine($"Updated element at index 1: {num[1]}");

            // Insert an element at a specific index using the Insert method.
            num.Insert(2, 40);
            Console.WriteLine($"Element at index 2 after insertion: {num[2]}");

            // Remove element directly
            Console.WriteLine("Remove Element " + num.Remove(10)); // true

            // Remove an element at a specific index using the RemoveAt method.
            num.RemoveAt(1);

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }





        }
    }
}
