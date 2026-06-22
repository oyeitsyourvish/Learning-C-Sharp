using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._15Abstraction
{
    abstract class SimpleExample
    {
        public abstract void Sound();
    }

    class Dog : SimpleExample
    {
        public override void Sound()
        {
            Console.WriteLine("Dog Sound");
        }
        public static void Main()
        {
            Dog d = new Dog();
            d.Sound();
        }
    }
}
