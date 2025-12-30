using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes.Loops.WhileLoop
{
    internal class ReverseNo
    {
        public static void Main(string[] args)
        {

            // using int 
            Console.WriteLine("Enter the Number");
            int a = Convert.ToInt32(Console.ReadLine());
            int st = 0;
            while (a > 0)
            {
                int temp = a % 10;
                st = st * 10 + temp;
                a /= 10;
            }
            Console.WriteLine(st);

            //using string
            int c = 12345;
            string str = "";
            while (c != 0)
            {
                str = str + c % 10; // here it do the concatination
                c /= 10;
            }
            Console.WriteLine(str);
        }
    }
}
