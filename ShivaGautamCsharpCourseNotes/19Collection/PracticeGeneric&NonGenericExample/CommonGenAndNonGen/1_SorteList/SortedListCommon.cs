using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19Collection.PracticeGeneric_NonGenericExample.CommonGenAndNonGen._1_SorteList
{
    internal class SortedListCommon
    {
        public static void Main(string[] args)
        {
            // SortedList :- It store key value pair But it store data in sorted order based on key.
            // and all methods are same like Dictionary.
            // Key must always Unique


            // Example of Non_Generic SorteList 
            Non_Generic_SortedList();
            Generic_SortedList();

        }

        public static void Non_Generic_SortedList()
        {
            // All Methods are same like Dictionary Collection but we just used Add() and Remove() method.
            SortedList sl = new SortedList();
            sl.Add(501, "RajuBhai");
            sl.Add(201, 50000);
            sl.Add(301, true);
            sl.Add(101, 3.5);

            foreach (DictionaryEntry i in sl)
            {
                Console.WriteLine($"Key is : {i.Key} and Value is : {i.Value}");
            }
            Console.WriteLine();

            // Remove
            sl.Remove(301);
            Console.WriteLine("After Removing");
            foreach (DictionaryEntry i in sl)
            {
                Console.WriteLine($"Key is : {i.Key} and Value is : {i.Value}");
            }
            Console.WriteLine();
        }


        public static void Generic_SortedList()
        {
            // All Methods are same like Dictionary Collection but we just used Add() and Remove() method.
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(606, "Peter England");
            sl.Add(106, "Bewkoof");
            sl.Add(906, "The Indian Garage");
            sl.Add(206, "Snitch");

            foreach (KeyValuePair<int, string> i in sl)
            {
                Console.WriteLine($"Key : {i.Key} and Value : {i.Value}");
            }
            Console.WriteLine();

            Console.WriteLine("After Remove snitch");
            sl.Remove(206);
            foreach (KeyValuePair<int, string> i in sl)
            {
                Console.WriteLine($"Key : {i.Key} and Value : {i.Value}");
            }
            // another way to iterate using foreach
            /* foreach (var i in sl)
             {
                 Console.WriteLine($"Key : {i.Key} and Value : {i.Value}");
             }
            */
        }
    }
}
