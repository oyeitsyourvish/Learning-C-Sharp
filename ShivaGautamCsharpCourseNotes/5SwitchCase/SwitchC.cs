using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._5SwitchCase
{
    internal class SwitchC
    {
        public static void Main(string[] args)
        {
            // Switch Case : it is used to create option based program, we pass option under switch () 
            // that will match from optionvalue and excute particular case.
            //Ex.
            char ch = 'z';
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("This is a Vovels");
                    break;

                default: Console.WriteLine("This is Consonent");
                    break;
            }
        }
    }
}
