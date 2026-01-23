using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._19Collection._1Generic._2Hashset
{
    internal class HashsetEx
    {
        internal void HashsetExample_Generic()
        {
            try
            {
                Console.WriteLine("Example of Generic HashSet");
                // we can store different data types in Generic HashSet by specifying data type
                /*HashSet<object> hs = new HashSet<object>();
                hs.Add("Radha");
                hs.Add(25);
                hs.Add("Rutuja"); // duplicate value will not be added */

                // OR
                HashSet<string> hs = new HashSet<string>();
                hs.Add("Radha");
                hs.Add("Rutuja");
                hs.Add("Sakshi");
                hs.Add("Rutuja"); // duplicate value will not be added

                // If we want to take input from user and add 
                Console.WriteLine("How many names you want to add in HashSet?");
                int n = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter name {0}:", i + 1);
                    string name = Console.ReadLine();
                    hs.Add(name); // adding user input names in HashSet
                } // in this case it also added our hs.add("data") values along with user input values


                // when we want to display data of generic HashSet specifying data type we have
                // to use foreach loop to iterate elements in HashSet
                foreach (var data in hs)
                {
                    Console.WriteLine(data);
                }

                Console.WriteLine();
                Console.WriteLine("After Remove Element");
                hs.Remove("Sakshi"); // removing element using Remove method
                foreach (object a in hs)
                {
                    Console.WriteLine(a);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something is wrong");
            }
        }
    }
}
