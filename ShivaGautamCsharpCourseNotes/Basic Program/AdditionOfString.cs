using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes.Basic_Program
{
    internal class AdditionOfString
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Value in string");
            string s = Console.ReadLine(); //12345
            int store = Convert.ToInt32(s); //12345
            int addition = 0;
            while (store > 0)
            {
                int temp = store % 10;
                addition += temp;
                store /= 10;
            }
            Console.WriteLine("The addition is : "+ addition);
        }
    }
}
