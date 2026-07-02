using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19Collection._1_0CollectionInterface
{
    internal class _2_ICollection_AfterIEnumerable
    {
        public static void Main(string[] args)
        {
            // ICollection : it is child of IEnumerable. and add collection features.
            /*   Purpose :- It allows reading and writing data one by one.
                 Methods :- Count, Add, Remove, Clear, Contains, CopyTo
            */
            ICollection<int> num = new List<int>();

            // Add elements to the collection using the Add method.
            num.Add(10);
            num.Add(30);
            num.Add(20);
            num.Add(10);

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }

            // Count the number of elements in the collection using the Count property.
            Console.WriteLine("Number of elements in the collection: " + num.Count);

            // Remove an element from the collection using the Remove method.
            num.Remove(10);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Removed 10 from the collection.");

            // Check if an element exists in the collection using the Contains method.
            if (num.Contains(20))
            {
                Console.WriteLine("20 exists in the collection.");
            }

            // Clear all elements from the collection using the Clear method.
            num.Clear();
            //it cant be used in foreach loop because it is empty now.
            foreach (var i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Cleared all elements from the collection.");

        }
    }
}
