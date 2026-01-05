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
            //Need to create object of class because its dyanamic/Nonstatic it store in heap
            //this is OBJECT 
            Employee emp = new Employee();

            //we call the non-static method or function.
            emp.Accept(1, "Vishal", 25);
            emp.Display();


            //Directely access by Class Name Cause it static  it store in stack.
            Console.WriteLine(StaticEx.a);
            StaticEx.Fun();
        }


        // If wee need to limited memory the we use static 
        // if we need to create unlimeted memory then we use Non-Static/Dyanamic
    }
}
