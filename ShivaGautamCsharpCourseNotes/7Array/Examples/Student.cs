using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7Array.Examples
{
    internal class Student
    {
        private int rollNo;
        private string name;
        internal int fees;

        internal void accept(int r, string n, int f)
        {
            this.rollNo = r;
            this.name = n;
            this.fees = f;
        }

        internal void display()
        {
            Console.WriteLine("Roll No         : "+ rollNo);
            Console.WriteLine("Name Of Student : "+ name);
            Console.WriteLine("Fees  is        : "+ fees);
        }
    }
}
