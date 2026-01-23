using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._19Collection._1Generic.Dictionary
{
    internal class Dictionary
    {
        public static void Main(string[] args)
        {
            /*
             Dictionary in C# :- Store the Data in key-value pairs that allows fast retrieval of values
                                 based on their associated keys.
                                 - We cant store duplicate keys, but values can be duplicate.
                Key Features:- 
                    1. Key-Value Pairs: Each entry consists of a unique key and a corresponding value.
                    2. Fast Lookups: Provides O(1) average time complexity for lookups, insertions, and
                       deletions based on keys.
                    3. Generic: Can store any data type for both keys and values (Dictionary<TKey, TValue>).
                    
                    
             When to use:- When you want to search fast using unique keys (like a phone book, where
                           names are keys and phone numbers are values).
             */
            DictionaryEx dictionaryEx = new DictionaryEx();
            dictionaryEx.DictionaryExample_Generic();
        }
    }
}
