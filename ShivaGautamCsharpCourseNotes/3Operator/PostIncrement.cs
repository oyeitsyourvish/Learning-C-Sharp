using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes.Operator
{
    internal class PostIncrement
    {
        public static void Main(string[] args)
        {
            // Post increment
            int a = 10; //10,  
            int b = a++ + a++ + a++; // b = 33
                                     //10  + 11  + 12 and a =13
            Console.WriteLine("a is {0} and b is {1}", a, b);


            //Pre Increment
            int c = 10; //10,  
            int d = ++c + ++c + ++c; // b = 36
                                     //11  + 12  + 13 and a =13
            Console.WriteLine("a is {0} and b is {1}", c, d);


            // Binary operator = it take two operent
            // Arethmetic Operator = +,-, *, /, %
            // Conditional and Reletional Operator = <,>,<=,>= it return in true or false
            // Assignment Operator = +=, -=, *=, /=
            // Comparison Operator = ==
            // Logical Operator = &&(if all cond true it return true), || (if any cond true return true), !

            // Ternary Operator : it is an expression it is used to solve condition based Program
            // ex. result = (condition) ? true: false;
            int e = 10;
            int f = 14;
            int g = 18;
            string res = (e > f && e>g) ? "E is greter" : (f>g && f>g)?"F Is Greater":"G Is greater";
            Console.WriteLine(res);

            //write a program odd even in ternary
            int z = 10;
            string oe = (z % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(oe);


            //write a program Leap Year in ternary
            int y = 2000;
            string leap = y % 400==0  || (y % 4 == 0 && y%100!=0) ? "Leap Year" : "Not A Leap Year";
            Console.WriteLine(leap);
        }
    }
}
