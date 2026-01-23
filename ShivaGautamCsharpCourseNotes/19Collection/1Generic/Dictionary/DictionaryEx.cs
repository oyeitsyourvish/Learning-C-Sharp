using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._19Collection._1Generic.Dictionary
{
    internal class DictionaryEx
    {
        internal void DictionaryExample_Generic()
        {
            try
            {
                // Creating a Dictionary to store student names (string) and their corresponding scores (int)
                Dictionary<int, string> st = new Dictionary<int, string>();
                // Adding key-value pairs to the Dictionary
                st.Add(1, "Python");
                st.Add(2, "Java");
                st.Add(3,"Csharp");
                st.Add(4,"Html");
                foreach (var item in st)
                {
                    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
                }

                // Accessing values using keys
                Console.WriteLine("st id : " + st[]);
                // Updating a value
                studentScores["Bob"] = 95;
                Console.WriteLine("Bob's Updated Score: " + studentScores["Bob"]);
                // Checking if a key exists
                if (studentScores.ContainsKey("Charlie"))
                {
                    Console.WriteLine("Charlie's Score: " + studentScores["Charlie"]);
                }
                // Iterating through the Dictionary
                Console.WriteLine("All Student Scores:");
                foreach (var kvp in studentScores)
                {
                    Console.WriteLine($"Student: {kvp.Key}, Score: {kvp.Value}");
                }
                // Removing a key-value pair
                studentScores.Remove("Alice");
                Console.WriteLine("After removing Alice, total students: " + studentScores.Count);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred: " + ex.Message);
            }
    }
}
