

                                                //Abstract class Program

using System;

namespace Abstraction
{

    abstract class animal
    {
        public abstract void animalsound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class dog : animal
    {
        public override void animalsound()
        {
            Console.WriteLine("The Dog barks");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            dog a1 = new dog();
            a1.animalsound();
            a1.sleep();
        }
    }
}
