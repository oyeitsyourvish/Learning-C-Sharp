using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19Collection.Non_Generic.Hashtable
{
    internal class HashTableMain
    {
        public static void Main(string [] args)
        {
            /*
             HashTable in C# :- it is a non-generic collection that stores key-value pairs.
            - key is user-defined (user provided) and must be unique.
            - value is data (data stored) associated with the key.
             */
            HashTableX ex = new HashTableX(); // creating object of HashTableX class
            ex.HashTableEx(); // calling HashTableEx method
        }
    }
}
