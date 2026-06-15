using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._6LogicBuilding
{
    internal class B_OverlsConsonant
    {
        public static void Main()
        {
            Console.WriteLine("Enter a character:");
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch=='a' || ch =='e'||ch =='i'|| ch == 'o'|| ch == 'u'||ch=='A' || ch =='E'||ch =='I'|| ch == 'O'|| ch == 'U')
            {
                Console.WriteLine("Ovels");
                System.Environment.Exit(1);
            }
            Console.WriteLine("Consonant");
        }
    }
}
