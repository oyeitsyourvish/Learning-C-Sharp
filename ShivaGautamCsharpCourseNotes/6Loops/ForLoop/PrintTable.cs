using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced.Loops.ForLoop
{
    internal class PrintTable
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number Which you want to print table");
            int Number = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(Number*i);
            }
        }
    }
}
