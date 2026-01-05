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
            Employee emp = new Employee();

            emp.Accept(1, "Vishal", 25);
            emp.Display();
        }
    }
}
