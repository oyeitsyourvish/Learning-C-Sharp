using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced.Loops.ForLoop
{
    internal class Factorial
    {
        public static void Main(string[] args)
        {

            // factorial (7! = 7*6*5*4*3*2*1)
            //in increasing way
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int facto = 1;
            for (int i = 1; i <= num; i++)
            {
                facto *= i;
            }
            Console.WriteLine("{0} factorial is {1}", num, facto);



            // in decreasing way 
            int factoInc = 1;
            for (int i = num; i > 1; i--)
            {
                factoInc *= i; //1*7
            }
            Console.WriteLine("{0} factorial is {1}", num, factoInc);
        }
    }
}
