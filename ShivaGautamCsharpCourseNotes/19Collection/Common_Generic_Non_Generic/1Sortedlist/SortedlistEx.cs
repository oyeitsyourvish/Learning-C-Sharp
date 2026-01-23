using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._19Collection.Non_Generic.Sortedlist
{
    internal class SortedlistEx
    {
        internal void SortedlistExample_Non_Generic()
        {
            try
            {
                Console.WriteLine("Example of Non-Generic Sortedlist");
                SortedList sl = new SortedList(); // creating object of Sortedlist class
                sl.Add("1", "Hyderabad"); // adding key-value pairs data in Sortedlist
                sl.Add("2", 25);
                sl.Add("3", "Banglore");
                // we want to desplay data 
                // we cant display data using for loop cause it does not manage index for data representation (key-value).
                // so we will use foreach loop to display data
                foreach (DictionaryEntry data in sl) //Using DictionaryEntry to iterate key-value pairs in Sortedlist
                {
                    Console.WriteLine("Key : {0} and Value : {1}", data.Key, data.Value);
                }
                Console.WriteLine("After Remove Method");
                sl.Remove("1"); // removing key-value pair using key
                foreach (DictionaryEntry data in sl)
                {
                    Console.WriteLine("Key : {0} and Value : {1}", data.Key, data.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something is wrong");
            }
        }

        internal void SortedlistExample_Generic()
        {
            Console.WriteLine("Example of Generic SortedList");
            try
            {
                // we can store different data types in Generic Sortedlist by specifying data types
                // of key and value as object
                SortedList<int, object> anotheEx = new SortedList<int, object>();
                anotheEx.Add(1, "Ramesh Kumar");
                anotheEx.Add(2, 30);
                anotheEx.Add(3, "Chennai");

                // when we want to display data of generic sortedlist specifying data types of key and value we have
                // to use KeyValuePair<TKey,TValue> to iterate key-value pairs in Sortedlist
                SortedList<int, string> sl = new SortedList<int, string>();
                sl.Add(1, "Shiva Gautam");
                sl.Add(2, "Kathmandu");
                sl.Add(3, "Nepal");
                

                /* when we want to display data of generic sortedlist specifying data types
                 of key and value we have to use KeyValuePair<TKey,TValue> to iterate key-value pairs
                 in Sortedlist */
                foreach (KeyValuePair<int, string> data in sl)
                {
                    Console.WriteLine("Key is : {0} and Value is : {1}",data.Key, data.Value);
                }

                Console.WriteLine("After Remove");
                sl.Remove(2); // removing key-value pair using key
                foreach (KeyValuePair<int, string> data in sl)
                {
                    Console.WriteLine("Key is : {0} and Value is : {1}", data.Key, data.Value);
                }

            }
            catch
            {
                Console.WriteLine("Something is wrong");
            }
        }
    }
}
