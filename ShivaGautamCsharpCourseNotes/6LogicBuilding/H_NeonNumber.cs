using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._6LogicBuilding
{
    internal class H_NeonNumber
    {
        public static void Main(string[] args)
        {

            /* Neon Number :-> A Neon Number is a number where the sum of the digits of its square is equal to the number itself.
             
            // Neon Number Example
            xample: intput = 9
            Square of 9 = 81
            Sum of digits = 8 + 1 = 9
            Since 9 = 9, 9 is a Neon Number.

            // Not Neon Number
            Example: intput = 7
            Square of 7 = 49
            Sum of digits = 4 + 9 = 13
            Since 13 ≠ 7, 7 is not a Neon Number.
             */
            Console.WriteLine("Enter the number you want to check Neon or not");
            int a = Convert.ToInt32(Console.ReadLine()); //9
            int store = a * a; //9*9=81
            int sum = 0; //1, 9

            while (store > 0) //81>9,  8>0, 0>0false
            {
                int temp = store % 10; // 81%10= 1, 8%10=8
                sum += temp; //0+1=1, 1+8=9
                store /= 10; // 81/10=8, 8/10=0
            }
            if (sum == a) //9==9
            {
                Console.WriteLine("Neon Number");
            }
            else
            {
                Console.WriteLine("Not");
            }


        }
    }
}
