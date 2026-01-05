using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._8Class_Object.Class
{
    internal class Employee
    {
        private int id;
        private string name;
        private int age;

        internal void Accept(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        internal void Display()
        {
            Console.WriteLine("Id : {0} Name : {1} Age : {2}",id, name,age);
        }

    }
}
