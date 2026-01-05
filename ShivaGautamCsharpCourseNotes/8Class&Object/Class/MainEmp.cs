using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._8Class_Object.Class
{
    internal class MainEmp
    {
        public static void Main(string[] args)
        {
            //Need to create object of class because its dyanamic it store in heap
            Employee emp = new Employee();

            emp.Accept(1, "Vishal", 25);
            emp.Display();


            //Directely access by Class Name Cause it static  it store in stack.
            Console.WriteLine(StaticEx.a);
            StaticEx.Fun();
        }
    }
}
