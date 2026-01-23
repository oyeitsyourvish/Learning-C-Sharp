using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._19Collection._1Generic._2Hashset
{
    internal class Hashset
    {
        public static void Main(string[] args)
        {
            /*
             HashSet in C# :- A collection that stores unique elements (no duplicates) in an unordered manner.
                Key Features:- 
                    1. Unordered: Does not maintain the order of elements.
                    2. Unique Elements: Automatically handles duplicates; only one instance of each element is stored.
                    3. Generic: Can store any data type (HashSet<T>). we need to provide data type while creating object of HashSet.
                    4. Set Operations: Supports mathematical set operations like union, intersection, and difference.
                    
             When to use:- When you want unique records (like unique emails, unique IDs).
             */
            HashsetEx hashset = new HashsetEx();
            hashset.HashsetExample_Generic();
        }
    }
}
