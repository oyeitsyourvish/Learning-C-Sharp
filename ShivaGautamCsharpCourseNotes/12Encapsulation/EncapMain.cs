using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._12Encapsulation
{
    internal class EncapMain
    {
        public static void Main(string[] args)
        {
            EncapEx e = new EncapEx();
            string namee = "vishal";
            e.Name = namee;  // this set the value in property/method not in datamember directly
            e.Age = 26;
            Console.WriteLine(e.Name); // fetch or get data from property not directly to datamember
            Console.WriteLine(e.Age);
        }

    }
}
