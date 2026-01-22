using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._19Collection.Non_Generic.Hashtable
{
    internal class HashTableX
    {
        internal void HashTableEx()
        {
            try
            {
                // we can store different data types in Hashtable using key-value pairs. cause it is non-generic collection.
                System.Collections.Hashtable ht = new System.Collections.Hashtable(); // creating object of Hashtable class
                ht.Add("1", "Virat Kohli"); // adding key-value pairs data in Hashtable
                ht.Add("2", 25);
                ht.Add("3", "Punjab");

                // we want to desplay data 
                // we cant display data using for loop cause it does not manage index for data representation (key-value).
                // so we will use foreach loop to display data

                foreach (DictionaryEntry data in ht) //Using DictionaryEntry to iterate key-value pairs in Hashtable
                {
                    Console.WriteLine("Key : {0} and Value : {1}", data.Key, data.Value);
                }

                Console.WriteLine("After Remove Method");
                ht.Remove("1"); // removing key-value pair using key
                foreach (DictionaryEntry data in ht)
                {
                    Console.WriteLine("Key : {0} and Value : {1}", data.Key, data.Value);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Something is wrong");

            }
        }
    }
}
