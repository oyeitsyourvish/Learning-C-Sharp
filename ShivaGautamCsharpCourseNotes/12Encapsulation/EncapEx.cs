using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._12Encapsulation
{
    internal class EncapEx
    {
        //Storing the private variable and method into single entity known as encapsulatio.

        //this two are private data member we cant directly access it. we need getter and setter method.
        private string name;
        private int age;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
    }

}

