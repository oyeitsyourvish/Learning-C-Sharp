using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._6LogicBuilding
{
    internal class C_DivisibleBy3_5
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 3 == 0 && a % 5 == 0)
            {
                Console.WriteLine("Hiiii......");
                System.Environment.Exit(1);
            }
            Console.WriteLine("Byeeee.....");
        }
    }
}
