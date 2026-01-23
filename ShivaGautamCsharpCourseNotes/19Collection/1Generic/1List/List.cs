using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._19Collection._1Generic.List
{
    internal class List
    {
        public static void Main(string[] args)
        {
            /*
             List in C# :- A dynamic array (size can grow/shrink). Stores items in order (index-based).
                           - it can store duplicate items.
                Key Features:- 
                    1. Dynamic Sizing: Automatically resizes as items are added/removed.
                    2. Index-Based Access: Fast access to elements using their index.
                    3. Generic: Can store any data type (List<T>). we need to provide data type while creating object of List.
                    4. Ordered: Maintains the order of insertion.
                    5. Allows Duplicates: Can store duplicate items.
                    6. Provides various methods for manipulation (Add, Remove, Find, Sort, etc.).
                    

             When to use:- When you need a simple list of items and want fast access using index.
             */
            ListEx list = new ListEx();
            list.List_Generic();
        }
    }
}
