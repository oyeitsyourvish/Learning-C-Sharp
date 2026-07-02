using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19Collection.Non_Generic.Sortedlist
{
    internal class Sortedlist
    {
        /*
        SortedList in C# :- it is also generic as well as non-generic collection that stores key-value pairs 
        in sorted order based on the keys in ascending order sorting.
         
         */
        public static void Main(string[] args)
        {
            SortedlistEx ex = new SortedlistEx(); // creating object of SortedlistEx class

            ex.SortedlistExample_Non_Generic(); 
            // calling SortedlistExample method using object of SortedlistEx class

            ex.SortedlistExample_Generic(); 
            // calling SortedlistExample_Generic method using object of SortedlistEx class
        }
    }
}
