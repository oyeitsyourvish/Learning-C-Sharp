using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._19Collection._1Generic.List
{
    internal class ListEx
    {
        internal void  List_Generic()
        {
            try
            {
                Console.WriteLine("This is List Example Adding Element");
                List <string> stud = new List<string>(); // creating object of List class
                stud.Add("Jagan"); // adding elements using Add method
                stud.Add("Ravi");
                stud.Add("Ajay");
                stud.Add("Ravi");

                foreach (var item in stud) // displaying elements using foreach loop
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("------------------------------------");
                Console.WriteLine();
                Console.WriteLine("For finding Element enter the name");
                string find = Console.ReadLine();
                if (stud.Contains(find)) // finding element using Contains method
                {
                    Console.WriteLine("Element Found"+find);
                }
                else
                {
                    Console.WriteLine("Element Not Found");
                }
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------");

                Console.WriteLine("After Remove Element");
                stud.Remove("Ajay"); // removing element using Remove method
                foreach (object item in stud)
                {
                    Console.WriteLine(item);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Something is wrong");
            }

        }
    }
}
