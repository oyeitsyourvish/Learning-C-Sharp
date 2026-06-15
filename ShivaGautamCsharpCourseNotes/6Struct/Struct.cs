using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._6Struct
{
    internal class Struct
    {
        public static void Main()
        {
            // Struct is a value type
            // Struct is used to create user-defined data types
            // Struct can contain fields, properties, methods, and events
            // Struct can implement interfaces but cannot inherit from another struct or class

            Employee emp;
            emp.id = 1;
            emp.name = "Vishal";
            emp.sal = 50000;
            Console.WriteLine(emp.id);
            Console.WriteLine(emp.name);
            Console.WriteLine(emp.sal);

        }
    }
}

struct Employee
{
    public int id;
    public string name;
    public double sal;
}