using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes.Basic_Program
{
    internal class CompundInterest
    {
        internal void CI(int p, int t, int r)
        {
            double amount = p * Math.Pow(1 + (r / 100.0), t);
            amount = Math.Round(amount,0);
            double CopInt = amount - p;
            CopInt = Math.Round(CopInt,0);
            Console.WriteLine("Total amount after "+t+" Years compunding is "+amount);
            Console.WriteLine("Only Compound Interest after "+t+" is "+CopInt);

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Amount");
            int loanAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Time Period in Year");
            int timePeriod = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Interest you want to calculate");
            int interest = Convert.ToInt32(Console.ReadLine());

            CompundInterest c = new CompundInterest();
            c.CI(loanAmount, timePeriod, interest);

        }
    }
}
