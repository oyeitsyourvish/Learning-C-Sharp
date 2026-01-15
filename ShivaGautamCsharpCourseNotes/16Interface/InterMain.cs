using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._16Interface
{
    internal class InterMain
    {
        /* Interface :- it is pure abstract class that contain set of abstract method to perform data abstraction.
         * interface also used to or achieve implement multiple inheritance which not possible by class cause of ambiguity when method name is same.
         * we cant create object of interface
         * 
          
        @Advantage :- 1. Data Abstraction, 2.Achieve Multiple inheritance
         
         */
        public static void Main(string[] args)
        {

            // all implementation in class but we create ref of interface where our method is declare 
            Console.WriteLine("Interface Ref and class obj");
            IFirst first = new ImplementationClass();
            first.Func();
            first.Func1();


            Console.WriteLine("Interface Ref and class obj");
            ISecond sec = new ImplementationClass();
            sec.Func();
            sec.Func1();
            sec.Func2();


            // Avoid it if you use interface.
            //this is not use of interface cause if we create ref of class and object of class then we dont need interface
            Console.WriteLine("Here Create Class Ref and Class Object");
            ImplementationClass intr = new ImplementationClass();
            intr.Func();
            intr.Func1();
            intr.Func2();
        }
     
    }
}
