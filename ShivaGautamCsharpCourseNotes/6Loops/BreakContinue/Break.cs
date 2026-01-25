using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._6Loops.BreakContinue
{
    internal class Break
    {
        public static void Main(string[] args)
        {
            Continuee();
            Breakk();
        }
        public static void Continuee()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue; // when this cond should true it will skip and go to next and Continue.
                }
                    Console.WriteLine("This is Contiue Statment {0}", i);

            }
        }
        public static void Breakk()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("This is Break Statment {0}", i);
                if (i == 5) 
                {
                    break;// when this cond should true it will break and cursur goes to out of block.
                }
            }
        }
    }
}
