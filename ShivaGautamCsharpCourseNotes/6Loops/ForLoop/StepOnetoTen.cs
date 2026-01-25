using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced.Loops.ForLoop
{
    internal class StepOnetoTen
    {
        public static void Main(string[] args)
        {
            for (int i =1; i <= 10; i++)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
            for (int i =10; i > 0; i--)
            {
                Console.Write(i+ " ");
            }
        }
    }
}
