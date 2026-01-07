using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._14Polymorphism
{
    internal class PolyMain
    {
        public static void Main(string[] args)
        {
            /* Polymorphism :- one object have many forms.
              
            @Types of Polymorphism :- 
            1. Static or Compiletime Polymorphism :-
             i) Method or Function Overloading : having a multiple function of method with same name
                    but different in parameter in same class called as overloading.
             ii) Constructor Overloading : same like overloading

            2. Dynamic or Runtime Polymorphism :-
             i) Method or Function Overridding : having a multiple function of method with same name
                    and same in parameter in different class called as overriding.
                    - for overrinding we also know about inheritance because overriding done in parent and child class.

             

             */

            //Constructor overloading
            Console.WriteLine("Constructor overloading");
            ConstructorOverloading c = new ConstructorOverloading(5,5);
            ConstructorOverloading cc = new ConstructorOverloading(5,5,6);
            ConstructorOverloading ccc = new ConstructorOverloading("Vishal ","Chinchane");
            Console.WriteLine();

            //Method Overloading
            Console.WriteLine("Method overloading");
            MethodOverloading m = new MethodOverloading();
            m.MethOverloading(5, 6);
            m.MethOverloading(5, 6, 7);
            m.MethOverloading("Akshay ", "Kumar");
            
        }
    }
}
