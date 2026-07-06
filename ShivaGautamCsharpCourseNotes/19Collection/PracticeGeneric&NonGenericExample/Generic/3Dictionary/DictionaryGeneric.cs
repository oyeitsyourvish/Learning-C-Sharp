using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19Collection.PracticeGeneric_NonGenericExample.Generic._3Dictionary
{
    internal class DictionaryGeneric
    {
        public static void Main(string[] args)
        {
            // Dictionary :- it store key value pair. and all methods are same.
            Dictionary<int, string> d = new Dictionary<int, string>();

            // Adding data
            d.Add(1, "Vish");
            d.Add(2, "Sanj");
            d.Add(303, "Sid");

            // Access elements by index using the indexer.
            Console.WriteLine($"Element at index 1: {d[1]}");

            // Update
            d[303] = "Raju";

            // Count
            Console.WriteLine(d.Count);

            //Keys
            foreach (int i in d.Keys)
            {
                Console.WriteLine(i);
            }

            //Values
            foreach (string j in d.Values)
            {
                Console.WriteLine(j);
            }

            // Remove 
            d.Remove(3);

            // Contain Key
            Console.WriteLine(d.ContainsKey(2));

            // Contain Value
            Console.WriteLine(d.ContainsValue("Vish"));

            // Add only key doesnot existed.
            d.TryAdd(5, "Kumar");

            // to display Dictionary Key And Value
            foreach (var i in d)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
            // another vay to display Dictionary Key And Value
            /* foreach (KeyValuePair<int, string> i in d)
             {
                 Console.WriteLine($"Key is : {i.Key} and Value is : {i.Value}");
             }
            */
        }
    }
}
