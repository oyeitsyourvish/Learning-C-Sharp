using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced.SI_Prgram
{
    internal class SimpleInterest
    {
        float p, r, t;
        internal void calsi()
        {
            p = 100000; //principle amount
            r = 16;  //Rate of interest
            t = 4; //Time in year

            float c = p * r * t / 100;
            Console.WriteLine("Your interest after "+t+" years is "+ c);

        }

        static void Main(string[] args)
        {
            SimpleInterest s = new SimpleInterest();
            s.calsi();
        }

    }
}
