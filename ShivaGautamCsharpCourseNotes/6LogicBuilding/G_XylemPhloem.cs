using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._6LogicBuilding
{
    internal class G_XylemPhloem
    {
        /* Xylem Number :->  A number is called a Xylem Number if the sum of its extreme digits (first and last digits) is equal
           to the sum of its mean digits (middle digits).
           Phloem Number :-> A number is called a Phloem Number if the sum of its extreme digits is not equal to the sum of its mean digits.
        
        //Example of Xylem
        Example: input = 1234
        Extreme digits (First and Last digit) = 1 + 4 = 5
        Mean digits (middle digit) = 2 + 3 = 5
        Since 5 = 5 (Extreme == Mean), 1234 is a Xylem Number.
        
        //Example of Phloem
        Example: input = 1211
        Extreme digits (First and Last digit) = 1 + 1 = 2
        Mean digits (middle digit) = 2 + 1 = 3
        Since 2 ≠ 3 (Extreme == Mean), 1211 is a Phloem Number.
         
         */

        public static void Main()
        {
            Console.WriteLine("enter the number to check it is Xylem or phloem");
            int a = Convert.ToInt32(Console.ReadLine());
            int lastDig = 0; //4
            int meanDigit = 0;
            lastDig = a % 10; //4
            a /= 10; //123
            while (a >= 9)
            {
                int meanst = a % 10; //3, 2
                meanDigit += meanst;//0+3=3, 3+2=5
                a /= 10;
            }
            lastDig += a; //4+1=5

            if (lastDig == meanDigit) //5==5
            {
                Console.WriteLine("Xylem");
            }
            else
            {
                Console.WriteLine("Phloem");
            }
        }
    }
}
