using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced.Loops.DoWhile
{
    internal class DoWhile
    {
        public static void Main(string[] args)
        {
            int i = 100;
            do
            {
                Console.WriteLine(i);
                i++;
            }while(i >200); //excute the condition would be false here
        }
    }
}
