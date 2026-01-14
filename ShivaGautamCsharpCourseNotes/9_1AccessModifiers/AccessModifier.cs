using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._9_1AccessModifiers
{
    internal class AccessModifier : Example
    {
        public static void Main(string[] args)
        {
            /*
             1) Private : can not be access outside of the class 
             2) Internal : can not access outside of the project only accessible in same assembly or project.
             3) Protected : can not access outside of the project without inheritance, in same project it is similar 
                to internal
             4) Protected Internal: combine features of internal and protected.
             5) public: it can be access outside of the project.               
             
             */


            Example e = new Example();
            //e.Private(); // we cant aceess private cause its only accissible in same class if we want to assess it in 
                      // another class then we need getter and setter method

            e.Internal();   // we can access it in same project(assembly)but cant access outside the project.
            //e.Protected();  // it is protected it access only derieved class 
            e.ProtectedInternal();  // protected internal it take the property of intranal also thats whay its accessible.
            e.Public();  // it can access any where.


            AccessModifier a = new AccessModifier();
            a.Protected(); // here we inherits and acces it from its child class.



            // NOTE : if we want to  access public method in different project(assembly) then class shoulb be public and
                    // and the path or project reference of that classs set into new project(assembly).
        }
    }
}
