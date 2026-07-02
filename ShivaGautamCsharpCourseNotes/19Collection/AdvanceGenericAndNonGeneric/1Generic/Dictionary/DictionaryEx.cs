using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19Collection._1Generic.Dictionary
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
                st.Add(3, "Csharp");
                st.Add(4, "Html");

                Console.WriteLine("Display all Records");
                foreach (var item in st)
                {
                    Console.WriteLine("Id {0} = Value {1}", item.Key, item.Value);
                }

                Console.WriteLine();
                Console.WriteLine("Accessing values using keys");
                Console.WriteLine("st id 1: " + st[1]);

                Console.WriteLine();
                Console.WriteLine("Updating a value");
                st[4] = "Css";
                Console.WriteLine("Updated Id 4 is : " + st[4]);

                Console.WriteLine();
                Console.WriteLine("Checking if a key exists");
                if (st.ContainsKey(3))
                {
                    Console.WriteLine("Id 3 is: " + st[3]);
                }

                Console.WriteLine();
                Console.WriteLine("Once again Display all Records");
                foreach (var item in st)
                {
                    Console.WriteLine("Id {0} = Value {1}", item.Key, item.Value);
                }

                Console.WriteLine();
                Console.WriteLine("Removing a key-value pair");
                st.Remove(3);
                Console.WriteLine("After remove id 3 " + st.Count);

                Console.WriteLine();
                Console.WriteLine("Last Display all Records");
                foreach (var item in st)
                {
                    Console.WriteLine("Id {0} = Value {1}", item.Key, item.Value);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred: " + ex.Message);
            }
        }
    }
}
