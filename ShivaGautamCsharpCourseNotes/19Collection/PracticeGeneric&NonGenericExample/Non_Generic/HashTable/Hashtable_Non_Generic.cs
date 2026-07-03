using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19Collection.PracticeGeneric_NonGenericExample.Non_Generic.HashTable
{
    internal class Hashtable_Non_Generic
    {
        public static void Main(string[] args)
        {
            // Hashtable :- it store key value pair. and all methods are same.
            Hashtable ht = new Hashtable();
            // Adding data
            ht.Add(1, "Vish");
            ht.Add(2, "Sanj");
            ht.Add(3, "Teju");
            ht.Add(4, "Rahul");
            foreach (DictionaryEntry i in ht)
            {
                Console.WriteLine($"Key: {i.Key}, Value: {i.Value}");
            }
            Console.WriteLine();

            ht.Remove(4);
            foreach (DictionaryEntry i in ht)
            {
                Console.WriteLine($"Key: {i.Key}, Value: {i.Value}");
            }

            Console.WriteLine(ht.ContainsKey(2));
            Console.WriteLine(ht.ContainsValue("Teju"));

            ht.Clear();
            foreach (DictionaryEntry i in ht)
            {
                Console.WriteLine($"Key: {i.Key}, Value: {i.Value}");
            }

        }
    }
}
