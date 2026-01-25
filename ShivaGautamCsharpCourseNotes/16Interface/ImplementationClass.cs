using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._16Interface
{
    internal class ImplementationClass : IFirst, ISecond
    {

        public void Func()
        {
            Console.WriteLine("Function");
        }

        public void Func1()
        {
            Console.WriteLine("Func 1");
        }
        public void Func2()
        {
            Console.WriteLine("Func 2");
        }

        // Another Way but for same method in both intrface only.
        // we can also dirct mention to which interface separete implementation 
        //void IFirst.Func()
        //{
        //    Console.WriteLine("Function");
        //}

        //void IFirst.Func1()
        //{
        //    Console.WriteLine("Func 1");
        //}
        //void ISecond.Func()
        //{
        //    Console.WriteLine("Function");
        //}

        //void ISecond.Func1()
        //{
        //    Console.WriteLine("Func 1");
        //}

    }
}
