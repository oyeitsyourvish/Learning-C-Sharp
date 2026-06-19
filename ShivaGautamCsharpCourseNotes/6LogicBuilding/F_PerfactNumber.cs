using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._6LogicBuilding
{
    internal class F_PerfactNumber
    {
        public static void Main(string[] args)
        {
            /*Perfect Number :-> It is a  Sum of factor of User number excluding itself and check it is equal to the user number(user == sumoffactor)
            Example: input = 6
            Divisors of 6 (excluding 6): 1, 2, 3
            SumOfFactor = 1 + 2 + 3 = 6
            input == SumOfFactor
             
             */
            Console.WriteLine("Enter the Number to check Perfect Number");
            int a = Convert.ToInt32(Console.ReadLine()); //6
            int s = 1;
            int addFact = 0; //1, 3, 6
            while (s < a) //1<6,2<6, 3<6, 4<6,
            {
                if (a % s == 0) //6%1==0, 6%2==0, 6%3==0, 6%4==0 false
                {
                    addFact += s; //0+1=1, 1+2=3, 3+3=6,
                }
                s++; //2,3,4
            }
            if (addFact == a)
            {
                Console.WriteLine($"{a} is a Perfect Number");
            }
            else
            {
                Console.WriteLine($"{a} is Not Perfect Number");
            }
        }
    }
}
