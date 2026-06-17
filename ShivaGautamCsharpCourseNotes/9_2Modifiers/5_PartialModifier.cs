using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._9_2Modifiers
{
    public partial class Employee
    {
        public void Method1()
        {
            Console.WriteLine("This is Method 1 from Employee class");
        }
    }
    public partial class Employee
    {
        public void Method2()
        {
            Console.WriteLine("This is Method 2 from Employee class");
        }
    }


    internal class _5_PartialModifier
    {
        public static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Method1();
            e.Method2();
        }
    }
}
