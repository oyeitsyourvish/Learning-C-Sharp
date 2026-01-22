using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._19Collection.Non_Generic.Sortedlist
{
    internal class SortedlistEx
    {
        internal void SortedlistExample()
        {
            try
            {
                System.Collections.SortedList sl = new System.Collections.SortedList(); // creating object of Sortedlist class
                sl.Add("1", "Shiva Gautam"); // adding key-value pairs data in Sortedlist
                sl.Add("2", 25);
                sl.Add("3", "Kathmandu");
                // we want to desplay data 
                // we cant display data using for loop cause it does not manage index for data representation (key-value).
                // so we will use foreach loop to display data
                foreach (System.Collections.DictionaryEntry data in sl) //Using DictionaryEntry to iterate key-value pairs in Sortedlist
                {
                    Console.WriteLine("Key : {0} and Value : {1}", data.Key, data.Value);
                }
                Console.WriteLine("After Remove Method");
                sl.Remove("1"); // removing key-value pair using key
                foreach (System.Collections.DictionaryEntry data in sl)
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
