using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._8Class_Object.Class
{
    internal class Employee
    {
        private int id; //global Non-Static/ Instance/ Dyanamic variable.
        private string name; //global Non-Static/ Instance/ Dyanamic variable.
        private int age; //global Non-Static/ Instance/ Dyanamic variable.

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
