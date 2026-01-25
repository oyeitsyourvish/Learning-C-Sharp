using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._11Property
{
    internal class PropMain
    {
        //we are declaring property here mostly we declare the properties in MVC concept Mostly in Model;
        public string name {  get; set; }
        public int age { get; set; }
        public static void Main(string[] args)
        {
            PropMain p = new PropMain();
            p.name = "vishal";   // here we set the value of that property
            p.age = 25;          // here we set the value of that property
            Console.WriteLine(p.name); //here we get or fetch the data
            Console.WriteLine(p.age);  //here we get or fetch the data
        }
    }
}
