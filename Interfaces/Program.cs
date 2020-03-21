//Explicit Implementation Of Interfaces

//using System;

//namespace Interfaces
//{
//    interface i1
//    {
//        void show();
//    }
//    interface i2
//    {
//        void show();
//    }

//    public class program : i1, i2
//    {
//        public void show()
//        {
//            Console.WriteLine("Welcome");
//        }

//        static void Main(string[] args)
//        {
//            program p = new program();
//            ((i1)p).show();
//            ((i2)p).show();
//        }
//    }
//}


                              //MultipleInterface

using System;

namespace MultipleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AB ab = new AB();
            ab.Amethod();
        }
    }
}
interface IA
{
    void Amethod();
}
interface IB
{
    void Bmethod();
}

public class A : IA
{
    public void Amethod()
    {
        Console.WriteLine("A");

    }

}

public class B : IB
{
    public void Bmethod()
    {
        Console.WriteLine("B");
    }

}

public class AB : IA, IB
{
    A a = new A();
    B b = new B();
    public void Amethod()
    {
        a.Amethod();
    }
    public void Bmethod()
    {
        b.Bmethod();
    }
}


